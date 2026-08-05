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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BACF60", Offset = "0x6BAB560", VA = "0x186BACF60")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IKDMDCOHIKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly byte[] IOBPFDIOONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemoryStream PEBOKJGIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CodedOutputStream OKJOLJACPCH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BADC00", Offset = "0x6BAC200", VA = "0x186BADC00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NGJAGNPPADD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MemoryStream PEBOKJGIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CodedInputStream HHLFGBNKBAN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2EB0", Offset = "0x6BB14B0", VA = "0x186BB2EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EOKHIAMJPPB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JNHPNJCOCKF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public EOKHIAMJPPB<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FF2410", Offset = "0x1FF0A10", VA = "0x181FF2410", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1229360", Offset = "0x1227960", VA = "0x181229360")]
		[DebuggerHidden]
		public JNHPNJCOCKF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2E71290", Offset = "0x2E6F890", VA = "0x182E71290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2E71450", Offset = "0x2E6FA50", VA = "0x182E71450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> LFDBLFMPKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream PEBOKJGIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream HHLFGBNKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf BLIHMNHLENE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int DIDJDLOPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B80A0", Offset = "0x9B66A0", VA = "0x1809B80A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1225850", Offset = "0x1223E50", VA = "0x181225850")]
	private EOKHIAMJPPB(byte[] IOBPFDIOONK, Action<Protobuf> LFDBLFMPKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1A50020", Offset = "0x1A4E620", VA = "0x181A50020")]
	public static EOKHIAMJPPB<Protobuf> PJDMJLOGMBM<Data>(ReadOnlySpan<byte> FBJCGAGDCPB, ReadOnlySpan<Data> CINKNDJPGAB, Action<Protobuf> LFDBLFMPKMA)
	{
		return default(EOKHIAMJPPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x12256C0", Offset = "0x1223CC0", VA = "0x1812256C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1225700", Offset = "0x1223D00", VA = "0x181225700", Slot = "4")]
	[IteratorStateMachine(typeof(EOKHIAMJPPB<>.JNHPNJCOCKF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1225800", Offset = "0x1223E00", VA = "0x181225800", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HDOPEKOBLCB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] IOBPFDIOONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Protobuf BLIHMNHLENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream PEBOKJGIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedOutputStream OKJOLJACPCH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F680", Offset = "0x2E4DC80", VA = "0x182E4F680")]
	private HDOPEKOBLCB(byte[] IOBPFDIOONK, in Protobuf BLIHMNHLENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1994F40", Offset = "0x1993540", VA = "0x181994F40")]
	public static HDOPEKOBLCB<Protobuf> PJDMJLOGMBM<T>(ReadOnlySpan<T> CINKNDJPGAB)
	{
		return default(HDOPEKOBLCB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F5C0", Offset = "0x2E4DBC0", VA = "0x182E4F5C0")]
	public void HMLPANLDPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F5F0", Offset = "0x2E4DBF0", VA = "0x182E4F5F0")]
	public ByteString IGKBCNFEIBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F4A0", Offset = "0x2E4DAA0", VA = "0x182E4F4A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class LBGJJCHNIGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class NCFAJIDBGOD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static T FEBHELIDNED;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool OBGCOMANLPH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24EC0C0", Offset = "0x24EA6C0", VA = "0x1824EC0C0")]
		public static void IONAJKOHHFK(in T ABBAPCAIMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public NCFAJIDBGOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeParallelHashMap<JMNOBBGCFCL, int2> PMPKCKKIBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<byte> IOBPFDIOONK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BB21A0", Offset = "0x6BB07A0", VA = "0x186BB21A0")]
	public LBGJJCHNIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2301D40", Offset = "0x2300340", VA = "0x182301D40")]
	public void PCICHOODFHC<T>(T FEBHELIDNED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2303960", Offset = "0x2301F60", VA = "0x182303960")]
	public T PIDCPOPDLLJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1E70", Offset = "0x6BB0470", VA = "0x186BB1E70")]
	public void PCICHOODFHC(Type LFBJHCMDIAE, IGCFDMLBPPM FEBHELIDNED, int EMLFCDFCCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1C10", Offset = "0x6BB0210", VA = "0x186BB1C10")]
	public bool HNEMDLLFNLP(Type LFBJHCMDIAE, out IGCFDMLBPPM GOMDNNCBLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2040", Offset = "0x6BB0640", VA = "0x186BB2040")]
	public IGCFDMLBPPM PIDCPOPDLLJ(Type LFBJHCMDIAE)
	{
		return default(IGCFDMLBPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1840", Offset = "0x6BAFE40", VA = "0x186BB1840")]
	public NativeArray<byte>.ReadOnly BHMIFPDMNLN(Type LFBJHCMDIAE)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1CE0", Offset = "0x6BB02E0", VA = "0x186BB1CE0")]
	public bool IOIFIKPBLMK(Type LFBJHCMDIAE, out NativeArray<byte>.ReadOnly GOMDNNCBLHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1A50", Offset = "0x6BB0050", VA = "0x186BB1A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1AF0", Offset = "0x6BB00F0", VA = "0x186BB1AF0", Slot = "1")]
	~LBGJJCHNIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1770", Offset = "0x6BAFD70", VA = "0x186BB1770")]
	private NativeArray<byte>.ReadOnly BFCKAPINEFG(int2 OCPDKFKPGDF)
	{
		return default(NativeArray<byte>.ReadOnly);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HEDMIMHLNEJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T CNODGJBIHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2E52460", Offset = "0x2E50A60", VA = "0x182E52460")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2E519C0", Offset = "0x2E4FFC0", VA = "0x182E519C0")]
	public static HEDMIMHLNEJ<T> BJIOOOHFEFG(T FEBHELIDNED)
	{
		return default(HEDMIMHLNEJ<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E51C90", Offset = "0x2E50290", VA = "0x182E51C90")]
	public static T BJIOOOHFEFG(HEDMIMHLNEJ<T> LLDPFOJMFMC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DAKDIDNMNME
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static LBGJJCHNIGP LHPNCLCMEEJ;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2996990", Offset = "0x2994F90", VA = "0x182996990")]
	public static void PCICHOODFHC<T>(T FEBHELIDNED) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2997BA0", Offset = "0x29961A0", VA = "0x182997BA0")]
	public static T PIDCPOPDLLJ<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC360", Offset = "0x6BAA960", VA = "0x186BAC360")]
	public static NativeArray<byte>.ReadOnly BHMIFPDMNLN(Type LFBJHCMDIAE)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC3F0", Offset = "0x6BAA9F0", VA = "0x186BAC3F0")]
	public static bool HNEMDLLFNLP(Type LFBJHCMDIAE, out IGCFDMLBPPM GOMDNNCBLHP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IELFFCMDKAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int BIKMMIGFKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int EGIKAKGFKPB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EAPFBGNMJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x15C4E60", Offset = "0x15C3460", VA = "0x1815C4E60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x187E3D0", Offset = "0x187C9D0", VA = "0x18187E3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HKPLGJMDMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OHMPHOIFEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BADA70", Offset = "0x6BAC070", VA = "0x186BADA70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BADA50", Offset = "0x6BAC050", VA = "0x186BADA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA2D850", Offset = "0xA2BE50", VA = "0x180A2D850")]
	private IELFFCMDKAM(int BIKMMIGFKEM, int EGIKAKGFKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D06B70", Offset = "0x2D05170", VA = "0x182D06B70")]
	public static IELFFCMDKAM HAPPBGFEOCI(int BIKMMIGFKEM, int EGIKAKGFKPB)
	{
		return default(IELFFCMDKAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BADA60", Offset = "0x6BAC060", VA = "0x186BADA60")]
	public static IELFFCMDKAM DFBIDONKAEG(int OCFMKLJCPIC, int ANMDJLIBDCA)
	{
		return default(IELFFCMDKAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BADA80", Offset = "0x6BAC080", VA = "0x186BADA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LMPMABFJNNE : AOBGJMJGDNF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2AB0", Offset = "0x6BB10B0", VA = "0x186BB2AB0")]
	public float ALEBOAFLKGL(in float3 FEBHELIDNED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2AB0", Offset = "0x6BB10B0", VA = "0x186BB2AB0", Slot = "4")]
	private float CMNGDIMCDND(in float3 FEBHELIDNED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LEEFEFFINEG : AOBGJMJGDNF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2250", Offset = "0x6BB0850", VA = "0x186BB2250")]
	public float ALEBOAFLKGL(in float3 FEBHELIDNED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2250", Offset = "0x6BB0850", VA = "0x186BB2250", Slot = "4")]
	private float CMNGDIMCDND(in float3 FEBHELIDNED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KDONLBKCGJB : AOBGJMJGDNF<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xFA5BA0", Offset = "0xFA41A0", VA = "0x180FA5BA0")]
	public float ALEBOAFLKGL(in float3 FEBHELIDNED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xFA5BA0", Offset = "0xFA41A0", VA = "0x180FA5BA0", Slot = "4")]
	private float CMNGDIMCDND(in float3 FEBHELIDNED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DBPFDGNDGAP : AOBGJMJGDNF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xCA2350", Offset = "0xCA0950", VA = "0x180CA2350")]
	public int ALEBOAFLKGL(in int3 FEBHELIDNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xCA2350", Offset = "0xCA0950", VA = "0x180CA2350", Slot = "4")]
	private int MBNKKBAHBOH(in int3 FEBHELIDNED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GOEPOINDJDL : AOBGJMJGDNF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6620050", Offset = "0x661E650", VA = "0x186620050")]
	public int ALEBOAFLKGL(in int3 FEBHELIDNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6620050", Offset = "0x661E650", VA = "0x186620050", Slot = "4")]
	private int MBNKKBAHBOH(in int3 FEBHELIDNED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KDKJBABBHEC : AOBGJMJGDNF<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xC2C9C0", Offset = "0xC2AFC0", VA = "0x180C2C9C0")]
	public int ALEBOAFLKGL(in int3 FEBHELIDNED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xC2C9C0", Offset = "0xC2AFC0", VA = "0x180C2C9C0", Slot = "4")]
	private int MBNKKBAHBOH(in int3 FEBHELIDNED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
internal struct JDPIBKECBIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public ComponentDataFromEntity OJEFKGJMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<Entity> FJABEBKKNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeList<Entity> BJMAMMDKKDH;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BADE20", Offset = "0x6BAC420", VA = "0x186BADE20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CABCAINBNAP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Type OAIDEDFLBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Type[] GGHOMANHEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class AFBGDHKOKKB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly World MDGIABLFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly World ODAMNFHNHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly ENAOPEFLDPO KNKIJMLJGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ComponentSystemGroup[] HOEEAHFCGKN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public World OIEFMCLOMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World PFIMAHMBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager IKKIOEAOHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB960", Offset = "0x6BA9F60", VA = "0x186BAB960")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ENAOPEFLDPO OKNBJFAFJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CGFANCJIEGH<DLJPBMLDJCL> BLBNPCPKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CGFANCJIEGH<LALLAGCMIHJ> KICDLEOIIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x944080", Offset = "0x942680", VA = "0x180944080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x943FA0", Offset = "0x9425A0", VA = "0x180943FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public CGFANCJIEGH<JOKAIGELPGN> LOPGPFDMFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x91DC10", Offset = "0x91C210", VA = "0x18091DC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x943F90", Offset = "0x942590", VA = "0x180943F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> LDGNNMJJEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B9E880", Offset = "0x2B9CE80", VA = "0x182B9E880")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] AFBENCEHFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB140", Offset = "0x6BA9740", VA = "0x186BAB140")]
	public static AFBGDHKOKKB CGIGDMJGPGJ(string HNPIEGONNBC, CFLKABPILKO OHMIPIKLIJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BABAA0", Offset = "0x6BAA0A0", VA = "0x186BABAA0")]
	public AFBGDHKOKKB(string HNPIEGONNBC, CFLKABPILKO OHMIPIKLIJM = CFLKABPILKO.Simulation, LOKOCEGOEBH JCCGAOBBGPH = LOKOCEGOEBH.Default, bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB940", Offset = "0x6BA9F40", VA = "0x186BAB940")]
	public ComponentSystemBase MMFDLIJLOOJ(Type LFBJHCMDIAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1021E60", Offset = "0x1020460", VA = "0x181021E60")]
	public T MMFDLIJLOOJ<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB730", Offset = "0x6BA9D30", VA = "0x186BAB730")]
	public void JKDLIAGIJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB980", Offset = "0x6BA9F80", VA = "0x186BAB980")]
	public void OLALMMDKCOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB9E0", Offset = "0x6BA9FE0", VA = "0x186BAB9E0")]
	public void OPEIMJFBJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB790", Offset = "0x6BA9D90", VA = "0x186BAB790")]
	public void KCMGEAPKJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB2A0", Offset = "0x6BA98A0", VA = "0x186BAB2A0")]
	public void DJJKHLPBLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB8E0", Offset = "0x6BA9EE0", VA = "0x186BAB8E0")]
	public void MJPFPPEMGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BABA40", Offset = "0x6BAA040", VA = "0x186BABA40")]
	public void PJBJPNNIINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB3D0", Offset = "0x6BA99D0", VA = "0x186BAB3D0")]
	public void EMFDDIJGGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB300", Offset = "0x6BA9900", VA = "0x186BAB300")]
	public void DJOMMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB1C0", Offset = "0x6BA97C0", VA = "0x186BAB1C0")]
	public void DBPCEKCENHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB7F0", Offset = "0x6BA9DF0", VA = "0x186BAB7F0")]
	internal void KEALGALKKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB220", Offset = "0x6BA9820", VA = "0x186BAB220")]
	private bool DCKBPAENDIH(ComponentSystemGroup HBJKBGILPGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB460", Offset = "0x6BA9A60", VA = "0x186BAB460")]
	private void HBBCMEDNCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB030", Offset = "0x6BA9630", VA = "0x186BAB030")]
	private ComponentSystemGroup[] AJOKOLHEJAK(LOKOCEGOEBH JCCGAOBBGPH, bool BMBAENBDCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BAB360", Offset = "0x6BA9960", VA = "0x186BAB360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PKEMKEOPFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3790", Offset = "0x6BB1D90", VA = "0x186BB3790")]
	[MustUseReturnValue]
	public static JobHandle PCCOPIKMBAL(this EntityCommandBufferSystem BADPEALHEAI, NativeList<Entity> DJGJGAHPJBG, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3680", Offset = "0x6BB1C80", VA = "0x186BB3680")]
	[MustUseReturnValue]
	public static JobHandle PCCOPIKMBAL(this EntityCommandBufferSystem BADPEALHEAI, NativeArrayAsync<Entity> DJGJGAHPJBG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CAPKOIBPMMI
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x169DC20", Offset = "0x169C220", VA = "0x18169DC20")]
	public static void BIPDEPCBOJC<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityQuery BGIEPHHDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x169E2C0", Offset = "0x169C8C0", VA = "0x18169E2C0")]
	[MustUseReturnValue]
	public static JobHandle ODNOILLKIPE<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeListAsync<Entity> DJGJGAHPJBG, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x169DC90", Offset = "0x169C290", VA = "0x18169DC90")]
	[MustUseReturnValue]
	public static JobHandle ODNOILLKIPE<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArrayAsync<Entity> DJGJGAHPJBG, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class ENAOPEFLDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AFBGDHKOKKB MDGIABLFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EntityManager BJBBKAHIPJF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AFBGDHKOKKB OIEFMCLOMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BACF10", Offset = "0x6BAB510", VA = "0x186BACF10")]
	public ENAOPEFLDPO(AFBGDHKOKKB MDGIABLFKGC, EntityManager BJBBKAHIPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2932A40", Offset = "0x2931040", VA = "0x182932A40")]
	public bool EJPHIIJAFHI<T>(Entity PEKCJMKIHGK) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2930E60", Offset = "0x292F460", VA = "0x182930E60")]
	public bool AELBGGGFIKF<T>(Entity PEKCJMKIHGK, out T FEBHELIDNED) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2930EF0", Offset = "0x292F4F0", VA = "0x182930EF0")]
	public T EELDDJLLIIM<T>(Entity PEKCJMKIHGK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2932A80", Offset = "0x2931080", VA = "0x182932A80")]
	private ComponentType GNNIGHAJHJP<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BACD80", Offset = "0x6BAB380", VA = "0x186BACD80")]
	private ComponentType GNNIGHAJHJP(Type LFBJHCMDIAE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PKPKGLNBMEI
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct GIGICMJBDBD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NativeArray<Entity> EINDHDDOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<T> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct FJEFLFGCPKN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NativeList<Entity> EINDHDDOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NativeArray<T> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct EIHJCOLLIMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArrayAsync<Entity> EINDHDDOBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArrayAsync<T> PFFLBBOLLGN;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1A4F2B0", Offset = "0x1A4D8B0", VA = "0x181A4F2B0")]
		public NativeListAsync<Entity> HMADAENKIEI<TPredicate>() where TPredicate : struct, BLIDOPNDMJN<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1BFE930", Offset = "0x1BFCF30", VA = "0x181BFE930")]
	public static EIHJCOLLIMB<T> PHDMMNHHIAP<T>(this NativeArrayAsync<Entity> FJABEBKKNPA, NativeArrayAsync<T> IFNKDNOEFIH, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct
	{
		return default(EIHJCOLLIMB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NBJPPFEIPOE : DJNINENAFBF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Type AHCPPLAGJGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2E60", Offset = "0x6BB1460", VA = "0x186BB2E60")]
	public NBJPPFEIPOE(Type FNFGMPHBPOK, Type OJEFKGJMKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class LEPKCHNPNOO
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct GAHKKILFOII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly Dictionary<Type, List<Type>> PBJPEPIIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly HashSet<Type> AAGNKENEBPD;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	public GAHKKILFOII(Dictionary<Type, List<Type>> PBJPEPIIJHL, HashSet<Type> AAGNKENEBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KDKFCGOGFJG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MCPMBIDPPMA : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
		public KDKFCGOGFJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public KDKFCGOGFJG <>3__<>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public MCPMBIDPPMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2DD0", Offset = "0x6BB13D0", VA = "0x186BB2DD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2AC0", Offset = "0x6BB10C0", VA = "0x186BB2AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2C90", Offset = "0x6BB1290", VA = "0x186BB2C90")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2D90", Offset = "0x6BB1390", VA = "0x186BB2D90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2CE0", Offset = "0x6BB12E0", VA = "0x186BB2CE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2CE0", Offset = "0x6BB12E0", VA = "0x186BB2CE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct KACBCPGMBLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Dictionary<Type, List<Type>> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Queue<Type> queue;
	}

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Type PDBJAGMOBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private LOKOCEGOEBH JCCGAOBBGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool HFJCHFFELJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool HLKKLMNELKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool BMBAENBDCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IEnumerable<Type> IOAGDNIFPIH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEB50", Offset = "0x6BAD150", VA = "0x186BAEB50")]
	public static KDKFCGOGFJG PJDMJLOGMBM()
	{
		return default(KDKFCGOGFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEB80", Offset = "0x6BAD180", VA = "0x186BAEB80")]
	public KDKFCGOGFJG PNOFEKMKKMB(LOKOCEGOEBH OHMIPIKLIJM)
	{
		return default(KDKFCGOGFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE9A0", Offset = "0x6BACFA0", VA = "0x186BAE9A0")]
	public KDKFCGOGFJG MFDKJJGJAEB(IEnumerable<Type> ECOJOMPMEMB)
	{
		return default(KDKFCGOGFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEB70", Offset = "0x6BAD170", VA = "0x186BAEB70")]
	public KDKFCGOGFJG PLDIHLMCMFC(bool GLIOFAKKJOM)
	{
		return default(KDKFCGOGFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEB40", Offset = "0x6BAD140", VA = "0x186BAEB40")]
	public KDKFCGOGFJG NPPHPMHAAPI(bool JNCKFEMBPFN)
	{
		return default(KDKFCGOGFJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE900", Offset = "0x6BACF00", VA = "0x186BAE900")]
	public GAHKKILFOII KECJKJPPKBJ(Type[] PBIKCKMBMFF)
	{
		return default(GAHKKILFOII);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE870", Offset = "0x6BACE70", VA = "0x186BAE870")]
	[IteratorStateMachine(typeof(MCPMBIDPPMA))]
	internal IEnumerable<Type> HNAOANJPMKI(IEnumerable<Type> ECOJOMPMEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEB90", Offset = "0x6BAD190", VA = "0x186BAEB90")]
	internal Dictionary<Type, List<Type>> POPPDCDLAPL(IEnumerable<Type> ECOJOMPMEMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BADF40", Offset = "0x6BAC540", VA = "0x186BADF40")]
	private void ADMMMAIGLEF(Dictionary<Type, List<Type>> LKDCEDKMNCG, Type LFBJHCMDIAE, Type MIMAAAFBFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE6A0", Offset = "0x6BACCA0", VA = "0x186BAE6A0")]
	internal HashSet<Type> DMABBAEGDEE(IEnumerable<Type> HOEEAHFCGKN, Dictionary<Type, List<Type>> FLBCJEFNHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE050", Offset = "0x6BAC650", VA = "0x186BAE050")]
	internal bool CCNPOJOGPCI(Type LFBJHCMDIAE, LOKOCEGOEBH JCCGAOBBGPH, bool BMBAENBDCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE9E0", Offset = "0x6BACFE0", VA = "0x186BAE9E0")]
	[CompilerGenerated]
	internal static void NMBPIEGBGKB(Type LFBJHCMDIAE, ref KACBCPGMBLO P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BNFOPFONPDF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x544F270", Offset = "0x544D870", VA = "0x18544F270")]
	public static NativeList<Entity> GBMPAMFCHOH<T>(this NativeArray<Entity> FJABEBKKNPA, EntityManager BJBBKAHIPJF, Allocator HDOCJKNPNPA = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ICKNNNACGEF
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct AILEPEBIMCE : AOBGJMJGDNF<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> HLCKMKDHAEH;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BABFC0", Offset = "0x6BAA5C0", VA = "0x186BABFC0")]
		[BurstCompatible]
		public Entity ALEBOAFLKGL(in Entity FEBHELIDNED)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BABFC0", Offset = "0x6BAA5C0", VA = "0x186BABFC0", Slot = "4")]
		private Entity MDMMKOLCFOK(in Entity FEBHELIDNED)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class CNBANEJHGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC180", Offset = "0x6BAA780", VA = "0x186BAC180")]
	public static bool LJLNGHFNFKN(Type LFBJHCMDIAE, Type JBEOGMIBBOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class IFHPKCIGGPL : FOHBLAFNBJN
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BADBB0", Offset = "0x6BAC1B0", VA = "0x186BADBB0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase JILDIEOFOGM();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BADB60", Offset = "0x6BAC160", VA = "0x186BADB60")]
	protected ComponentSystemBase ANNFGHKNEOI(params ComponentSystemBase[] AAGNKENEBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2011220", Offset = "0x200F820", VA = "0x182011220")]
	protected ComponentSystemBase ANNFGHKNEOI<T>(params ComponentSystemBase[] AAGNKENEBPD) where T : FOHBLAFNBJN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2011310", Offset = "0x200F910", VA = "0x182011310")]
	protected ComponentSystemBase LNNJACENKPC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2011310", Offset = "0x200F910", VA = "0x182011310")]
	protected ComponentSystemBase NBNMFDGDKLD<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BADB10", Offset = "0x6BAC110", VA = "0x186BADB10")]
	protected ComponentSystemBase ALCLFJILEBG(params SystemHandleUntyped[] AAGNKENEBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2011190", Offset = "0x200F790", VA = "0x182011190")]
	protected ComponentSystemBase ALCLFJILEBG<T>(params SystemHandleUntyped[] AAGNKENEBPD) where T : FOHBLAFNBJN, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x20112C0", Offset = "0x200F8C0", VA = "0x1820112C0")]
	protected SystemHandleUntyped CGMODHIKCFI<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD0B0", Offset = "0x6BAB6B0", VA = "0x186BAD0B0")]
	protected IFHPKCIGGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface GFMKHDGGPAF<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGHKDEOPGPN(int BODNDJCNKFP);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGFANCJIEGH<BaseClass> JGPFICKHNLO();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FGFFPNFCNII
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x20B3D50", Offset = "0x20B2350", VA = "0x1820B3D50")]
	public static NativeList<T> PJBDMDJCJKP<T>(NativeList<T> IFNKDNOEFIH, Allocator HDOCJKNPNPA) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class PBPPFMIOFDP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct ELOJOHNPINF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : AOBGJMJGDNF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	public NativeArray<TFrom> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeList<TFrom> CNNHOEIDKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeParallelHashSet<TTo> ECEEIOKBPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public TMap INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct IJNNJHGIHIM<T, TPredicate> : IJob where T : struct where TPredicate : struct, BLIDOPNDMJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public NativeArray<T> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> EINDHDDOBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> DNNFBEAAFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public TPredicate INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1FF2FF0", Offset = "0x1FF15F0", VA = "0x181FF2FF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct FLJLDIJCKMC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, AOBGJMJGDNF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	public NativeArray<TFrom> ONFCGLFONGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[WriteOnly]
	public NativeList<TTo> NMHILBDKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TMap INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class MCEHPKDILOP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public LOKOCEGOEBH PELMOJMIPBA;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class IBANKEAEACJ : LKOIIDAOMOG<NBJPPFEIPOE, DLJPBMLDJCL>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD9E0", Offset = "0x6BABFE0", VA = "0x186BAD9E0")]
	public IBANKEAEACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class LKOIIDAOMOG<Attribute, BaseClass> : GFMKHDGGPAF<BaseClass>, GKBJHDBHLPK where Attribute : DJNINENAFBF
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string HNPIEGONNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, Type> GOOFLCHIFHN;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2E0EB20", Offset = "0x2E0D120", VA = "0x182E0EB20")]
	public LKOIIDAOMOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E5F0", Offset = "0x2E0CBF0", VA = "0x182E0E5F0", Slot = "4")]
	public bool GGHKDEOPGPN(int BODNDJCNKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E650", Offset = "0x2E0CC50", VA = "0x182E0E650", Slot = "5")]
	public CGFANCJIEGH<BaseClass> JGPFICKHNLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E8F0", Offset = "0x2E0CEF0", VA = "0x182E0E8F0", Slot = "7")]
	protected virtual bool LJLNGHFNFKN(Type LFBJHCMDIAE, int CLLBMJDMHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E560", Offset = "0x2E0CB60", VA = "0x182E0E560", Slot = "8")]
	protected virtual int EGMDNJMOBGM(Type LFBJHCMDIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E9F0", Offset = "0x2E0CFF0", VA = "0x182E0E9F0")]
	public void NGALBCBKFHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x2E0E4C0", Offset = "0x2E0CAC0", VA = "0x182E0E4C0", Slot = "6")]
	public void BLMBLLKPLEN(Type LFBJHCMDIAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KLLMFKDDDNP
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct LJKOMAOMKBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly ulong MNJINDFEKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly PNGHFJFCFKJ LNOPBDHGFFF;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x15C4190", Offset = "0x15C2790", VA = "0x1815C4190")]
		public LJKOMAOMKBH(ulong IBJCFHMGFFG, PNGHFJFCFKJ BPECCILLAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB29B0", Offset = "0x6BB0FB0", VA = "0x186BB29B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class OLKBKCHGIBM : IEnumerable<PNGHFJFCFKJ>, IEnumerable, IEnumerator<PNGHFJFCFKJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private PNGHFJFCFKJ <>2__current;

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
		private IEnumerator<JMCBBDDNFGG> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private JMCBBDDNFGG <attrib>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private PNGHFJFCFKJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Attributes.NameHash>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PNGHFJFCFKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6BB32D0", Offset = "0x6BB18D0", VA = "0x186BB32D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F3CA0", Offset = "0x9F22A0", VA = "0x1809F3CA0")]
		[DebuggerHidden]
		public OLKBKCHGIBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3320", Offset = "0x6BB1920", VA = "0x186BB3320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2F20", Offset = "0x6BB1520", VA = "0x186BB2F20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3190", Offset = "0x6BB1790", VA = "0x186BB3190")]
		private void PIAHDKPIMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3290", Offset = "0x6BB1890", VA = "0x186BB3290", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB31E0", Offset = "0x6BB17E0", VA = "0x186BB31E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PNGHFJFCFKJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB31E0", Offset = "0x6BB17E0", VA = "0x186BB31E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Type IOMFOHEFNDC;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static Dictionary<ulong, int> PPNAADFMBEL;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static LJKOMAOMKBH[] FHPGHJFKOCL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool OBGCOMANLPH;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0D90", Offset = "0x6BAF390", VA = "0x186BB0D90")]
	public static ulong JPONJKOKGMF(int BODNDJCNKFP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BB13D0", Offset = "0x6BAF9D0", VA = "0x186BB13D0")]
	public static int MHABKJECIOH(ulong BPECCILLAHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0E80", Offset = "0x6BAF480", VA = "0x186BB0E80")]
	public static void KGHKJOCLFMF(bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0520", Offset = "0x6BAEB20", VA = "0x186BB0520")]
	private static void FHIFBAJHFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BB05E0", Offset = "0x6BAEBE0", VA = "0x186BB05E0")]
	private static void FHIFBAJHFEC(IEnumerable<Type> ECOJOMPMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0CB0", Offset = "0x6BAF2B0", VA = "0x186BB0CB0")]
	private static void JNAPJHFLLPD(int CLBEIJFJNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BB01D0", Offset = "0x6BAE7D0", VA = "0x186BB01D0")]
	private static void CCGMOLGEIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0B30", Offset = "0x6BAF130", VA = "0x186BB0B30")]
	private static (ulong, IEnumerable<PNGHFJFCFKJ>) HKOCGEHECIL(Type LFBJHCMDIAE)
	{
		return default((ulong, IEnumerable<PNGHFJFCFKJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0DF0", Offset = "0x6BAF3F0", VA = "0x186BB0DF0")]
	[IteratorStateMachine(typeof(OLKBKCHGIBM))]
	private static IEnumerable<PNGHFJFCFKJ> KGGHHDOBHIN(Type LFBJHCMDIAE, ulong BPECCILLAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6BB10D0", Offset = "0x6BAF6D0", VA = "0x186BB10D0")]
	private static void KPEFLNFJCFN(ulong BPECCILLAHP, IEnumerable<PNGHFJFCFKJ> LDOPIHAIIPN, TypeManager.TypeInfo KKEDDOLGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0A30", Offset = "0x6BAF030", VA = "0x186BB0A30")]
	private static void GNMCGJHHIOJ(LJKOMAOMKBH KKEDDOLGMFO, int BODNDJCNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BB08B0", Offset = "0x6BAEEB0", VA = "0x186BB08B0")]
	private static void FLIELNNNPNI(LJKOMAOMKBH KKEDDOLGMFO, int BODNDJCNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6BB09A0", Offset = "0x6BAEFA0", VA = "0x186BB09A0")]
	private static LJKOMAOMKBH GMCJLCPLIKK(int BODNDJCNKFP)
	{
		return default(LJKOMAOMKBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1480", Offset = "0x6BAFA80", VA = "0x186BB1480")]
	private static int MHHOHGBPPMK(int BODNDJCNKFP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class GHBKPJENOLH
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct JJCNIICPFHC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NativeArray<T>.ReadOnly JHKFLJIAOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int DGHDJOAODLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int LEGMPHKFDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private T FNKDCLHHBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private T PJEKJMNEHAP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IELFFCMDKAM JIOGCDMDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2056DB0", Offset = "0x20553B0", VA = "0x182056DB0")]
			get
			{
				return default(IELFFCMDKAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EJPDGBNEKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x15C51E0", Offset = "0x15C37E0", VA = "0x1815C51E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, IELFFCMDKAM) PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x372F460", Offset = "0x372DA60", VA = "0x18372F460")]
			get
			{
				return default((T, IELFFCMDKAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x372F9B0", Offset = "0x372DFB0", VA = "0x18372F9B0")]
		public JJCNIICPFHC(NativeArray<T> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x240A0D0", Offset = "0x24086D0", VA = "0x18240A0D0")]
		public JJCNIICPFHC<T> PFBFKEIKCCB()
		{
			return default(JJCNIICPFHC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x372F5E0", Offset = "0x372DBE0", VA = "0x18372F5E0")]
		public bool OOCNFJOMNCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1999790", Offset = "0x1997D90", VA = "0x181999790")]
		public LBDJEFGDACI<T, TComparer> LJIGCHMOLDL<TComparer>([Optional] TComparer OOCJOJBKFEG) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LBDJEFGDACI<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LBDJEFGDACI<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<T>.ReadOnly JHKFLJIAOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int DGHDJOAODLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int LEGMPHKFDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T FNKDCLHHBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T PJEKJMNEHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TComparer OOCJOJBKFEG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IELFFCMDKAM JIOGCDMDANF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x2056DB0", Offset = "0x20553B0", VA = "0x182056DB0")]
			get
			{
				return default(IELFFCMDKAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T EJPDGBNEKGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x15C51E0", Offset = "0x15C37E0", VA = "0x1815C51E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, IELFFCMDKAM range) PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x2056CE0", Offset = "0x20552E0", VA = "0x182056CE0")]
			get
			{
				return default((T, IELFFCMDKAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2057060", Offset = "0x2055660", VA = "0x182057060")]
		public LBDJEFGDACI(NativeArray<T>.ReadOnly JHKFLJIAOGC, TComparer OOCJOJBKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2057020", Offset = "0x2055620", VA = "0x182057020")]
		public LBDJEFGDACI<T, TComparer> PFBFKEIKCCB()
		{
			return default(LBDJEFGDACI<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2056DC0", Offset = "0x20553C0", VA = "0x182056DC0")]
		public bool OOCNFJOMNCK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1B7A1A0", Offset = "0x1B787A0", VA = "0x181B7A1A0")]
	public static JJCNIICPFHC<T> ANNFGHKNEOI<T>(this NativeArray<T> JHKFLJIAOGC) where T : struct
	{
		return default(JJCNIICPFHC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AOBGJMJGDNF<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ALEBOAFLKGL(in TFrom FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AHDFLEKOJMC
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GJLDIEDDKOO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GJEGGFOLBKJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		public GJEGGFOLBKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class FPNJNHNLAFA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		public FPNJNHNLAFA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<Func<JobHandle, JobHandle>> EHACKJPNMKE;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD180", Offset = "0x6BAB780", VA = "0x186BAD180")]
	public GJLDIEDDKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AGJANIKNDPK
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class CIEMMMCHGKG : EntityCommandBufferSystem, OHPHFEGDEGO
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
	protected CIEMMMCHGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CLCHNNGBNOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x16A9DD0", Offset = "0x16A83D0", VA = "0x1816A9DD0")]
	[MustUseReturnValue]
	public static JobHandle ELPIPEBGKNF<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArray<Entity> DJGJGAHPJBG, NativeArray<T> GOMDNNCBLHP, JobHandle BKEGHOOCGPC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct GHJPDIALADA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	public NativeArray<T> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<T> CNNHOEIDKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeParallelHashSet<T> ECEEIOKBPPG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2100", Offset = "0x2DC0700", VA = "0x182DC2100", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CGFANCJIEGH<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<int, BaseClass> JKNEDCECEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<Type, BaseClass> DJKLBFOHMHN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KLPPADFIIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2BB24E0", Offset = "0x2BB0AE0", VA = "0x182BB24E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> LLBGLHMLEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2510", Offset = "0x2BB0B10", VA = "0x182BB2510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2960", Offset = "0x2BB0F60", VA = "0x182BB2960")]
	public CGFANCJIEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BB27C0", Offset = "0x2BB0DC0", VA = "0x182BB27C0")]
	public CGFANCJIEGH(int IOKNIDFIOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2740", Offset = "0x2BB0D40", VA = "0x182BB2740")]
	internal void PEECNHFNIGK(int BODNDJCNKFP, BaseClass KNKIJMLJGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1A47FE0", Offset = "0x1A465E0", VA = "0x181A47FE0")]
	public bool DNOBBCPABEI<T>(out BaseClass FEBHELIDNED) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB2410", Offset = "0x2BB0A10", VA = "0x182BB2410")]
	public bool DNOBBCPABEI(Type OPJLLGPDDMN, out BaseClass FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x28F1FB0", Offset = "0x28F05B0", VA = "0x1828F1FB0")]
	public bool LHHMOIFIOHI(int BODNDJCNKFP, out BaseClass FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1A48DA0", Offset = "0x1A473A0", VA = "0x181A48DA0")]
	public T HBLKAAMONFO<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB24B0", Offset = "0x2BB0AB0", VA = "0x182BB24B0")]
	public BaseClass HBLKAAMONFO(Type PCGECMHEPLF)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class CGMFPJBNNCK : LKOIIDAOMOG<FKAKJEIIGLM, LALLAGCMIHJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC110", Offset = "0x6BAA710", VA = "0x186BAC110")]
	public CGMFPJBNNCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct KBDLFIJIICN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BADEE0", Offset = "0x6BAC4E0", VA = "0x186BADEE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HIAIJPMKKAL
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AD54C0", Offset = "0x2AD3AC0", VA = "0x182AD54C0")]
	public static NativeArray<T> MLEPAGJGKEC<T>(this NativeList<Entity> IFNKDNOEFIH, EntityManager BJBBKAHIPJF, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5250", Offset = "0x2AD3850", VA = "0x182AD5250")]
	public static NativeArray<T> MLEPAGJGKEC<T>(this NativeArray<Entity> IFNKDNOEFIH, EntityManager BJBBKAHIPJF, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface GGFECNKNGLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NPNLCENKBKD
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct BJKIFNPCOAL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public T FEBHELIDNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3927B60", Offset = "0x3926160", VA = "0x183927B60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AFDEMGDOCFC
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x10220E0", Offset = "0x10206E0", VA = "0x1810220E0")]
	[MustUseReturnValue]
	public static JobHandle PGAFLCJDGEO<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, EntityQuery BGIEPHHDBCF, T FEBHELIDNED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1022000", Offset = "0x1020600", VA = "0x181022000")]
	[MustUseReturnValue]
	public static JobHandle PGAFLCJDGEO<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArrayAsync<Entity> DJGJGAHPJBG, NativeArrayAsync<T> FEBHELIDNED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1021E90", Offset = "0x1020490", VA = "0x181021E90")]
	[MustUseReturnValue]
	public static JobHandle PGAFLCJDGEO<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, NativeArrayAsync<Entity> DJGJGAHPJBG, NativeArrayAsync<T> FEBHELIDNED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class GDFEIHIMHCH : LKOIIDAOMOG<NCKNDIGLLDH, JOKAIGELPGN>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD110", Offset = "0x6BAB710", VA = "0x186BAD110")]
	public GDFEIHIMHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class JDGJKBFHEAL<Data> : LALLAGCMIHJ where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public virtual Data EDEKLFBDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x29FBCB0", Offset = "0x29FA2B0", VA = "0x1829FBCB0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F00860", Offset = "0x1EFEE60", VA = "0x181F00860", Slot = "8")]
	protected virtual bool DMINBGOOKMK(ReadOnlySpan<Data> CINKNDJPGAB, DMLKBMEDDEL JIOGNMAJEEJ, out ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "9")]
	protected virtual bool PAGOOBJBPDJ(int BOBBHCFAPPK, Span<Data> CINKNDJPGAB, in ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29FA1C0", Offset = "0x29F87C0", VA = "0x1829FA1C0", Slot = "5")]
	internal sealed override bool DMINBGOOKMK(ref Unity.Entities.Chunk DABCHPLIHMK, int KJKLBJFEDLA, DMLKBMEDDEL JIOGNMAJEEJ, out ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x29FA730", Offset = "0x29F8D30", VA = "0x1829FA730", Slot = "6")]
	internal sealed override bool PAGOOBJBPDJ(int BOBBHCFAPPK, ref Unity.Entities.Chunk DABCHPLIHMK, int KJKLBJFEDLA, in ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x19996A0", Offset = "0x1997CA0", VA = "0x1819996A0")]
	protected HDOPEKOBLCB<Protobuf> FFPGDOOCPAK<Protobuf>(ReadOnlySpan<Data> CINKNDJPGAB) where Protobuf : IMessage, new()
	{
		return default(HDOPEKOBLCB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x19996F0", Offset = "0x1997CF0", VA = "0x1819996F0")]
	protected EOKHIAMJPPB<Protobuf> JOBGNCMOPML<Protobuf>(ReadOnlySpan<byte> FBJCGAGDCPB, ReadOnlySpan<Data> CINKNDJPGAB, Action<Protobuf> LFDBLFMPKMA) where Protobuf : IMessage, new()
	{
		return default(EOKHIAMJPPB<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2135EB0", Offset = "0x21344B0", VA = "0x182135EB0")]
	protected JDGJKBFHEAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class LALLAGCMIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected internal abstract int KPKAGFLDHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1750", Offset = "0x6BAFD50", VA = "0x186BB1750", Slot = "5")]
	internal virtual bool DMINBGOOKMK(ref Unity.Entities.Chunk DABCHPLIHMK, int KJKLBJFEDLA, DMLKBMEDDEL JIOGNMAJEEJ, out ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x921810", Offset = "0x91FE10", VA = "0x180921810", Slot = "6")]
	internal virtual bool PAGOOBJBPDJ(int BOBBHCFAPPK, ref Unity.Entities.Chunk DABCHPLIHMK, int KJKLBJFEDLA, in ReadOnlySpan<byte> FBJCGAGDCPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected LALLAGCMIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HJNNFMOEBGB
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct PBPIBFHLFPG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct PFAPBLBNCJL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			internal PBPIBFHLFPG<TFrom> KHJHJOOPMKP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal NativeArray<TFrom> FDDHIMHLJAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct OCLNODMMGKH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct CJLBONEEFKD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			internal OCLNODMMGKH<TFrom> KHJHJOOPMKP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal NativeList<TFrom> FDDHIMHLJAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct PMMDGMLNDPK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct BMDICABNEGI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			internal PMMDGMLNDPK<TFrom> KHJHJOOPMKP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal NativeArrayAsync<TFrom> FDDHIMHLJAI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct PMMCDFPPCGF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct IMCGNBJDCJG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			internal PMMCDFPPCGF<TFrom> KHJHJOOPMKP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal NativeListAsync<TFrom> FDDHIMHLJAI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct LGJJIAKPOBF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EPHOPPPDCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	public NativeArray<Entity> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[WriteOnly]
	public NativeArray<T> NMHILBDKBOH;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DFA260", Offset = "0x2DF8860", VA = "0x182DFA260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BurstCompile]
internal struct GAHCAJHDJKN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OJEFKGJMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	public NativeArray<Entity> FJABEBKKNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> EAACDEBGCMI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct NBEGJABKLNC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	public NativeArray<T> BCDJFNKOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x24E97A0", Offset = "0x24E7DA0", VA = "0x1824E97A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DKHCPEHKCKA
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class BCEBELHLHEA
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D07340", Offset = "0x1D05940", VA = "0x181D07340")]
	public static NativeListAsync<Entity> OIHACOCHODJ<T, TPredicate>(this NativeArrayAsync<T> IFNKDNOEFIH, NativeArrayAsync<Entity> FJABEBKKNPA, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct where TPredicate : struct, BLIDOPNDMJN<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D07190", Offset = "0x1D05790", VA = "0x181D07190")]
	private static NativeListAsync<Entity> IBIHMAIIOBE<T, TPredicate>(NativeArrayAsync<T> MGIDMNAPOMG, NativeArrayAsync<Entity> FJABEBKKNPA, int CPHEGBCGAHF, Allocator HDOCJKNPNPA) where T : struct where TPredicate : struct, BLIDOPNDMJN<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MGMNPFAMMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x177AD00", Offset = "0x1779300", VA = "0x18177AD00")]
	[MustUseReturnValue]
	public static JobHandle GAGPNBEHMDE<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArray<Entity> DJGJGAHPJBG, T FEBHELIDNED, [Optional] JobHandle BKEGHOOCGPC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x177AC30", Offset = "0x1779230", VA = "0x18177AC30")]
	[MustUseReturnValue]
	public static JobHandle GAGPNBEHMDE<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, NativeArray<Entity> DJGJGAHPJBG, T FEBHELIDNED, [Optional] JobHandle BKEGHOOCGPC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x177AB60", Offset = "0x1779160", VA = "0x18177AB60")]
	[MustUseReturnValue]
	public static JobHandle GAGPNBEHMDE<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, NativeArray<Entity> DJGJGAHPJBG, NativeArray<T> BCDJFNKOFCL, [Optional] JobHandle BKEGHOOCGPC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class NCKNDIGLLDH : DJNINENAFBF
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class LHDFECJBICD
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2313830", Offset = "0x2311E30", VA = "0x182313830")]
	public static NativeList<T> PJBDMDJCJKP<T>(this NativeList<T> IFNKDNOEFIH, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2313660", Offset = "0x2311C60", VA = "0x182313660")]
	public static NativeList<T> PJBDMDJCJKP<T>(this NativeArray<T> IFNKDNOEFIH, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class MLDLECIOBFB
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct BOLONBAHJNE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeArray<T> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KJJJEPHMLKJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<T> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct BNJLAHONCJD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeArrayAsync<T> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct HHBIEDNBJAK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NativeListAsync<T> PFFLBBOLLGN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct HKJAHPJCECP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, AOBGJMJGDNF<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<TFrom> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[WriteOnly]
	public NativeArray<TTo> NMHILBDKBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public TMap INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
public enum LOKOCEGOEBH
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
public interface BLIDOPNDMJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HMADAENKIEI(T FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct LMGEOHCHOMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ComponentTypes JFPGBOMFJBO;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2A50", Offset = "0x6BB1050", VA = "0x186BB2A50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct MLPGCLLIMJP<T, TPredicate> : IJob where T : struct where TPredicate : struct, BLIDOPNDMJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	public NativeArray<T> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<T> CNNHOEIDKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public TPredicate INJMGBDPOBO;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class FOHBLAFNBJN : MDMOCCLABPA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD080", Offset = "0x6BAB680", VA = "0x186BAD080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD0B0", Offset = "0x6BAB6B0", VA = "0x186BAD0B0")]
	public FOHBLAFNBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class DJNINENAFBF : JAHLGPIJLNB
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Type JMJKDALCGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x35848A0", Offset = "0x3582EA0", VA = "0x1835848A0")]
	public DJNINENAFBF(Type OJEFKGJMKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class PMKPBFNEAAF
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly Dictionary<int, int> LPFCGLFCOAE;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool OBGCOMANLPH;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB39A0", Offset = "0x6BB1FA0", VA = "0x186BB39A0")]
	public static int FPHMOFKIKCK(int BODNDJCNKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3A40", Offset = "0x6BB2040", VA = "0x186BB3A40")]
	public static void KGHKJOCLFMF(bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3AE0", Offset = "0x6BB20E0", VA = "0x186BB3AE0")]
	private static void NFDLMELPOPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3D60", Offset = "0x6BB2360", VA = "0x186BB3D60")]
	private static int POOIOGKEMGO(Type LFBJHCMDIAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3920", Offset = "0x6BB1F20", VA = "0x186BB3920")]
	private static void CCIICLEBIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BurstCompile]
internal struct GIANLCOCDDD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OJEFKGJMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	public NativeArray<Entity> FJABEBKKNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<bool> EAACDEBGCMI;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2DC32A0", Offset = "0x2DC18A0", VA = "0x182DC32A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct CEGHKHECMLE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeArray<T> GOMDNNCBLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x364FD10", Offset = "0x364E310", VA = "0x18364FD10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FNJBJFJAIHO
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BACFF0", Offset = "0x6BAB5F0", VA = "0x186BACFF0")]
	public static ulong GCKGOEEPMBL(Type LFBJHCMDIAE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6BACF80", Offset = "0x6BAB580", VA = "0x186BACF80")]
	public static ulong GCKGOEEPMBL(string FFPCEODMBGJ)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal static class LILIINHIPNJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly Dictionary<Type, int> AGLPPHMDAMJ;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static bool OBGCOMANLPH;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2790", Offset = "0x6BB0D90", VA = "0x186BB2790")]
	public static void KGHKJOCLFMF(bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6BB22E0", Offset = "0x6BB08E0", VA = "0x186BB22E0")]
	private static void EMEPDHLPIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2510", Offset = "0x6BB0B10", VA = "0x186BB2510")]
	private static void IBIDFEGJGHM(Type PJDPBHHAMCC, Type DPNGJGBLPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2260", Offset = "0x6BB0860", VA = "0x186BB2260")]
	private static void CCIICLEBIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2830", Offset = "0x6BB0E30", VA = "0x186BB2830")]
	public static int NJOBICMGGDL(Type PJDPBHHAMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB26F0", Offset = "0x6BB0CF0", VA = "0x186BB26F0")]
	public static bool KDAPLKKPCEI(Type PJDPBHHAMCC, out int BODNDJCNKFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class KGJMLCDCJJF
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEF80", Offset = "0x6BAD580", VA = "0x186BAEF80")]
	public static ComponentSystemGroup[] AJOKOLHEJAK(World MDGIABLFKGC, LOKOCEGOEBH JCCGAOBBGPH = LOKOCEGOEBH.Default, bool BMBAENBDCKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF050", Offset = "0x6BAD650", VA = "0x186BAF050")]
	private static Type[] DDJELIAEMBN(LOKOCEGOEBH JCCGAOBBGPH, bool BMBAENBDCKP, ComponentSystemGroup[] HOEEAHFCGKN, ComponentSystemGroup EJGLCHDPGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF540", Offset = "0x6BADB40", VA = "0x186BAF540")]
	private static ComponentSystemGroup[] ICBEENOMDKF(World MDGIABLFKGC, out ComponentSystemGroup EJGLCHDPGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFEB0", Offset = "0x6BAE4B0", VA = "0x186BAFEB0")]
	internal static bool MKDOJIMBCKA(CFLKABPILKO OHMIPIKLIJM, out CABCAINBNAP GBBMPJOFFEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF850", Offset = "0x6BADE50", VA = "0x186BAF850")]
	private static ComponentSystemGroup IOHCHNPCGHD(Type LFBJHCMDIAE, World MDGIABLFKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF410", Offset = "0x6BADA10", VA = "0x186BAF410")]
	private static ComponentSystemGroup[] FPHGIKABLNP(Type[] ECOJOMPMEMB, World MDGIABLFKGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF930", Offset = "0x6BADF30", VA = "0x186BAF930")]
	internal static void JHDLDDBNHPM(World MDGIABLFKGC, Type[] BJNBGDBCODC, ComponentSystemGroup[] HOEEAHFCGKN, ComponentSystemGroup EJGLCHDPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF3B0", Offset = "0x6BAD9B0", VA = "0x186BAF3B0")]
	internal static bool DICHADGPKPE(ComponentSystemBase DKJCAOAEBFD, ComponentSystemGroup[] HOEEAHFCGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFE50", Offset = "0x6BAE450", VA = "0x186BAFE50")]
	private static void LFBLDNDONCM(ComponentSystemGroup[] HOEEAHFCGKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class FKAKJEIIGLM : DJNINENAFBF
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x35848A0", Offset = "0x3582EA0", VA = "0x1835848A0")]
	public FKAKJEIIGLM(Type OJEFKGJMKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BurstCompile]
internal struct HLBFNCFDMBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public ComponentDataFromEntity OJEFKGJMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	public NativeArray<Entity> FJABEBKKNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public NativeList<Entity> BJMAMMDKKDH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD950", Offset = "0x6BABF50", VA = "0x186BAD950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class IPDKKDCNEBN : SystemBase, OHPHFEGDEGO
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6BADD40", Offset = "0x6BAC340", VA = "0x186BADD40")]
	public ComponentDataFromEntity NKFLBMHCBLF(int BODNDJCNKFP, bool ELNCOGPNOCM = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6BADD20", Offset = "0x6BAC320", VA = "0x186BADD20")]
	public EntityExistenceLookupByEntity LAFMJHAPBAF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6BADE10", Offset = "0x6BAC410", VA = "0x186BADE10", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	protected IPDKKDCNEBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class JPCKEHCPKFH : IPDKKDCNEBN
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6BADEB0", Offset = "0x6BAC4B0", VA = "0x186BADEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	protected JPCKEHCPKFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class CJCNCGHCNHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface OHPHFEGDEGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class MDMOCCLABPA : ComponentSystemGroup, OHPHFEGDEGO
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD0B0", Offset = "0x6BAB6B0", VA = "0x186BAD0B0")]
	protected MDMOCCLABPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class BCJAFAIJJLO<View, Data> : DLJPBMLDJCL where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static ComponentType JCEJNANHDIK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override Type IMMFPADKGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x50BBFB0", Offset = "0x50BA5B0", VA = "0x1850BBFB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int DABLBPLHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x306FAB0", Offset = "0x306E0B0", VA = "0x18306FAB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x306F680", Offset = "0x306DC80", VA = "0x18306F680")]
	public Data CMHICPGENOM(Entity PEKCJMKIHGK)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View FKKHFCFCKNI(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x35F7580", Offset = "0x35F5B80", VA = "0x1835F7580", Slot = "14")]
	protected internal override T FKKHFCFCKNI<T>(Entity PEKCJMKIHGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2135EB0", Offset = "0x21344B0", VA = "0x182135EB0")]
	protected BCJAFAIJJLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class DLJPBMLDJCL : NKNEAONODKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DynamicComponentTypeHandle OIHEJHEBMDO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EntityManager IKKIOEAOHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xF4BDA0", Offset = "0xF4A3A0", VA = "0x180F4BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract Type IMMFPADKGII
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int DABLBPLHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Type BMANJCAJJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x46060F0", Offset = "0x46046F0", VA = "0x1846060F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int GNFMECFLELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC8D0", Offset = "0x6BAAED0", VA = "0x186BAC8D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private PKJHJMAHAIO[] IPCJIKBDHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1382230", Offset = "0x1380830", VA = "0x181382230", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual PKJHJMAHAIO[] KHJAKIBCAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC810", Offset = "0x6BAAE10", VA = "0x186BAC810", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC6F0", Offset = "0x6BAACF0", VA = "0x186BAC6F0")]
	public void KGHKJOCLFMF(EntityManager BJBBKAHIPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA62EB0", Offset = "0xA614B0", VA = "0x180A62EB0")]
	protected NKNEAONODKJ JEGLNDFFBCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T FKKHFCFCKNI<T>(Entity PEKCJMKIHGK) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC620", Offset = "0x6BAAC20", VA = "0x186BAC620", Slot = "8")]
	public (uint, uint) FPHMOFKIKCK(Entity PEKCJMKIHGK)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC580", Offset = "0x6BAAB80", VA = "0x186BAC580", Slot = "9")]
	public bool ANNIJOIHIAC(Entity PEKCJMKIHGK, (uint order, uint change) BOBBHCFAPPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected DLJPBMLDJCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct EDODGJINCKN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly CMJEFMOJNAO NJCJMLIIBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<Type> ECOJOMPMEMB;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	private EDODGJINCKN(List<Type> ECOJOMPMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6BACC60", Offset = "0x6BAB260", VA = "0x186BACC60")]
	public static void NGALBCBKFHF(List<Type> ECOJOMPMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BACA30", Offset = "0x6BAB030", VA = "0x186BACA30")]
	private void MPDKPPCJOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC9B0", Offset = "0x6BAAFB0", VA = "0x186BAC9B0")]
	private bool LJLNGHFNFKN(Type LFBJHCMDIAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC950", Offset = "0x6BAAF50", VA = "0x186BAC950")]
	private void HFJBIBICFCI(Type LFBJHCMDIAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class DOJJOFMDJPO
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
internal struct FKIDIFGCPEC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EPHOPPPDCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	public NativeArray<Entity> PFFLBBOLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[WriteOnly]
	public NativeList<T> CNNHOEIDKMD;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
public enum CFLKABPILKO
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
public class OIKHBGEEDLE : JAHLGPIJLNB
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CFLKABPILKO IFMKHANHMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x86D470", Offset = "0x86BA70", VA = "0x18086D470")]
		[CompilerGenerated]
		get
		{
			return default(CFLKABPILKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2EF0", Offset = "0x6BB14F0", VA = "0x186BB2EF0")]
	public OIKHBGEEDLE(CFLKABPILKO OHMIPIKLIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class OBACPKBOGAI : JAHLGPIJLNB
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	public OBACPKBOGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class JOKAIGELPGN
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	protected JOKAIGELPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class PGDLIOOJNPP
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct EHGABDJGHPK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly NativeArray<TSrc> JHKFLJIAOGC;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public EHGABDJGHPK(NativeArray<TSrc> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		public GDIOJPPEPJM<TSrc, TValue> LAOILIOGJAJ<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(GDIOJPPEPJM<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct GDIOJPPEPJM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly NativeArray<TSrc> JHKFLJIAOGC;

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public GDIOJPPEPJM(NativeArray<TSrc> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
		public NDBHAHNFIEO<TSrc, TValue, TSelector> DIPKNPGDJJG<TSelector>() where TSelector : struct, AOBGJMJGDNF<TSrc, TValue>
		{
			return default(NDBHAHNFIEO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct NDBHAHNFIEO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, AOBGJMJGDNF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> JHKFLJIAOGC;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
		public NDBHAHNFIEO(NativeArray<TSrc> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x24EE500", Offset = "0x24ECB00", VA = "0x1824EE500")]
		public DBHAOHEHOMD<TSrc, TValue, TSelector> ANNFGHKNEOI()
		{
			return default(DBHAOHEHOMD<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct PGHGKECPLLA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, AOBGJMJGDNF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly NativeArray<TSrc> JHKFLJIAOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TSelector OAFBJNCKOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int IIOMOLKAONM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TValue PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2C4FD10", Offset = "0x2C4E310", VA = "0x182C4FD10")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int IKGMLJIBDML
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x954B80", Offset = "0x953180", VA = "0x180954B80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int DIDJDLOPKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xD4FCC0", Offset = "0xD4E2C0", VA = "0x180D4FCC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FD90", Offset = "0x2C4E390", VA = "0x182C4FD90")]
		public PGHGKECPLLA(NativeArray<TSrc> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FD80", Offset = "0x2C4E380", VA = "0x182C4FD80")]
		public bool OOCNFJOMNCK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2C4FBF0", Offset = "0x2C4E1F0", VA = "0x182C4FBF0")]
		private TSrc DMJOENDHLHC(int JMCLMPHOKNG)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct DBHAOHEHOMD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, AOBGJMJGDNF<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private PGHGKECPLLA<TSrc, TValue, TSelector> NLCCEHBOCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TValue FNKDCLHHBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int DGHDJOAODLO;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public IELFFCMDKAM JIOGCDMDANF
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x25B2B30", Offset = "0x25B1130", VA = "0x1825B2B30")]
			get
			{
				return default(IELFFCMDKAM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue EJPDGBNEKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x944070", Offset = "0x942670", VA = "0x180944070")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, IELFFCMDKAM range) PGNBHIOAFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x25B2A60", Offset = "0x25B1060", VA = "0x1825B2A60")]
			get
			{
				return default((TValue, IELFFCMDKAM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x25B2CA0", Offset = "0x25B12A0", VA = "0x1825B2CA0")]
		public DBHAOHEHOMD(NativeArray<TSrc> JHKFLJIAOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x15C4C80", Offset = "0x15C3280", VA = "0x1815C4C80")]
		public DBHAOHEHOMD<TSrc, TValue, TSelector> PFBFKEIKCCB()
		{
			return default(DBHAOHEHOMD<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x25B2B70", Offset = "0x25B1170", VA = "0x1825B2B70")]
		public bool OOCNFJOMNCK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1BFCCE0", Offset = "0x1BFB2E0", VA = "0x181BFCCE0")]
	public static EHGABDJGHPK<T> BIOJANIOKFO<T>(this NativeList<T> EKFNNDEBOAK) where T : struct
	{
		return default(EHGABDJGHPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA96690", Offset = "0xA94C90", VA = "0x180A96690")]
	public static EHGABDJGHPK<T> BIOJANIOKFO<T>(this NativeArray<T> JHKFLJIAOGC) where T : struct
	{
		return default(EHGABDJGHPK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class GPHJOJEPBPD
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct BFGFIBEOMKH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct GENCGDEOJMB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public BFGFIBEOMKH<TFrom> FDDHIMHLJAI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<TFrom> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct MINAEKGGOBD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct KFBDMJMEJGP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public MINAEKGGOBD<TFrom> FDDHIMHLJAI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NativeArrayAsync<TFrom> PFFLBBOLLGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct FPHJCFAKFLF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct ICAHIPGMKJD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public FPHJCFAKFLF<TFrom> FDDHIMHLJAI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Allocator HDOCJKNPNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NativeListAsync<TFrom> PFFLBBOLLGN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
internal struct HFFBBGGJHOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<Entity> DJGJGAHPJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EntityCommandBuffer FEDAIFMANMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ComponentType OPJLLGPDDMN;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD920", Offset = "0x6BABF20", VA = "0x186BAD920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class FMEFKDKIABC
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1B6C9C0", Offset = "0x1B6AFC0", VA = "0x181B6C9C0")]
	public static bool IEPLEMKMOGA<T>(this NativeArray<Entity> FJABEBKKNPA, EntityManager BJBBKAHIPJF, Allocator HDOCJKNPNPA = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class DBIIAMFMDLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class KABCNJCDOEN
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class MCAENBEEEDE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual bool GCPJODOCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9146D0", Offset = "0x912CD0", VA = "0x1809146D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	protected MCAENBEEEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class AJHCJMHPGKE : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public AJHCJMHPGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class HNIPLJFAFCB : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public HNIPLJFAFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class HGPNJGALKEE : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public HGPNJGALKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class ODCNEHACDGI : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public ODCNEHACDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class KIGEFLMEOIE : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public KIGEFLMEOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class MFIOCBCAMKA : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public MFIOCBCAMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class DFFDMANNMPP : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public DFFDMANNMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class ALIACFLGCLO : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public ALIACFLGCLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class CLEODJBIGIB : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public CLEODJBIGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class FNLOEPJKKCA : FICLOIAHHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public FNLOEPJKKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class KIEAKDJCODH : FICLOIAHHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public KIEAKDJCODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class FIHIBKNGCBH : FICLOIAHHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public FIHIBKNGCBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class AJFAHOFJICJ : FICLOIAHHMC
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public AJFAHOFJICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[DisableAutoCreation]
[EJCCKEPGBMA(GMBNIBPKKJK.Application)]
public class FICLOIAHHMC : MCAENBEEEDE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override bool GCPJODOCHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x915250", Offset = "0x913850", VA = "0x180915250", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6BABFD0", Offset = "0x6BAA5D0", VA = "0x186BABFD0")]
	public FICLOIAHHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class HAKPOLMMLJM
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly IBANKEAEACJ NNAPBMDLLAM;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly CGMFPJBNNCK ONIBOHPFGCB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly GDFEIHIMHCH AOLJEBIHMPG;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly List<Type> PBCIHELMKML;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static bool OBGCOMANLPH;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	internal static GFMKHDGGPAF<DLJPBMLDJCL> BLBNPCPKCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD690", Offset = "0x6BABC90", VA = "0x186BAD690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static GFMKHDGGPAF<LALLAGCMIHJ> KICDLEOIIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD200", Offset = "0x6BAB800", VA = "0x186BAD200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static GFMKHDGGPAF<JOKAIGELPGN> LOPGPFDMFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD2E0", Offset = "0x6BAB8E0", VA = "0x186BAD2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD340", Offset = "0x6BAB940", VA = "0x186BAD340")]
	public static void KGHKJOCLFMF(bool PNPIPMIPGBD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6BAD260", Offset = "0x6BAB860", VA = "0x186BAD260")]
	public static Type[] EKNGLLCLMEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PCGOCMFCPGN
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1BFB560", Offset = "0x1BF9B60", VA = "0x181BFB560")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArrayAsync<Entity> DJGJGAHPJBG, NativeArrayAsync<T> GOMDNNCBLHP, [Optional] JobHandle BKEGHOOCGPC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1BFBB90", Offset = "0x1BFA190", VA = "0x181BFBB90")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArrayAsync<Entity> DJGJGAHPJBG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x1BFB6B0", Offset = "0x1BF9CB0", VA = "0x181BFB6B0")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM<T>(this EntityCommandBufferSystem BADPEALHEAI, NativeArray<Entity> DJGJGAHPJBG, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1BFBA70", Offset = "0x1BFA070", VA = "0x181BFBA70")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM<T>(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, NativeArray<Entity> DJGJGAHPJBG, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6BB33B0", Offset = "0x6BB19B0", VA = "0x186BB33B0")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM(this EntityCommandBufferSystem BADPEALHEAI, NativeArray<Entity> DJGJGAHPJBG, ComponentTypes JFPGBOMFJBO, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3520", Offset = "0x6BB1B20", VA = "0x186BB3520")]
	[MustUseReturnValue]
	public static JobHandle KENKEAKDJMM(this EntityCommandBufferSystem BADPEALHEAI, EntityCommandBuffer FEDAIFMANMN, NativeArray<Entity> DJGJGAHPJBG, ComponentTypes JFPGBOMFJBO, [Optional] JobHandle BKEGHOOCGPC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class POAHJHILGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4030", Offset = "0x6BB2630", VA = "0x186BB4030")]
	private unsafe static Span<byte> NKGMEILHIGD(Unity.Entities.Chunk* DABCHPLIHMK, int KJKLBJFEDLA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1C043E0", Offset = "0x1C029E0", VA = "0x181C043E0")]
	public unsafe static Span<T> EFJAAFEBGLD<T>(Unity.Entities.Chunk* DABCHPLIHMK, int KJKLBJFEDLA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1C043A0", Offset = "0x1C029A0", VA = "0x181C043A0")]
	public static Span<T> EFJAAFEBGLD<T>(this ref Unity.Entities.Chunk DABCHPLIHMK, int KJKLBJFEDLA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3FC0", Offset = "0x6BB25C0", VA = "0x186BB3FC0")]
	public unsafe static Span<Entity> GAEAGNBLOHE(Unity.Entities.Chunk* DABCHPLIHMK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3E30", Offset = "0x6BB2430", VA = "0x186BB3E30")]
	public unsafe static void CCIICLEBIPJ(Unity.Entities.Chunk* DABCHPLIHMK, int KJKLBJFEDLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class DMLKBMEDDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> PHGHPDGEGLJ;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2098710", Offset = "0x2096D10", VA = "0x182098710")]
	public DMLKBMEDDEL(NativeArray<EntityRemapUtility.EntityRemapInfo> PHGHPDGEGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC940", Offset = "0x6BAAF40", VA = "0x186BAC940")]
	public Entity IJCCKPACBGC(Entity BDIPIDIIILI)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AttributeUsage(AttributeTargets.Class)]
public class PEBGPAOMBFI : JAHLGPIJLNB
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x9BED80", Offset = "0x9BD380", VA = "0x1809BED80")]
	public PEBGPAOMBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class KNBLECKHHFD
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate void NNAJNEPDBNI<From, To>(From FDDHIMHLJAI, ref To PBFCNGOCEEJ, DMLKBMEDDEL JIOGNMAJEEJ);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class GCBABEPBCCH<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static NNAJNEPDBNI<From, To> HJAEMCIFPPE;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GCBABEPBCCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1590", Offset = "0x6BAFB90", VA = "0x186BB1590")]
	static KNBLECKHHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3887ED0", Offset = "0x38864D0", VA = "0x183887ED0")]
	public static void GOMALBALKJJ<T>(NNAJNEPDBNI<T, T> CMEHOEDKMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3887CD0", Offset = "0x38862D0", VA = "0x183887CD0")]
	public static void GOMALBALKJJ<From, To>(NNAJNEPDBNI<From, To> CMEHOEDKMKM, NNAJNEPDBNI<To, From> IBPDPHJJMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3887D60", Offset = "0x3886360", VA = "0x183887D60")]
	public static void GOMALBALKJJ<From, To>(NNAJNEPDBNI<From, To> HJAEMCIFPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3881C90", Offset = "0x3880290", VA = "0x183881C90")]
	public static NNAJNEPDBNI<From, To> GKKMJIIPKCN<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3880E30", Offset = "0x387F430", VA = "0x183880E30")]
	public static void AMBAMIOHBJM<From, To>(From FDDHIMHLJAI, ref To PBFCNGOCEEJ, DMLKBMEDDEL JIOGNMAJEEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface CFDHHNGIBNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOHCINOJMMB(Entity PEKCJMKIHGK, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHBMJIIKPND(Entity PEKCJMKIHGK, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ENCEGKDHKBO(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> DFFMLGOELGM(Entity PEKCJMKIHGK);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LGEGMHHGDLF(Entity PEKCJMKIHGK);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class AOHPPEMBOHN<TComponentData, TValue> : BGLKEBPECBJ<TValue>, IDisposable where TComponentData : struct, PJLMLLPIOIJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class JINBAFKOGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> EKFNNDEBOAK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int KLPPADFIIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x1AD0FB0", Offset = "0x1ACF5B0", VA = "0x181AD0FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x372D320", Offset = "0x372B920", VA = "0x18372D320")]
		public bool DLDJIJCOOOG(out TValue FEBHELIDNED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x372D460", Offset = "0x372BA60", VA = "0x18372D460")]
		public void PEECNHFNIGK(object LODBJLOKBLP, TValue FEBHELIDNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x372D3E0", Offset = "0x372B9E0", VA = "0x18372D3E0")]
		public bool FAKCPBGGFBC(object LODBJLOKBLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x372D270", Offset = "0x372B870", VA = "0x18372D270")]
		public int AEFBMFIIMHN(object LODBJLOKBLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x372D510", Offset = "0x372BB10", VA = "0x18372D510")]
		public JINBAFKOGNH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<JINBAFKOGNH> HGIGJPAJBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private AEPPHAAOECH<BPBJOMPNFMJ, JINBAFKOGNH> BLHKNHKEIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager BJBBKAHIPJF;

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C69110", Offset = "0x3C67710", VA = "0x183C69110")]
	public AOHPPEMBOHN(EntityManager BJBBKAHIPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C68C40", Offset = "0x3C67240", VA = "0x183C68C40", Slot = "4")]
	public void EOHCINOJMMB(Entity PEKCJMKIHGK, object LODBJLOKBLP, TValue FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C68F80", Offset = "0x3C67580", VA = "0x183C68F80", Slot = "5")]
	public bool PHBMJIIKPND(Entity PEKCJMKIHGK, object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C68B50", Offset = "0x3C67150", VA = "0x183C68B50", Slot = "6")]
	public bool DLDJIJCOOOG(Entity PEKCJMKIHGK, out TValue FEBHELIDNED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C68C20", Offset = "0x3C67220", VA = "0x183C68C20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C68F00", Offset = "0x3C67500", VA = "0x183C68F00")]
	private void PGOGEEADDIH(JINBAFKOGNH KFNLBHOMCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C68E30", Offset = "0x3C67430", VA = "0x183C68E30")]
	private bool JMBLNBNNLFK(Entity PEKCJMKIHGK, out BPBJOMPNFMJ GMLKHLPDINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C68AC0", Offset = "0x3C670C0", VA = "0x183C68AC0")]
	private void DKGEBDOFJGC(Entity PEKCJMKIHGK, BPBJOMPNFMJ GMLKHLPDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C68AA0", Offset = "0x3C670A0", VA = "0x183C68AA0")]
	private bool BEPJMJDFHOL(BPBJOMPNFMJ GMLKHLPDINM, out JINBAFKOGNH KFNLBHOMCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3C68D60", Offset = "0x3C67360", VA = "0x183C68D60")]
	private JINBAFKOGNH EPLNKENPIPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface BGLKEBPECBJ<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOHCINOJMMB(Entity PEKCJMKIHGK, object LODBJLOKBLP, TValue FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHBMJIIKPND(Entity PEKCJMKIHGK, object LODBJLOKBLP);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DLDJIJCOOOG(Entity PEKCJMKIHGK, out TValue FEBHELIDNED);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface PJLMLLPIOIJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BPBJOMPNFMJ CLPMLFCNGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct BPBJOMPNFMJ : GAIFJLIBHND<BPBJOMPNFMJ>, DMCNAIJDMDB, IEquatable<BPBJOMPNFMJ>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly BPBJOMPNFMJ MJIPICDIFME;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int IKGMLJIBDML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CreateProperty]
	public int KPKAGFLDHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x15C4E60", Offset = "0x15C3460", VA = "0x1815C4E60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x187E3D0", Offset = "0x187C9D0", VA = "0x18187E3D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC030", Offset = "0x6BAA630", VA = "0x186BAC030", Slot = "8")]
	public bool Equals(BPBJOMPNFMJ EJECOGCICOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6BAC080", Offset = "0x6BAA680", VA = "0x186BAC080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class EGGGMJEICDB<THasTokensTag> : CFDHHNGIBNG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Dictionary<Entity, BPBJOMPNFMJ> ANJJIONHPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stack<HashSet<object>> HGIGJPAJBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private AEPPHAAOECH<BPBJOMPNFMJ, HashSet<object>> BLHKNHKEIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager BJBBKAHIPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem BADPEALHEAI;

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A56610", Offset = "0x2A54C10", VA = "0x182A56610")]
	public EGGGMJEICDB(EntityManager BJBBKAHIPJF, EntityCommandBufferSystem BADPEALHEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A55670", Offset = "0x2A53C70", VA = "0x182A55670", Slot = "4")]
	public bool EOHCINOJMMB(Entity PEKCJMKIHGK, object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A56350", Offset = "0x2A54950", VA = "0x182A56350", Slot = "5")]
	public bool PHBMJIIKPND(Entity PEKCJMKIHGK, object LODBJLOKBLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A554B0", Offset = "0x2A53AB0", VA = "0x182A554B0", Slot = "6")]
	public bool ENCEGKDHKBO(Entity PEKCJMKIHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A555D0", Offset = "0x2A53BD0", VA = "0x182A555D0", Slot = "10")]
	public bool ENCEGKDHKBO(BPBJOMPNFMJ GMLKHLPDINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A55200", Offset = "0x2A53800", VA = "0x182A55200", Slot = "7")]
	public IEnumerable<object> DFFMLGOELGM(Entity PEKCJMKIHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A55000", Offset = "0x2A53600", VA = "0x182A55000", Slot = "11")]
	public IEnumerable<object> DFFMLGOELGM(BPBJOMPNFMJ GMLKHLPDINM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A55EE0", Offset = "0x2A544E0", VA = "0x182A55EE0", Slot = "8")]
	public bool LGEGMHHGDLF(Entity PEKCJMKIHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A55430", Offset = "0x2A53A30", VA = "0x182A55430", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A56120", Offset = "0x2A54720", VA = "0x182A56120")]
	private void PGOGEEADDIH(HashSet<object> KFNLBHOMCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A55B50", Offset = "0x2A54150", VA = "0x182A55B50")]
	private bool JMBLNBNNLFK(Entity PEKCJMKIHGK, out BPBJOMPNFMJ GMLKHLPDINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A55D10", Offset = "0x2A54310", VA = "0x182A55D10")]
	private bool KLELFJPDDNA(Entity PEKCJMKIHGK, out BPBJOMPNFMJ GMLKHLPDINM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A56090", Offset = "0x2A54690", VA = "0x182A56090")]
	private void PFCHCBDKNDC(Entity PEKCJMKIHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A552C0", Offset = "0x2A538C0", VA = "0x182A552C0")]
	private void DGLNOKNHKGN(Entity PEKCJMKIHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A54F80", Offset = "0x2A53580", VA = "0x182A54F80")]
	private void DAHNOKJFJMB(Entity PEKCJMKIHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A553C0", Offset = "0x2A539C0", VA = "0x182A553C0")]
	private void DKGEBDOFJGC(Entity PEKCJMKIHGK, BPBJOMPNFMJ GMLKHLPDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A56030", Offset = "0x2A54630", VA = "0x182A56030")]
	private bool MJOLFJNODOO(BPBJOMPNFMJ GMLKHLPDINM, out HashSet<object> KFNLBHOMCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A559D0", Offset = "0x2A53FD0", VA = "0x182A559D0")]
	private HashSet<object> EPLNKENPIPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class OIJEEIEMIJG
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void LDPPKBFPNFK(this CMJEFMOJNAO NJCJMLIIBBO, NativeArray<Entity> DJGJGAHPJBG, [Optional][CallerFilePath] string AAONFIOOJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void LDPPKBFPNFK(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, NativeArray<Entity> DJGJGAHPJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void LDPPKBFPNFK(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<Entity> DJGJGAHPJBG, bool GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void FIAAOLFNOOM(this CMJEFMOJNAO NJCJMLIIBBO, NativeArray<Entity> DJGJGAHPJBG, EntityManager BJBBKAHIPJF, [Optional][CallerFilePath] string AAONFIOOJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void FIAAOLFNOOM(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<Entity> DJGJGAHPJBG, EntityManager BJBBKAHIPJF, bool GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void PJIBLAPEIMD(this CMJEFMOJNAO NJCJMLIIBBO, NativeArray<Entity> DJGJGAHPJBG, NativeArray<Entity> NANANNGJCIL, [Optional][CallerFilePath] string AAONFIOOJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void PJIBLAPEIMD(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<Entity> DJGJGAHPJBG, NativeArray<Entity> NANANNGJCIL, bool GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1BF08C0", Offset = "0x1BEEEC0", VA = "0x181BF08C0")]
	public static void KPAEFJOGELL<T>(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, NativeArray<Entity> DJGJGAHPJBG, NativeList<T> GOMDNNCBLHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0870", Offset = "0x1BEEE70", VA = "0x181BF0870")]
	public static void KPAEFJOGELL<T>(this CMJEFMOJNAO NJCJMLIIBBO, NativeArray<Entity> DJGJGAHPJBG, NativeArray<T> GOMDNNCBLHP, [Optional][CallerFilePath] string AAONFIOOJNP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0830", Offset = "0x1BEEE30", VA = "0x181BF0830")]
	public static void KPAEFJOGELL<T>(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, NativeArray<Entity> DJGJGAHPJBG, NativeArray<T> GOMDNNCBLHP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void KPAEFJOGELL<T>(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<Entity> DJGJGAHPJBG, NativeArray<T> GOMDNNCBLHP, bool GHPPJEFLOKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1BF07D0", Offset = "0x1BEEDD0", VA = "0x181BF07D0")]
	public static void KDLKMJBINFN<T>(this CMJEFMOJNAO NJCJMLIIBBO, NativeList<T> GOMDNNCBLHP, [Optional][CallerFilePath] string AAONFIOOJNP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1BF07A0", Offset = "0x1BEEDA0", VA = "0x181BF07A0")]
	public static void KDLKMJBINFN<T>(this CMJEFMOJNAO NJCJMLIIBBO, NativeArray<T> GOMDNNCBLHP, [Optional][CallerFilePath] string AAONFIOOJNP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void KDLKMJBINFN<T>(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<T> GOMDNNCBLHP, bool GHPPJEFLOKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void OCFNNDFKMKE(this CMJEFMOJNAO NJCJMLIIBBO, EntityQuery BGIEPHHDBCF, [Optional][CallerFilePath] string AAONFIOOJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void OCFNNDFKMKE(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, EntityQuery BGIEPHHDBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void OCFNNDFKMKE(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, EntityQuery BGIEPHHDBCF, bool GHPPJEFLOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0770", Offset = "0x1BEED70", VA = "0x181BF0770")]
	public static void ENICLDBOFFG<T, T2>(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, EntityQuery BGIEPHHDBCF) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	private static void ENICLDBOFFG<T, T2>(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, EntityQuery BGIEPHHDBCF, bool GHPPJEFLOKJ) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0770", Offset = "0x1BEED70", VA = "0x181BF0770")]
	public static void IPIEACMPPDN<T>(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, NativeList<T> JHKFLJIAOGC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void IPIEACMPPDN<T>(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeList<T> JHKFLJIAOGC, bool GHPPJEFLOKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1BF0770", Offset = "0x1BEED70", VA = "0x181BF0770")]
	public static void JFGILEGCFEG<T>(this CMJEFMOJNAO NJCJMLIIBBO, string HNPIEGONNBC, NativeArray<T> JHKFLJIAOGC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750")]
	public static void JFGILEGCFEG<T>(this CMJEFMOJNAO NJCJMLIIBBO, string AAONFIOOJNP, NativeArray<T> JHKFLJIAOGC, bool GHPPJEFLOKJ) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
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
