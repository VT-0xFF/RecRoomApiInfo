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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x76FE0E0", Offset = "0x76FD4E0", VA = "0x1876FE0E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
			[DebuggerHidden]
			public MIHDPMADDLO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x76FDEC0", Offset = "0x76FD2C0", VA = "0x1876FDEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76FE090", Offset = "0x76FD490", VA = "0x1876FE090", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9AFBB0", Offset = "0x9AEFB0", VA = "0x1809AFBB0")]
			[DebuggerHidden]
			public HBKNEGCDBKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76FDE00", Offset = "0x76FD200", VA = "0x1876FDE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76FDE70", Offset = "0x76FD270", VA = "0x1876FDE70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AA370", Offset = "0x9A9770", VA = "0x1809AA370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9AA510", Offset = "0x9A9910", VA = "0x1809AA510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76FDBB0", Offset = "0x76FCFB0", VA = "0x1876FDBB0")]
		public static AsyncBatch Create(Transform KLDFHLFOOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76FDCF0", Offset = "0x76FD0F0", VA = "0x1876FDCF0")]
		[IteratorStateMachine(typeof(MIHDPMADDLO))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76FD7A0", Offset = "0x76FCBA0", VA = "0x1876FD7A0")]
		public void Add(string IGEPDAOOLBO, DJNFHDJGNJD MCOJNHGAONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76FD940", Offset = "0x76FCD40", VA = "0x1876FD940")]
		public void Add(string IGEPDAOOLBO, IEnumerator GBBPIGBGDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76FDC60", Offset = "0x76FD060", VA = "0x1876FDC60")]
		[IteratorStateMachine(typeof(HBKNEGCDBKC))]
		private IEnumerator FIFDONIKIEO(NOCDIBGNFAP MCOJNHGAONG, IEnumerator GBBPIGBGDCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76FDD70", Offset = "0x76FD170", VA = "0x1876FDD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE36A00", Offset = "0xE35E00", VA = "0x180E36A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public BHCAEEABCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F1D800", Offset = "0x5F1CC00", VA = "0x185F1D800")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C85A90", Offset = "0x4C84E90", VA = "0x184C85A90")]
	public JNCAJFGGEFB([Optional] int? LPHFOKFELCN, bool NLKHNHPLDGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA61E0", Offset = "0x3BA55E0", VA = "0x183BA61E0")]
	public GOBMEFCJDOP<TValue> ECGCNMEGGIM<TValue>(TKey DJBLFBEBKGO) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA55A0", Offset = "0x3BA49A0", VA = "0x183BA55A0")]
	public void ABNMLABLKDF<TValue>(TKey DJBLFBEBKGO, GOBMEFCJDOP<TValue> MCOJNHGAONG, TimeSpan JNODBBNPLOO) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6840", Offset = "0x3BA5C40", VA = "0x183BA6840")]
	public GOBMEFCJDOP<TValue> GKCPEMLKOBC<TValue>(TKey DJBLFBEBKGO, Func<GOBMEFCJDOP<TValue>> NECHOHNOMHJ) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6760", Offset = "0x3BA5B60", VA = "0x183BA6760")]
	public GOBMEFCJDOP<TValue> GKCPEMLKOBC<TValue>(TKey DJBLFBEBKGO, Func<GOBMEFCJDOP<TValue>> NECHOHNOMHJ, TimeSpan JNODBBNPLOO) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C84710", Offset = "0x4C83B10", VA = "0x184C84710")]
	public bool JEBJOEBLLEI(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C83CC0", Offset = "0x4C830C0", VA = "0x184C83CC0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4C843F0", Offset = "0x4C837F0", VA = "0x184C843F0")]
	private void DPIKBAMOAAN(BDHDIPPIPNH ECBAJKPMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C847D0", Offset = "0x4C83BD0", VA = "0x184C847D0")]
	private void MFPGGFFHJOK(BDHDIPPIPNH ECBAJKPMIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C83480", Offset = "0x4C82880", VA = "0x184C83480")]
	private void AGBFMMCMAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4C856F0", Offset = "0x4C84AF0", VA = "0x184C856F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public PBKJKEAGNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76FE160", Offset = "0x76FD560", VA = "0x1876FE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NKCNBMLPHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50FE4D0", Offset = "0x50FD8D0", VA = "0x1850FE4D0")]
		internal void IIIMLICHEEJ(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76FE2E0", Offset = "0x76FD6E0", VA = "0x1876FE2E0")]
	public static DJNFHDJGNJD AAKAOCDAJDP(this DJNFHDJGNJD MCOJNHGAONG, string FFOELGPCCOI, [Optional] AEHPAJILBPF? LLNLMEMOHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3825710", Offset = "0x3824B10", VA = "0x183825710")]
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
