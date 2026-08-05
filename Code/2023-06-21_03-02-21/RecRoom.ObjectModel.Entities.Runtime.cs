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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BEB480", Offset = "0x6BEA680", VA = "0x186BEB480")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FHLKGAJODDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly byte[] HEENIHIEKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemoryStream MNDMLEMMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CodedOutputStream NKJLPCNMOFM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB4A0", Offset = "0x6BEA6A0", VA = "0x186BEB4A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HEIEKJDKAJP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MemoryStream MNDMLEMMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CodedInputStream ODDIENGHFAB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBA50", Offset = "0x6BEAC50", VA = "0x186BEBA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GGDNLJDGAPA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class HLDJHNKDPMA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public GGDNLJDGAPA<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8F8BD0", Offset = "0x8F7DD0", VA = "0x1808F8BD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2DD00E0", Offset = "0x2DCF2E0", VA = "0x182DD00E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x275B2F0", Offset = "0x275A4F0", VA = "0x18275B2F0")]
		[DebuggerHidden]
		public HLDJHNKDPMA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCFEE0", Offset = "0x2DCF0E0", VA = "0x182DCFEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2DD00A0", Offset = "0x2DCF2A0", VA = "0x182DD00A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> CFNMGBODIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream MNDMLEMMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream ODDIENGHFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf KPGLOHJPHFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int CGOAKPGGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x841C90", Offset = "0x840E90", VA = "0x180841C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFF10", Offset = "0x3EEF110", VA = "0x183EEFF10")]
	private GGDNLJDGAPA(byte[] HEENIHIEKKF, Action<Protobuf> CFNMGBODIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x262DEC0", Offset = "0x262D0C0", VA = "0x18262DEC0")]
	public static GGDNLJDGAPA<Protobuf> LNIGJBIDADO<Data>(ReadOnlySpan<byte> CFOODOIEFBB, ReadOnlySpan<Data> HMNOPGDGOJJ, Action<Protobuf> CFNMGBODIJH)
	{
		return default(GGDNLJDGAPA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFD80", Offset = "0x3EEEF80", VA = "0x183EEFD80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFDC0", Offset = "0x3EEEFC0", VA = "0x183EEFDC0", Slot = "4")]
	[IteratorStateMachine(typeof(GGDNLJDGAPA<>.HLDJHNKDPMA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3EEFEC0", Offset = "0x3EEF0C0", VA = "0x183EEFEC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HOPFLHGPKGN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] HEENIHIEKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Protobuf KPGLOHJPHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream MNDMLEMMFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedOutputStream NKJLPCNMOFM;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCDE0", Offset = "0x2DDBFE0", VA = "0x182DDCDE0")]
	private HOPFLHGPKGN(byte[] HEENIHIEKKF, in Protobuf KPGLOHJPHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x26327C0", Offset = "0x26319C0", VA = "0x1826327C0")]
	public static HOPFLHGPKGN<Protobuf> LNIGJBIDADO<T>(ReadOnlySpan<T> HMNOPGDGOJJ)
	{
		return default(HOPFLHGPKGN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCC00", Offset = "0x2DDBE00", VA = "0x182DDCC00")]
	public void DPPCKMGJFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCD50", Offset = "0x2DDBF50", VA = "0x182DDCD50")]
	public ByteString KBAMJNAOHLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2DDCC30", Offset = "0x2DDBE30", VA = "0x182DDCC30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OFKFFPHNNJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class IBECPOBCAPI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static T ACKOJNNBEBO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool JJKMPKPOGCP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2D92B70", Offset = "0x2D91D70", VA = "0x182D92B70")]
		public static void FPAONKDPNEF(in T GFFDBEMENLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public IBECPOBCAPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeHashMap<HFEMONOGMMO, int2> ICLNJLBDMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<byte> HEENIHIEKKF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0640", Offset = "0x6BEF840", VA = "0x186BF0640")]
	public OFKFFPHNNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x34C1A50", Offset = "0x34C0C50", VA = "0x1834C1A50")]
	public void EBIKLMMGLOI<T>(T ACKOJNNBEBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x34C3670", Offset = "0x34C2870", VA = "0x1834C3670")]
	public T MEINKDCJHDP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFCB0", Offset = "0x6BEEEB0", VA = "0x186BEFCB0")]
	public void EBIKLMMGLOI(Type JAACLLLIGMF, GMFPPNNBHJB ACKOJNNBEBO, int FFKJPDKGMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0200", Offset = "0x6BEF400", VA = "0x186BF0200")]
	public bool IDJOIMMOOEO(Type JAACLLLIGMF, out GMFPPNNBHJB JCEJEOAKGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF02D0", Offset = "0x6BEF4D0", VA = "0x186BF02D0")]
	public GMFPPNNBHJB MEINKDCJHDP(Type JAACLLLIGMF)
	{
		return default(GMFPPNNBHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF03A0", Offset = "0x6BEF5A0", VA = "0x186BF03A0")]
	public NativeArray<byte>.ReadOnly MJHGDNBMGID(Type JAACLLLIGMF)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFE80", Offset = "0x6BEF080", VA = "0x186BEFE80")]
	public bool EKKKAFDCBHE(Type JAACLLLIGMF, out NativeArray<byte>.ReadOnly JCEJEOAKGOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFC10", Offset = "0x6BEEE10", VA = "0x186BEFC10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0010", Offset = "0x6BEF210", VA = "0x186BF0010", Slot = "1")]
	~OFKFFPHNNJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0130", Offset = "0x6BEF330", VA = "0x186BF0130")]
	private NativeArray<byte>.ReadOnly GBNADBANAEH(int2 PPDOIDEGPCN)
	{
		return default(NativeArray<byte>.ReadOnly);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MNDNANJGJOL<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T IHPKAGOHFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C360", Offset = "0x2C7B560", VA = "0x182C7C360")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D620", Offset = "0x2C7C820", VA = "0x182C7D620")]
	public static MNDNANJGJOL<T> MDCOPBLGMCP(T ACKOJNNBEBO)
	{
		return default(MNDNANJGJOL<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F230", Offset = "0x2C7E430", VA = "0x182C7F230")]
	public static T MDCOPBLGMCP(MNDNANJGJOL<T> DDGOMDBNGFF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CLHGGPMFOIG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static OFKFFPHNNJJ NANIAFPAINE;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E46B70", Offset = "0x2E45D70", VA = "0x182E46B70")]
	public static void EBIKLMMGLOI<T>(T ACKOJNNBEBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D80", Offset = "0x2E46F80", VA = "0x182E47D80")]
	public static T MEINKDCJHDP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA610", Offset = "0x6BE9810", VA = "0x186BEA610")]
	public static NativeArray<byte>.ReadOnly MJHGDNBMGID(Type JAACLLLIGMF)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA580", Offset = "0x6BE9780", VA = "0x186BEA580")]
	public static bool IDJOIMMOOEO(Type JAACLLLIGMF, out GMFPPNNBHJB JCEJEOAKGOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ANLNPEGKJAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int ADLHMCAGLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int IGDJHHPIJBK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OAELCJGKCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC56930", Offset = "0xC55B30", VA = "0x180C56930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x159B400", Offset = "0x159A600", VA = "0x18159B400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IKMFAAIPDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DNFFBAJCDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9D60", Offset = "0x6BE8F60", VA = "0x186BE9D60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9D50", Offset = "0x6BE8F50", VA = "0x186BE9D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86FF80", Offset = "0x86F180", VA = "0x18086FF80")]
	private ANLNPEGKJAF(int ADLHMCAGLJA, int IGDJHHPIJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3BFAFD0", Offset = "0x3BFA1D0", VA = "0x183BFAFD0")]
	public static ANLNPEGKJAF HDFGDNJOLDG(int ADLHMCAGLJA, int IGDJHHPIJBK)
	{
		return default(ANLNPEGKJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9D40", Offset = "0x6BE8F40", VA = "0x186BE9D40")]
	public static ANLNPEGKJAF FPDOOECAALF(int CPPJLPOOLJG, int AIMLNLNCPLA)
	{
		return default(ANLNPEGKJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9D70", Offset = "0x6BE8F70", VA = "0x186BE9D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OGCJFKEDFPL : FBGIPHGKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BF07D0", Offset = "0x6BEF9D0", VA = "0x186BF07D0")]
	public float ECBDNFMACBD(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BF07D0", Offset = "0x6BEF9D0", VA = "0x186BF07D0", Slot = "4")]
	private float LCFOIOHBCCJ(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MPABMDACNDF : FBGIPHGKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF6E0", Offset = "0x6BEE8E0", VA = "0x186BEF6E0")]
	public float ECBDNFMACBD(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF6E0", Offset = "0x6BEE8E0", VA = "0x186BEF6E0", Slot = "4")]
	private float LCFOIOHBCCJ(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct COIPHGICGCF : FBGIPHGKDFE<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1CE81B0", Offset = "0x1CE73B0", VA = "0x181CE81B0")]
	public float ECBDNFMACBD(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE81B0", Offset = "0x1CE73B0", VA = "0x181CE81B0", Slot = "4")]
	private float LCFOIOHBCCJ(in float3 ACKOJNNBEBO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FOELDKMIKEK : FBGIPHGKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x10E0050", Offset = "0x10DF250", VA = "0x1810E0050")]
	public int ECBDNFMACBD(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10E0050", Offset = "0x10DF250", VA = "0x1810E0050", Slot = "4")]
	private int ODMMNCHKDIM(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LCIPJDKNCEP : FBGIPHGKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6763610", Offset = "0x6762810", VA = "0x186763610")]
	public int ECBDNFMACBD(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6763610", Offset = "0x6762810", VA = "0x186763610", Slot = "4")]
	private int ODMMNCHKDIM(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DMLDDFGIIJH : FBGIPHGKDFE<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x18B2250", Offset = "0x18B1450", VA = "0x1818B2250")]
	public int ECBDNFMACBD(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x18B2250", Offset = "0x18B1450", VA = "0x1818B2250", Slot = "4")]
	private int ODMMNCHKDIM(in int3 ACKOJNNBEBO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
internal struct NNJDBHOPHIJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public ComponentDataFromEntity EKKFGMNHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<Entity> EPLNAGGLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeList<Entity> MJOJGOPKLNG;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF6F0", Offset = "0x6BEE8F0", VA = "0x186BEF6F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OPJCCMPKCLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Type GKFGILEGBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Type[] LDPHCLLOECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class AMEHENOOIKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly World EIAHLMIGNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly World OJGJJGMCNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DAPDDMANBGJ DFFNFBOJLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ComponentSystemGroup[] PDPGAHIJLHO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public World KBDCDOFELIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World PCEIEGPMHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager GLHEACEJGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9470", Offset = "0x6BE8670", VA = "0x186BE9470")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DAPDDMANBGJ CCKFADONHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EKENKDNMCMN<MAPMLCJFIJL> EHHJJBODKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EKENKDNMCMN<JNIMENAMJOD> HJMNCKEJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF660", Offset = "0x8DE860", VA = "0x1808DF660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EKENKDNMCMN<KPLMCFJAMHK> EAICHDDILCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8DF670", Offset = "0x8DE870", VA = "0x1808DF670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> LCKLJFKANOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x365FA10", Offset = "0x365EC10", VA = "0x18365FA10")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] HBLHDLHCBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9050", Offset = "0x6BE8250", VA = "0x186BE9050")]
	public static AMEHENOOIKA CPLIBCPOPGP(string PCKMHBLNCII, CAONBNKGIMF BIAEGHNJKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9820", Offset = "0x6BE8A20", VA = "0x186BE9820")]
	public AMEHENOOIKA(string PCKMHBLNCII, CAONBNKGIMF BIAEGHNJKDJ = CAONBNKGIMF.Simulation, ONIPDAHKEAG GMGCAACJFOL = ONIPDAHKEAG.Default, bool PPHFAHHOGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9130", Offset = "0x6BE8330", VA = "0x186BE9130")]
	public ComponentSystemBase DKLEDPBMIGD(Type JAACLLLIGMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5350", Offset = "0x2AF4550", VA = "0x182AF5350")]
	public T DKLEDPBMIGD<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BE92D0", Offset = "0x6BE84D0", VA = "0x186BE92D0")]
	public void FHDLCKBJNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8DB0", Offset = "0x6BE7FB0", VA = "0x186BE8DB0")]
	public void AEGKLBLFKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8E70", Offset = "0x6BE8070", VA = "0x186BE8E70")]
	public void BKBEJILCFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE93B0", Offset = "0x6BE85B0", VA = "0x186BE93B0")]
	public void HLOABHKJHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE97C0", Offset = "0x6BE89C0", VA = "0x186BE97C0")]
	public void PJFOHFKFMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8E10", Offset = "0x6BE8010", VA = "0x186BE8E10")]
	public void AKIGCDOCDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9760", Offset = "0x6BE8960", VA = "0x186BE9760")]
	public void PGIDEKCKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8ED0", Offset = "0x6BE80D0", VA = "0x186BE8ED0")]
	public void BMMHGDBHLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9410", Offset = "0x6BE8610", VA = "0x186BE9410")]
	public void IKIOJHHKPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BE90D0", Offset = "0x6BE82D0", VA = "0x186BE90D0")]
	public void DCLFIPMAABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8F60", Offset = "0x6BE8160", VA = "0x186BE8F60")]
	internal void CGCIGNMGNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9330", Offset = "0x6BE8530", VA = "0x186BE9330")]
	private bool FMAOKFIBAPD(ComponentSystemGroup JCKBEJKIJPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9490", Offset = "0x6BE8690", VA = "0x186BE9490")]
	private void PBMMDKBEBHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BE91C0", Offset = "0x6BE83C0", VA = "0x186BE91C0")]
	private ComponentSystemGroup[] EJNNKOLHDPK(ONIPDAHKEAG GMGCAACJFOL, bool ELDCELHMHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9150", Offset = "0x6BE8350", VA = "0x186BE9150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PHJIBFELKID
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0A00", Offset = "0x6BEFC00", VA = "0x186BF0A00")]
	[MustUseReturnValue]
	public static JobHandle LKKHNKGBPHK(this EntityCommandBufferSystem AAHGOGAPMBE, NativeList<Entity> KPALEEBPIBN, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BF08F0", Offset = "0x6BEFAF0", VA = "0x186BF08F0")]
	[MustUseReturnValue]
	public static JobHandle LKKHNKGBPHK(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArrayAsync<Entity> KPALEEBPIBN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HLMCBFIIEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2872FF0", Offset = "0x28721F0", VA = "0x182872FF0")]
	public static void PGBCNDIPBJD<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityQuery PODFABCMECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2873690", Offset = "0x2872890", VA = "0x182873690")]
	[MustUseReturnValue]
	public static JobHandle PHBMPBGIHNA<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeListAsync<Entity> KPALEEBPIBN, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2873060", Offset = "0x2872260", VA = "0x182873060")]
	[MustUseReturnValue]
	public static JobHandle PHBMPBGIHNA<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArrayAsync<Entity> KPALEEBPIBN, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class DAPDDMANBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AMEHENOOIKA EIAHLMIGNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EntityManager NBACICFMHBN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AMEHENOOIKA KBDCDOFELIM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAD60", Offset = "0x6BE9F60", VA = "0x186BEAD60")]
	public DAPDDMANBGJ(AMEHENOOIKA EIAHLMIGNAE, EntityManager NBACICFMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF8E0", Offset = "0x2BFEAE0", VA = "0x182BFF8E0")]
	public bool GKAEGODPHDA<T>(Entity FADPOFMJIJF) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C01CF0", Offset = "0x2C00EF0", VA = "0x182C01CF0")]
	public bool OPCNNMLDKHH<T>(Entity FADPOFMJIJF, out T ACKOJNNBEBO) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF920", Offset = "0x2BFEB20", VA = "0x182BFF920")]
	public T HINAFKFCFOF<T>(Entity FADPOFMJIJF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C01470", Offset = "0x2C00670", VA = "0x182C01470")]
	private ComponentType NOJCCKCPKOM<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BEABD0", Offset = "0x6BE9DD0", VA = "0x186BEABD0")]
	private ComponentType NOJCCKCPKOM(Type JAACLLLIGMF)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FCAPPMCCECP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct NNBNCIBPNOH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NativeArray<Entity> NMBFNPEFGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<T> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct NEJHAMGMPAP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NativeList<Entity> NMBFNPEFGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NativeArray<T> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct PGDLKGLEOMC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArrayAsync<Entity> NMBFNPEFGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArrayAsync<T> AKBLDBCDLHB;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24FDA80", Offset = "0x24FCC80", VA = "0x1824FDA80")]
		public NativeListAsync<Entity> MOLLMHANNGD<TPredicate>() where TPredicate : struct, JGAEABGNDLI<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3118370", Offset = "0x3117570", VA = "0x183118370")]
	public static PGDLKGLEOMC<T> LKCDIMGBJDG<T>(this NativeArrayAsync<Entity> EPLNAGGLGMC, NativeArrayAsync<T> DJJHIADBLID, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct
	{
		return default(PGDLKGLEOMC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DICMKCNAMBK : KHIHJPNGLAH
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Type MAPIOOOELBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB090", Offset = "0x6BEA290", VA = "0x186BEB090")]
	public DICMKCNAMBK(Type EGMBIJHEOKD, Type EKKFGMNHPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JMBHPOGEOCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct FOJKEJIHFGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly Dictionary<Type, List<Type>> HHGNAHCBGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly HashSet<Type> ENKAKAIOPHC;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public FOJKEJIHFGF(Dictionary<Type, List<Type>> HHGNAHCBGIN, HashSet<Type> ENKAKAIOPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct AHIIJLGAGNA
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LKBOJKIOENP : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
		public AHIIJLGAGNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public AHIIJLGAGNA <>3__<>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public LKBOJKIOENP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE040", Offset = "0x6BED240", VA = "0x186BEE040", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDD80", Offset = "0x6BECF80", VA = "0x186BEDD80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDD30", Offset = "0x6BECF30", VA = "0x186BEDD30")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE000", Offset = "0x6BED200", VA = "0x186BEE000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDF50", Offset = "0x6BED150", VA = "0x186BEDF50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDF50", Offset = "0x6BED150", VA = "0x186BEDF50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct GKHKMBDMIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Dictionary<Type, List<Type>> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Queue<Type> queue;
	}

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Type MCCIKPEPLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ONIPDAHKEAG GMGCAACJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool LKPDIPMHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool CIHPNOKHAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool ELDCELHMHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IEnumerable<Type> PDFNEBKKJKC;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8640", Offset = "0x6BE7840", VA = "0x186BE8640")]
	public static AHIIJLGAGNA LNIGJBIDADO()
	{
		return default(AHIIJLGAGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7D70", Offset = "0x6BE6F70", VA = "0x186BE7D70")]
	public AHIIJLGAGNA AACJBPIPLBK(ONIPDAHKEAG BIAEGHNJKDJ)
	{
		return default(AHIIJLGAGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8390", Offset = "0x6BE7590", VA = "0x186BE8390")]
	public AHIIJLGAGNA HALPIGAOOIA(IEnumerable<Type> OMNEJPNCJMO)
	{
		return default(AHIIJLGAGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE82E0", Offset = "0x6BE74E0", VA = "0x186BE82E0")]
	public AHIIJLGAGNA GENJIJELKML(bool IDJFLNPJEHO)
	{
		return default(AHIIJLGAGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE82D0", Offset = "0x6BE74D0", VA = "0x186BE82D0")]
	public AHIIJLGAGNA CNHENHABALO(bool AGCPCCLFIJO)
	{
		return default(AHIIJLGAGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE82F0", Offset = "0x6BE74F0", VA = "0x186BE82F0")]
	public FOJKEJIHFGF GJHMNGDBMMP(Type[] NLJIGNIBDJN)
	{
		return default(FOJKEJIHFGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8240", Offset = "0x6BE7440", VA = "0x186BE8240")]
	[IteratorStateMachine(typeof(LKBOJKIOENP))]
	internal IEnumerable<Type> BLHJHDNCOHN(IEnumerable<Type> OMNEJPNCJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7D80", Offset = "0x6BE6F80", VA = "0x186BE7D80")]
	internal Dictionary<Type, List<Type>> ANDIKJIKGHN(IEnumerable<Type> OMNEJPNCJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8530", Offset = "0x6BE7730", VA = "0x186BE8530")]
	private void LABNKJIGPBA(Dictionary<Type, List<Type>> OLFODNBFFOI, Type JAACLLLIGMF, Type GPOFJEKBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8070", Offset = "0x6BE7270", VA = "0x186BE8070")]
	internal HashSet<Type> APKBLOLOBIA(IEnumerable<Type> PDPGAHIJLHO, Dictionary<Type, List<Type>> DADDIMDIKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8660", Offset = "0x6BE7860", VA = "0x186BE8660")]
	internal bool OFDJFLHCKMC(Type JAACLLLIGMF, ONIPDAHKEAG GMGCAACJFOL, bool ELDCELHMHEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BE83D0", Offset = "0x6BE75D0", VA = "0x186BE83D0")]
	[CompilerGenerated]
	internal static void JLIDGOPICBI(Type JAACLLLIGMF, ref GKHKMBDMIEB P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CKNFBLEKKGM
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x323F170", Offset = "0x323E370", VA = "0x18323F170")]
	public static NativeList<Entity> DLNJGOHPAIF<T>(this NativeArray<Entity> EPLNAGGLGMC, EntityManager NBACICFMHBN, Allocator IEOPKOGNAGJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OMGDNDCJBCA
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct JPJDDNCMNAJ : FBGIPHGKDFE<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MNJNFPOOMLO;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BED770", Offset = "0x6BEC970", VA = "0x186BED770")]
		[BurstCompatible]
		public Entity ECBDNFMACBD(in Entity ACKOJNNBEBO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BED770", Offset = "0x6BEC970", VA = "0x186BED770", Slot = "4")]
		private Entity PNABFNIBLLN(in Entity ACKOJNNBEBO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class DHKOKEIMILA
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAEB0", Offset = "0x6BEA0B0", VA = "0x186BEAEB0")]
	public static bool AIBKFPCAFEF(Type JAACLLLIGMF, Type HKJGIJKMJFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class HLCBGEBABFD : JBCNOLJLIBO
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC2B0", Offset = "0x6BEB4B0", VA = "0x186BEC2B0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase BDNDKCJJBHL();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC210", Offset = "0x6BEB410", VA = "0x186BEC210")]
	protected ComponentSystemBase FGOMMBLKHCO(params ComponentSystemBase[] ENKAKAIOPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2872EC0", Offset = "0x28720C0", VA = "0x182872EC0")]
	protected ComponentSystemBase FGOMMBLKHCO<T>(params ComponentSystemBase[] ENKAKAIOPHC) where T : JBCNOLJLIBO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2872E30", Offset = "0x2872030", VA = "0x182872E30")]
	protected ComponentSystemBase FMFFOBPKHPK<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2872E30", Offset = "0x2872030", VA = "0x182872E30")]
	protected ComponentSystemBase CKDCEEJIMOF<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC260", Offset = "0x6BEB460", VA = "0x186BEC260")]
	protected ComponentSystemBase KHLCMGPOKFH(params SystemHandleUntyped[] ENKAKAIOPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2872F60", Offset = "0x2872160", VA = "0x182872F60")]
	protected ComponentSystemBase KHLCMGPOKFH<T>(params SystemHandleUntyped[] ENKAKAIOPHC) where T : JBCNOLJLIBO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2872E70", Offset = "0x2872070", VA = "0x182872E70")]
	protected SystemHandleUntyped EGNAJDALNBE<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC300", Offset = "0x6BEB500", VA = "0x186BEC300")]
	protected HLCBGEBABFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JJEGODCIOOI<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PLLNGOBMPBN(int JIFLFJEBLBE);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EKENKDNMCMN<BaseClass> IKBMKHPNABH();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class PHJIOAIAJFB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x42F5670", Offset = "0x42F4870", VA = "0x1842F5670")]
	public static NativeList<T> JPMIBFMNDBG<T>(NativeList<T> DJJHIADBLID, Allocator IEOPKOGNAGJ) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OPDLIGDONJP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct CHFLKLDHPEG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FBGIPHGKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	public NativeArray<TFrom> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeList<TFrom> NDBEGNCDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeHashSet<TTo> NLCGADBFNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public TMap JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct CMDMCDGMIJA<T, TPredicate> : IJob where T : struct where TPredicate : struct, JGAEABGNDLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public NativeArray<T> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> NMBFNPEFGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> JGCLMLCNFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public TPredicate JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A495B0", Offset = "0x4A487B0", VA = "0x184A495B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct CDFMIMLPJJD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FBGIPHGKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	public NativeArray<TFrom> POLNHEKFJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[WriteOnly]
	public NativeList<TTo> EJPHMKNFAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TMap JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class INPKEIJMENA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ONIPDAHKEAG HFLKBHOEMPH;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class EJHHLBFFFPM : JNOBAENFAMP<DICMKCNAMBK, MAPMLCJFIJL>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB410", Offset = "0x6BEA610", VA = "0x186BEB410")]
	public EJHHLBFFFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class JNOBAENFAMP<Attribute, BaseClass> : JJEGODCIOOI<BaseClass>, PCKIPJJGBMJ where Attribute : KHIHJPNGLAH
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string PCKMHBLNCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, Type> LNMOLGMMGGO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3616F80", Offset = "0x3616180", VA = "0x183616F80")]
	public JNOBAENFAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3616E80", Offset = "0x3616080", VA = "0x183616E80", Slot = "4")]
	public bool PLLNGOBMPBN(int JIFLFJEBLBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3616AB0", Offset = "0x3615CB0", VA = "0x183616AB0", Slot = "5")]
	public EKENKDNMCMN<BaseClass> IKBMKHPNABH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3616920", Offset = "0x3615B20", VA = "0x183616920", Slot = "7")]
	protected virtual bool AIBKFPCAFEF(Type JAACLLLIGMF, int IPMCEBICLGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3616A20", Offset = "0x3615C20", VA = "0x183616A20", Slot = "8")]
	protected virtual int HIDPAJKKLBM(Type JAACLLLIGMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3616DF0", Offset = "0x3615FF0", VA = "0x183616DF0")]
	public void NHOFJKDINME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3616D50", Offset = "0x3615F50", VA = "0x183616D50", Slot = "6")]
	public void JFGPOAFMNED(Type JAACLLLIGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ICNBEKFOHHE
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct PGAIABELJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly ulong CFHBNOHIFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly JHLFPAOJKCG DIPLGFPFFJA;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86FA50", Offset = "0x86EC50", VA = "0x18086FA50")]
		public PGAIABELJOB(ulong HGDEHGAMAKH, JHLFPAOJKCG BENPFMGGJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0850", Offset = "0x6BEFA50", VA = "0x186BF0850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class NONMBFPIDLP : IEnumerable<JHLFPAOJKCG>, IEnumerable, IEnumerator<JHLFPAOJKCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private JHLFPAOJKCG <>2__current;

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
		private IEnumerator<CJEGIPLHGDB> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private CJEGIPLHGDB <attrib>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private JHLFPAOJKCG System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Attributes.NameHash>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JHLFPAOJKCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFB30", Offset = "0x6BEED30", VA = "0x186BEFB30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xECAD80", Offset = "0xEC9F80", VA = "0x180ECAD80")]
		[DebuggerHidden]
		public NONMBFPIDLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFB80", Offset = "0x6BEED80", VA = "0x186BEFB80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF7D0", Offset = "0x6BEE9D0", VA = "0x186BEF7D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF780", Offset = "0x6BEE980", VA = "0x186BEF780")]
		private void LNJGNFIDMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFAF0", Offset = "0x6BEECF0", VA = "0x186BEFAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFA40", Offset = "0x6BEEC40", VA = "0x186BEFA40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JHLFPAOJKCG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFA40", Offset = "0x6BEEC40", VA = "0x186BEFA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Type NFLGBGOOKBM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static Dictionary<ulong, int> NHCGKINPFLI;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static PGAIABELJOB[] EJBICPDNPLK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool JJKMPKPOGCP;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC570", Offset = "0x6BEB770", VA = "0x186BEC570")]
	public static ulong BNABEKDCMFI(int JIFLFJEBLBE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC6C0", Offset = "0x6BEB8C0", VA = "0x186BEC6C0")]
	public static int FAGKMLIMPIK(ulong BENPFMGGJIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BED2D0", Offset = "0x6BEC4D0", VA = "0x186BED2D0")]
	public static void OHLMLHJNBAL(bool PPHFAHHOGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECA50", Offset = "0x6BEBC50", VA = "0x186BECA50")]
	private static void GAENDIODHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC780", Offset = "0x6BEB980", VA = "0x186BEC780")]
	private static void GAENDIODHOC(IEnumerable<Type> OMNEJPNCJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6BECE10", Offset = "0x6BEC010", VA = "0x186BECE10")]
	private static void KKKPELBBCPC(int OLIBEKDJHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BECF80", Offset = "0x6BEC180", VA = "0x186BECF80")]
	private static void NLCELCLBHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC3F0", Offset = "0x6BEB5F0", VA = "0x186BEC3F0")]
	private static (ulong, IEnumerable<JHLFPAOJKCG>) BLNMEINAFFG(Type JAACLLLIGMF)
	{
		return default((ulong, IEnumerable<JHLFPAOJKCG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BECEF0", Offset = "0x6BEC0F0", VA = "0x186BECEF0")]
	[IteratorStateMachine(typeof(NONMBFPIDLP))]
	private static IEnumerable<JHLFPAOJKCG> MOKPELPIEBA(Type JAACLLLIGMF, ulong BENPFMGGJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6BECB10", Offset = "0x6BEBD10", VA = "0x186BECB10")]
	private static void KJACNJDOCOB(ulong BENPFMGGJIB, IEnumerable<JHLFPAOJKCG> DPEJJJBCJBN, TypeManager.TypeInfo GJHFOKPAEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BED520", Offset = "0x6BEC720", VA = "0x186BED520")]
	private static void PKFADGGDNEG(PGAIABELJOB GJHFOKPAEOL, int JIFLFJEBLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC5D0", Offset = "0x6BEB7D0", VA = "0x186BEC5D0")]
	private static void CFHLBOOKPKB(PGAIABELJOB GJHFOKPAEOL, int JIFLFJEBLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC360", Offset = "0x6BEB560", VA = "0x186BEC360")]
	private static PGAIABELJOB BLKOLFODHLM(int JIFLFJEBLBE)
	{
		return default(PGAIABELJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC770", Offset = "0x6BEB970", VA = "0x186BEC770")]
	private static int FMOLHDOIIAF(int JIFLFJEBLBE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EOGNJJPGAHG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct PMLODCGBDKA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NativeArray<T>.ReadOnly BGBPILICHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int PFBJKNIILDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int JOBIJPMDDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private T CJBFEOODPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private T ILKGPGKAKFF;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ANLNPEGKJAF EJLHCKHAGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x31CDE70", Offset = "0x31CD070", VA = "0x1831CDE70")]
			get
			{
				return default(ANLNPEGKJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T PBIJPLGCHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x30CCBC0", Offset = "0x30CBDC0", VA = "0x1830CCBC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, ANLNPEGKJAF) HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x31CDA60", Offset = "0x31CCC60", VA = "0x1831CDA60")]
			get
			{
				return default((T, ANLNPEGKJAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x31CDE80", Offset = "0x31CD080", VA = "0x1831CDE80")]
		public PMLODCGBDKA(NativeArray<T> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x317B3E0", Offset = "0x317A5E0", VA = "0x18317B3E0")]
		public PMLODCGBDKA<T> KECFEFHENMC()
		{
			return default(PMLODCGBDKA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x31CDCE0", Offset = "0x31CCEE0", VA = "0x1831CDCE0")]
		public bool CKPDOOCLIPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x24FDBA0", Offset = "0x24FCDA0", VA = "0x1824FDBA0")]
		public BEAPDMLPLMA<T, TComparer> JPNEKOCNGFA<TComparer>([Optional] TComparer CECAMEFIHNJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BEAPDMLPLMA<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct BEAPDMLPLMA<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<T>.ReadOnly BGBPILICHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int PFBJKNIILDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int JOBIJPMDDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T CJBFEOODPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T ILKGPGKAKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TComparer CECAMEFIHNJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ANLNPEGKJAF EJLHCKHAGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x31CDE70", Offset = "0x31CD070", VA = "0x1831CDE70")]
			get
			{
				return default(ANLNPEGKJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T PBIJPLGCHKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x30CCBC0", Offset = "0x30CBDC0", VA = "0x1830CCBC0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, ANLNPEGKJAF range) HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x4446A60", Offset = "0x4445C60", VA = "0x184446A60")]
			get
			{
				return default((T, ANLNPEGKJAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4446D90", Offset = "0x4445F90", VA = "0x184446D90")]
		public BEAPDMLPLMA(NativeArray<T>.ReadOnly BGBPILICHHA, TComparer CECAMEFIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x317B840", Offset = "0x317AA40", VA = "0x18317B840")]
		public BEAPDMLPLMA<T, TComparer> KECFEFHENMC()
		{
			return default(BEAPDMLPLMA<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x4446B30", Offset = "0x4445D30", VA = "0x184446B30")]
		public bool CKPDOOCLIPP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2D9DEB0", Offset = "0x2D9D0B0", VA = "0x182D9DEB0")]
	public static PMLODCGBDKA<T> FGOMMBLKHCO<T>(this NativeArray<T> BGBPILICHHA) where T : struct
	{
		return default(PMLODCGBDKA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FBGIPHGKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ECBDNFMACBD(in TFrom ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class BDCHGKLJMLA
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EAADKJIDGMI
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PONDCKPPIEG<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		public PONDCKPPIEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ABDFAMCEANC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		public ABDFAMCEANC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<Func<JobHandle, JobHandle>> EFFEGBFKNFH;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB1B0", Offset = "0x6BEA3B0", VA = "0x186BEB1B0")]
	public EAADKJIDGMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class BGMGHGEDHOM
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class MAGJDOKGPID : EntityCommandBufferSystem, JDNLMKHCPBL
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
	protected MAGJDOKGPID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ILDEHIBDDBI
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x268F010", Offset = "0x268E210", VA = "0x18268F010")]
	[MustUseReturnValue]
	public static JobHandle MLGEDJAIEBA<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArray<Entity> KPALEEBPIBN, NativeArray<T> JCEJEOAKGOJ, JobHandle NJAJFFLKILC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct CFEAHHIKDHB<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	public NativeArray<T> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<T> NDBEGNCDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeHashSet<T> NLCGADBFNFB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x36D7D40", Offset = "0x36D6F40", VA = "0x1836D7D40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EKENKDNMCMN<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<int, BaseClass> DMFJLMIKLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<Type, BaseClass> GHAJMIFLMBH;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CNOEMCDBJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3668AE0", Offset = "0x3667CE0", VA = "0x183668AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> JGPHEDHNBJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x36687E0", Offset = "0x36679E0", VA = "0x1836687E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3668B90", Offset = "0x3667D90", VA = "0x183668B90")]
	public EKENKDNMCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3668D30", Offset = "0x3667F30", VA = "0x183668D30")]
	public EKENKDNMCMN(int HBHBCIIAIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3668B10", Offset = "0x3667D10", VA = "0x183668B10")]
	internal void PPMBLONPHPF(int JIFLFJEBLBE, BaseClass DFFNFBOJLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x26285F0", Offset = "0x26277F0", VA = "0x1826285F0")]
	public bool NPJCNPPHBFD<T>(out BaseClass ACKOJNNBEBO) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3668A40", Offset = "0x3667C40", VA = "0x183668A40")]
	public bool NPJCNPPHBFD(Type ICEMMELMHPB, out BaseClass ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3563A40", Offset = "0x3562C40", VA = "0x183563A40")]
	public bool GMCHJBIEOJB(int JIFLFJEBLBE, out BaseClass ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2628510", Offset = "0x2627710", VA = "0x182628510")]
	public T KIOGAJJDFGP<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3668A10", Offset = "0x3667C10", VA = "0x183668A10")]
	public BaseClass KIOGAJJDFGP(Type FKGNCKEGMCI)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class OJALFOGMFCB : JNOBAENFAMP<KAAIFMHPEIG, JNIMENAMJOD>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6BF07E0", Offset = "0x6BEF9E0", VA = "0x186BF07E0")]
	public OJALFOGMFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct HFKCJJNHHIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC1B0", Offset = "0x6BEB3B0", VA = "0x186BEC1B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class EMPHGELGBKF
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x33C36E0", Offset = "0x33C28E0", VA = "0x1833C36E0")]
	public static NativeArray<T> IACCHBNEKDP<T>(this NativeList<Entity> DJJHIADBLID, EntityManager NBACICFMHBN, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x33C33A0", Offset = "0x33C25A0", VA = "0x1833C33A0")]
	public static NativeArray<T> IACCHBNEKDP<T>(this NativeArray<Entity> DJJHIADBLID, EntityManager NBACICFMHBN, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface IPPDJJCDGHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HADEBILLKED
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct ANFPFFHFCML<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public T ACKOJNNBEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3931DE0", Offset = "0x3930FE0", VA = "0x183931DE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class OADJBKEHJDA
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34BCA90", Offset = "0x34BBC90", VA = "0x1834BCA90")]
	[MustUseReturnValue]
	public static JobHandle DMPAEBBNFCM<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, EntityQuery PODFABCMECB, T ACKOJNNBEBO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34BC840", Offset = "0x34BBA40", VA = "0x1834BC840")]
	[MustUseReturnValue]
	public static JobHandle DMPAEBBNFCM<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArrayAsync<Entity> KPALEEBPIBN, NativeArrayAsync<T> ACKOJNNBEBO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34BC920", Offset = "0x34BBB20", VA = "0x1834BC920")]
	[MustUseReturnValue]
	public static JobHandle DMPAEBBNFCM<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, NativeArrayAsync<Entity> KPALEEBPIBN, NativeArrayAsync<T> ACKOJNNBEBO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class DNJJNGFBLCK : JNOBAENFAMP<BPAHEGCGIMB, KPLMCFJAMHK>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB0E0", Offset = "0x6BEA2E0", VA = "0x186BEB0E0")]
	public DNJJNGFBLCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class EPFJHBCEOJN<Data> : JNIMENAMJOD where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public virtual Data OONGDIKAKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x367B510", Offset = "0x367A710", VA = "0x18367B510", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x826270", Offset = "0x825470", VA = "0x180826270", Slot = "8")]
	protected virtual bool JOPHCGPEAEF(ReadOnlySpan<Data> HMNOPGDGOJJ, KGLCBEHIGBD FHAMOHFMLKK, out ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "9")]
	protected virtual bool PEJNAIHNJID(int EJEDLELNMDA, Span<Data> HMNOPGDGOJJ, in ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1912540", Offset = "0x1911740", VA = "0x181912540", Slot = "5")]
	internal sealed override bool JOPHCGPEAEF(ref Unity.Entities.Chunk JHIKJCCHBCK, int KGCFIGFKIBC, KGLCBEHIGBD FHAMOHFMLKK, out ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x367B540", Offset = "0x367A740", VA = "0x18367B540", Slot = "6")]
	internal sealed override bool PEJNAIHNJID(int EJEDLELNMDA, ref Unity.Entities.Chunk JHIKJCCHBCK, int KGCFIGFKIBC, in ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2629AF0", Offset = "0x2628CF0", VA = "0x182629AF0")]
	protected HOPFLHGPKGN<Protobuf> CGGGNJJEIEA<Protobuf>(ReadOnlySpan<Data> HMNOPGDGOJJ) where Protobuf : IMessage, new()
	{
		return default(HOPFLHGPKGN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2629A60", Offset = "0x2628C60", VA = "0x182629A60")]
	protected GGDNLJDGAPA<Protobuf> AOAFPCLBJLI<Protobuf>(ReadOnlySpan<byte> CFOODOIEFBB, ReadOnlySpan<Data> HMNOPGDGOJJ, Action<Protobuf> CFNMGBODIJH) where Protobuf : IMessage, new()
	{
		return default(GGDNLJDGAPA<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1913980", Offset = "0x1912B80", VA = "0x181913980")]
	protected EPFJHBCEOJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class JNIMENAMJOD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected internal abstract int OLFLDONEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BED750", Offset = "0x6BEC950", VA = "0x186BED750", Slot = "5")]
	internal virtual bool JOPHCGPEAEF(ref Unity.Entities.Chunk JHIKJCCHBCK, int KGCFIGFKIBC, KGLCBEHIGBD FHAMOHFMLKK, out ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x826280", Offset = "0x825480", VA = "0x180826280", Slot = "6")]
	internal virtual bool PEJNAIHNJID(int EJEDLELNMDA, ref Unity.Entities.Chunk JHIKJCCHBCK, int KGCFIGFKIBC, in ReadOnlySpan<byte> CFOODOIEFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected JNIMENAMJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HNDMIGHGPMK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct KDHPILALIBO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct ADLGNBCNHGL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			internal KDHPILALIBO<TFrom> BLFIAOLNAKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal NativeArray<TFrom> KDAGJHGAEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct APNEGJMAGKP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct FAIKAPJLADG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			internal APNEGJMAGKP<TFrom> BLFIAOLNAKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal NativeList<TFrom> KDAGJHGAEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct HLOOKDGGKJI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct GNLNHDBBFDB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			internal HLOOKDGGKJI<TFrom> BLFIAOLNAKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal NativeArrayAsync<TFrom> KDAGJHGAEFN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct IDLGMLOPPIC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct BGGMAFJBGOE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			internal IDLGMLOPPIC<TFrom> BLFIAOLNAKG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal NativeListAsync<TFrom> KDAGJHGAEFN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct EHNBFLHBFIP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NAGCPMGBDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	public NativeArray<Entity> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[WriteOnly]
	public NativeArray<T> EJPHMKNFAAJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4489FA0", Offset = "0x44891A0", VA = "0x184489FA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BurstCompile]
internal struct IJABOHACJBH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EKKFGMNHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	public NativeArray<Entity> EPLNAGGLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> GNJFJCPGMPF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct CAKKGJLFNHH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	public NativeArray<T> DNDGJFJKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3691930", Offset = "0x3690B30", VA = "0x183691930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CNLEIBOAOAB
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PENOCCKFFHA
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2EB72D0", Offset = "0x2EB64D0", VA = "0x182EB72D0")]
	public static NativeListAsync<Entity> ANHCPMIMIFB<T, TPredicate>(this NativeArrayAsync<T> DJJHIADBLID, NativeArrayAsync<Entity> EPLNAGGLGMC, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct where TPredicate : struct, JGAEABGNDLI<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2EB7390", Offset = "0x2EB6590", VA = "0x182EB7390")]
	private static NativeListAsync<Entity> MOLCBAPJNAC<T, TPredicate>(NativeArrayAsync<T> PNPKIEHENPI, NativeArrayAsync<Entity> EPLNAGGLGMC, int CGGOJFONIPE, Allocator IEOPKOGNAGJ) where T : struct where TPredicate : struct, JGAEABGNDLI<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FIIEOOKNAIB
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x383A910", Offset = "0x3839B10", VA = "0x18383A910")]
	[MustUseReturnValue]
	public static JobHandle OHNLBDKLNIB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArray<Entity> KPALEEBPIBN, T ACKOJNNBEBO, [Optional] JobHandle NJAJFFLKILC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x383A840", Offset = "0x3839A40", VA = "0x18383A840")]
	[MustUseReturnValue]
	public static JobHandle OHNLBDKLNIB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, NativeArray<Entity> KPALEEBPIBN, T ACKOJNNBEBO, [Optional] JobHandle NJAJFFLKILC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x383A770", Offset = "0x3839970", VA = "0x18383A770")]
	[MustUseReturnValue]
	public static JobHandle OHNLBDKLNIB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, NativeArray<Entity> KPALEEBPIBN, NativeArray<T> DNDGJFJKDEB, [Optional] JobHandle NJAJFFLKILC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BPAHEGCGIMB : KHIHJPNGLAH
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class LDBFGBLKMHG
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3340F60", Offset = "0x3340160", VA = "0x183340F60")]
	public static NativeList<T> JPMIBFMNDBG<T>(this NativeList<T> DJJHIADBLID, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3340D90", Offset = "0x333FF90", VA = "0x183340D90")]
	public static NativeList<T> JPMIBFMNDBG<T>(this NativeArray<T> DJJHIADBLID, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class HINHHKAAJLK
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct NINKNBLEJGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeArray<T> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct LPHHMDNOACI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<T> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct KBEKJECGMCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeArrayAsync<T> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct GBIDJHPJLCN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NativeListAsync<T> AKBLDBCDLHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct EAMLDGACKKL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FBGIPHGKDFE<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<TFrom> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[WriteOnly]
	public NativeArray<TTo> EJPHMKNFAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public TMap JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
public enum ONIPDAHKEAG
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
public interface JGAEABGNDLI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOLLMHANNGD(T ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct LAIFJJPCLEO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ComponentTypes JGPBCLLLPOP;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BED790", Offset = "0x6BEC990", VA = "0x186BED790", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct NHLJOAPGNNK<T, TPredicate> : IJob where T : struct where TPredicate : struct, JGAEABGNDLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	public NativeArray<T> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<T> NDBEGNCDMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public TPredicate JFFMHPNGJBK;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class JBCNOLJLIBO : PFMKNEEODEF
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BED720", Offset = "0x6BEC920", VA = "0x186BED720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC300", Offset = "0x6BEB500", VA = "0x186BEC300")]
	public JBCNOLJLIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class KHIHJPNGLAH : HMEEAGFGNAN
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Type JDCIFEPKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xD5E510", Offset = "0xD5D710", VA = "0x180D5E510")]
	public KHIHJPNGLAH(Type EKKFGMNHPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class LHFPCFANEKE
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly Dictionary<int, int> MCLMOKNNFMJ;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool JJKMPKPOGCP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6BED8F0", Offset = "0x6BECAF0", VA = "0x186BED8F0")]
	public static int LNEPHPEGANN(int JIFLFJEBLBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDC10", Offset = "0x6BECE10", VA = "0x186BEDC10")]
	public static void OHLMLHJNBAL(bool PPHFAHHOGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6BED990", Offset = "0x6BECB90", VA = "0x186BED990")]
	private static void NEMFGGHHJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6BED8A0", Offset = "0x6BECAA0", VA = "0x186BED8A0")]
	private static int GIPDLMICAIM(Type JAACLLLIGMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6BED820", Offset = "0x6BECA20", VA = "0x186BED820")]
	private static void DAFFCKIEONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BurstCompile]
internal struct BIHHHMNMMCB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EKKFGMNHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	public NativeArray<Entity> EPLNAGGLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<bool> GNJFJCPGMPF;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x33F96D0", Offset = "0x33F88D0", VA = "0x1833F96D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct JNNKHLNAKBB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeArray<T> JCEJEOAKGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x36166E0", Offset = "0x36158E0", VA = "0x1836166E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DHABIDIKIAF
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BEADB0", Offset = "0x6BE9FB0", VA = "0x186BEADB0")]
	public static ulong PPCMCPPKEFH(Type JAACLLLIGMF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAE40", Offset = "0x6BEA040", VA = "0x186BEAE40")]
	public static ulong PPCMCPPKEFH(string IMGHCJKEHNM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal static class BPEILAKMECB
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly Dictionary<Type, int> OKEAJEDFJCA;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static bool JJKMPKPOGCP;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA450", Offset = "0x6BE9650", VA = "0x186BEA450")]
	public static void OHLMLHJNBAL(bool PPHFAHHOGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9ED0", Offset = "0x6BE90D0", VA = "0x186BE9ED0")]
	private static void BDMLHMIPIGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA270", Offset = "0x6BE9470", VA = "0x186BEA270")]
	private static void LHENDKMDIKE(Type FNOHMGHADFE, Type PDDCMNAKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA100", Offset = "0x6BE9300", VA = "0x186BEA100")]
	private static void DAFFCKIEONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA180", Offset = "0x6BE9380", VA = "0x186BEA180")]
	public static int FBCHHCLHBOD(Type FNOHMGHADFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9E30", Offset = "0x6BE9030", VA = "0x186BE9E30")]
	public static bool AIOIEGNPIOI(Type FNOHMGHADFE, out int JIFLFJEBLBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class LLILKIIGMLK
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE7E0", Offset = "0x6BED9E0", VA = "0x186BEE7E0")]
	public static ComponentSystemGroup[] EJNNKOLHDPK(World EIAHLMIGNAE, ONIPDAHKEAG GMGCAACJFOL = ONIPDAHKEAG.Default, bool ELDCELHMHEI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEBC0", Offset = "0x6BEDDC0", VA = "0x186BEEBC0")]
	private static Type[] KKHMPCGEEMB(ONIPDAHKEAG GMGCAACJFOL, bool ELDCELHMHEI, ComponentSystemGroup[] PDPGAHIJLHO, ComponentSystemGroup EDHIJLPGPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE8B0", Offset = "0x6BEDAB0", VA = "0x186BEE8B0")]
	private static ComponentSystemGroup[] HBGJDJMFOIO(World EIAHLMIGNAE, out ComponentSystemGroup EDHIJLPGPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF000", Offset = "0x6BEE200", VA = "0x186BEF000")]
	internal static bool NEDMHCHJMFB(CAONBNKGIMF BIAEGHNJKDJ, out OPJCCMPKCLJ AFOHKJFLKCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEF20", Offset = "0x6BEE120", VA = "0x186BEEF20")]
	private static ComponentSystemGroup LOHGFGPJHJO(Type JAACLLLIGMF, World EIAHLMIGNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE0D0", Offset = "0x6BED2D0", VA = "0x186BEE0D0")]
	private static ComponentSystemGroup[] BCBEFOLIPAN(Type[] OMNEJPNCJMO, World EIAHLMIGNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE2C0", Offset = "0x6BED4C0", VA = "0x186BEE2C0")]
	internal static void EDDIJFAFNKO(World EIAHLMIGNAE, Type[] GLAAIFEGDMP, ComponentSystemGroup[] PDPGAHIJLHO, ComponentSystemGroup EDHIJLPGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE260", Offset = "0x6BED460", VA = "0x186BEE260")]
	internal static bool DMCCGJNDBFJ(ComponentSystemBase MIHOJHKAIJH, ComponentSystemGroup[] PDPGAHIJLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE200", Offset = "0x6BED400", VA = "0x186BEE200")]
	private static void CAEDMAPGIEM(ComponentSystemGroup[] PDPGAHIJLHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KAAIFMHPEIG : KHIHJPNGLAH
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xD5E510", Offset = "0xD5D710", VA = "0x180D5E510")]
	public KAAIFMHPEIG(Type EKKFGMNHPLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BurstCompile]
internal struct EDBFONDDKDN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public ComponentDataFromEntity EKKFGMNHPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	public NativeArray<Entity> EPLNAGGLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public NativeList<Entity> MJOJGOPKLNG;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB230", Offset = "0x6BEA430", VA = "0x186BEB230", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class EHLNJDNFIGJ : SystemBase, JDNLMKHCPBL
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB310", Offset = "0x6BEA510", VA = "0x186BEB310")]
	public ComponentDataFromEntity ENBJIFHPOHB(int JIFLFJEBLBE, bool OCDKNNEJFOH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB3E0", Offset = "0x6BEA5E0", VA = "0x186BEB3E0")]
	public EntityExistenceLookupByEntity GJJFNGPFHML()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB2C0", Offset = "0x6BEA4C0", VA = "0x186BEB2C0")]
	public EntityQuery BPLBMICBKBE(in EntityQueryDescBuilder HJGBFDAMKPJ)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB400", Offset = "0x6BEA600", VA = "0x186BEB400", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	protected EHLNJDNFIGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class BJIICJLIAMB : EHLNJDNFIGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9E00", Offset = "0x6BE9000", VA = "0x186BE9E00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	protected BJIICJLIAMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class HLIOHHMFGHL
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface JDNLMKHCPBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class PFMKNEEODEF : ComponentSystemGroup, JDNLMKHCPBL
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC300", Offset = "0x6BEB500", VA = "0x186BEC300")]
	protected PFMKNEEODEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class JPLHKBHAKIK<View, Data> : MAPMLCJFIJL where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static ComponentType JMGCLOAKOCP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override Type INKNMGBPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x361CF80", Offset = "0x361C180", VA = "0x18361CF80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int IFFGAKEDHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x361D2F0", Offset = "0x361C4F0", VA = "0x18361D2F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x361D280", Offset = "0x361C480", VA = "0x18361D280")]
	public Data IDIODJLMFAH(Entity FADPOFMJIJF)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View PHBOJMIJLFG(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3D217B0", Offset = "0x3D209B0", VA = "0x183D217B0", Slot = "14")]
	protected internal override T PHBOJMIJLFG<T>(Entity FADPOFMJIJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1913980", Offset = "0x1912B80", VA = "0x181913980")]
	protected JPLHKBHAKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class MAPMLCJFIJL : INNOJNEKDJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DynamicComponentTypeHandle IMCKNHPHMPB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EntityManager GLHEACEJGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B00", Offset = "0x8D3D00", VA = "0x1808D4B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract Type INKNMGBPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int IFFGAKEDHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Type BIOINJOHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xF3B4D0", Offset = "0xF3A6D0", VA = "0x180F3B4D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int GIAGNMMAKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF670", Offset = "0x6BEE870", VA = "0x186BEF670", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private HBGGGACDKNF[] FAAJCEBOJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2B0", Offset = "0x9AD4B0", VA = "0x1809AE2B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual HBGGGACDKNF[] BFIJMMBMBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF320", Offset = "0x6BEE520", VA = "0x186BEF320", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF550", Offset = "0x6BEE750", VA = "0x186BEF550")]
	public void OHLMLHJNBAL(EntityManager NBACICFMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9A16E0", Offset = "0x9A08E0", VA = "0x1809A16E0")]
	protected INNOJNEKDJI HHMHJEKNNAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T PHBOJMIJLFG<T>(Entity FADPOFMJIJF) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF3E0", Offset = "0x6BEE5E0", VA = "0x186BEF3E0", Slot = "8")]
	public (uint, uint) LNEPHPEGANN(Entity FADPOFMJIJF)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF4B0", Offset = "0x6BEE6B0", VA = "0x186BEF4B0", Slot = "9")]
	public bool MMMAGGLADCL(Entity FADPOFMJIJF, (uint order, uint change) EJEDLELNMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected MAPMLCJFIJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct DAOGNFPFCCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ENGBMBNJAKF OEBNJDFJMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<Type> OMNEJPNCJMO;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	private DAOGNFPFCCJ(List<Type> OMNEJPNCJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAA50", Offset = "0x6BE9C50", VA = "0x186BEAA50")]
	public static void NHOFJKDINME(List<Type> OMNEJPNCJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA7A0", Offset = "0x6BE99A0", VA = "0x186BEA7A0")]
	private void AHIGFHAELHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA9D0", Offset = "0x6BE9BD0", VA = "0x186BEA9D0")]
	private bool AIBKFPCAFEF(Type JAACLLLIGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAAE0", Offset = "0x6BE9CE0", VA = "0x186BEAAE0")]
	private void NOILFEIIFKC(Type JAACLLLIGMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class EGEKHPPNFAD
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
internal struct DLAICHKAKOI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NAGCPMGBDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	public NativeArray<Entity> AKBLDBCDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[WriteOnly]
	public NativeList<T> NDBEGNCDMEC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
public enum CAONBNKGIMF
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
public class ANDMKFNAJKN : HMEEAGFGNAN
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CAONBNKGIMF HACDPJMJFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
		[CompilerGenerated]
		get
		{
			return default(CAONBNKGIMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x15AADB0", Offset = "0x15A9FB0", VA = "0x1815AADB0")]
	public ANDMKFNAJKN(CAONBNKGIMF BIAEGHNJKDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class NMPIABAFBIL : HMEEAGFGNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	public NMPIABAFBIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class KPLMCFJAMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	protected KPLMCFJAMHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class GMAOKCIBAID
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct AHOJFMEABIC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly NativeArray<TSrc> BGBPILICHHA;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869960", VA = "0x18086A760")]
		public AHOJFMEABIC(NativeArray<TSrc> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		public BFPHGJIPJBE<TSrc, TValue> OJLOCLMHONL<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(BFPHGJIPJBE<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct BFPHGJIPJBE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly NativeArray<TSrc> BGBPILICHHA;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869960", VA = "0x18086A760")]
		public BFPHGJIPJBE(NativeArray<TSrc> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
		public HGMGNBBILHE<TSrc, TValue, TSelector> DBNLJPLNHKH<TSelector>() where TSelector : struct, FBGIPHGKDFE<TSrc, TValue>
		{
			return default(HGMGNBBILHE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct HGMGNBBILHE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FBGIPHGKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> BGBPILICHHA;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869960", VA = "0x18086A760")]
		public HGMGNBBILHE(NativeArray<TSrc> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3375DE0", Offset = "0x3374FE0", VA = "0x183375DE0")]
		public PJAOJDCKBIE<TSrc, TValue, TSelector> FGOMMBLKHCO()
		{
			return default(PJAOJDCKBIE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct HCHEJHMJFPO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FBGIPHGKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly NativeArray<TSrc> BGBPILICHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TSelector MMFBKCHICCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int MMFFFGBLCAP;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TValue HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x336D2C0", Offset = "0x336C4C0", VA = "0x18336D2C0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int FPMEKFLEFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x841C80", Offset = "0x840E80", VA = "0x180841C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int CGOAKPGGPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x9A3760", Offset = "0x9A2960", VA = "0x1809A3760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x336D460", Offset = "0x336C660", VA = "0x18336D460")]
		public HCHEJHMJFPO(NativeArray<TSrc> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x336D330", Offset = "0x336C530", VA = "0x18336D330")]
		public bool CKPDOOCLIPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x336D340", Offset = "0x336C540", VA = "0x18336D340")]
		private TSrc HFKAPKGGBOP(int PPKKHBJMHLB)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct PJAOJDCKBIE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FBGIPHGKDFE<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private HCHEJHMJFPO<TSrc, TValue, TSelector> DGEHLDDPFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TValue CJBFEOODPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int PFBJKNIILDN;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ANLNPEGKJAF EJLHCKHAGAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x359EDD0", Offset = "0x359DFD0", VA = "0x18359EDD0")]
			get
			{
				return default(ANLNPEGKJAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue PBIJPLGCHKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8D86B0", Offset = "0x8D78B0", VA = "0x1808D86B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, ANLNPEGKJAF range) HMPLADJAFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x359EBD0", Offset = "0x359DDD0", VA = "0x18359EBD0")]
			get
			{
				return default((TValue, ANLNPEGKJAF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x359EE10", Offset = "0x359E010", VA = "0x18359EE10")]
		public PJAOJDCKBIE(NativeArray<TSrc> BGBPILICHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x25D0880", Offset = "0x25CFA80", VA = "0x1825D0880")]
		public PJAOJDCKBIE<TSrc, TValue, TSelector> KECFEFHENMC()
		{
			return default(PJAOJDCKBIE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x359ECA0", Offset = "0x359DEA0", VA = "0x18359ECA0")]
		public bool CKPDOOCLIPP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D950", Offset = "0x2B0CB50", VA = "0x182B0D950")]
	public static AHOJFMEABIC<T> AMHNMEDAAOM<T>(this NativeList<T> IEKCFDAIBOJ) where T : struct
	{
		return default(AHOJFMEABIC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1127750", Offset = "0x1126950", VA = "0x181127750")]
	public static AHOJFMEABIC<T> AMHNMEDAAOM<T>(this NativeArray<T> BGBPILICHHA) where T : struct
	{
		return default(AHOJFMEABIC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class OKEEJNBEDFF
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct ABIECKJBKPA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct PMOADPJACIG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public ABIECKJBKPA<TFrom> KDAGJHGAEFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<TFrom> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct HOABPHEGDPN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct BHAEDBMBBNK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public HOABPHEGDPN<TFrom> KDAGJHGAEFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NativeArrayAsync<TFrom> AKBLDBCDLHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct KBODJHEHJPK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct EHBBKNGMADC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public KBODJHEHJPK<TFrom> KDAGJHGAEFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Allocator IEOPKOGNAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NativeListAsync<TFrom> AKBLDBCDLHB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
internal struct LBKMKNHJGCE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<Entity> KPALEEBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EntityCommandBuffer CPFNOJENLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ComponentType ICEMMELMHPB;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6BED7F0", Offset = "0x6BEC9F0", VA = "0x186BED7F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class LGMJHAHDGAK
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x33424D0", Offset = "0x33416D0", VA = "0x1833424D0")]
	public static bool PMBNAKHKMBJ<T>(this NativeArray<Entity> EPLNAGGLGMC, EntityManager NBACICFMHBN, Allocator IEOPKOGNAGJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class LBIAHDGKIHN
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class MBNEKENKNNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class LMJDMPKKDEN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual bool JHKFLGNGINA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	protected LMJDMPKKDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class NCNIJJIDBLN : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public NCNIJJIDBLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class GHDCLKNEDNH : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public GHDCLKNEDNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class LLGGEDPKCCA : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public LLGGEDPKCCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class KCAEIAHDELJ : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public KCAEIAHDELJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class HKOCMPINHPG : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public HKOCMPINHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class FJOOGCCCKNE : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public FJOOGCCCKNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class HMECOFHONEF : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public HMECOFHONEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class LJJLBFKCFME : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public LJJLBFKCFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class JDPHMKNENNH : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public JDPHMKNENNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class MMIGILLPCGB : DPOKDPPJOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public MMIGILLPCGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class KIJFIDJFPDC : DPOKDPPJOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public KIJFIDJFPDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class JKFNJPKOIHC : DPOKDPPJOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public JKFNJPKOIHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class PAEAIMDKMPI : DPOKDPPJOEN
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public PAEAIMDKMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[DisableAutoCreation]
[BMMANLOIKJC(GPIAMNEIDDC.Application)]
public class DPOKDPPJOEN : LMJDMPKKDEN
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override bool JHKFLGNGINA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x844710", Offset = "0x843910", VA = "0x180844710", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB150", Offset = "0x6BEA350", VA = "0x186BEB150")]
	public DPOKDPPJOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class HEIKEAPPLII
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly EJHHLBFFFPM KHKILAOLMNK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly OJALFOGMFCB PAKNILCHICG;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly DNJJNGFBLCK EGJFKJHPBCF;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly List<Type> IONDLJIPCJO;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static bool JJKMPKPOGCP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	internal static JJEGODCIOOI<MAPMLCJFIJL> EHHJJBODKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBB70", Offset = "0x6BEAD70", VA = "0x186BEBB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static JJEGODCIOOI<JNIMENAMJOD> HJMNCKEJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBF20", Offset = "0x6BEB120", VA = "0x186BEBF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static JJEGODCIOOI<KPLMCFJAMHK> EAICHDDILCM
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBB10", Offset = "0x6BEAD10", VA = "0x186BEBB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBBD0", Offset = "0x6BEADD0", VA = "0x186BEBBD0")]
	public static void OHLMLHJNBAL(bool PPHFAHHOGGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6BEBA90", Offset = "0x6BEAC90", VA = "0x186BEBA90")]
	public static Type[] DJEFOLLICNE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class AFLCMAKAEOO
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5840", Offset = "0x2AE4A40", VA = "0x182AE5840")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArrayAsync<Entity> KPALEEBPIBN, NativeArrayAsync<T> JCEJEOAKGOJ, [Optional] JobHandle NJAJFFLKILC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5E70", Offset = "0x2AE5070", VA = "0x182AE5E70")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArrayAsync<Entity> KPALEEBPIBN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5990", Offset = "0x2AE4B90", VA = "0x182AE5990")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArray<Entity> KPALEEBPIBN, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5D50", Offset = "0x2AE4F50", VA = "0x182AE5D50")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB<T>(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, NativeArray<Entity> KPALEEBPIBN, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7C00", Offset = "0x6BE6E00", VA = "0x186BE7C00")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB(this EntityCommandBufferSystem AAHGOGAPMBE, NativeArray<Entity> KPALEEBPIBN, ComponentTypes JGPBCLLLPOP, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7AA0", Offset = "0x6BE6CA0", VA = "0x186BE7AA0")]
	[MustUseReturnValue]
	public static JobHandle GHJNKMJILCB(this EntityCommandBufferSystem AAHGOGAPMBE, EntityCommandBuffer CPFNOJENLAJ, NativeArray<Entity> KPALEEBPIBN, ComponentTypes JGPBCLLLPOP, [Optional] JobHandle NJAJFFLKILC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class HBAFNBDAELI
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB980", Offset = "0x6BEAB80", VA = "0x186BEB980")]
	private unsafe static Span<byte> IEEENBPGDOB(Unity.Entities.Chunk* JHIKJCCHBCK, int KGCFIGFKIBC)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x285AFC0", Offset = "0x285A1C0", VA = "0x18285AFC0")]
	public unsafe static Span<T> IHHGOMALHPB<T>(Unity.Entities.Chunk* JHIKJCCHBCK, int KGCFIGFKIBC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x285AF80", Offset = "0x285A180", VA = "0x18285AF80")]
	public static Span<T> IHHGOMALHPB<T>(this ref Unity.Entities.Chunk JHIKJCCHBCK, int KGCFIGFKIBC)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB910", Offset = "0x6BEAB10", VA = "0x186BEB910")]
	public unsafe static Span<Entity> FGFPIMBIAEO(Unity.Entities.Chunk* JHIKJCCHBCK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB780", Offset = "0x6BEA980", VA = "0x186BEB780")]
	public unsafe static void DAFFCKIEONE(Unity.Entities.Chunk* JHIKJCCHBCK, int KGCFIGFKIBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KGLCBEHIGBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> LKAJLMMOIAC;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x86D300", Offset = "0x86C500", VA = "0x18086D300")]
	public KGLCBEHIGBD(NativeArray<EntityRemapUtility.EntityRemapInfo> LKAJLMMOIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6BED780", Offset = "0x6BEC980", VA = "0x186BED780")]
	public Entity GKDCALHCKDK(Entity PHDPIMPEHFJ)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AttributeUsage(AttributeTargets.Class)]
public class DNNIJLPHFDG : HMEEAGFGNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955F50", VA = "0x180956D50")]
	public DNNIJLPHFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GIHNGKKMJPC
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate void PALMOHJIFLL<From, To>(From KDAGJHGAEFN, ref To BLDOOIAGGHO, KGLCBEHIGBD FHAMOHFMLKK);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class OMBDHIELOKC<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static PALMOHJIFLL<From, To> PGNIHHIOOLB;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public OMBDHIELOKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB5C0", Offset = "0x6BEA7C0", VA = "0x186BEB5C0")]
	static GIHNGKKMJPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2B02340", Offset = "0x2B01540", VA = "0x182B02340")]
	public static void HPLKOHIGFAE<T>(PALMOHJIFLL<T, T> FAMECPEAJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2B020B0", Offset = "0x2B012B0", VA = "0x182B020B0")]
	public static void HPLKOHIGFAE<From, To>(PALMOHJIFLL<From, To> FAMECPEAJEG, PALMOHJIFLL<To, From> IOFIDOJDOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2B02140", Offset = "0x2B01340", VA = "0x182B02140")]
	public static void HPLKOHIGFAE<From, To>(PALMOHJIFLL<From, To> PGNIHHIOOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2B071C0", Offset = "0x2B063C0", VA = "0x182B071C0")]
	public static PALMOHJIFLL<From, To> NAFPOPAHAKF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2B046D0", Offset = "0x2B038D0", VA = "0x182B046D0")]
	public static void MCFDCGKBLBD<From, To>(From KDAGJHGAEFN, ref To BLDOOIAGGHO, KGLCBEHIGBD FHAMOHFMLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface AKOBDMKCOIJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIPPDLFPNHC(Entity FADPOFMJIJF, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKOEHJCGFDH(Entity FADPOFMJIJF, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HPJHLGGLCHK(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> OLGEBGPNCAL(Entity FADPOFMJIJF);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCMDDLIBJCH(Entity FADPOFMJIJF);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class CIEDHGFGGCI<TComponentData, TValue> : KIJANLNGAPB<TValue>, IDisposable where TComponentData : struct, OJDHPBCAOEE
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class FICDOPCFBMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> IEKCFDAIBOJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int CNOEMCDBJKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x2904080", Offset = "0x2903280", VA = "0x182904080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FA00", Offset = "0x4C4EC00", VA = "0x184C4FA00")]
		public bool JDBKLIKPLKB(out TValue ACKOJNNBEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FB40", Offset = "0x4C4ED40", VA = "0x184C4FB40")]
		public void PPMBLONPHPF(object IBIKCCMDMHA, TValue ACKOJNNBEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FAC0", Offset = "0x4C4ECC0", VA = "0x184C4FAC0")]
		public bool PLKCAALIKKA(object IBIKCCMDMHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F950", Offset = "0x4C4EB50", VA = "0x184C4F950")]
		public int HJCHNAJGEJK(object IBIKCCMDMHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C4FBF0", Offset = "0x4C4EDF0", VA = "0x184C4FBF0")]
		public FICDOPCFBMM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<FICDOPCFBMM> GFGLKAHHPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private BGGPGHADMCD<OFPEJFIPOIA, FICDOPCFBMM> IKHKECONCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager NBACICFMHBN;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x50631B0", Offset = "0x50623B0", VA = "0x1850631B0")]
	public CIEDHGFGGCI(EntityManager NBACICFMHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5063090", Offset = "0x5062290", VA = "0x185063090", Slot = "4")]
	public void PIPPDLFPNHC(Entity FADPOFMJIJF, object IBIKCCMDMHA, TValue ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5062C50", Offset = "0x5061E50", VA = "0x185062C50", Slot = "5")]
	public bool HKOEHJCGFDH(Entity FADPOFMJIJF, object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5062DE0", Offset = "0x5061FE0", VA = "0x185062DE0", Slot = "6")]
	public bool JDBKLIKPLKB(Entity FADPOFMJIJF, out TValue ACKOJNNBEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5062B40", Offset = "0x5061D40", VA = "0x185062B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5062F40", Offset = "0x5062140", VA = "0x185062F40")]
	private void OGMHFOLLCLF(FICDOPCFBMM PIAPLEKKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5062FC0", Offset = "0x50621C0", VA = "0x185062FC0")]
	private bool OMKGCPMOCOF(Entity FADPOFMJIJF, out OFPEJFIPOIA CPJGFEGBDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5062EB0", Offset = "0x50620B0", VA = "0x185062EB0")]
	private void LIAMAAAGFBN(Entity FADPOFMJIJF, OFPEJFIPOIA CPJGFEGBDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5062C30", Offset = "0x5061E30", VA = "0x185062C30")]
	private bool GLIGLJDACEM(OFPEJFIPOIA CPJGFEGBDOF, out FICDOPCFBMM PIAPLEKKODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5062B60", Offset = "0x5061D60", VA = "0x185062B60")]
	private FICDOPCFBMM FIGGMFJDHGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface KIJANLNGAPB<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIPPDLFPNHC(Entity FADPOFMJIJF, object IBIKCCMDMHA, TValue ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKOEHJCGFDH(Entity FADPOFMJIJF, object IBIKCCMDMHA);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDBKLIKPLKB(Entity FADPOFMJIJF, out TValue ACKOJNNBEBO);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface OJDHPBCAOEE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OFPEJFIPOIA IPLAOCJEGDH
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
public struct OFPEJFIPOIA : PGAAPACJAHM<OFPEJFIPOIA>, DGHMCHAIFOA, IEquatable<OFPEJFIPOIA>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly OFPEJFIPOIA EACGNLJCKKO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int FPMEKFLEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CreateProperty]
	public int OLFLDONEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xC56930", Offset = "0xC55B30", VA = "0x180C56930", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x159B400", Offset = "0x159A600", VA = "0x18159B400", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF06F0", Offset = "0x6BEF8F0", VA = "0x186BF06F0", Slot = "8")]
	public bool Equals(OFPEJFIPOIA HPOECFLNEOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0740", Offset = "0x6BEF940", VA = "0x186BF0740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class OEMPIDKGNNB<THasTokensTag> : AKOBDMKCOIJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Dictionary<Entity, OFPEJFIPOIA> JBOFBOONIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stack<HashSet<object>> GFGLKAHHPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private BGGPGHADMCD<OFPEJFIPOIA, HashSet<object>> IKHKECONCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager NBACICFMHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem AAHGOGAPMBE;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x35752C0", Offset = "0x35744C0", VA = "0x1835752C0")]
	public OEMPIDKGNNB(EntityManager NBACICFMHBN, EntityCommandBufferSystem AAHGOGAPMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3574D20", Offset = "0x3573F20", VA = "0x183574D20", Slot = "4")]
	public bool PIPPDLFPNHC(Entity FADPOFMJIJF, object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x35738E0", Offset = "0x3572AE0", VA = "0x1835738E0", Slot = "5")]
	public bool HKOEHJCGFDH(Entity FADPOFMJIJF, object IBIKCCMDMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3573CD0", Offset = "0x3572ED0", VA = "0x183573CD0", Slot = "6")]
	public bool HPJHLGGLCHK(Entity FADPOFMJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3573E90", Offset = "0x3573090", VA = "0x183573E90", Slot = "10")]
	public bool HPJHLGGLCHK(OFPEJFIPOIA CPJGFEGBDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3574660", Offset = "0x3573860", VA = "0x183574660", Slot = "7")]
	public IEnumerable<object> OLGEBGPNCAL(Entity FADPOFMJIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3574720", Offset = "0x3573920", VA = "0x183574720", Slot = "11")]
	public IEnumerable<object> OLGEBGPNCAL(OFPEJFIPOIA CPJGFEGBDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x35732E0", Offset = "0x35724E0", VA = "0x1835732E0", Slot = "8")]
	public bool DCMDDLIBJCH(Entity FADPOFMJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x35736C0", Offset = "0x35728C0", VA = "0x1835736C0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3574490", Offset = "0x3573690", VA = "0x183574490")]
	private void OGMHFOLLCLF(HashSet<object> PIAPLEKKODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3574A00", Offset = "0x3573C00", VA = "0x183574A00")]
	private bool OMKGCPMOCOF(Entity FADPOFMJIJF, out OFPEJFIPOIA CPJGFEGBDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3573120", Offset = "0x3572320", VA = "0x183573120")]
	private bool CLOKOKNLMOO(Entity FADPOFMJIJF, out OFPEJFIPOIA CPJGFEGBDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x35741A0", Offset = "0x35733A0", VA = "0x1835741A0")]
	private void MACGAJALEKO(Entity FADPOFMJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x35735B0", Offset = "0x35727B0", VA = "0x1835735B0")]
	private void DIIODPMLGGH(Entity FADPOFMJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x35742B0", Offset = "0x35734B0", VA = "0x1835742B0")]
	private void MHPIFOGLKJB(Entity FADPOFMJIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x35740C0", Offset = "0x35732C0", VA = "0x1835740C0")]
	private void LIAMAAAGFBN(Entity FADPOFMJIJF, OFPEJFIPOIA CPJGFEGBDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3573F30", Offset = "0x3573130", VA = "0x183573F30")]
	private bool JFKCFFMMHLN(OFPEJFIPOIA CPJGFEGBDOF, out HashSet<object> PIAPLEKKODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3573700", Offset = "0x3572900", VA = "0x183573700")]
	private HashSet<object> FIGGMFJDHGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class BBCLDJBAOLO
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void CBKLJIGPJGE(this ENGBMBNJAKF OEBNJDFJMBE, NativeArray<Entity> KPALEEBPIBN, [Optional][CallerFilePath] string OHBBEDEEPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void CBKLJIGPJGE(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, NativeArray<Entity> KPALEEBPIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void CBKLJIGPJGE(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<Entity> KPALEEBPIBN, bool KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void EOCMOLMLJFJ(this ENGBMBNJAKF OEBNJDFJMBE, NativeArray<Entity> KPALEEBPIBN, EntityManager NBACICFMHBN, [Optional][CallerFilePath] string OHBBEDEEPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void EOCMOLMLJFJ(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<Entity> KPALEEBPIBN, EntityManager NBACICFMHBN, bool KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void JLNFKEEMEMK(this ENGBMBNJAKF OEBNJDFJMBE, NativeArray<Entity> KPALEEBPIBN, NativeArray<Entity> OCIOEHNALGM, [Optional][CallerFilePath] string OHBBEDEEPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void JLNFKEEMEMK(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<Entity> KPALEEBPIBN, NativeArray<Entity> OCIOEHNALGM, bool KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D36530", Offset = "0x2D35730", VA = "0x182D36530")]
	public static void KNHHOLDOJIB<T>(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, NativeArray<Entity> KPALEEBPIBN, NativeList<T> JCEJEOAKGOJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D365C0", Offset = "0x2D357C0", VA = "0x182D365C0")]
	public static void KNHHOLDOJIB<T>(this ENGBMBNJAKF OEBNJDFJMBE, NativeArray<Entity> KPALEEBPIBN, NativeArray<T> JCEJEOAKGOJ, [Optional][CallerFilePath] string OHBBEDEEPKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D364F0", Offset = "0x2D356F0", VA = "0x182D364F0")]
	public static void KNHHOLDOJIB<T>(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, NativeArray<Entity> KPALEEBPIBN, NativeArray<T> JCEJEOAKGOJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void KNHHOLDOJIB<T>(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<Entity> KPALEEBPIBN, NativeArray<T> JCEJEOAKGOJ, bool KKHDHHGCHBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D36460", Offset = "0x2D35660", VA = "0x182D36460")]
	public static void EJFAELIOOAP<T>(this ENGBMBNJAKF OEBNJDFJMBE, NativeList<T> JCEJEOAKGOJ, [Optional][CallerFilePath] string OHBBEDEEPKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D36430", Offset = "0x2D35630", VA = "0x182D36430")]
	public static void EJFAELIOOAP<T>(this ENGBMBNJAKF OEBNJDFJMBE, NativeArray<T> JCEJEOAKGOJ, [Optional][CallerFilePath] string OHBBEDEEPKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void EJFAELIOOAP<T>(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<T> JCEJEOAKGOJ, bool KKHDHHGCHBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void LLGADMEDMAF(this ENGBMBNJAKF OEBNJDFJMBE, EntityQuery PODFABCMECB, [Optional][CallerFilePath] string OHBBEDEEPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void LLGADMEDMAF(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, EntityQuery PODFABCMECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void LLGADMEDMAF(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, EntityQuery PODFABCMECB, bool KKHDHHGCHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D364C0", Offset = "0x2D356C0", VA = "0x182D364C0")]
	public static void GDJPJNGHHJA<T, T2>(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, EntityQuery PODFABCMECB) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	private static void GDJPJNGHHJA<T, T2>(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, EntityQuery PODFABCMECB, bool KKHDHHGCHBO) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D364C0", Offset = "0x2D356C0", VA = "0x182D364C0")]
	public static void KNPKFPJMEBN<T>(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, NativeList<T> BGBPILICHHA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void KNPKFPJMEBN<T>(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeList<T> BGBPILICHHA, bool KKHDHHGCHBO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D364C0", Offset = "0x2D356C0", VA = "0x182D364C0")]
	public static void FLEPGOFHJGN<T>(this ENGBMBNJAKF OEBNJDFJMBE, string PCKMHBLNCII, NativeArray<T> BGBPILICHHA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
	public static void FLEPGOFHJGN<T>(this ENGBMBNJAKF OEBNJDFJMBE, string OHBBEDEEPKI, NativeArray<T> BGBPILICHHA, bool KKHDHHGCHBO) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
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
