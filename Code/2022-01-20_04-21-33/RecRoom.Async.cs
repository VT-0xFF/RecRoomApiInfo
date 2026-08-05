using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AsyncBatch : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private struct ELMMLMNHLBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public string HIDCHKFDOPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JFNFLBIAFDM COMDJNCEJFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public float? OGAJNDNKFCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public float? FHGFMLPKGMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IDisposable BGINNNMIMNE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class NHJLHENJOHJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public NHJLHENJOHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x4506AE0", Offset = "0x45052E0", VA = "0x184506AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4506CB0", Offset = "0x45054B0", VA = "0x184506CB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class IJKDKAHIALF : IEnumerator<object>, IEnumerator, IDisposable
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
			public PFHHFCMCGEB promise;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D7870", Offset = "0x4D6070", VA = "0x1804D7870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5044B0", Offset = "0x502CB0", VA = "0x1805044B0")]
			[DebuggerHidden]
			public IJKDKAHIALF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4DCEF0", Offset = "0x4DB6F0", VA = "0x1804DCEF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4506A40", Offset = "0x4505240", VA = "0x184506A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4506A90", Offset = "0x4505290", VA = "0x184506A90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private List<ELMMLMNHLBI> FBOKMJOEPDI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CPBHKCLAOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B30", Offset = "0x4E0330", VA = "0x1804E1B30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4E1B40", Offset = "0x4E0340", VA = "0x1804E1B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4506880", Offset = "0x4505080", VA = "0x184506880")]
		public static AsyncBatch Create(Transform PJIPIGLGNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4506980", Offset = "0x4505180", VA = "0x184506980")]
		[IteratorStateMachine(typeof(NHJLHENJOHJ))]
		private IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4506790", Offset = "0x4504F90", VA = "0x184506790")]
		public void Add(string JKIKPMPMGPL, JFNFLBIAFDM JCFDMLOHLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4506620", Offset = "0x4504E20", VA = "0x184506620")]
		public void Add(string JKIKPMPMGPL, IEnumerator HBONJFPLFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4506910", Offset = "0x4505110", VA = "0x184506910")]
		[IteratorStateMachine(typeof(IJKDKAHIALF))]
		private IEnumerator INBOJBBAMPN(PFHHFCMCGEB JCFDMLOHLFH, IEnumerator HBONJFPLFPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x45069E0", Offset = "0x45051E0", VA = "0x1845069E0")]
		public AsyncBatch()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJDNJMKHGHF<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LDFPMJAEPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TKey JHBMCIBCLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public JFNFLBIAFDM COMDJNCEJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DateTime DDOOMMECLFB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public LDFPMJAEPBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AKJHFKCAFEG<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::OJDNJMKHGHF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TKey key;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public AKJHFKCAFEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ENKMPINILAD<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LDFPMJAEPBD cacheEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AKJHFKCAFEG<TValue> CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFEFFE0", Offset = "0xFEE7E0", VA = "0x180FEFFE0")]
		public ENKMPINILAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2C93B60", Offset = "0x2C92360", VA = "0x182C93B60")]
		internal void <SetPromise>b__0(string e)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<TKey, LDFPMJAEPBD> BPDBEEIMJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private LinkedList<LDFPMJAEPBD> MMKDMDMPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LinkedList<LDFPMJAEPBD> CGBOCOHBKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private int GOAFGDFEKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DGIFFPPJEBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICollection<TKey> GCMPCHCFHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5870", Offset = "0x2CA4070", VA = "0x182CA5870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2CA62F0", Offset = "0x2CA4AF0", VA = "0x182CA62F0")]
	public OJDNJMKHGHF([Optional] int? GOAFGDFEKKB, bool DGIFFPPJEBJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7EC0", Offset = "0x2BC66C0", VA = "0x182BC7EC0")]
	public bool DLFGMKOIJMC(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1431890", Offset = "0x1430090", VA = "0x181431890")]
	public global::GHMNNNIJAKN<TValue> AAFKIOAFOHE<TValue>(TKey PONAFPGHKNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2223A70", Offset = "0x2222270", VA = "0x182223A70")]
	public void JMFPAALFGDI<TValue>(TKey PONAFPGHKNA, TValue IJBLIGDNDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2223B50", Offset = "0x2222350", VA = "0x182223B50")]
	public void JMFPAALFGDI<TValue>(TKey PONAFPGHKNA, TValue IJBLIGDNDKF, TimeSpan ACOCBCJBGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22239C0", Offset = "0x22221C0", VA = "0x1822239C0")]
	public void BKLLFBBLPDD<TValue>(TKey PONAFPGHKNA, global::GHMNNNIJAKN<TValue> JCFDMLOHLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2223690", Offset = "0x2221E90", VA = "0x182223690")]
	public void BKLLFBBLPDD<TValue>(TKey PONAFPGHKNA, global::GHMNNNIJAKN<TValue> JCFDMLOHLFH, TimeSpan ACOCBCJBGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1431F30", Offset = "0x1430730", VA = "0x181431F30")]
	public global::GHMNNNIJAKN<TValue> PLIKICLCDBI<TValue>(TKey PONAFPGHKNA, Func<global::GHMNNNIJAKN<TValue>> NEIEFENGNNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1431DF0", Offset = "0x14305F0", VA = "0x181431DF0")]
	public global::GHMNNNIJAKN<TValue> PLIKICLCDBI<TValue>(TKey PONAFPGHKNA, Func<global::GHMNNNIJAKN<TValue>> NEIEFENGNNL, TimeSpan ACOCBCJBGBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA58A0", Offset = "0x2CA40A0", VA = "0x182CA58A0")]
	public bool MEHJLGGLJCP(TKey PONAFPGHKNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4FA0", Offset = "0x2CA37A0", VA = "0x182CA4FA0")]
	public int DKILKACAENN(Predicate<TKey> LOKJAKEBOFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2CA57E0", Offset = "0x2CA3FE0", VA = "0x182CA57E0")]
	public void GFLIGMLNIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5400", Offset = "0x2CA3C00", VA = "0x182CA5400")]
	private void FPFPJPDDNBK(LDFPMJAEPBD PHPKDBCMDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CA5E80", Offset = "0x2CA4680", VA = "0x182CA5E80")]
	private void OIECHNLBPOC(LDFPMJAEPBD PHPKDBCMDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4910", Offset = "0x2CA3110", VA = "0x182CA4910")]
	private void BKHAEHDMNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4480", Offset = "0x2CA2C80", VA = "0x182CA4480")]
	private bool ANKHMCGBDOC(LDFPMJAEPBD PHPKDBCMDGB)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NNEGPLICMMD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static byte[] JIMKOONODID;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static int NMMFCBLNDCI;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static int PHIEOBCOOJB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BigInteger DPMJLFEPCLI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
	public NNEGPLICMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4506D00", Offset = "0x4505500", VA = "0x184506D00")]
	private static string CFIIEEFNNDM(byte[] DALEFJAMHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4506E00", Offset = "0x4505600", VA = "0x184506E00")]
	public static string DHILBOIALCB(byte[] EGBGAEKCIGK, bool DAJGEBLMHFN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D75D0", Offset = "0x4D5DD0", VA = "0x1804D75D0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
