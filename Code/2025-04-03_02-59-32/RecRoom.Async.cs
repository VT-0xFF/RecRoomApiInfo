using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x76B0250", Offset = "0x76AF650", VA = "0x1876B0250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct JJAFEIPEPEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string KAFLMFCDNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public DJNFHDJGNJD AOPIMFKAFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? CMIONGHHAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? ENIDAAAJMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable KCLPHGLIKFD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MIHDPMADDLO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public MIHDPMADDLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x76B0030", Offset = "0x76AF430", VA = "0x1876B0030", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76B0200", Offset = "0x76AF600", VA = "0x1876B0200", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HBKNEGCDBKC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public NOCDIBGNFAP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public HBKNEGCDBKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76AFF70", Offset = "0x76AF370", VA = "0x1876AFF70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76AFFE0", Offset = "0x76AF3E0", VA = "0x1876AFFE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<JJAFEIPEPEF> JMCGEFOOILH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IAEHNHFNHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9943A0", Offset = "0x9937A0", VA = "0x1809943A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x994540", Offset = "0x993940", VA = "0x180994540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76AFD20", Offset = "0x76AF120", VA = "0x1876AFD20")]
		public static AsyncBatch Create(Transform KLDFHLFOOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76AFE60", Offset = "0x76AF260", VA = "0x1876AFE60")]
		[IteratorStateMachine(typeof(MIHDPMADDLO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76AF910", Offset = "0x76AED10", VA = "0x1876AF910")]
		public void Add(string IGEPDAOOLBO, DJNFHDJGNJD MCOJNHGAONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76AFAB0", Offset = "0x76AEEB0", VA = "0x1876AFAB0")]
		public void Add(string IGEPDAOOLBO, IEnumerator GBBPIGBGDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76AFDD0", Offset = "0x76AF1D0", VA = "0x1876AFDD0")]
		[IteratorStateMachine(typeof(HBKNEGCDBKC))]
		private IEnumerator FIFDONIKIEO(NOCDIBGNFAP MCOJNHGAONG, IEnumerator GBBPIGBGDCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76AFEE0", Offset = "0x76AF2E0", VA = "0x1876AFEE0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JNCAJFGGEFB<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class BDHDIPPIPNH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey KKGMNHPHOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public DJNFHDJGNJD AOPIMFKAFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime PAHDPHJAFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE32290", Offset = "0xE31690", VA = "0x180E32290")]
		public BDHDIPPIPNH(TKey DJBLFBEBKGO, DJNFHDJGNJD MCOJNHGAONG, DateTime PEPJCBPALGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BHCAEEABCGN<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JNCAJFGGEFB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public BDHDIPPIPNH cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BHCAEEABCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A090", Offset = "0x5E59490", VA = "0x185E5A090")]
		internal void OOLHFJKPFED(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, BDHDIPPIPNH> OEEONBHNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<BDHDIPPIPNH> KPBIBFHNFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<BDHDIPPIPNH> MOPBFLFHEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int LPHFOKFELCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NLKHNHPLDGO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C65970", Offset = "0x4C64D70", VA = "0x184C65970")]
	public JNCAJFGGEFB([Optional] int? LPHFOKFELCN, bool NLKHNHPLDGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9F20", Offset = "0x3BA9320", VA = "0x183BA9F20")]
	public GOBMEFCJDOP<TValue> ECGCNMEGGIM<TValue>(TKey DJBLFBEBKGO) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA92B0", Offset = "0x3BA86B0", VA = "0x183BA92B0")]
	public void ABNMLABLKDF<TValue>(TKey DJBLFBEBKGO, GOBMEFCJDOP<TValue> MCOJNHGAONG, TimeSpan JNODBBNPLOO) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA580", Offset = "0x3BA9980", VA = "0x183BAA580")]
	public GOBMEFCJDOP<TValue> GKCPEMLKOBC<TValue>(TKey DJBLFBEBKGO, Func<GOBMEFCJDOP<TValue>> NECHOHNOMHJ) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA4A0", Offset = "0x3BA98A0", VA = "0x183BAA4A0")]
	public GOBMEFCJDOP<TValue> GKCPEMLKOBC<TValue>(TKey DJBLFBEBKGO, Func<GOBMEFCJDOP<TValue>> NECHOHNOMHJ, TimeSpan JNODBBNPLOO) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C645F0", Offset = "0x4C639F0", VA = "0x184C645F0")]
	public bool JEBJOEBLLEI(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C63BA0", Offset = "0x4C62FA0", VA = "0x184C63BA0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C642D0", Offset = "0x4C636D0", VA = "0x184C642D0")]
	private void DPIKBAMOAAN(BDHDIPPIPNH ECBAJKPMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C646B0", Offset = "0x4C63AB0", VA = "0x184C646B0")]
	private void MFPGGFFHJOK(BDHDIPPIPNH ECBAJKPMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C63360", Offset = "0x4C62760", VA = "0x184C63360")]
	private void AGBFMMCMAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C655D0", Offset = "0x4C649D0", VA = "0x184C655D0")]
	private bool NOKPDEAMPFD(BDHDIPPIPNH ECBAJKPMIPA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PJIOCJKHBAK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PBKJKEAGNFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AEHPAJILBPF? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PBKJKEAGNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76B02D0", Offset = "0x76AF6D0", VA = "0x1876B02D0")]
		internal void IIIMLICHEEJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NKCNBMLPHJB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AEHPAJILBPF? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NKCNBMLPHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50DD430", Offset = "0x50DC830", VA = "0x1850DD430")]
		internal void IIIMLICHEEJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76B0460", Offset = "0x76AF860", VA = "0x1876B0460")]
	public static DJNFHDJGNJD AAKAOCDAJDP(this DJNFHDJGNJD MCOJNHGAONG, string FFOELGPCCOI, [Optional] AEHPAJILBPF? LLNLMEMOHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3811F60", Offset = "0x3811360", VA = "0x183811F60")]
	public static GOBMEFCJDOP<T> AAKAOCDAJDP<T>(this GOBMEFCJDOP<T> MCOJNHGAONG, string FFOELGPCCOI, [Optional] AEHPAJILBPF? LLNLMEMOHHF)
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
