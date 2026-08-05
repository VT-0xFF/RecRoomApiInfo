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
		private struct KEPGFNLEGNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string DEIIFAKABEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HFADLOCOGOG FGAFOOLPPEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? CEBKHOBFKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? PEKCCODNJPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable COPIFJKEEMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FPDOOKKEHFP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6727D0", Offset = "0x670FD0", VA = "0x1806727D0")]
			[DebuggerHidden]
			public FPDOOKKEHFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4F01F70", Offset = "0x4F00770", VA = "0x184F01F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4F02140", Offset = "0x4F00940", VA = "0x184F02140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class KEDLJNIAJIK : IEnumerator<object>, IEnumerator, IDisposable
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
			public JLIHNEGNJFG promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6727D0", Offset = "0x670FD0", VA = "0x1806727D0")]
			[DebuggerHidden]
			public KEDLJNIAJIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4F02190", Offset = "0x4F00990", VA = "0x184F02190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4F021F0", Offset = "0x4F009F0", VA = "0x184F021F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<KEPGFNLEGNL> JMNKPFJKEHN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OPGCJKPKIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x561190", Offset = "0x55F990", VA = "0x180561190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C5AA0", Offset = "0x6C42A0", VA = "0x1806C5AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4F01E00", Offset = "0x4F00600", VA = "0x184F01E00")]
		public static AsyncBatch Create(Transform HNINKJAJDDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4F01E90", Offset = "0x4F00690", VA = "0x184F01E90")]
		[IteratorStateMachine(typeof(FPDOOKKEHFP))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4F01CE0", Offset = "0x4F004E0", VA = "0x184F01CE0")]
		public void Add(string JIEIIEKPPIJ, HFADLOCOGOG IGPEFPAFKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F01B20", Offset = "0x4F00320", VA = "0x184F01B20")]
		public void Add(string JIEIIEKPPIJ, IEnumerator KIOFEDFKJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F01A90", Offset = "0x4F00290", VA = "0x184F01A90")]
		[IteratorStateMachine(typeof(KEDLJNIAJIK))]
		private IEnumerator AADFDLICOFF(JLIHNEGNJFG IGPEFPAFKHD, IEnumerator KIOFEDFKJDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4F01F00", Offset = "0x4F00700", VA = "0x184F01F00")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GBGPBKCMPGN<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OMHOHIDDIAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey LOKNCHMIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HFADLOCOGOG FGAFOOLPPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime GBIJOPMPAJL;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public OMHOHIDDIAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class NJIOOHKPBLI<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::GBGPBKCMPGN<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public NJIOOHKPBLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CMMAECKBNHN<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public OMHOHIDDIAB cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NJIOOHKPBLI<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		public CMMAECKBNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3356180", Offset = "0x3354980", VA = "0x183356180")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, OMHOHIDDIAB> MFCNIHPOHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<OMHOHIDDIAB> GHKMDGGIDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<OMHOHIDDIAB> AJCJPKFLIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int FLGHLKJIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool PKGBECDJLJH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> JGBNGJPBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1D98520", Offset = "0x1D96D20", VA = "0x181D98520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x335ABD0", Offset = "0x33593D0", VA = "0x18335ABD0")]
	public GBGPBKCMPGN([Optional] int? FLGHLKJIEBO, bool PKGBECDJLJH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2819A40", Offset = "0x2818240", VA = "0x182819A40")]
	public bool ENMGGOLDCEG(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27FE3F0", Offset = "0x27FCBF0", VA = "0x1827FE3F0")]
	public global::PKODKNLJGEP<TValue> FEKBJIGPBAL<TValue>(TKey BJKKIOODGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2520DA0", Offset = "0x251F5A0", VA = "0x182520DA0")]
	public void FINDIOADIDM<TValue>(TKey BJKKIOODGOA, TValue MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2521560", Offset = "0x251FD60", VA = "0x182521560")]
	public void HAJMMPJFGNK<TValue>(TKey BJKKIOODGOA, global::PKODKNLJGEP<TValue> IGPEFPAFKHD, TimeSpan HMOBPGIEJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27FDE90", Offset = "0x27FC690", VA = "0x1827FDE90")]
	public global::PKODKNLJGEP<TValue> BPBDFPNEKML<TValue>(TKey BJKKIOODGOA, Func<global::PKODKNLJGEP<TValue>> HKKAHKJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27FDDF0", Offset = "0x27FC5F0", VA = "0x1827FDDF0")]
	public global::PKODKNLJGEP<TValue> BPBDFPNEKML<TValue>(TKey BJKKIOODGOA, Func<global::PKODKNLJGEP<TValue>> HKKAHKJNOCO, TimeSpan HMOBPGIEJKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3359830", Offset = "0x3358030", VA = "0x183359830")]
	public bool JPAMCOIJOBL(TKey BJKKIOODGOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x335A0C0", Offset = "0x33588C0", VA = "0x18335A0C0")]
	public int MLPEKAEPDGA(Predicate<TKey> IJPHBEGKADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3358930", Offset = "0x3357130", VA = "0x183358930")]
	public void BNEMLHGGHNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3359260", Offset = "0x3357A60", VA = "0x183359260")]
	private void GHDLMOAEFCD(OMHOHIDDIAB IOELKPFLGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3359B60", Offset = "0x3358360", VA = "0x183359B60")]
	private void KPOAKPOOJME(OMHOHIDDIAB IOELKPFLGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33589C0", Offset = "0x33571C0", VA = "0x1833589C0")]
	private void EGKCEMMNHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3358ED0", Offset = "0x33576D0", VA = "0x183358ED0")]
	private bool EMJGCPLMJKB(OMHOHIDDIAB IOELKPFLGGG)
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
