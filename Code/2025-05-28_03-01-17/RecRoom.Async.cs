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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC2BE0", Offset = "0x7BC19E0", VA = "0x187BC2BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
		private struct PDCHBAMBBLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public string KHKODDKNOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public AAFDGGPNGMA JMKHJBFPMNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float? GFADGNOGEMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public float? ICGKAIPIHCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public IDisposable ECEFPFNDICA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class BELLJONDONF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public BELLJONDONF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC26D0", Offset = "0x7BC14D0", VA = "0x187BC26D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7BC28A0", Offset = "0x7BC16A0", VA = "0x187BC28A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AGCJGBCAEPA : IEnumerator<object>, IEnumerator, IDisposable
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
			public OJGPCEPDLBJ promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public AGCJGBCAEPA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1FB0", Offset = "0x7BC0DB0", VA = "0x187BC1FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7BC2020", Offset = "0x7BC0E20", VA = "0x187BC2020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private List<PDCHBAMBBLK> BMIDCHLCNJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IGGJDLMDHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2480", Offset = "0x7BC1280", VA = "0x187BC2480")]
		public static AsyncBatch Create(Transform BOGJJGPKPIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC25C0", Offset = "0x7BC13C0", VA = "0x187BC25C0")]
		[IteratorStateMachine(typeof(BELLJONDONF))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BC22E0", Offset = "0x7BC10E0", VA = "0x187BC22E0")]
		public void Add(string IHGFMOMOADA, AAFDGGPNGMA MEHDPIFMILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2070", Offset = "0x7BC0E70", VA = "0x187BC2070")]
		public void Add(string IHGFMOMOADA, IEnumerator OLJDKIPINIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2530", Offset = "0x7BC1330", VA = "0x187BC2530")]
		[IteratorStateMachine(typeof(AGCJGBCAEPA))]
		private IEnumerator PGAKJNNAGJC(OJGPCEPDLBJ MEHDPIFMILF, IEnumerator OLJDKIPINIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2640", Offset = "0x7BC1440", VA = "0x187BC2640")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IABCFKNIHNB<TKey> where TKey : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class NPANOCCNNJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public TKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AAFDGGPNGMA JMKHJBFPMNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DateTime LFKGGJMOJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xF08C40", Offset = "0xF07A40", VA = "0x180F08C40")]
		public NPANOCCNNJM(TKey MAKJJJECHHB, AAFDGGPNGMA MEHDPIFMILF, DateTime MFPDGEMABPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EGDDLKCBMIF<TValue> where TValue : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IABCFKNIHNB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NPANOCCNNJM cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EGDDLKCBMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x45F5BC0", Offset = "0x45F49C0", VA = "0x1845F5BC0")]
		internal void LDPENDDNHKJ(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<TKey, NPANOCCNNJM> EHNDDIAIEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LinkedList<NPANOCCNNJM> CMNKEEJANPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LinkedList<NPANOCCNNJM> MOGOEIDOGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int FLEPMMNNEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LNJOJGCALEK;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D23240", Offset = "0x4D22040", VA = "0x184D23240")]
	public IABCFKNIHNB([Optional] int? FLEPMMNNEHP, bool LNJOJGCALEK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAC30", Offset = "0x3BA9A30", VA = "0x183BAAC30")]
	public HMBEFKLHMDK<TValue> NKJFOHJLBPH<TValue>(TKey MAKJJJECHHB) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAA300", Offset = "0x3BA9100", VA = "0x183BAA300")]
	public void MCBOPEHBODC<TValue>(TKey MAKJJJECHHB, HMBEFKLHMDK<TValue> MEHDPIFMILF, TimeSpan PGKIKBGENDF) where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9DF0", Offset = "0x3BA8BF0", VA = "0x183BA9DF0")]
	public HMBEFKLHMDK<TValue> DOAJEEJCNDI<TValue>(TKey MAKJJJECHHB, Func<HMBEFKLHMDK<TValue>> GHOLHCPCBDK) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA9EA0", Offset = "0x3BA8CA0", VA = "0x183BA9EA0")]
	public HMBEFKLHMDK<TValue> DOAJEEJCNDI<TValue>(TKey MAKJJJECHHB, Func<HMBEFKLHMDK<TValue>> GHOLHCPCBDK, TimeSpan PGKIKBGENDF) where TValue : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D21FE0", Offset = "0x4D20DE0", VA = "0x184D21FE0")]
	public bool FKCGDELNEED(TKey MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D21980", Offset = "0x4D20780", VA = "0x184D21980")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D226E0", Offset = "0x4D214E0", VA = "0x184D226E0")]
	private void GJGBCBHGLBP(NPANOCCNNJM JFIAIHCFEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D20C30", Offset = "0x4D1FA30", VA = "0x184D20C30")]
	private void ALKOPOEBKFD(NPANOCCNNJM JFIAIHCFEPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D22CC0", Offset = "0x4D21AC0", VA = "0x184D22CC0")]
	private void NHDJAOECPMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D21E10", Offset = "0x4D20C10", VA = "0x184D21E10")]
	private bool DJNPNNFADFO(NPANOCCNNJM JFIAIHCFEPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KDAJKFJGMPK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NIHDLDIHLGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HBKLMMOCKFE? logFlags;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NIHDLDIHLGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2A50", Offset = "0x7BC1850", VA = "0x187BC2A50")]
		internal void OLLIMFGKGBD(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NLGMJCFANLK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public string errorPrefix;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public HBKLMMOCKFE? logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NLGMJCFANLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x54CFA60", Offset = "0x54CE860", VA = "0x1854CFA60")]
		internal void OLLIMFGKGBD(string error)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC28F0", Offset = "0x7BC16F0", VA = "0x187BC28F0")]
	public static AAFDGGPNGMA NCKOJAKADNI(this AAFDGGPNGMA MEHDPIFMILF, string BKAMMEPMJEP, [Optional] HBKLMMOCKFE? OHFLKOCBNNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x39C4AE0", Offset = "0x39C38E0", VA = "0x1839C4AE0")]
	public static HMBEFKLHMDK<T> NCKOJAKADNI<T>(this HMBEFKLHMDK<T> MEHDPIFMILF, string BKAMMEPMJEP, [Optional] HBKLMMOCKFE? OHFLKOCBNNO)
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
