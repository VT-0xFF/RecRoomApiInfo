using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct IFAICDPJKOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string JAGOKEMFLBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public PONAFBMJJFC GBJLGGKCNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? KDGFLIGGBEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? OHDCKAFMPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable GFACPINHLKI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class EAEEKADJBPJ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public AsyncBatch <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000C")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public EAEEKADJBPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B320C0", Offset = "0x6B30EC0", VA = "0x186B320C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6B322C0", Offset = "0x6B310C0", VA = "0x186B322C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HIKFIDKMHPE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IEnumerator coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public OOJANPILAPP promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public HIKFIDKMHPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6B32300", Offset = "0x6B31100", VA = "0x186B32300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B32360", Offset = "0x6B31160", VA = "0x186B32360", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<IFAICDPJKOJ> GHHOKKFDKKE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MEPDPOKDAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B360", VA = "0x18075C560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7D64C0", Offset = "0x7D52C0", VA = "0x1807D64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B31E90", Offset = "0x6B30C90", VA = "0x186B31E90")]
		public static AsyncBatch Create(Transform GANAMHNGMGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B31FD0", Offset = "0x6B30DD0", VA = "0x186B31FD0")]
		[IteratorStateMachine(typeof(EAEEKADJBPJ))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B31D60", Offset = "0x6B30B60", VA = "0x186B31D60")]
		public void Add(string ICIEGOLHGJN, PONAFBMJJFC MDMLEAMEPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B31B90", Offset = "0x6B30990", VA = "0x186B31B90")]
		public void Add(string ICIEGOLHGJN, IEnumerator IPNDPOFCJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B31F40", Offset = "0x6B30D40", VA = "0x186B31F40")]
		[IteratorStateMachine(typeof(HIKFIDKMHPE))]
		private IEnumerator OIKPGBNJINI(OOJANPILAPP MDMLEAMEPOH, IEnumerator IPNDPOFCJMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B32040", Offset = "0x6B30E40", VA = "0x186B32040")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKCINMEABEB<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ABFLMBFCOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey MPJCJINPOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PONAFBMJJFC GBJLGGKCNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime IJLEMPKMFFF;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public ABFLMBFCOAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AJOOHKEEECH<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::EKCINMEABEB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ABFLMBFCOAC cacheEntry;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public AJOOHKEEECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24E0B00", Offset = "0x24DF900", VA = "0x1824E0B00")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, ABFLMBFCOAC> DPNMFCPMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<ABFLMBFCOAC> HDGILJGMJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<ABFLMBFCOAC> EALNNLFJJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int CEAIPMFNGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FMEMIEMNILL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x433EB10", Offset = "0x433D910", VA = "0x18433EB10")]
	public EKCINMEABEB([Optional] int? CEAIPMFNGJN, bool FMEMIEMNILL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x433D3E0", Offset = "0x433C1E0", VA = "0x18433D3E0")]
	public bool EJNKOOJFENG(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A770", Offset = "0x2C79570", VA = "0x182C7A770")]
	public global::OOLBMJPBBIG<TValue> HAGEMFCPMDE<TValue>(TKey JHANOPJHOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A970", Offset = "0x2C79770", VA = "0x182C7A970")]
	public void KFMNCDLPMGL<TValue>(TKey JHANOPJHOLP, TValue MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AD90", Offset = "0x2C79B90", VA = "0x182C7AD90")]
	public void OJBBKGMABNL<TValue>(TKey JHANOPJHOLP, global::OOLBMJPBBIG<TValue> MDMLEAMEPOH, TimeSpan KGMBGFIMAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A100", Offset = "0x2C78F00", VA = "0x182C7A100")]
	public global::OOLBMJPBBIG<TValue> EOOGIIAFEIK<TValue>(TKey JHANOPJHOLP, Func<global::OOLBMJPBBIG<TValue>> HAAJPOINFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A1B0", Offset = "0x2C78FB0", VA = "0x182C7A1B0")]
	public global::OOLBMJPBBIG<TValue> EOOGIIAFEIK<TValue>(TKey JHANOPJHOLP, Func<global::OOLBMJPBBIG<TValue>> HAAJPOINFCP, TimeSpan KGMBGFIMAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x433D360", Offset = "0x433C160", VA = "0x18433D360")]
	public bool CJGLMEKHGBL(TKey JHANOPJHOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x433EA90", Offset = "0x433D890", VA = "0x18433EA90")]
	public void ODCBHOABBME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x433E8A0", Offset = "0x433D6A0", VA = "0x18433E8A0")]
	private void KAEIIOKOIBA(ABFLMBFCOAC LBNKEEKMHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x433D970", Offset = "0x433C770", VA = "0x18433D970")]
	private void FFOHENIFMEC(ABFLMBFCOAC LBNKEEKMHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x433DFB0", Offset = "0x433CDB0", VA = "0x18433DFB0")]
	private void GPPMCHKKLBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x433DC20", Offset = "0x433CA20", VA = "0x18433DC20")]
	private bool GIKJGIOFECP(ABFLMBFCOAC LBNKEEKMHJK)
	{
		return default(bool);
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
