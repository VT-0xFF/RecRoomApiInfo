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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AB5AC0", Offset = "0x6AB4EC0", VA = "0x186AB5AC0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LIDBCFHEOLF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly byte[] ENPOOOLHCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemoryStream ELNNHDNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CodedOutputStream GHFLDNNMCHA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9940", Offset = "0x6AB8D40", VA = "0x186AB9940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IKKNOLIJDDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MemoryStream ELNNHDNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CodedInputStream ALGBDOBIKJC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7540", Offset = "0x6AB6940", VA = "0x186AB7540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EOKEPBFNBNH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class EIHPCKLMNPD : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public global::EOKEPBFNBNH<Protobuf> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x914010", Offset = "0x913410", VA = "0x180914010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37543A0", Offset = "0x37537A0", VA = "0x1837543A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1C688A0", Offset = "0x1C67CA0", VA = "0x181C688A0")]
		[DebuggerHidden]
		public EIHPCKLMNPD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x37541B0", Offset = "0x37535B0", VA = "0x1837541B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3754360", Offset = "0x3753760", VA = "0x183754360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly Action<Protobuf> MOPBCMBIEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MemoryStream ELNNHDNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CodedInputStream ALGBDOBIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Protobuf DJBMAHFONBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public readonly int EAGEACLGNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80EC90", Offset = "0x80E090", VA = "0x18080EC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1C6E270", Offset = "0x1C6D670", VA = "0x181C6E270")]
	private EOKEPBFNBNH(byte[] ENPOOOLHCDD, Action<Protobuf> MOPBCMBIEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD820", Offset = "0x2CACC20", VA = "0x182CAD820")]
	public static global::EOKEPBFNBNH<Protobuf> EDGHPEHNECD<Data>(ReadOnlySpan<byte> MPNODGMHCDM, ReadOnlySpan<Data> FDOLNONHOJG, Action<Protobuf> MOPBCMBIEOE)
	{
		return default(global::EOKEPBFNBNH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1C6E0E0", Offset = "0x1C6D4E0", VA = "0x181C6E0E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1C6E120", Offset = "0x1C6D520", VA = "0x181C6E120", Slot = "4")]
	[IteratorStateMachine(typeof(global::EOKEPBFNBNH<>.EIHPCKLMNPD))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C6E220", Offset = "0x1C6D620", VA = "0x181C6E220", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OEEBBLLMCMN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly byte[] ENPOOOLHCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Protobuf DJBMAHFONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly MemoryStream ELNNHDNLDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly CodedOutputStream GHFLDNNMCHA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B8A0", Offset = "0x3F2ACA0", VA = "0x183F2B8A0")]
	private OEEBBLLMCMN(byte[] ENPOOOLHCDD, in Protobuf DJBMAHFONBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D7E0", Offset = "0x2F8CBE0", VA = "0x182F8D7E0")]
	public static global::OEEBBLLMCMN<Protobuf> EDGHPEHNECD<T>(ReadOnlySpan<T> FDOLNONHOJG)
	{
		return default(global::OEEBBLLMCMN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B870", Offset = "0x3F2AC70", VA = "0x183F2B870")]
	public void KFDDCEHEMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B7E0", Offset = "0x3F2ABE0", VA = "0x183F2B7E0")]
	public ByteString EJEONOACJJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F2B6B0", Offset = "0x3F2AAB0", VA = "0x183F2B6B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class LFEJCMGOMPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class DHFAIHKLBCM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static T EOEKGHMNIDN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool MPLBAKOOBJF;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x360ADB0", Offset = "0x360A1B0", VA = "0x18360ADB0")]
		public static void CEBPBFKDMNN(in T IGHGGFJEGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public DHFAIHKLBCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeHashMap<EKMGCKPOKKB, int2> KAKKDDIHKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeList<byte> ENPOOOLHCDD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9490", Offset = "0x6AB8890", VA = "0x186AB9490")]
	public LFEJCMGOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3021B60", Offset = "0x3020F60", VA = "0x183021B60")]
	public void BCHEBCENJDG<T>(T EOEKGHMNIDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3023780", Offset = "0x3022B80", VA = "0x183023780")]
	public T LLPKLFBKNII<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A60", Offset = "0x6AB7E60", VA = "0x186AB8A60")]
	public void BCHEBCENJDG(Type ONBHBHIHHNE, GGCEFKOAKOD EOEKGHMNIDN, int DKJECOLDDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8CD0", Offset = "0x6AB80D0", VA = "0x186AB8CD0")]
	public bool EPJAPKGCCDE(Type ONBHBHIHHNE, out GGCEFKOAKOD KOCKBILIHNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9260", Offset = "0x6AB8660", VA = "0x186AB9260")]
	public GGCEFKOAKOD LLPKLFBKNII(Type ONBHBHIHHNE)
	{
		return default(GGCEFKOAKOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9050", Offset = "0x6AB8450", VA = "0x186AB9050")]
	public NativeArray<byte>.ReadOnly JHPHOGELEBM(Type ONBHBHIHHNE)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8DA0", Offset = "0x6AB81A0", VA = "0x186AB8DA0")]
	public bool FHFBHFICAIC(Type ONBHBHIHHNE, out NativeArray<byte>.ReadOnly KOCKBILIHNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8C30", Offset = "0x6AB8030", VA = "0x186AB8C30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8F30", Offset = "0x6AB8330", VA = "0x186AB8F30", Slot = "1")]
	~LFEJCMGOMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9330", Offset = "0x6AB8730", VA = "0x186AB9330")]
	private NativeArray<byte>.ReadOnly MBEAAKAFIAP(int2 MGMOAFDEFKJ)
	{
		return default(NativeArray<byte>.ReadOnly);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LNDDHPNNKAA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public T DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38B9440", Offset = "0x38B8840", VA = "0x1838B9440")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x38BC0E0", Offset = "0x38BB4E0", VA = "0x1838BC0E0")]
	public static global::LNDDHPNNKAA<T> ILINJACDGKH(T EOEKGHMNIDN)
	{
		return default(global::LNDDHPNNKAA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x38B9A30", Offset = "0x38B8E30", VA = "0x1838B9A30")]
	public static T ILINJACDGKH(global::LNDDHPNNKAA<T> BICCJELLHLH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PNMKJIDKOEO
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static LFEJCMGOMPI EPAGBANOJBM;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x24DD880", Offset = "0x24DCC80", VA = "0x1824DD880")]
	public static void BCHEBCENJDG<T>(T EOEKGHMNIDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24DEA90", Offset = "0x24DDE90", VA = "0x1824DEA90")]
	public static T LLPKLFBKNII<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCD50", Offset = "0x6ABC150", VA = "0x186ABCD50")]
	public static NativeArray<byte>.ReadOnly JHPHOGELEBM(Type ONBHBHIHHNE)
	{
		return default(NativeArray<byte>.ReadOnly);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCCC0", Offset = "0x6ABC0C0", VA = "0x186ABCCC0")]
	public static bool EPJAPKGCCDE(Type ONBHBHIHHNE, out GGCEFKOAKOD KOCKBILIHNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ENLJKOPLLHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int OKCABOJFCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int HHFCIFFLNGA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KOJCAHIFAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xB820F0", Offset = "0xB814F0", VA = "0x180B820F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1115560", Offset = "0x1114960", VA = "0x181115560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CAOFKEAGCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HBCAHGJIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5990", Offset = "0x6AB4D90", VA = "0x186AB5990")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5980", Offset = "0x6AB4D80", VA = "0x186AB5980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83CF20", Offset = "0x83C320", VA = "0x18083CF20")]
	private ENLJKOPLLHP(int OKCABOJFCGG, int HHFCIFFLNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3B8EC40", Offset = "0x3B8E040", VA = "0x183B8EC40")]
	public static ENLJKOPLLHP EEACPAFIPPG(int OKCABOJFCGG, int HHFCIFFLNGA)
	{
		return default(ENLJKOPLLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AB59A0", Offset = "0x6AB4DA0", VA = "0x186AB59A0")]
	public static ENLJKOPLLHP KNBMOOBIEML(int BHNALBBIKPM, int DHLNIOOELBF)
	{
		return default(ENLJKOPLLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AB59B0", Offset = "0x6AB4DB0", VA = "0x186AB59B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct POAJGBLGEKA : global::EFGAELHGFFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCEE0", Offset = "0x6ABC2E0", VA = "0x186ABCEE0")]
	public float NFDPOJCCKNE(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCEE0", Offset = "0x6ABC2E0", VA = "0x186ABCEE0", Slot = "4")]
	private float AEGPHNHNDKA(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CHACFIGHANG : global::EFGAELHGFFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB43A0", Offset = "0x6AB37A0", VA = "0x186AB43A0")]
	public float NFDPOJCCKNE(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB43A0", Offset = "0x6AB37A0", VA = "0x186AB43A0", Slot = "4")]
	private float AEGPHNHNDKA(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MNNHNHOFAFH : global::EFGAELHGFFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1ED5F60", Offset = "0x1ED5360", VA = "0x181ED5F60")]
	public float NFDPOJCCKNE(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1ED5F60", Offset = "0x1ED5360", VA = "0x181ED5F60", Slot = "4")]
	private float AEGPHNHNDKA(in float3 EOEKGHMNIDN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EEIIAMODJNP : global::EFGAELHGFFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x10E0220", Offset = "0x10DF620", VA = "0x1810E0220")]
	public int NFDPOJCCKNE(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10E0220", Offset = "0x10DF620", VA = "0x1810E0220", Slot = "4")]
	private int NMFHNOBGBKP(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GEPICBNMIOM : global::EFGAELHGFFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6739850", Offset = "0x6738C50", VA = "0x186739850")]
	public int NFDPOJCCKNE(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6739850", Offset = "0x6738C50", VA = "0x186739850", Slot = "4")]
	private int NMFHNOBGBKP(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NEHAJFBIJEN : global::EFGAELHGFFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2C80", VA = "0x1828B3880")]
	public int NFDPOJCCKNE(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28B3880", Offset = "0x28B2C80", VA = "0x1828B3880", Slot = "4")]
	private int NMFHNOBGBKP(in int3 EOEKGHMNIDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BurstCompile]
internal struct KBHFKFDLIKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public ComponentDataFromEntity BLIGEINIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<Entity> GIMCLHOJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeList<Entity> HAPLBFKKMGJ;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8920", Offset = "0x6AB7D20", VA = "0x186AB8920", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MLMNPKNLNBP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Type ELGLNGNMJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Type[] MPPBPNNBDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class KAHNJLHAPKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly World MKIMPHJOKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly World CNFHBAKMNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly MOPOAILGOFG PKNMLFAJHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly ComponentSystemGroup[] DKOABOPFNPP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public World GGAMEKGGKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public World CJNLHJIALEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EntityManager CPFDJDFIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7EC0", Offset = "0x6AB72C0", VA = "0x186AB7EC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MOPOAILGOFG IHOEDBBHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public global::JNIKAANOIAO<AFEAMCGGOEP> FALHDIOFOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public global::JNIKAANOIAO<IBNOCBDOBMO> PAKPKKLJGII
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85D510", Offset = "0x85C910", VA = "0x18085D510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public global::JNIKAANOIAO<ECKBCBFHFLP> MNKLLJKLEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1740", Offset = "0x7F0B40", VA = "0x1807F1740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85D520", Offset = "0x85C920", VA = "0x18085D520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public World.NoAllocReadOnlyCollection<ComponentSystemBase> MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3770340", Offset = "0x376F740", VA = "0x183770340")]
		get
		{
			return default(World.NoAllocReadOnlyCollection<ComponentSystemBase>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ComponentSystemGroup[] NBGAMKPDKBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7D00", Offset = "0x6AB7100", VA = "0x186AB7D00")]
	public static KAHNJLHAPKM HOMOEPFAPGC(string LMAOKJPAKEM, LPABHHGNJGE CNGGDCGDNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8400", Offset = "0x6AB7800", VA = "0x186AB8400")]
	public KAHNJLHAPKM(string LMAOKJPAKEM, LPABHHGNJGE CNGGDCGDNBM = LPABHHGNJGE.Simulation, GDAHAABNIGH GNFGNDDBPMK = GDAHAABNIGH.Default, bool BLLAAOPKLPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6AB79A0", Offset = "0x6AB6DA0", VA = "0x186AB79A0")]
	public ComponentSystemBase AGNNCJKGGGL(Type ONBHBHIHHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2CF88B0", Offset = "0x2CF7CB0", VA = "0x182CF88B0")]
	public T AGNNCJKGGGL<T>() where T : ComponentSystemBase
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7EE0", Offset = "0x6AB72E0", VA = "0x186AB7EE0")]
	public void MCODEMHJACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7D80", Offset = "0x6AB7180", VA = "0x186AB7D80")]
	public void ILEOOEBJPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7BE0", Offset = "0x6AB6FE0", VA = "0x186AB7BE0")]
	public void FKHHBDMCKEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB80D0", Offset = "0x6AB74D0", VA = "0x186AB80D0")]
	public void OPADIFDNOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7C40", Offset = "0x6AB7040", VA = "0x186AB7C40")]
	public void FMLNHEMDLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7A50", Offset = "0x6AB6E50", VA = "0x186AB7A50")]
	public void ANNDGLOFGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7B10", Offset = "0x6AB6F10", VA = "0x186AB7B10")]
	public void COMKDJNNIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB79C0", Offset = "0x6AB6DC0", VA = "0x186AB79C0")]
	public void ALBEIEOCLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7CA0", Offset = "0x6AB70A0", VA = "0x186AB7CA0")]
	public void HNLMFBFFMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7AB0", Offset = "0x6AB6EB0", VA = "0x186AB7AB0")]
	public void BCLJHNBIMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7DE0", Offset = "0x6AB71E0", VA = "0x186AB7DE0")]
	internal void JIDIDHNKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8050", Offset = "0x6AB7450", VA = "0x186AB8050")]
	private bool NBJMPEFEICJ(ComponentSystemGroup ACHKMLIMANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8130", Offset = "0x6AB7530", VA = "0x186AB8130")]
	private void PJOOHOCKLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7F40", Offset = "0x6AB7340", VA = "0x186AB7F40")]
	private ComponentSystemGroup[] MKPGGANDNEN(GDAHAABNIGH GNFGNDDBPMK, bool PCBIIDLBJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7B70", Offset = "0x6AB6F70", VA = "0x186AB7B70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EFMMGDDOJPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5700", Offset = "0x6AB4B00", VA = "0x186AB5700")]
	[MustUseReturnValue]
	public static JobHandle NKDFGKEHLOL(this EntityCommandBufferSystem HPAHLNDAIIL, NativeList<Entity> JEBIOEILLHO, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5600", Offset = "0x6AB4A00", VA = "0x186AB5600")]
	[MustUseReturnValue]
	public static JobHandle NKDFGKEHLOL(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArrayAsync<Entity> JEBIOEILLHO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EPCOKBKIFHB
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x32F49E0", Offset = "0x32F3DE0", VA = "0x1832F49E0")]
	public static void APEHAMNNMEE<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityQuery HBIFFOCBHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x32F5060", Offset = "0x32F4460", VA = "0x1832F5060")]
	[MustUseReturnValue]
	public static JobHandle OLEPJAJLBNN<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeListAsync<Entity> JEBIOEILLHO, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x32F4A60", Offset = "0x32F3E60", VA = "0x1832F4A60")]
	[MustUseReturnValue]
	public static JobHandle OLEPJAJLBNN<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArrayAsync<Entity> JEBIOEILLHO, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class MOPOAILGOFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly KAHNJLHAPKM MKIMPHJOKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EntityManager CLFAKBGHDNF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public KAHNJLHAPKM GGAMEKGGKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA0B0", Offset = "0x6AB94B0", VA = "0x186ABA0B0")]
	public MOPOAILGOFG(KAHNJLHAPKM MKIMPHJOKAN, EntityManager CLFAKBGHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27CB590", Offset = "0x27CA990", VA = "0x1827CB590")]
	public bool EBDJACCCILN<T>(Entity HHCOBCONNMJ) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x27CB5D0", Offset = "0x27CA9D0", VA = "0x1827CB5D0")]
	public bool HCJEKNCAEDL<T>(Entity HHCOBCONNMJ, out T EOEKGHMNIDN) where T : struct, IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27CB660", Offset = "0x27CAA60", VA = "0x1827CB660")]
	public T HOLBKFCHBMO<T>(Entity HHCOBCONNMJ) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27CD1B0", Offset = "0x27CC5B0", VA = "0x1827CD1B0")]
	private ComponentType PGKLGEJMPOC<T>() where T : struct, IComponent
	{
		return default(ComponentType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9F20", Offset = "0x6AB9320", VA = "0x186AB9F20")]
	private ComponentType PGKLGEJMPOC(Type ONBHBHIHHNE)
	{
		return default(ComponentType);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class KHJADPDFGGM
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct JDAHMJHDDLL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public NativeArray<Entity> JOCKMCNDLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<T> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public struct KAKAPNOCNDH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NativeList<Entity> JOCKMCNDLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NativeArray<T> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct NPBPNHLOBLM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NativeArrayAsync<Entity> JOCKMCNDLDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public NativeArrayAsync<T> ACMNDMONPCA;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2F8BD90", Offset = "0x2F8B190", VA = "0x182F8BD90")]
		public NativeListAsync<Entity> HEMFDKICHNE<TPredicate>() where TPredicate : struct, global::CCKKJLCBHIJ<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2D005E0", Offset = "0x2CFF9E0", VA = "0x182D005E0")]
	public static NPBPNHLOBLM<T> IEMOLNDEELE<T>(this NativeArrayAsync<Entity> GIMCLHOJIMP, NativeArrayAsync<T> MBAJFLPFKBI, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct
	{
		return default(NPBPNHLOBLM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EHKICOCLMJD : NPELNOKKLBD
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Type BJKNFPHFGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5890", Offset = "0x6AB4C90", VA = "0x186AB5890")]
	public EHKICOCLMJD(Type MMBELIMCNEJ, Type BLIGEINIHML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class ACGNNHPNGDF
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HNGELODLGCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly Dictionary<Type, List<Type>> LDNKKHDJFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly HashSet<Type> MAKOKGANKMI;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	public HNGELODLGCF(Dictionary<Type, List<Type>> LDNKKHDJFNO, HashSet<Type> MAKOKGANKMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct EDIAFAMLAPD
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LIANMNDGBCB : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
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
		public EDIAFAMLAPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EDIAFAMLAPD <>3__<>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public LIANMNDGBCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AB98B0", Offset = "0x6AB8CB0", VA = "0x186AB98B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AB95F0", Offset = "0x6AB89F0", VA = "0x186AB95F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AB95A0", Offset = "0x6AB89A0", VA = "0x186AB95A0")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9870", Offset = "0x6AB8C70", VA = "0x186AB9870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB97C0", Offset = "0x6AB8BC0", VA = "0x186AB97C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB97C0", Offset = "0x6AB8BC0", VA = "0x186AB97C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct EDPMPICIHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Dictionary<Type, List<Type>> map;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Queue<Type> queue;
	}

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly Type DIIBMMLOODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private GDAHAABNIGH GNFGNDDBPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool FCBLLFJMEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool KPKEMMNEIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool PCBIIDLBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private IEnumerable<Type> MEJPHGLIFPO;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4E70", Offset = "0x6AB4270", VA = "0x186AB4E70")]
	public static EDIAFAMLAPD EDGHPEHNECD()
	{
		return default(EDIAFAMLAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4E90", Offset = "0x6AB4290", VA = "0x186AB4E90")]
	public EDIAFAMLAPD EHPDFGANPCH(GDAHAABNIGH CNGGDCGDNBM)
	{
		return default(EDIAFAMLAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4F50", Offset = "0x6AB4350", VA = "0x186AB4F50")]
	public EDIAFAMLAPD JNCPPKOEEGH(IEnumerable<Type> FKOMPPKIBLI)
	{
		return default(EDIAFAMLAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4EA0", Offset = "0x6AB42A0", VA = "0x186AB4EA0")]
	public EDIAFAMLAPD FKNBBDAJJOD(bool OELMGPGPOAK)
	{
		return default(EDIAFAMLAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5270", Offset = "0x6AB4670", VA = "0x186AB5270")]
	public EDIAFAMLAPD LIAACHBGPDO(bool JAAGLHCFKJL)
	{
		return default(EDIAFAMLAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4EB0", Offset = "0x6AB42B0", VA = "0x186AB4EB0")]
	public HNGELODLGCF IBHLKIIMAIK(Type[] HHOFJKLBEAP)
	{
		return default(HNGELODLGCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5390", Offset = "0x6AB4790", VA = "0x186AB5390")]
	[IteratorStateMachine(typeof(LIANMNDGBCB))]
	internal IEnumerable<Type> PMFDDHNGGLG(IEnumerable<Type> FKOMPPKIBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4F90", Offset = "0x6AB4390", VA = "0x186AB4F90")]
	internal Dictionary<Type, List<Type>> KGEMDJHJIGB(IEnumerable<Type> FKOMPPKIBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5280", Offset = "0x6AB4680", VA = "0x186AB5280")]
	private void LPMDKMIKCMG(Dictionary<Type, List<Type>> OAEDMJEOPNM, Type ONBHBHIHHNE, Type JPNJBGCJMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4670", Offset = "0x6AB3A70", VA = "0x186AB4670")]
	internal HashSet<Type> AIKGGGBLGEG(IEnumerable<Type> DKOABOPFNPP, Dictionary<Type, List<Type>> FHEFHDDBGPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4830", Offset = "0x6AB3C30", VA = "0x186AB4830")]
	internal bool CEFLBMPMMCP(Type ONBHBHIHHNE, GDAHAABNIGH GNFGNDDBPMK, bool PCBIIDLBJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4510", Offset = "0x6AB3910", VA = "0x186AB4510")]
	[CompilerGenerated]
	internal static void AFJPJFBKFKM(Type ONBHBHIHHNE, ref EDPMPICIHIF P_1)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MGPBGAJHPFD
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x301A2D0", Offset = "0x30196D0", VA = "0x18301A2D0")]
	public static NativeList<Entity> EMKFNEAMGDH<T>(this NativeArray<Entity> GIMCLHOJIMP, EntityManager CLFAKBGHDNF, Allocator NAFCEIMFOBK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class EPJBGNNIDLM
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct FAHFFIOBBND : global::EFGAELHGFFK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MLEPIBDEPIM;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5AE0", Offset = "0x6AB4EE0", VA = "0x186AB5AE0")]
		[BurstCompatible]
		public Entity NFDPOJCCKNE(in Entity EOEKGHMNIDN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5AE0", Offset = "0x6AB4EE0", VA = "0x186AB5AE0", Slot = "4")]
		private Entity LBILGCPHEGD(in Entity EOEKGHMNIDN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class OAEPOIDMPAB
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA100", Offset = "0x6AB9500", VA = "0x186ABA100")]
	public static bool INDIBJDNAOP(Type ONBHBHIHHNE, Type NGHIHEICEJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class JHGBMFNCKDM : PMCGJJDJEOL
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6AB78A0", Offset = "0x6AB6CA0", VA = "0x186AB78A0", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase AAMIDGHDFOP();

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AB78F0", Offset = "0x6AB6CF0", VA = "0x186AB78F0")]
	protected ComponentSystemBase PPIKOKNHOPE(params ComponentSystemBase[] MAKOKGANKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20CF390", Offset = "0x20CE790", VA = "0x1820CF390")]
	protected ComponentSystemBase PPIKOKNHOPE<T>(params ComponentSystemBase[] MAKOKGANKMI) where T : PMCGJJDJEOL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20CF270", Offset = "0x20CE670", VA = "0x1820CF270")]
	protected ComponentSystemBase AKLGPAFCJPA<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20CF270", Offset = "0x20CE670", VA = "0x1820CF270")]
	protected ComponentSystemBase OOMBBKKFGCO<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7850", Offset = "0x6AB6C50", VA = "0x186AB7850")]
	protected ComponentSystemBase EIHBOCBKKGE(params SystemHandleUntyped[] MAKOKGANKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x20CF2B0", Offset = "0x20CE6B0", VA = "0x1820CF2B0")]
	protected ComponentSystemBase EIHBOCBKKGE<T>(params SystemHandleUntyped[] MAKOKGANKMI) where T : PMCGJJDJEOL, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x20CF340", Offset = "0x20CE740", VA = "0x1820CF340")]
	protected SystemHandleUntyped IOABNNDCCKM<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7940", Offset = "0x6AB6D40", VA = "0x186AB7940")]
	protected JHGBMFNCKDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JCFFOAPHPKI<BaseClass>
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MEIKKLBJCPM(int POFPJBOBPKJ);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::JNIKAANOIAO<BaseClass> PNNIODLLKJI();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class LKLDLKCDDLM
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2FFD320", Offset = "0x2FFC720", VA = "0x182FFD320")]
	public static NativeList<T> FINGMAJAFDI<T>(NativeList<T> MBAJFLPFKBI, Allocator NAFCEIMFOBK) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OLNLOAKBEIF
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct FBNGDENEBLC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : global::EFGAELHGFFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	public NativeArray<TFrom> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeList<TFrom> GHEJEDGCOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeHashSet<TTo> HEIAHJNMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public TMap ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[BurstCompile]
internal struct FJHKCLPBMGH<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::CCKKJLCBHIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public NativeArray<T> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> JOCKMCNDLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> PBHMDIGOHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public TPredicate ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3896F60", Offset = "0x3896360", VA = "0x183896F60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct HLMNKDCLLBG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::EFGAELHGFFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	public NativeArray<TFrom> BPABBPPBBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[WriteOnly]
	public NativeList<TTo> DPLNIEKMOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public TMap ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[AttributeUsage(AttributeTargets.Class)]
public sealed class ACGBIIOIFPD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public GDAHAABNIGH AELDINDKAIC;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class CMLIAKNODEP : global::KJIALKDPDGH<EHKICOCLMJD, AFEAMCGGOEP>
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4440", Offset = "0x6AB3840", VA = "0x186AB4440")]
	public CMLIAKNODEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal abstract class KJIALKDPDGH<Attribute, BaseClass> : global::JCFFOAPHPKI<BaseClass>, DNANDPGLDGM where Attribute : NPELNOKKLBD
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly string LMAOKJPAKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<int, Type> EEBNJHMEBNO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x42F0F40", Offset = "0x42F0340", VA = "0x1842F0F40")]
	public KJIALKDPDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x42F0B90", Offset = "0x42EFF90", VA = "0x1842F0B90", Slot = "4")]
	public bool MEIKKLBJCPM(int POFPJBOBPKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x42F0BF0", Offset = "0x42EFFF0", VA = "0x1842F0BF0", Slot = "5")]
	public global::JNIKAANOIAO<BaseClass> PNNIODLLKJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x42F0960", Offset = "0x42EFD60", VA = "0x1842F0960", Slot = "7")]
	protected virtual bool INDIBJDNAOP(Type ONBHBHIHHNE, int CGKBEFNODHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x42F08D0", Offset = "0x42EFCD0", VA = "0x1842F08D0", Slot = "8")]
	protected virtual int BALFCPPHMMB(Type ONBHBHIHHNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x42F0B00", Offset = "0x42EFF00", VA = "0x1842F0B00")]
	public void MEBDGDDNOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42F0A60", Offset = "0x42EFE60", VA = "0x1842F0A60", Slot = "6")]
	public void KJCLACJNMFM(Type ONBHBHIHHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GINCMEANICC
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private struct KNBFHCJAGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly ulong KLAKAJJLEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly OCKCBOIBCOM LLECKCAKMGD;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83C9F0", Offset = "0x83BDF0", VA = "0x18083C9F0")]
		public KNBFHCJAGMO(ulong EBFFLLGJJLA, OCKCBOIBCOM LMJPPANFIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AB89B0", Offset = "0x6AB7DB0", VA = "0x186AB89B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HAHBPLJDBPB : IEnumerable<OCKCBOIBCOM>, IEnumerable, IEnumerator<OCKCBOIBCOM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private OCKCBOIBCOM <>2__current;

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
		private IEnumerator<BGJOAHJCBBE> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private BGJOAHJCBBE <attrib>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private OCKCBOIBCOM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Attributes.NameHash>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OCKCBOIBCOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6AB7440", Offset = "0x6AB6840", VA = "0x186AB7440", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
		[DebuggerHidden]
		public HAHBPLJDBPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7490", Offset = "0x6AB6890", VA = "0x186AB7490", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AB70E0", Offset = "0x6AB64E0", VA = "0x186AB70E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7090", Offset = "0x6AB6490", VA = "0x186AB7090")]
		private void DJGMDMALOCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7400", Offset = "0x6AB6800", VA = "0x186AB7400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7350", Offset = "0x6AB6750", VA = "0x186AB7350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OCKCBOIBCOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Attributes.NameHash>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7350", Offset = "0x6AB6750", VA = "0x186AB7350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Type MGIJGBHPALA;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static Dictionary<ulong, int> AFPFNKJLMNJ;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static KNBFHCJAGMO[] MHNLNNHFIHA;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static bool MPLBAKOOBJF;

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6860", Offset = "0x6AB5C60", VA = "0x186AB6860")]
	public static ulong MGIAINKHKOJ(int POFPJBOBPKJ)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5F20", Offset = "0x6AB5320", VA = "0x186AB5F20")]
	public static int CBCDGFHEMAD(ulong LMJPPANFIAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB69B0", Offset = "0x6AB5DB0", VA = "0x186AB69B0")]
	public static void OAGJEKOOFKN(bool BLLAAOPKLPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6C00", Offset = "0x6AB6000", VA = "0x186AB6C00")]
	private static void OIOMMPKMFEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6CC0", Offset = "0x6AB60C0", VA = "0x186AB6CC0")]
	private static void OIOMMPKMFEI(IEnumerable<Type> FKOMPPKIBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5E40", Offset = "0x6AB5240", VA = "0x186AB5E40")]
	private static void BPBPLBMHBFP(int IBEAKAONCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AB60F0", Offset = "0x6AB54F0", VA = "0x186AB60F0")]
	private static void FFNDKIFMGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5CC0", Offset = "0x6AB50C0", VA = "0x186AB5CC0")]
	private static (ulong, IEnumerable<OCKCBOIBCOM>) AGCHDCLAFBG(Type ONBHBHIHHNE)
	{
		return default((ulong, IEnumerable<OCKCBOIBCOM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6060", Offset = "0x6AB5460", VA = "0x186AB6060")]
	[IteratorStateMachine(typeof(HAHBPLJDBPB))]
	private static IEnumerable<OCKCBOIBCOM> FBJBCFNKBDI(Type ONBHBHIHHNE, ulong LMJPPANFIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6560", Offset = "0x6AB5960", VA = "0x186AB6560")]
	private static void KBGHCMKDEME(ulong LMJPPANFIAK, IEnumerable<OCKCBOIBCOM> GGDFJHHLIBI, TypeManager.TypeInfo MOOGJKOOKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6450", Offset = "0x6AB5850", VA = "0x186AB6450")]
	private static void HNGOBHKDLDH(KNBFHCJAGMO MOOGJKOOKBF, int POFPJBOBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB68C0", Offset = "0x6AB5CC0", VA = "0x186AB68C0")]
	private static void NHIBDNENOPB(KNBFHCJAGMO MOOGJKOOKBF, int POFPJBOBPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5FD0", Offset = "0x6AB53D0", VA = "0x186AB5FD0")]
	private static KNBFHCJAGMO CKCKDCGKLLJ(int POFPJBOBPKJ)
	{
		return default(KNBFHCJAGMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6550", Offset = "0x6AB5950", VA = "0x186AB6550")]
	private static int JGHCILFLEOA(int POFPJBOBPKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class HAKEJLFHFIE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DCEOJKFIKCF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly NativeArray<T>.ReadOnly BIBDBFOMNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int CBDFEPEIFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int BMPOGCNHJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private T LJIBHCLPKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private T PNAKPPLALMB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public ENLJKOPLLHP JJIOMBHAMDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x35FAFE0", Offset = "0x35FA3E0", VA = "0x1835FAFE0")]
			get
			{
				return default(ENLJKOPLLHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public T EFLDDGJOAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x2824E30", Offset = "0x2824230", VA = "0x182824E30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (T, ENLJKOPLLHP) HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x35FAF10", Offset = "0x35FA310", VA = "0x1835FAF10")]
			get
			{
				return default((T, ENLJKOPLLHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x35FB3C0", Offset = "0x35FA7C0", VA = "0x1835FB3C0")]
		public DCEOJKFIKCF(NativeArray<T> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x35FAE20", Offset = "0x35FA220", VA = "0x1835FAE20")]
		public DCEOJKFIKCF<T> KLBJEDHKGHJ()
		{
			return default(DCEOJKFIKCF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x35FB1A0", Offset = "0x35FA5A0", VA = "0x1835FB1A0")]
		public bool PPCIFOBIFBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA5A0", Offset = "0x2CA99A0", VA = "0x182CAA5A0")]
		public KNNHBDFAILF<T, TComparer> PHHLGKMGONP<TComparer>([Optional] TComparer AOCGKKCIOLP) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KNNHBDFAILF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct KNNHBDFAILF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<T>.ReadOnly BIBDBFOMNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int CBDFEPEIFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int BMPOGCNHJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T LJIBHCLPKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private T PNAKPPLALMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TComparer AOCGKKCIOLP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ENLJKOPLLHP JJIOMBHAMDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x35FAFE0", Offset = "0x35FA3E0", VA = "0x1835FAFE0")]
			get
			{
				return default(ENLJKOPLLHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T EFLDDGJOAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x2824E30", Offset = "0x2824230", VA = "0x182824E30")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T value, ENLJKOPLLHP range) HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x42FB0F0", Offset = "0x42FA4F0", VA = "0x1842FB0F0")]
			get
			{
				return default((T, ENLJKOPLLHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x42FB420", Offset = "0x42FA820", VA = "0x1842FB420")]
		public KNNHBDFAILF(NativeArray<T>.ReadOnly BIBDBFOMNHM, TComparer AOCGKKCIOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x318B8C0", Offset = "0x318ACC0", VA = "0x18318B8C0")]
		public KNNHBDFAILF<T, TComparer> KLBJEDHKGHJ()
		{
			return default(KNNHBDFAILF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x42FB1C0", Offset = "0x42FA5C0", VA = "0x1842FB1C0")]
		public bool PPCIFOBIFBE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB170", Offset = "0x2CEA570", VA = "0x182CEB170")]
	public static DCEOJKFIKCF<T> PPIKOKNHOPE<T>(this NativeArray<T> BIBDBFOMNHM) where T : struct
	{
		return default(DCEOJKFIKCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface EFGAELHGFFK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NFDPOJCCKNE(in TFrom EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JGHMEINLAKN
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EPJGJIDBNEN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MJPKGIMCONK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		public MJPKGIMCONK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DIBNHFMDGJJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		public DIBNHFMDGJJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly List<Func<JobHandle, JobHandle>> NEAAANJELPI;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5A40", Offset = "0x6AB4E40", VA = "0x186AB5A40")]
	public EPJGJIDBNEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GMKPFHAFGDF
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class EGHEKLDCEMA : EntityCommandBufferSystem, PEIEKNMBMHB
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
	protected EGHEKLDCEMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GFDNHHAMEKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2CDFFF0", Offset = "0x2CDF3F0", VA = "0x182CDFFF0")]
	[MustUseReturnValue]
	public static JobHandle GFNPFCEFDAB<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArray<Entity> JEBIOEILLHO, NativeArray<T> KOCKBILIHNN, JobHandle ABBGOJCBKII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct NKJOCIPKFMK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	public NativeArray<T> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<T> GHEJEDGCOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeHashSet<T> HEIAHJNMBMG;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB9690", Offset = "0x3BB8A90", VA = "0x183BB9690", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class JNIKAANOIAO<BaseClass>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<int, BaseClass> KFKDFGBDNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<Type, BaseClass> HAMKGEBDNJK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x309C720", Offset = "0x309BB20", VA = "0x18309C720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IEnumerable<BaseClass> PEEGGPJLJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x309C3D0", Offset = "0x309B7D0", VA = "0x18309C3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x309C750", Offset = "0x309BB50", VA = "0x18309C750")]
	public JNIKAANOIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x309C8E0", Offset = "0x309BCE0", VA = "0x18309C8E0")]
	public JNIKAANOIAO(int FJOEBJHKPLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x309C6A0", Offset = "0x309BAA0", VA = "0x18309C6A0")]
	internal void MGOOIKEIGMG(int POFPJBOBPKJ, BaseClass PKNMLFAJHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3989D90", Offset = "0x3989190", VA = "0x183989D90")]
	public bool LKFFJNMNJBN<T>(out BaseClass EOEKGHMNIDN) where T : IComponent
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x309C600", Offset = "0x309BA00", VA = "0x18309C600")]
	public bool LKFFJNMNJBN(Type AAKBFLPBBEK, out BaseClass EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x309C3A0", Offset = "0x309B7A0", VA = "0x18309C3A0")]
	public bool GODJJABIKHD(int POFPJBOBPKJ, out BaseClass EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3989CB0", Offset = "0x39890B0", VA = "0x183989CB0")]
	public T AOLBHGDKCJL<T>() where T : BaseClass
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x309C370", Offset = "0x309B770", VA = "0x18309C370")]
	public BaseClass AOLBHGDKCJL(Type OLJHCJGIPGC)
	{
		return (BaseClass)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class ENEANCEACFE : global::KJIALKDPDGH<KKJAMDIONOB, IBNOCBDOBMO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5910", Offset = "0x6AB4D10", VA = "0x186AB5910")]
	public ENEANCEACFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[BurstCompile]
internal struct DLKBBLDCFOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB44B0", Offset = "0x6AB38B0", VA = "0x186AB44B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DBEELBMCKAH
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2857770", Offset = "0x2856B70", VA = "0x182857770")]
	public static NativeArray<T> NPGBMDMNFHA<T>(this NativeList<Entity> MBAJFLPFKBI, EntityManager CLFAKBGHDNF, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2857500", Offset = "0x2856900", VA = "0x182857500")]
	public static NativeArray<T> NPGBMDMNFHA<T>(this NativeArray<Entity> MBAJFLPFKBI, EntityManager CLFAKBGHDNF, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CJIEEABJGMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EGPCBHECMKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal struct GDLBCDGJOKP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[ReadOnly]
	public T EOEKGHMNIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x40D01E0", Offset = "0x40CF5E0", VA = "0x1840D01E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class MKBNPKMHDIM
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27C6270", Offset = "0x27C5670", VA = "0x1827C6270")]
	[MustUseReturnValue]
	public static JobHandle MCILBLPKDJM<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, EntityQuery HBIFFOCBHKC, T EOEKGHMNIDN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27C6190", Offset = "0x27C5590", VA = "0x1827C6190")]
	[MustUseReturnValue]
	public static JobHandle MCILBLPKDJM<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArrayAsync<Entity> JEBIOEILLHO, NativeArrayAsync<T> EOEKGHMNIDN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27C6020", Offset = "0x27C5420", VA = "0x1827C6020")]
	[MustUseReturnValue]
	public static JobHandle MCILBLPKDJM<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, NativeArrayAsync<Entity> JEBIOEILLHO, NativeArrayAsync<T> EOEKGHMNIDN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal class MOPBCEMOFFP : global::KJIALKDPDGH<CPGNMJOGMBJ, ECKBCBFHFLP>
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9EB0", Offset = "0x6AB92B0", VA = "0x186AB9EB0")]
	public MOPBCEMOFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class OENEHJGCIEJ<Data> : IBNOCBDOBMO where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public virtual Data JCHJHPLBGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F317B0", Offset = "0x3F30BB0", VA = "0x183F317B0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CB0", Offset = "0x7F20B0", VA = "0x1807F2CB0", Slot = "8")]
	protected virtual bool ECNBFEKJHIE(ReadOnlySpan<Data> FDOLNONHOJG, KNJGMHCOMNG FFLKMHBHAJP, out ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0", Slot = "9")]
	protected virtual bool PNPGALGJHOJ(int EGPHDEMHMDI, Span<Data> FDOLNONHOJG, in ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3549EE0", Offset = "0x35492E0", VA = "0x183549EE0", Slot = "5")]
	internal sealed override bool ECNBFEKJHIE(ref Unity.Entities.Chunk IAFAPNBJLGA, int ACGFGOKCOPJ, KNJGMHCOMNG FFLKMHBHAJP, out ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F32520", Offset = "0x3F31920", VA = "0x183F32520", Slot = "6")]
	internal sealed override bool PNPGALGJHOJ(int EGPHDEMHMDI, ref Unity.Entities.Chunk IAFAPNBJLGA, int ACGFGOKCOPJ, in ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2F90470", Offset = "0x2F8F870", VA = "0x182F90470")]
	protected global::OEEBBLLMCMN<Protobuf> JGMMOFHDCNO<Protobuf>(ReadOnlySpan<Data> FDOLNONHOJG) where Protobuf : IMessage, new()
	{
		return default(global::OEEBBLLMCMN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2F904C0", Offset = "0x2F8F8C0", VA = "0x182F904C0")]
	protected global::EOKEPBFNBNH<Protobuf> NDJPJLCBJNH<Protobuf>(ReadOnlySpan<byte> MPNODGMHCDM, ReadOnlySpan<Data> FDOLNONHOJG, Action<Protobuf> MOPBCMBIEOE) where Protobuf : IMessage, new()
	{
		return default(global::EOKEPBFNBNH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2FD0", Offset = "0x2EC23D0", VA = "0x182EC2FD0")]
	protected OENEHJGCIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class IBNOCBDOBMO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	protected internal abstract int COABGJJGOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7520", Offset = "0x6AB6920", VA = "0x186AB7520", Slot = "5")]
	internal virtual bool ECNBFEKJHIE(ref Unity.Entities.Chunk IAFAPNBJLGA, int ACGFGOKCOPJ, KNJGMHCOMNG FFLKMHBHAJP, out ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F2CD0", Offset = "0x7F20D0", VA = "0x1807F2CD0", Slot = "6")]
	internal virtual bool PNPGALGJHOJ(int EGPHDEMHMDI, ref Unity.Entities.Chunk IAFAPNBJLGA, int ACGFGOKCOPJ, in ReadOnlySpan<byte> MPNODGMHCDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected IBNOCBDOBMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class AFILAKHHPDG
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct BIPPBGLDLMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public struct CPHEAABBEEA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			internal BIPPBGLDLMK<TFrom> MOHMMJFCOKF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		internal Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		internal NativeArray<TFrom> PMOIDBEHJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct DHPHNLNHOKL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public struct EOLKBGLKOND<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			internal DHPHNLNHOKL<TFrom> MOHMMJFCOKF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		internal Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		internal NativeList<TFrom> PMOIDBEHJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct MEFPLBNNEGB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public struct BGGICILBNKB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			internal MEFPLBNNEGB<TFrom> MOHMMJFCOKF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal NativeArrayAsync<TFrom> PMOIDBEHJHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct PJDCEIFCCEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public struct OHBIHJCMBLL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			internal PJDCEIFCCEI<TFrom> MOHMMJFCOKF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal NativeListAsync<TFrom> PMOIDBEHJHP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct OBOEOLINFAE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DBLFNDKAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[ReadOnly]
	public NativeArray<Entity> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[WriteOnly]
	public NativeArray<T> DPLNIEKMOBD;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3F28CE0", Offset = "0x3F280E0", VA = "0x183F28CE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[BurstCompile]
internal struct AEBOHJPFLHG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLIGEINIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[ReadOnly]
	public NativeArray<Entity> GIMCLHOJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> FCHKLKLFMHD;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct OKIGMBCNPLC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[ReadOnly]
	public NativeArray<T> ICOGIPBOJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x355CDE0", Offset = "0x355C1E0", VA = "0x18355CDE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface FNHLCIOMLDK
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KPPNPDCNPDN
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x643ECC0", Offset = "0x643E0C0", VA = "0x18643ECC0")]
	public static NativeListAsync<Entity> KEOMLBLBEGA<T, TPredicate>(this NativeArrayAsync<T> MBAJFLPFKBI, NativeArrayAsync<Entity> GIMCLHOJIMP, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct where TPredicate : struct, global::CCKKJLCBHIJ<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x643ED80", Offset = "0x643E180", VA = "0x18643ED80")]
	private static NativeListAsync<Entity> POHDJMGPIKJ<T, TPredicate>(NativeArrayAsync<T> GPDNHBKPDFA, NativeArrayAsync<Entity> GIMCLHOJIMP, int JNPIFHIHMEO, Allocator NAFCEIMFOBK) where T : struct where TPredicate : struct, global::CCKKJLCBHIJ<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class IMIFIHGNJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEC70", Offset = "0x2ECE070", VA = "0x182ECEC70")]
	[MustUseReturnValue]
	public static JobHandle IHGJMIPPEEJ<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArray<Entity> JEBIOEILLHO, T EOEKGHMNIDN, [Optional] JobHandle ABBGOJCBKII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2ECED40", Offset = "0x2ECE140", VA = "0x182ECED40")]
	[MustUseReturnValue]
	public static JobHandle IHGJMIPPEEJ<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, NativeArray<Entity> JEBIOEILLHO, T EOEKGHMNIDN, [Optional] JobHandle ABBGOJCBKII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2ECEBB0", Offset = "0x2ECDFB0", VA = "0x182ECEBB0")]
	[MustUseReturnValue]
	public static JobHandle IHGJMIPPEEJ<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, NativeArray<Entity> JEBIOEILLHO, NativeArray<T> ICOGIPBOJIN, [Optional] JobHandle ABBGOJCBKII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CPGNMJOGMBJ : NPELNOKKLBD
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NEJMDDJKFNF
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2915CA0", Offset = "0x29150A0", VA = "0x182915CA0")]
	public static NativeList<T> FINGMAJAFDI<T>(this NativeList<T> MBAJFLPFKBI, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2915AD0", Offset = "0x2914ED0", VA = "0x182915AD0")]
	public static NativeList<T> FINGMAJAFDI<T>(this NativeArray<T> MBAJFLPFKBI, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class CDFECENPKJP
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct NDIOLIDPPDG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public NativeArray<T> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EHPBOFNPBJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public NativeList<T> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct DGAFCGMIGIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public NativeArrayAsync<T> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct PMBMHEAIADG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public NativeListAsync<T> ACMNDMONPCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct BPDIAFCBGNG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, global::EFGAELHGFFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	public NativeArray<TFrom> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[WriteOnly]
	public NativeArray<TTo> DPLNIEKMOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public TMap ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Flags]
public enum GDAHAABNIGH
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
public interface CCKKJLCBHIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HEMFDKICHNE(T EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct LFFAPFDOOMK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ComponentTypes MPGKFCGNCJC;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9540", Offset = "0x6AB8940", VA = "0x186AB9540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[BurstCompile]
internal struct DJNKJMPPCKA<T, TPredicate> : IJob where T : struct where TPredicate : struct, global::CCKKJLCBHIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[ReadOnly]
	public NativeArray<T> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeList<T> GHEJEDGCOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public TPredicate ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PMCGJJDJEOL : JHJHIIHCBPH
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6ABCC90", Offset = "0x6ABC090", VA = "0x186ABCC90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7940", Offset = "0x6AB6D40", VA = "0x186AB7940")]
	public PMCGJJDJEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public abstract class NPELNOKKLBD : FPJMLFDHOCI
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Type MLKPCNJJKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xCA1D50", Offset = "0xCA1150", VA = "0x180CA1D50")]
	public NPELNOKKLBD(Type BLIGEINIHML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class OMOOIHGEPFK
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly Dictionary<int, int> GIAMDGLMGOF;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static bool MPLBAKOOBJF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBE10", Offset = "0x6ABB210", VA = "0x186ABBE10")]
	public static int CHMBHGHBPNC(int POFPJBOBPKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBF30", Offset = "0x6ABB330", VA = "0x186ABBF30")]
	public static void OAGJEKOOFKN(bool BLLAAOPKLPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBFD0", Offset = "0x6ABB3D0", VA = "0x186ABBFD0")]
	private static void PBKONDIBIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBDC0", Offset = "0x6ABB1C0", VA = "0x186ABBDC0")]
	private static int CBCDKMCABEC(Type ONBHBHIHHNE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBEB0", Offset = "0x6ABB2B0", VA = "0x186ABBEB0")]
	private static void DDMMLHIFNLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BurstCompile]
internal struct DAIFHAJKMMK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BLIGEINIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	public NativeArray<Entity> GIMCLHOJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<bool> FCHKLKLFMHD;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x324EC60", Offset = "0x324E060", VA = "0x18324EC60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BurstCompile]
internal struct IKAOKMAJCDJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	public NativeArray<T> KOCKBILIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x27A81F0", Offset = "0x27A75F0", VA = "0x1827A81F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class CCLJFGBNGNN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4310", Offset = "0x6AB3710", VA = "0x186AB4310")]
	public static ulong PCGFFHCCBCA(Type ONBHBHIHHNE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AB42A0", Offset = "0x6AB36A0", VA = "0x186AB42A0")]
	public static ulong PCGFFHCCBCA(string ODDHFCBFDOO)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal static class OGCIJMGMEAG
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly Dictionary<Type, int> DMEAMGKFPJO;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static bool MPLBAKOOBJF;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBAA0", Offset = "0x6ABAEA0", VA = "0x186ABBAA0")]
	public static void OAGJEKOOFKN(bool BLLAAOPKLPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB780", Offset = "0x6ABAB80", VA = "0x186ABB780")]
	private static void EPDOKOAMBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB520", Offset = "0x6ABA920", VA = "0x186ABB520")]
	private static void BNAGJLKFOBB(Type DMPFJINHCAB, Type ICMDHGDOHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB700", Offset = "0x6ABAB00", VA = "0x186ABB700")]
	private static void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB9B0", Offset = "0x6ABADB0", VA = "0x186ABB9B0")]
	public static int NNBIHDDGPGP(Type DMPFJINHCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBB40", Offset = "0x6ABAF40", VA = "0x186ABBB40")]
	public static bool OIOCCNBFCEH(Type DMPFJINHCAB, out int POFPJBOBPKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class OGAMLOAHEJA
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABADC0", Offset = "0x6ABA1C0", VA = "0x186ABADC0")]
	public static ComponentSystemGroup[] MKPGGANDNEN(World MKIMPHJOKAN, GDAHAABNIGH GNFGNDDBPMK = GDAHAABNIGH.Default, bool PCBIIDLBJPH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA330", Offset = "0x6AB9730", VA = "0x186ABA330")]
	private static Type[] CAIDDBEPHOB(GDAHAABNIGH GNFGNDDBPMK, bool PCBIIDLBJPH, ComponentSystemGroup[] DKOABOPFNPP, ComponentSystemGroup KKBJHDFFPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA920", Offset = "0x6AB9D20", VA = "0x186ABA920")]
	private static ComponentSystemGroup[] JFMACMOJJHN(World MKIMPHJOKAN, out ComponentSystemGroup KKBJHDFFPKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA690", Offset = "0x6AB9A90", VA = "0x186ABA690")]
	internal static bool ELFGMMILEMG(LPABHHGNJGE CNGGDCGDNBM, out MLMNPKNLNBP OMHCDHAADNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAE90", Offset = "0x6ABA290", VA = "0x186ABAE90")]
	private static ComponentSystemGroup OBHHBIAFMOA(Type ONBHBHIHHNE, World MKIMPHJOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAC30", Offset = "0x6ABA030", VA = "0x186ABAC30")]
	private static ComponentSystemGroup[] JPCAJIDOKFO(Type[] FKOMPPKIBLI, World MKIMPHJOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAF70", Offset = "0x6ABA370", VA = "0x186ABAF70")]
	internal static void PEEBKJKCLDN(World MKIMPHJOKAN, Type[] EKPLJMENMBG, ComponentSystemGroup[] DKOABOPFNPP, ComponentSystemGroup KKBJHDFFPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ABA2D0", Offset = "0x6AB96D0", VA = "0x186ABA2D0")]
	internal static bool BPCDKMMEIAA(ComponentSystemBase LCNPOLBBNJN, ComponentSystemGroup[] DKOABOPFNPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAD60", Offset = "0x6ABA160", VA = "0x186ABAD60")]
	private static void MKKIKNLGIOH(ComponentSystemGroup[] DKOABOPFNPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class KKJAMDIONOB : NPELNOKKLBD
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0xCA1D50", Offset = "0xCA1150", VA = "0x180CA1D50")]
	public KKJAMDIONOB(Type BLIGEINIHML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[BurstCompile]
internal struct CMBGMCFLJGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	public ComponentDataFromEntity BLIGEINIHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	public NativeArray<Entity> GIMCLHOJIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public NativeList<Entity> HAPLBFKKMGJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB43B0", Offset = "0x6AB37B0", VA = "0x186AB43B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public abstract class OJHIMGCPGOP : SystemBase, PEIEKNMBMHB
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBCE0", Offset = "0x6ABB0E0", VA = "0x186ABBCE0")]
	public ComponentDataFromEntity NBEGCPAAKCK(int POFPJBOBPKJ, bool FMCAIONNHHE = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBCC0", Offset = "0x6ABB0C0", VA = "0x186ABBCC0")]
	public EntityExistenceLookupByEntity NAKJAEFOPCN()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBC70", Offset = "0x6ABB070", VA = "0x186ABBC70")]
	public EntityQuery BJJHDFFBDHC(in EntityQueryDescBuilder LDELMCMMJMO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6ABBDB0", Offset = "0x6ABB1B0", VA = "0x186ABBDB0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	protected OJHIMGCPGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public abstract class ELIDCJKMFAJ : OJHIMGCPGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6AB58E0", Offset = "0x6AB4CE0", VA = "0x186AB58E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	protected ELIDCJKMFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class LALAEDJNNJF
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public interface PEIEKNMBMHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class JHJHIIHCBPH : ComponentSystemGroup, PEIEKNMBMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7940", Offset = "0x6AB6D40", VA = "0x186AB7940")]
	protected JHJHIIHCBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class GNBPIMOEPPN<View, Data> : AFEAMCGGOEP where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static ComponentType IMJKMKONEGG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public override Type PABJJAHPFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5773820", Offset = "0x5772C20", VA = "0x185773820", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override int ABBJGFLHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5774240", Offset = "0x5773640", VA = "0x185774240", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5774300", Offset = "0x5773700", VA = "0x185774300")]
	public Data PNIDINFGPBH(Entity HHCOBCONNMJ)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View BFDCJEEGMLD(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x411F610", Offset = "0x411EA10", VA = "0x18411F610", Slot = "14")]
	protected internal override T BFDCJEEGMLD<T>(Entity HHCOBCONNMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2FD0", Offset = "0x2EC23D0", VA = "0x182EC2FD0")]
	protected GNBPIMOEPPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class AFEAMCGGOEP : FEMEEEFLEPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DynamicComponentTypeHandle GLLDNHJPECB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EntityManager CPFDJDFIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x891D20", Offset = "0x891120", VA = "0x180891D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public abstract Type PABJJAHPFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public abstract int ABBJGFLHJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Type HKLCBNOFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xF0B7B0", Offset = "0xF0ABB0", VA = "0x180F0B7B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private int OCEFDOMCCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3FF0", Offset = "0x6AB33F0", VA = "0x186AB3FF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private BHEOFHMFIKM[] PGPFIMEABGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x99E5F0", Offset = "0x99D9F0", VA = "0x18099E5F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	protected internal virtual BHEOFHMFIKM[] OIPPKMDLCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3F30", Offset = "0x6AB3330", VA = "0x186AB3F30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6AB40F0", Offset = "0x6AB34F0", VA = "0x186AB40F0")]
	public void OAGJEKOOFKN(EntityManager CLFAKBGHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0")]
	protected FEMEEEFLEPL BHDILFAAIAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected internal abstract T BFDCJEEGMLD<T>(Entity HHCOBCONNMJ) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3E70", Offset = "0x6AB3270", VA = "0x186AB3E70", Slot = "8")]
	public (uint, uint) CHMBHGHBPNC(Entity HHCOBCONNMJ)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4060", Offset = "0x6AB3460", VA = "0x186AB4060", Slot = "9")]
	public bool NNKNCNJJDHP(Entity HHCOBCONNMJ, (uint order, uint change) EGPHDEMHMDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected AFEAMCGGOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
internal struct MIDKDDFBPBF
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<Type> FKOMPPKIBLI;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	private MIDKDDFBPBF(List<Type> FKOMPPKIBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D90", Offset = "0x6AB9190", VA = "0x186AB9D90")]
	public static void MEBDGDDNOCJ(List<Type> FKOMPPKIBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9A70", Offset = "0x6AB8E70", VA = "0x186AB9A70")]
	private void BMEEIFEGPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9D10", Offset = "0x6AB9110", VA = "0x186AB9D10")]
	private bool INDIBJDNAOP(Type ONBHBHIHHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9CB0", Offset = "0x6AB90B0", VA = "0x186AB9CB0")]
	private void DJOHFFFFABD(Type ONBHBHIHHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class FIEGPKEBNIB
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
internal struct GJKDBPHNJGC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DBLFNDKAAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	public NativeArray<Entity> ACMNDMONPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[WriteOnly]
	public NativeList<T> GHEJEDGCOHK;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
public enum LPABHHGNJGE
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
public class NJDJFOIBHBA : FPJMLFDHOCI
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LPABHHGNJGE POFFCDNIKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60")]
		[CompilerGenerated]
		get
		{
			return default(LPABHHGNJGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1710740", Offset = "0x170FB40", VA = "0x181710740")]
	public NJDJFOIBHBA(LPABHHGNJGE CNGGDCGDNBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class DFFOIOHHNCM : FPJMLFDHOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	public DFFOIOHHNCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public abstract class ECKBCBFHFLP
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	protected ECKBCBFHFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class KMDIDEPAGJH
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public readonly struct IMPKEOEDPCJ<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly NativeArray<TSrc> BIBDBFOMNHM;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x837700", Offset = "0x836B00", VA = "0x180837700")]
		public IMPKEOEDPCJ(NativeArray<TSrc> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		public ONIEDIMDGFM<TSrc, TValue> FAMGADMDMIA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(ONIEDIMDGFM<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public readonly struct ONIEDIMDGFM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly NativeArray<TSrc> BIBDBFOMNHM;

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x837700", Offset = "0x836B00", VA = "0x180837700")]
		public ONIEDIMDGFM(NativeArray<TSrc> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		public CLBMCKDDBNE<TSrc, TValue, TSelector> MBFKHCKGDPM<TSelector>() where TSelector : struct, global::EFGAELHGFFK<TSrc, TValue>
		{
			return default(CLBMCKDDBNE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public readonly struct CLBMCKDDBNE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, global::EFGAELHGFFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly NativeArray<TSrc> BIBDBFOMNHM;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x837700", Offset = "0x836B00", VA = "0x180837700")]
		public CLBMCKDDBNE(NativeArray<TSrc> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3C968E0", Offset = "0x3C95CE0", VA = "0x183C968E0")]
		public KEBBHFOLELD<TSrc, TValue, TSelector> PPIKOKNHOPE()
		{
			return default(KEBBHFOLELD<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct OMEKOOPFMGE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, global::EFGAELHGFFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private readonly NativeArray<TSrc> BIBDBFOMNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TSelector NOADCEBOFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int CJOLACIBAJH;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public TValue HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x355F420", Offset = "0x355E820", VA = "0x18355F420")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int BEOOPJIPEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x80EC80", Offset = "0x80E080", VA = "0x18080EC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int EAGEACLGNGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x355F2E0", Offset = "0x355E6E0", VA = "0x18355F2E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x355F4B0", Offset = "0x355E8B0", VA = "0x18355F4B0")]
		public OMEKOOPFMGE(NativeArray<TSrc> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x355F490", Offset = "0x355E890", VA = "0x18355F490")]
		public bool PPCIFOBIFBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x355F2F0", Offset = "0x355E6F0", VA = "0x18355F2F0")]
		private TSrc JCLAAOILLKN(int GGGLLOBDBOL)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public struct KEBBHFOLELD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, global::EFGAELHGFFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private OMEKOOPFMGE<TSrc, TValue, TSelector> CJENBGBEBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private TValue LJIBHCLPKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int CBDFEPEIFFE;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ENLJKOPLLHP JJIOMBHAMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x2F482D0", Offset = "0x2F476D0", VA = "0x182F482D0")]
			get
			{
				return default(ENLJKOPLLHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public TValue EFLDDGJOAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x855970", VA = "0x180856570")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public (TValue value, ENLJKOPLLHP range) HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x2F481F0", Offset = "0x2F475F0", VA = "0x182F481F0")]
			get
			{
				return default((TValue, ENLJKOPLLHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2F48440", Offset = "0x2F47840", VA = "0x182F48440")]
		public KEBBHFOLELD(NativeArray<TSrc> BIBDBFOMNHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2824A90", Offset = "0x2823E90", VA = "0x182824A90")]
		public KEBBHFOLELD<TSrc, TValue, TSelector> KLBJEDHKGHJ()
		{
			return default(KEBBHFOLELD<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2F48310", Offset = "0x2F47710", VA = "0x182F48310")]
		public bool PPCIFOBIFBE()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2D03AE0", Offset = "0x2D02EE0", VA = "0x182D03AE0")]
	public static IMPKEOEDPCJ<T> NGIAJJEGLHA<T>(this NativeList<T> FGINDFDIDLG) where T : struct
	{
		return default(IMPKEOEDPCJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
	public static IMPKEOEDPCJ<T> NGIAJJEGLHA<T>(this NativeArray<T> BIBDBFOMNHM) where T : struct
	{
		return default(IMPKEOEDPCJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class GENADBPCLAG
{
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public struct MEHADGJJKHJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008A")]
		public struct JOFALFHMGLB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public MEHADGJJKHJ<TFrom> PMOIDBEHJHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<TFrom> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public struct HMEENGNJACH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct CKFCMDCAOPE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public HMEENGNJACH<TFrom> PMOIDBEHJHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public NativeArrayAsync<TFrom> ACMNDMONPCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct KOMKGDMBADG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public struct HAEOKBMDMEF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public KOMKGDMBADG<TFrom> PMOIDBEHJHP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Allocator NAFCEIMFOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public NativeListAsync<TFrom> ACMNDMONPCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
internal struct BGFNHCHIOPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<Entity> JEBIOEILLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public EntityCommandBuffer EEMBCFLKDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public ComponentType AAKBFLPBBEK;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4270", Offset = "0x6AB3670", VA = "0x186AB4270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class DOCKEPNDPNP
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3E0D770", Offset = "0x3E0CB70", VA = "0x183E0D770")]
	public static bool CIKNBJAKEGD<T>(this NativeArray<Entity> GIMCLHOJIMP, EntityManager CLFAKBGHDNF, Allocator NAFCEIMFOBK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class AFKBMFNPLKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class DBEMGMHBBAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class FOIPAOJEMHH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public virtual bool GPCLIGIAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	protected FOIPAOJEMHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DisableAutoCreation]
public sealed class POCOMNGDCIM : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public POCOMNGDCIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DisableAutoCreation]
public sealed class COMDDKBGIJB : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public COMDDKBGIJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DisableAutoCreation]
public sealed class KJAGFAFAECP : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public KJAGFAFAECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DisableAutoCreation]
public sealed class CFFPHNEPMHI : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public CFFPHNEPMHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DisableAutoCreation]
public sealed class KEDIHOABMNM : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public KEDIHOABMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DisableAutoCreation]
public sealed class IFKHBPJNOOP : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public IFKHBPJNOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[DisableAutoCreation]
public sealed class AKPGAKOMLFF : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public AKPGAKOMLFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DisableAutoCreation]
public sealed class NFJDECJLHNE : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public NFJDECJLHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[DisableAutoCreation]
public sealed class CBOPPACNFDF : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public CBOPPACNFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public sealed class CIKIFBOFDPL : MLMJPDPHLNF
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public CIKIFBOFDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class KHHDFGEHINH : MLMJPDPHLNF
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public KHHDFGEHINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public sealed class GALDFFDANFO : MLMJPDPHLNF
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public GALDFFDANFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class ONFIOCCLHAE : MLMJPDPHLNF
{
	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public ONFIOCCLHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[DisableAutoCreation]
[ICGNAGLJMJJ(FCAJHDGOHAJ.Application)]
public class MLMJPDPHLNF : FOIPAOJEMHH
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public override bool GPCLIGIAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4210", Offset = "0x6AB3610", VA = "0x186AB4210")]
	public MLMJPDPHLNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public static class PFCCEFOHGOG
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly CMLIAKNODEP GBFKDHJJIKK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly ENEANCEACFE PFLGDNCDMBI;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly MOPBCEMOFFP DPDHKNNOFPH;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly List<Type> EKMEFBJOFEF;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static bool MPLBAKOOBJF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	internal static global::JCFFOAPHPKI<AFEAMCGGOEP> FALHDIOFOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC660", Offset = "0x6ABBA60", VA = "0x186ABC660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal static global::JCFFOAPHPKI<IBNOCBDOBMO> PAKPKKLJGII
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC600", Offset = "0x6ABBA00", VA = "0x186ABC600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static global::JCFFOAPHPKI<ECKBCBFHFLP> MNKLLJKLEOF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC6C0", Offset = "0x6ABBAC0", VA = "0x186ABC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC720", Offset = "0x6ABBB20", VA = "0x186ABC720")]
	public static void OAGJEKOOFKN(bool BLLAAOPKLPH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC580", Offset = "0x6ABB980", VA = "0x186ABC580")]
	public static Type[] DDKKKIOFGPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class PDGBHIGAOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x24D6AB0", Offset = "0x24D5EB0", VA = "0x1824D6AB0")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArrayAsync<Entity> JEBIOEILLHO, NativeArrayAsync<T> KOCKBILIHNN, [Optional] JobHandle ABBGOJCBKII) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x24D70E0", Offset = "0x24D64E0", VA = "0x1824D70E0")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArrayAsync<Entity> JEBIOEILLHO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x24D6C00", Offset = "0x24D6000", VA = "0x1824D6C00")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE<T>(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArray<Entity> JEBIOEILLHO, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x24D6FC0", Offset = "0x24D63C0", VA = "0x1824D6FC0")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE<T>(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, NativeArray<Entity> JEBIOEILLHO, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC420", Offset = "0x6ABB820", VA = "0x186ABC420")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE(this EntityCommandBufferSystem HPAHLNDAIIL, NativeArray<Entity> JEBIOEILLHO, ComponentTypes MPGKFCGNCJC, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6ABC2D0", Offset = "0x6ABB6D0", VA = "0x186ABC2D0")]
	[MustUseReturnValue]
	public static JobHandle ENHCJJOGEDE(this EntityCommandBufferSystem HPAHLNDAIIL, EntityCommandBuffer EEMBCFLKDCM, NativeArray<Entity> JEBIOEILLHO, ComponentTypes MPGKFCGNCJC, [Optional] JobHandle ABBGOJCBKII)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal static class IPEHDENJHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7580", Offset = "0x6AB6980", VA = "0x186AB7580")]
	private unsafe static Span<byte> CHFPKHBJOAN(Unity.Entities.Chunk* IAFAPNBJLGA, int ACGFGOKCOPJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0640", Offset = "0x2ECFA40", VA = "0x182ED0640")]
	public unsafe static Span<T> NEFIMKHNIGK<T>(Unity.Entities.Chunk* IAFAPNBJLGA, int ACGFGOKCOPJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2ED07D0", Offset = "0x2ECFBD0", VA = "0x182ED07D0")]
	public static Span<T> NEFIMKHNIGK<T>(this ref Unity.Entities.Chunk IAFAPNBJLGA, int ACGFGOKCOPJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB77E0", Offset = "0x6AB6BE0", VA = "0x186AB77E0")]
	public unsafe static Span<Entity> DLDNDBNJGLB(Unity.Entities.Chunk* IAFAPNBJLGA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7650", Offset = "0x6AB6A50", VA = "0x186AB7650")]
	public unsafe static void DDMMLHIFNLF(Unity.Entities.Chunk* IAFAPNBJLGA, int ACGFGOKCOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class KNJGMHCOMNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> NNLOCGLNOGO;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x83A2A0", Offset = "0x8396A0", VA = "0x18083A2A0")]
	public KNJGMHCOMNG(NativeArray<EntityRemapUtility.EntityRemapInfo> NNLOCGLNOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A50", Offset = "0x6AB7E50", VA = "0x186AB8A50")]
	public Entity PFIFDCAGLNO(Entity NNEEJCHOPPB)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[AttributeUsage(AttributeTargets.Class)]
public class PKNHCGIPCHM : FPJMLFDHOCI
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x973F80", Offset = "0x973380", VA = "0x180973F80")]
	public PKNHCGIPCHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class FCAHIHECFMF
{
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public delegate void BFCAAIKAPDJ<From, To>(From PMOIDBEHJHP, ref To ADPDPMGCAGF, KNJGMHCOMNG FFLKMHBHAJP);

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class AIGNADIEMOM<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public static BFCAAIKAPDJ<From, To> JGKIDNGLMHI;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public AIGNADIEMOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5AF0", Offset = "0x6AB4EF0", VA = "0x186AB5AF0")]
	static FCAHIHECFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2FB21C0", Offset = "0x2FB15C0", VA = "0x182FB21C0")]
	public static void CAAABDFIPMI<T>(BFCAAIKAPDJ<T, T> FJJKCAFEHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1FC0", Offset = "0x2FB13C0", VA = "0x182FB1FC0")]
	public static void CAAABDFIPMI<From, To>(BFCAAIKAPDJ<From, To> FJJKCAFEHKN, BFCAAIKAPDJ<To, From> PELDGDEEOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2050", Offset = "0x2FB1450", VA = "0x182FB2050")]
	public static void CAAABDFIPMI<From, To>(BFCAAIKAPDJ<From, To> JGKIDNGLMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x29F8840", Offset = "0x29F7C40", VA = "0x1829F8840")]
	public static BFCAAIKAPDJ<From, To> BLELBCIKMBD<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5760", Offset = "0x2FB4B60", VA = "0x182FB5760")]
	public static void OGNALDDMLLF<From, To>(From PMOIDBEHJHP, ref To ADPDPMGCAGF, KNJGMHCOMNG FFLKMHBHAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public interface CJPACHAIOGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCIOLGDIPKJ(Entity HHCOBCONNMJ, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLMKAPBDBKA(Entity HHCOBCONNMJ, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGKMLIFHIOB(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEnumerable<object> FLJEIMFFFDK(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PIPGHOHAJCB(Entity HHCOBCONNMJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class FBMGCPHLGGK<TComponentData, TValue> : global::OPFMANDKCOF<TValue>, IDisposable where TComponentData : struct, GOAFIKPCPGB
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class OEGGOOKOLEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private List<(object token, TValue value)> FGINDFDIDLG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int KLCJBBHGHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x279A3F0", Offset = "0x27997F0", VA = "0x18279A3F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B970", Offset = "0x3F2AD70", VA = "0x183F2B970")]
		public bool AFBLANIPAAM(out TValue EOEKGHMNIDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BB60", Offset = "0x3F2AF60", VA = "0x183F2BB60")]
		public void MGOOIKEIGMG(object IJNLJGNNJFA, TValue EOEKGHMNIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BA30", Offset = "0x3F2AE30", VA = "0x183F2BA30")]
		public bool AJCNBIMBJPF(object IJNLJGNNJFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BAB0", Offset = "0x3F2AEB0", VA = "0x183F2BAB0")]
		public int EJKNOHPCKFM(object IJNLJGNNJFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BC10", Offset = "0x3F2B010", VA = "0x183F2BC10")]
		public OEGGOOKOLEL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<OEGGOOKOLEL> MJECJCLFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private global::APPNKIDHNEK<EFFDBMGJLGC, OEGGOOKOLEL> BHFHJOFILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EntityManager CLFAKBGHDNF;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x341A3F0", Offset = "0x34197F0", VA = "0x18341A3F0")]
	public FBMGCPHLGGK(EntityManager CLFAKBGHDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x341A200", Offset = "0x3419600", VA = "0x18341A200", Slot = "4")]
	public void NCIOLGDIPKJ(Entity HHCOBCONNMJ, object IJNLJGNNJFA, TValue EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3419E90", Offset = "0x3419290", VA = "0x183419E90", Slot = "5")]
	public bool GLMKAPBDBKA(Entity HHCOBCONNMJ, object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3419D80", Offset = "0x3419180", VA = "0x183419D80", Slot = "6")]
	public bool AFBLANIPAAM(Entity HHCOBCONNMJ, out TValue EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3419E50", Offset = "0x3419250", VA = "0x183419E50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x341A180", Offset = "0x3419580", VA = "0x18341A180")]
	private void LBCDNBCGHBG(OEGGOOKOLEL CEGLFBEMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x341A020", Offset = "0x3419420", VA = "0x18341A020")]
	private bool JDJGJMDHMNL(Entity HHCOBCONNMJ, out EFFDBMGJLGC KJJOLPFLKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x341A0F0", Offset = "0x34194F0", VA = "0x18341A0F0")]
	private void KEAABDMGCIG(Entity HHCOBCONNMJ, EFFDBMGJLGC KJJOLPFLKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3419E70", Offset = "0x3419270", VA = "0x183419E70")]
	private bool EBLLDNFNPJN(EFFDBMGJLGC KJJOLPFLKFF, out OEGGOOKOLEL CEGLFBEMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x341A320", Offset = "0x3419720", VA = "0x18341A320")]
	private OEGGOOKOLEL NMHKFPFEFGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public interface OPFMANDKCOF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCIOLGDIPKJ(Entity HHCOBCONNMJ, object IJNLJGNNJFA, TValue EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLMKAPBDBKA(Entity HHCOBCONNMJ, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AFBLANIPAAM(Entity HHCOBCONNMJ, out TValue EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public interface GOAFIKPCPGB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	EFFDBMGJLGC OHJODMBCLEM
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
public struct EFFDBMGJLGC : global::IOBMJIDOGJO<EFFDBMGJLGC>, BEDBGJPABOB, IEquatable<EFFDBMGJLGC>
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public static readonly EFFDBMGJLGC AMDFEIFOGIH;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[CreateProperty]
	public int BEOOPJIPEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[CreateProperty]
	public int COABGJJGOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xB820F0", Offset = "0xB814F0", VA = "0x180B820F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1115560", Offset = "0x1114960", VA = "0x181115560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5520", Offset = "0x6AB4920", VA = "0x186AB5520", Slot = "8")]
	public bool Equals(EFFDBMGJLGC CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5570", Offset = "0x6AB4970", VA = "0x186AB5570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class IMGBKCPCOFK<THasTokensTag> : CJPACHAIOGJ, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Dictionary<Entity, EFFDBMGJLGC> JBBEANMGJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Stack<HashSet<object>> MJECJCLFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private global::APPNKIDHNEK<EFFDBMGJLGC, HashSet<object>> BHFHJOFILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EntityManager CLFAKBGHDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private EntityCommandBufferSystem HPAHLNDAIIL;

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x27B18A0", Offset = "0x27B0CA0", VA = "0x1827B18A0")]
	public IMGBKCPCOFK(EntityManager CLFAKBGHDNF, EntityCommandBufferSystem HPAHLNDAIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x27B1520", Offset = "0x27B0920", VA = "0x1827B1520", Slot = "4")]
	public bool NCIOLGDIPKJ(Entity HHCOBCONNMJ, object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x27B0F00", Offset = "0x27B0300", VA = "0x1827B0F00", Slot = "5")]
	public bool GLMKAPBDBKA(Entity HHCOBCONNMJ, object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x27B1300", Offset = "0x27B0700", VA = "0x1827B1300", Slot = "6")]
	public bool KGKMLIFHIOB(Entity HHCOBCONNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x27B1380", Offset = "0x27B0780", VA = "0x1827B1380", Slot = "10")]
	public bool KGKMLIFHIOB(EFFDBMGJLGC KJJOLPFLKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x27B0E40", Offset = "0x27B0240", VA = "0x1827B0E40", Slot = "7")]
	public IEnumerable<object> FLJEIMFFFDK(Entity HHCOBCONNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x27B0DA0", Offset = "0x27B01A0", VA = "0x1827B0DA0", Slot = "11")]
	public IEnumerable<object> FLJEIMFFFDK(EFFDBMGJLGC KJJOLPFLKFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27B17B0", Offset = "0x27B0BB0", VA = "0x1827B17B0", Slot = "8")]
	public bool PIPGHOHAJCB(Entity HHCOBCONNMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x27B0D00", Offset = "0x27B0100", VA = "0x1827B0D00", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27B1420", Offset = "0x27B0820", VA = "0x1827B1420")]
	private void LBCDNBCGHBG(HashSet<object> CEGLFBEMIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x27B10D0", Offset = "0x27B04D0", VA = "0x1827B10D0")]
	private bool JDJGJMDHMNL(Entity HHCOBCONNMJ, out EFFDBMGJLGC KJJOLPFLKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27B11B0", Offset = "0x27B05B0", VA = "0x1827B11B0")]
	private bool JEELLBPPEGB(Entity HHCOBCONNMJ, out EFFDBMGJLGC KJJOLPFLKFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27B1490", Offset = "0x27B0890", VA = "0x1827B1490")]
	private void LIONPDBGDHM(Entity HHCOBCONNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x27B1680", Offset = "0x27B0A80", VA = "0x1827B1680")]
	private void NFJMHHPIDFC(Entity HHCOBCONNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x27B1050", Offset = "0x27B0450", VA = "0x1827B1050")]
	private void INHHGDLHHMJ(Entity HHCOBCONNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x27B1290", Offset = "0x27B0690", VA = "0x1827B1290")]
	private void KEAABDMGCIG(Entity HHCOBCONNMJ, EFFDBMGJLGC KJJOLPFLKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x27B0D40", Offset = "0x27B0140", VA = "0x1827B0D40")]
	private bool EOPLJCPEMBM(EFFDBMGJLGC KJJOLPFLKFF, out HashSet<object> CEGLFBEMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x27B1710", Offset = "0x27B0B10", VA = "0x1827B1710")]
	private HashSet<object> NMHKFPFEFGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class MGGHIFCAEGB
{
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void EKKDDDAEIKI(this NDPMEMNFALO OLHOJKMAKNP, NativeArray<Entity> JEBIOEILLHO, [Optional][CallerFilePath] string OEILDBLLEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void EKKDDDAEIKI(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, NativeArray<Entity> JEBIOEILLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void EKKDDDAEIKI(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<Entity> JEBIOEILLHO, bool NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void GLCMCCDOGKL(this NDPMEMNFALO OLHOJKMAKNP, NativeArray<Entity> JEBIOEILLHO, EntityManager CLFAKBGHDNF, [Optional][CallerFilePath] string OEILDBLLEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void GLCMCCDOGKL(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<Entity> JEBIOEILLHO, EntityManager CLFAKBGHDNF, bool NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void NDKLDCJOIFP(this NDPMEMNFALO OLHOJKMAKNP, NativeArray<Entity> JEBIOEILLHO, NativeArray<Entity> KAIJMBMEJCP, [Optional][CallerFilePath] string OEILDBLLEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void NDKLDCJOIFP(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<Entity> JEBIOEILLHO, NativeArray<Entity> KAIJMBMEJCP, bool NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3019FC0", Offset = "0x30193C0", VA = "0x183019FC0")]
	public static void DEHFDLMIMFB<T>(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, NativeArray<Entity> JEBIOEILLHO, NativeList<T> KOCKBILIHNN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x301A050", Offset = "0x3019450", VA = "0x18301A050")]
	public static void DEHFDLMIMFB<T>(this NDPMEMNFALO OLHOJKMAKNP, NativeArray<Entity> JEBIOEILLHO, NativeArray<T> KOCKBILIHNN, [Optional][CallerFilePath] string OEILDBLLEJG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3019F80", Offset = "0x3019380", VA = "0x183019F80")]
	public static void DEHFDLMIMFB<T>(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, NativeArray<Entity> JEBIOEILLHO, NativeArray<T> KOCKBILIHNN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void DEHFDLMIMFB<T>(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<Entity> JEBIOEILLHO, NativeArray<T> KOCKBILIHNN, bool NHCJLGOCMKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x301A0D0", Offset = "0x30194D0", VA = "0x18301A0D0")]
	public static void HDOFMMHIIHE<T>(this NDPMEMNFALO OLHOJKMAKNP, NativeList<T> KOCKBILIHNN, [Optional][CallerFilePath] string OEILDBLLEJG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x301A0A0", Offset = "0x30194A0", VA = "0x18301A0A0")]
	public static void HDOFMMHIIHE<T>(this NDPMEMNFALO OLHOJKMAKNP, NativeArray<T> KOCKBILIHNN, [Optional][CallerFilePath] string OEILDBLLEJG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void HDOFMMHIIHE<T>(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<T> KOCKBILIHNN, bool NHCJLGOCMKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void CPBANEIOHPG(this NDPMEMNFALO OLHOJKMAKNP, EntityQuery HBIFFOCBHKC, [Optional][CallerFilePath] string OEILDBLLEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void CPBANEIOHPG(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, EntityQuery HBIFFOCBHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void CPBANEIOHPG(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, EntityQuery HBIFFOCBHKC, bool NHCJLGOCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x301A130", Offset = "0x3019530", VA = "0x18301A130")]
	public static void PCHBEKDMCGN<T, T2>(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, EntityQuery HBIFFOCBHKC) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void PCHBEKDMCGN<T, T2>(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, EntityQuery HBIFFOCBHKC, bool NHCJLGOCMKJ) where T : struct, IComponentData where T2 : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x301A130", Offset = "0x3019530", VA = "0x18301A130")]
	public static void PBENIMJHIPG<T>(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, NativeList<T> BIBDBFOMNHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void PBENIMJHIPG<T>(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeList<T> BIBDBFOMNHM, bool NHCJLGOCMKJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x301A130", Offset = "0x3019530", VA = "0x18301A130")]
	public static void PMBBOPKFMGM<T>(this NDPMEMNFALO OLHOJKMAKNP, string LMAOKJPAKEM, NativeArray<T> BIBDBFOMNHM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	public static void PMBBOPKFMGM<T>(this NDPMEMNFALO OLHOJKMAKNP, string OEILDBLLEJG, NativeArray<T> BIBDBFOMNHM, bool NHCJLGOCMKJ) where T : struct
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
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
