using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine;
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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9E60", Offset = "0x5FD8A60", VA = "0x185FD9E60")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AGAmplitudeAnalyticsSettings : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings ILIBIGMGBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LFAFMEFLHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B9F80", Offset = "0x7B8B80", VA = "0x1807B9F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum AINGNBDEELL
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class AFPAMMPBHGE
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class EIKGBKDBAAK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int HBGHPEKNOKC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> PMCMMPNHKBH;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public EIKGBKDBAAK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class FGPBHBFEIIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
				public FGPBHBFEIIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5FD3E60", Offset = "0x5FD2A60", VA = "0x185FD3E60")]
				internal bool IOPKOPJGIHD(EIKGBKDBAAK item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string POBIIKCIEMF = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string CMCOOMKLEBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<EIKGBKDBAAK> MGJOAMECBOJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? MGGHNLEHHHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5FCA790", Offset = "0x5FC9390", VA = "0x185FCA790")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5FCA830", Offset = "0x5FC9430", VA = "0x185FCA830")]
			internal AFPAMMPBHGE(string HMDCAJKHALI, string LCCFFCEPJIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5FCA5E0", Offset = "0x5FC91E0", VA = "0x185FCA5E0")]
			public int MDFPMIEBPJK([Optional] int? OKKHOANIJJK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5FCA120", Offset = "0x5FC8D20", VA = "0x185FCA120")]
			public List<Dictionary<string, object>> LBNOMMHLDDD(int PLENMDCJLCI, int? OKKHOANIJJK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9C00", Offset = "0x5FC8800", VA = "0x185FC9C00")]
			public void GDJLLJIFABB(AmplitudeAnalyticsIdentifyMessage OGGNGHKHHGI, bool NIELCJCJPOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9AF0", Offset = "0x5FC86F0", VA = "0x185FC9AF0")]
			public void GDJLLJIFABB(Dictionary<string, object> OGGNGHKHHGI, bool NIELCJCJPOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9570", Offset = "0x5FC8170", VA = "0x185FC9570")]
			public void DHNAMDIBLNN(params Dictionary<string, object>[] GPCLPCGFHDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FCA390", Offset = "0x5FC8F90", VA = "0x185FCA390")]
			public void LOBOHBMAION(List<Dictionary<string, object>> HINIJGCJFCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9EE0", Offset = "0x5FC8AE0", VA = "0x185FC9EE0")]
			private void IEICIHLKOKH(Dictionary<string, object> OGGNGHKHHGI, bool NIELCJCJPOG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9CA0", Offset = "0x5FC88A0", VA = "0x185FC9CA0")]
			public void HELDLCBFFNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9700", Offset = "0x5FC8300", VA = "0x185FC9700")]
			private void DOHBNDHOCNH([Optional] string KNAABMGLEBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5FC9FF0", Offset = "0x5FC8BF0", VA = "0x185FC9FF0")]
			private static string JDIJFDHMIOO(string BLKAHBIJBJO, string CGGNJKGENIH)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5FDB850", Offset = "0x5FDA450", VA = "0x185FDB850")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct GHDFBGKKKOJ<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int NNKKENFNGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string MJAPHLMCKKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T GEEGNAJDEGO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HGANGGMCKDP : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private BILDDJDOJHA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public HGANGGMCKDP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5FD48D0", Offset = "0x5FD34D0", VA = "0x185FD48D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD5090", Offset = "0x5FD3C90", VA = "0x185FD5090", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GIEFMGANHDA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AIEMBHKGDME quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public GIEFMGANHDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5FD4770", Offset = "0x5FD3370", VA = "0x185FD4770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5FD4880", Offset = "0x5FD3480", VA = "0x185FD4880", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GCNKALIIGEP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public GCNKALIIGEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5FD44B0", Offset = "0x5FD30B0", VA = "0x185FD44B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD4620", Offset = "0x5FD3220", VA = "0x185FD4620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class EKFNOBFHNFG : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private BILDDJDOJHA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public EKFNOBFHNFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD3B40", Offset = "0x5FD2740", VA = "0x185FD3B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5FD3DC0", Offset = "0x5FD29C0", VA = "0x185FD3DC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NDMPDBLNNGN : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private BILDDJDOJHA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public NDMPDBLNNGN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9B80", Offset = "0x5FD8780", VA = "0x185FD9B80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9E10", Offset = "0x5FD8A10", VA = "0x185FD9E10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MJPPLLDMPNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AFPAMMPBHGE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public MJPPLLDMPNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9860", Offset = "0x5FD8460", VA = "0x185FD9860")]
			internal void KCGBKLFJELM(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD9410", Offset = "0x5FD8010", VA = "0x185FD9410")]
			internal void IPJJBHHNBMN(GHDFBGKKKOJ<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LFDGLHAHOCL : IEnumerator<BILDDJDOJHA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private BILDDJDOJHA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AFPAMMPBHGE cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private MJPPLLDMPNF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private string <apiKey>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private float <startTime>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private bool <timedOut>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int <batchSize>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private BILDDJDOJHA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000085")]
				[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F20", Offset = "0x7B3B20", VA = "0x1807B4F20")]
			[DebuggerHidden]
			public LFDGLHAHOCL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FD88F0", Offset = "0x5FD74F0", VA = "0x185FD88F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5FD91A0", Offset = "0x5FD7DA0", VA = "0x185FD91A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class OFHHKMGHJHF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public OFHHKMGHJHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x386A2B0", Offset = "0x3868EB0", VA = "0x18386A2B0")]
			internal GHDFBGKKKOJ<T> GBPDJJGIIMM(JOELPFOKNLK postResponse)
			{
				return default(GHDFBGKKKOJ<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class HFKJLKIAMGA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public HFKJLKIAMGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x386A2B0", Offset = "0x3868EB0", VA = "0x18386A2B0")]
			internal GHDFBGKKKOJ<T> LJFPEGECLPC(JOELPFOKNLK postResponse)
			{
				return default(GHDFBGKKKOJ<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private PPHJJGMPHOI BIEGJCPFCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<GOKKHLHNFJK> KPOCGINPOFF;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string ANGHKCGLPIC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ODFPGBHOGBP = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string HKOFEMLNNIH = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int ACBFKHNOFMK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int EAOMGBLABHF = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int FFNHKGJFANG = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float HIIOBDMDBHD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long NGNGGDOAHIM = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CGKIAIOFCPJ = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string NFOGLICMIML = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool AOGFCGHPAMJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool OGNCEOCMFEC;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int MMENHEJIEJE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int NMIGAPGHDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private JLGFDHLMHNE BGDJABLCPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CGBNIGLGOJM JJBOPCMPPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CAAKFJJOJHB JOGENKLDHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NOIEBFBBEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float AMCBMLNEJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float PGLFPHGBKNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int ILPMKLDKKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int JILMECJKBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? OPPCELGHLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? IBEJBMDLFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long GDPHHLDDMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string ELCCDODLBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool LKFMINMHGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long EFGIGBKACOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string COPAGPCDOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string EHFBDLHBMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> BCHKJEJBLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AINGNBDEELL GKCBIIHMNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int IJMGOBOKMKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int KIJIEGCMLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float HGKJKFOOCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool CPEJLKHCPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool POBNNMCBMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private AFPAMMPBHGE BIFFAPOENJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private AFPAMMPBHGE EKOLEKLIMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AFPAMMPBHGE AJHKLDMLIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FLMMBJLJHCJ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo NJJLFEOFJKG;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string EEJPKIJKNEM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string MGHKFDDOKDF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string CIEMFLDIGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string FPLKAAEDIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string NDLCCKKJIOI;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PPHJJGMPHOI KJFEGDJMPKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5FCD750", Offset = "0x5FCC350", VA = "0x185FCD750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GOKKHLHNFJK JADMMHMJLHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5FCE230", Offset = "0x5FCCE30", VA = "0x185FCE230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EDJLAEEHKFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5FCE570", Offset = "0x5FCD170", VA = "0x185FCE570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long KCHDACELJNI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5FD05C0", Offset = "0x5FCF1C0", VA = "0x185FD05C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD06E0", Offset = "0x5FCF2E0", VA = "0x185FD06E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string IACHLLAGFME
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0560", Offset = "0x5FCF160", VA = "0x185FD0560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string GDKFFOOIIIM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0590", Offset = "0x5FCF190", VA = "0x185FD0590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IGILMJCBHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D4140", Offset = "0x8D2D40", VA = "0x1808D4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D45A0", Offset = "0x8D31A0", VA = "0x1808D45A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? ODIOGHGNJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8FECC0", Offset = "0x8FD8C0", VA = "0x1808FECC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5FD06D0", Offset = "0x5FCF2D0", VA = "0x185FD06D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HJOFNMKJNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xFDE200", Offset = "0xFDCE00", VA = "0x180FDE200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xFDDE80", Offset = "0xFDCA80", VA = "0x180FDDE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool JIPNJIMLNDH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0460", Offset = "0x5FCF060", VA = "0x185FD0460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CDDPOHGLCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD03A0", Offset = "0x5FCEFA0", VA = "0x185FD03A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD0610", Offset = "0x5FCF210", VA = "0x185FD0610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB8F0", Offset = "0x5FCA4F0", VA = "0x185FCB8F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FCCAD0", Offset = "0x5FCB6D0", VA = "0x185FCCAD0")]
		private void HEOPPGMIBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF980", Offset = "0x5FCE580", VA = "0x185FCF980")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEB60", Offset = "0x5FCD760", VA = "0x185FCEB60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFD20", Offset = "0x5FCE920", VA = "0x185FCFD20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEC20", Offset = "0x5FCD820", VA = "0x185FCEC20")]
		public BMPAGEIJFCN PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD6C0", Offset = "0x5FCC2C0", VA = "0x185FCD6C0")]
		[IteratorStateMachine(typeof(HGANGGMCKDP))]
		public IEnumerator<BILDDJDOJHA> Initialize(AmplitudeAnalyticsEvent MHNCFGBFJBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFC60", Offset = "0x5FCE860", VA = "0x185FCFC60")]
		public void UpdateLastKnownInteractionCategory(string FOAODJALIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFB70", Offset = "0x5FCE770", VA = "0x185FCFB70")]
		public void UpdateLastAliveTime(float HINGOJPJBCE = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD170", Offset = "0x5FCBD70", VA = "0x185FCD170")]
		private BMPAGEIJFCN HMGFCOLKPGG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC150", Offset = "0x5FCAD50", VA = "0x185FCC150")]
		private BMPAGEIJFCN EBOFJDFBKHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF3D0", Offset = "0x5FCDFD0", VA = "0x185FCF3D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBD60", Offset = "0x5FCA960", VA = "0x185FCBD60")]
		[IteratorStateMachine(typeof(GIEFMGANHDA))]
		private IEnumerator CPKDLPDIIFO(AIEMBHKGDME MGPHCMAODJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFFB0", Offset = "0x5FCEBB0", VA = "0x185FCFFB0")]
		[IteratorStateMachine(typeof(GCNKALIIGEP))]
		public IEnumerator WaitForFlush(float IAJJLFLHIDC = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FCFA50", Offset = "0x5FCE650", VA = "0x185FCFA50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF990", Offset = "0x5FCE590", VA = "0x185FCF990")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EAKAKFEGLBF)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD230", Offset = "0x5FCBE30", VA = "0x185FCD230")]
		public static GHLOPGGPJLM Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB780", Offset = "0x5FCA380", VA = "0x185FCB780")]
		public static OIJCOGJFNCK AccountSelectionPostLoginEvent([NotNull] string FKLMOPGGKGO, string FPILOFCFNEM, bool EHPDGHCEJDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC440", Offset = "0x5FCB040", VA = "0x185FCC440")]
		public static OIJCOGJFNCK Event([NotNull] string FKLMOPGGKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEC60", Offset = "0x5FCD860", VA = "0x185FCEC60")]
		public static OIJCOGJFNCK PreviousSessionEvent([NotNull] string FKLMOPGGKGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD3E0", Offset = "0x5FCBFE0", VA = "0x185FCD3E0")]
		public static OIJCOGJFNCK InitializeEvent(string FPILOFCFNEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF590", Offset = "0x5FCE190", VA = "0x185FCF590")]
		public static OIJCOGJFNCK StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBDF0", Offset = "0x5FCA9F0", VA = "0x185FCBDF0")]
		public static OIJCOGJFNCK CreateOutOfSessionEvent(string FKLMOPGGKGO, bool ONJFLOFLPFC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDD20", Offset = "0x5FCC920", VA = "0x185FCDD20")]
		public static BMPAGEIJFCN LogOutOfSessionEvent(OIJCOGJFNCK GLJABOHKFCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDAA0", Offset = "0x5FCC6A0", VA = "0x185FCDAA0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OOIIFDHNIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE010", Offset = "0x5FCCC10", VA = "0x185FCE010")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OOIIFDHNIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE150", Offset = "0x5FCCD50", VA = "0x185FCE150")]
		public void LogSerializedEventAsync(Dictionary<string, object> JHAEALDHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FCDBE0", Offset = "0x5FCC7E0", VA = "0x185FCDBE0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage LLOLLNPKOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC050", Offset = "0x5FCAC50", VA = "0x185FCC050")]
		private void DBGJFMDLMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC820", Offset = "0x5FCB420", VA = "0x185FCC820")]
		private void GLLPLENAFDP(Dictionary<string, object> JDMLHEHAJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE320", Offset = "0x5FCCF20", VA = "0x185FCE320")]
		private void NGMHFCJGPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD8D0", Offset = "0x5FCC4D0", VA = "0x185FCD8D0")]
		private void LBOILPEPGGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC740", Offset = "0x5FCB340", VA = "0x185FCC740")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAA20", Offset = "0x5FC9620", VA = "0x185FCAA20")]
		[IteratorStateMachine(typeof(EKFNOBFHNFG))]
		private IEnumerator<BILDDJDOJHA> AFGFAOLNEJB(float IAJJLFLHIDC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE280", Offset = "0x5FCCE80", VA = "0x185FCE280")]
		[IteratorStateMachine(typeof(NDMPDBLNNGN))]
		private IEnumerator<BILDDJDOJHA> MNLDCIIPOCD(float IAJJLFLHIDC = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD070", Offset = "0x5FCBC70", VA = "0x185FCD070")]
		[IteratorStateMachine(typeof(LFDGLHAHOCL))]
		private IEnumerator<BILDDJDOJHA> HGJDACIIFMJ(AFPAMMPBHGE MKCCPGLPKFD, int? OKKHOANIJJK, string NELECDMJFLK, string FMFCOPJNJEI, float IAJJLFLHIDC, Action<int> JAOEOIIBCAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD7C0", Offset = "0x5FCC3C0", VA = "0x185FCD7C0")]
		private static void KDKJMFJNOGD(bool EMIBGAMJHNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEA30", Offset = "0x5FCD630", VA = "0x185FCEA30")]
		private LHJBMADJJFP<GHDFBGKKKOJ<Dictionary<string, object>>> ONPKNDLNEHJ(string NELECDMJFLK, string FMFCOPJNJEI, string CBBJCPOBMCE, string EGDECOFGIJN, Dictionary<string, object> GEEGNAJDEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE750", Offset = "0x5FCD350", VA = "0x185FCE750")]
		private LHJBMADJJFP<GHDFBGKKKOJ<List<Dictionary<string, object>>>> ONPKNDLNEHJ(string NELECDMJFLK, string FMFCOPJNJEI, string CBBJCPOBMCE, string EGDECOFGIJN, List<Dictionary<string, object>> GEEGNAJDEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD9F0", Offset = "0x2DCC5F0", VA = "0x182DCD9F0")]
		private LHJBMADJJFP<GHDFBGKKKOJ<T>> HPKEDGIFPOC<T>(string NELECDMJFLK, string FMFCOPJNJEI, string EGDECOFGIJN, T GEEGNAJDEGO, Dictionary<string, object> BFDNBCOEGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD6A0", Offset = "0x2DCC2A0", VA = "0x182DCD6A0")]
		private LHJBMADJJFP<GHDFBGKKKOJ<T>> ECNFNLJAGFE<T>(string NELECDMJFLK, string FMFCOPJNJEI, string CBBJCPOBMCE, T GEEGNAJDEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC7D0", Offset = "0x5FCB3D0", VA = "0x185FCC7D0")]
		private bool GGPCDOCAMOP(float OCJFHPHIOEO, float IAJJLFLHIDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAAB0", Offset = "0x5FC96B0", VA = "0x185FCAAB0")]
		private Dictionary<string, object> ALGFBICNPAA(string FMFCOPJNJEI, Dictionary<string, object> GEEGNAJDEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FD00A0", Offset = "0x5FCECA0", VA = "0x185FD00A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE410", Offset = "0x5FCD010", VA = "0x185FCE410")]
		[CompilerGenerated]
		private long NKBHMBFMFCC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FCE310", Offset = "0x5FCCF10", VA = "0x185FCE310")]
		[CompilerGenerated]
		private void MOMADGNFFDF(int LKNEKHAEFCI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly bool isBrazeUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1440", Offset = "0x5FD0040", VA = "0x185FD1440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1520", Offset = "0x5FD0120", VA = "0x185FD1520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1480", Offset = "0x5FD0080", VA = "0x185FD1480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1580", Offset = "0x5FD0180", VA = "0x185FD1580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1400", Offset = "0x5FD0000", VA = "0x185FD1400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5FD14C0", Offset = "0x5FD00C0", VA = "0x185FD14C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7B79F0", Offset = "0x7B65F0", VA = "0x1807B79F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FD09B0", Offset = "0x5FCF5B0", VA = "0x185FD09B0")]
		public static OIJCOGJFNCK JOBBHNKGDPO(string KAHEAPGLNDI, [NotNull] string EMGABGLHFNB, long GFAPMFNAAFO, long ALPJKJDLIHB, string FPILOFCFNEM, bool EHPDGHCEJDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0850", Offset = "0x5FCF450", VA = "0x185FD0850")]
		public static OIJCOGJFNCK HAHJECNOCCA(string KAHEAPGLNDI, [NotNull] string EMGABGLHFNB, long GFAPMFNAAFO, long ALPJKJDLIHB, string FPILOFCFNEM, long IECNOBDBECN, bool EHPDGHCEJDD, string NCDINMOMBFN, string OOKAKGNHABO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1270", Offset = "0x5FCFE70", VA = "0x185FD1270")]
		private AmplitudeAnalyticsEvent(string KAHEAPGLNDI, [NotNull] string EMGABGLHFNB, long GFAPMFNAAFO, long ALPJKJDLIHB, string FPILOFCFNEM, bool EHPDGHCEJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3EB0", Offset = "0x1AC2AB0", VA = "0x181AC3EB0")]
		public void BHCNBMMAAKC(long IBCBAHBJCKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0740", Offset = "0x5FCF340", VA = "0x185FD0740", Slot = "5")]
		public override void CEKLFGPPOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0BC0", Offset = "0x5FCF7C0", VA = "0x185FD0BC0", Slot = "6")]
		public override void NMPGCIDFACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0D40", Offset = "0x5FCF940", VA = "0x185FD0D40", Slot = "4")]
		protected override Dictionary<string, object> PNPCFGNCOCP(Dictionary<string, object> KOJMKGFELBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0AB0", Offset = "0x5FCF6B0", VA = "0x185FD0AB0")]
		private void LMILHBADMFN(string CGGNJKGENIH, string BLKAHBIJBJO, bool BAIAGGBGCCI = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5FD39C0", Offset = "0x5FD25C0", VA = "0x185FD39C0")]
			public void EGILFLLPLKC(Dictionary<string, object> ALHGACHKPIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5FDB4E0", Offset = "0x5FDA0E0", VA = "0x185FDB4E0")]
			public void EGILFLLPLKC(Dictionary<string, object> HBBIBIEMNHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x93BD60", Offset = "0x93A960", VA = "0x18093BD60")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1780", Offset = "0x5FD0380", VA = "0x185FD1780")]
		public static GHLOPGGPJLM JOBBHNKGDPO(string KAHEAPGLNDI, string FPILOFCFNEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1CA0", Offset = "0x5FD08A0", VA = "0x185FD1CA0")]
		protected AmplitudeAnalyticsIdentifyMessage(string KAHEAPGLNDI, string FPILOFCFNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1840", Offset = "0x5FD0440", VA = "0x185FD1840")]
		public Dictionary<string, object> MMHGLAGNOCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1960", Offset = "0x5FD0560", VA = "0x185FD1960", Slot = "4")]
		protected virtual Dictionary<string, object> PNPCFGNCOCP(Dictionary<string, object> KOJMKGFELBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1670", Offset = "0x5FD0270", VA = "0x185FD1670")]
		protected void DBHHJPOOKMK(string CGGNJKGENIH, Dictionary<string, object> GNMFNNGALFB, Dictionary<string, object> IJHKNLPIKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1710", Offset = "0x5FD0310", VA = "0x185FD1710")]
		protected void HOBLDBOGHKJ(string CGGNJKGENIH, string BLKAHBIJBJO, Dictionary<string, object> ENNDPHCCPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FD15E0", Offset = "0x5FD01E0", VA = "0x185FD15E0", Slot = "5")]
		public virtual void CEKLFGPPOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FD18D0", Offset = "0x5FD04D0", VA = "0x185FD18D0", Slot = "6")]
		public virtual void NMPGCIDFACB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GHLOPGGPJLM : MKEGOKAANMB<AmplitudeAnalyticsIdentifyMessage, GHLOPGGPJLM>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override GHLOPGGPJLM KHIBJFACIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FBMGAJNNHMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4720", Offset = "0x5FD3320", VA = "0x185FD4720")]
	public GHLOPGGPJLM(AmplitudeAnalyticsIdentifyMessage COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4670", Offset = "0x5FD3270", VA = "0x185FD4670", Slot = "4")]
	public override void NMPGCIDFACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OIJCOGJFNCK : MKEGOKAANMB<AmplitudeAnalyticsEvent, OIJCOGJFNCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GCMCBHJGLLO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override OIJCOGJFNCK KHIBJFACIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x871640", Offset = "0x870240", VA = "0x180871640", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long AHBIHLMEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA5F0", Offset = "0x5FD91F0", VA = "0x185FDA5F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3970", Offset = "0x5FD2570", VA = "0x185FD3970")]
	public OIJCOGJFNCK(AmplitudeAnalyticsEvent COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "5")]
	public override AmplitudeAnalyticsEvent FBMGAJNNHMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA450", Offset = "0x5FD9050", VA = "0x185FDA450", Slot = "4")]
	public override void NMPGCIDFACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x293A1E0", Offset = "0x2938DE0", VA = "0x18293A1E0")]
	public OIJCOGJFNCK HKKJMEIELHM<T>(string FOGOAFCOGPF, T[] BLKAHBIJBJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x293A1E0", Offset = "0x2938DE0", VA = "0x18293A1E0")]
	public OIJCOGJFNCK HKKJMEIELHM(string FOGOAFCOGPF, string[] BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2939F30", Offset = "0x2938B30", VA = "0x182939F30")]
	public OIJCOGJFNCK HKKJMEIELHM<T>(string FOGOAFCOGPF, T BLKAHBIJBJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA330", Offset = "0x5FD8F30", VA = "0x185FDA330")]
	public OIJCOGJFNCK HKKJMEIELHM(string FOGOAFCOGPF, long BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA3B0", Offset = "0x5FD8FB0", VA = "0x185FDA3B0")]
	public OIJCOGJFNCK HKKJMEIELHM(string FOGOAFCOGPF, string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA420", Offset = "0x5FD9020", VA = "0x185FDA420")]
	public OIJCOGJFNCK NFCFKGLNOOK(string FOGOAFCOGPF, object? BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA290", Offset = "0x5FD8E90", VA = "0x185FDA290")]
	public OIJCOGJFNCK BDGDFJGCMCG(string FOGOAFCOGPF, string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA4F0", Offset = "0x5FD90F0", VA = "0x185FDA4F0")]
	private OIJCOGJFNCK NPLPMFCOLNI(string FOGOAFCOGPF, object BLKAHBIJBJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DKMOAJDAEPO : OIJCOGJFNCK
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3970", Offset = "0x5FD2570", VA = "0x185FD3970")]
	public DKMOAJDAEPO(AmplitudeAnalyticsEvent COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5FD37C0", Offset = "0x5FD23C0", VA = "0x185FD37C0", Slot = "4")]
	public override void NMPGCIDFACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class MKEGOKAANMB<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MKEGOKAANMB<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M COECLHOAJJF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR KHIBJFACIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public MKEGOKAANMB(M COECLHOAJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B9D0", Offset = "0x3E5A5D0", VA = "0x183E5B9D0")]
	public BLDR IFEDKKFLGBM(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NMPELOJGNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E5BA50", Offset = "0x3E5A650", VA = "0x183E5BA50")]
	public BLDR LLLHOCKCGLF(AmplitudeAnalyticsIdentifyMessage.RevenueData BBBGPCNOHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B950", Offset = "0x3E5A550", VA = "0x183E5B950")]
	public BLDR ALBFLKGHKJP(string FOGOAFCOGPF, string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x25AD5A0", Offset = "0x25AC1A0", VA = "0x1825AD5A0")]
	public BLDR ALBFLKGHKJP<T>(string FOGOAFCOGPF, T BLKAHBIJBJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NMPGCIDFACB();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E5BA20", Offset = "0x3E5A620", VA = "0x183E5BA20")]
	internal static string JFBAAHLEJEK(string BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B850", Offset = "0x3E5A450", VA = "0x183E5B850")]
	private BLDR AAGFBEJGDJO(string FOGOAFCOGPF, object BLKAHBIJBJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FBMGAJNNHMN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class OGHPFCIEBDL : JLGFDHLMHNE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct DJNICKMFGFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<JOELPFOKNLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public OGHPFCIEBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private FormUrlEncodedContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2EB0", Offset = "0x5FD1AB0", VA = "0x185FD2EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3750", Offset = "0x5FD2350", VA = "0x185FD3750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct PFHCHJLFBEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<JOELPFOKNLK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public OGHPFCIEBDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA610", Offset = "0x5FD9210", VA = "0x185FDA610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB040", Offset = "0x5FD9C40", VA = "0x185FDB040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient GKDFHAEGIFM;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA050", Offset = "0x5FD8C50", VA = "0x185FDA050")]
	[JDFNDIEGGDI(COFBNFOEGIB.None)]
	private static void IDIHJGEHGIA(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA210", Offset = "0x5FD8E10", VA = "0x185FDA210")]
	[RecRoom.NoEngine.Common.Preserve]
	public OGHPFCIEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA0C0", Offset = "0x5FD8CC0", VA = "0x185FDA0C0", Slot = "4")]
	[AsyncStateMachine(typeof(DJNICKMFGFE))]
	public Task<JOELPFOKNLK> ONPKNDLNEHJ(string NELECDMJFLK, Dictionary<string, string> LHOELAPLLIM, bool JNCLBLEJLLE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9EE0", Offset = "0x5FD8AE0", VA = "0x185FD9EE0", Slot = "5")]
	[AsyncStateMachine(typeof(PFHCHJLFBEC))]
	public Task<JOELPFOKNLK> FKIJNHFGKKN(string NELECDMJFLK, string MKMGMLMILBP, string HBLPMBMOHMP, string EIPLMAMEDJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KAEHEEBBAFH
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LBEKNPGEGOO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7C70", Offset = "0x5FD6870", VA = "0x185FD7C70")]
	internal static bool NJPLLHGFHJC(string CGGNJKGENIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JLGFDHLMHNE
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JOELPFOKNLK> ONPKNDLNEHJ(string NELECDMJFLK, Dictionary<string, string> LHOELAPLLIM, bool JNCLBLEJLLE = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JOELPFOKNLK> FKIJNHFGKKN(string NELECDMJFLK, string MKMGMLMILBP, string HBLPMBMOHMP, string EIPLMAMEDJN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JOELPFOKNLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int EPMFNAEAFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string LALJBNHGKCA;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xC4B980", Offset = "0xC4A580", VA = "0x180C4B980")]
	public JOELPFOKNLK(int NNKKENFNGIC, string MJAPHLMCKKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum IKPCGBOIIEJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IPDBGLCGHCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long OFCPDPMGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OIJCOGJFNCK BLCOAMBFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool PIPDFCCALNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float HCPCBGMBMCD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FD54C0", Offset = "0x5FD40C0", VA = "0x185FD54C0")]
	public IPDBGLCGHCD(string INOHEDGPION, float HCPCBGMBMCD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x282C910", Offset = "0x282B510", VA = "0x18282C910")]
	public void HKKJMEIELHM<T>(string FOGOAFCOGPF, T BLKAHBIJBJO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5350", Offset = "0x5FD3F50", VA = "0x185FD5350")]
	public void HKKJMEIELHM(string FOGOAFCOGPF, string BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FD53D0", Offset = "0x5FD3FD0", VA = "0x185FD53D0")]
	public void IBNGCDHGIME(string OMOMDKOOKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5130", Offset = "0x5FD3D30", VA = "0x185FD5130")]
	public void AHDFFBJBONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FD51F0", Offset = "0x5FD3DF0", VA = "0x185FD51F0")]
	private void BOPNDPCNIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5300", Offset = "0x5FD3F00", VA = "0x185FD5300")]
	private bool FHHIAOBJAGO()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum JPMGGGILIMC
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private JPMGGGILIMC parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JPMGGGILIMC Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750")]
			get
			{
				return default(JPMGGGILIMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x879630", Offset = "0x878230", VA = "0x180879630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB650", Offset = "0x5FDA250", VA = "0x185FDB650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class LLPKNJPEHEI : CPEBGKKDOBC, IOEPBMNNAND
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void PIGDLHLDABO(string CGGNJKGENIH, object BLKAHBIJBJO, bool EPOOBNNHCEA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly PFMHKEIJELF EKCHLBHMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly PIGDLHLDABO JACOCHDLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly string FGEPBAMLHJB;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KNHBEFIGINN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10A0DB0", Offset = "0x109F9B0", VA = "0x1810A0DB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LMGIOCJKMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9360", Offset = "0x5FD7F60", VA = "0x185FD9360", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MGNNKAIGFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5FD9380", Offset = "0x5FD7F80", VA = "0x185FD9380", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> EFJBKBOCNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10A0EE0", Offset = "0x109FAE0", VA = "0x1810A0EE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5FD93A0", Offset = "0x5FD7FA0", VA = "0x185FD93A0")]
	public LLPKNJPEHEI(PFMHKEIJELF LCKLFNLGOKK, string CFJCHOMLCOA, [Optional] PIGDLHLDABO GCMPDCGFLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2880CB0", Offset = "0x287F8B0", VA = "0x182880CB0", Slot = "8")]
	public T CPPPHMALPOD<T>(string CGGNJKGENIH, T FCKGAANHHID)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JJLIFCJECBB : HIGGBJHAIJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FLPJAJDFHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public JJLIFCJECBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public CGBNIGLGOJM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3FD0", Offset = "0x5FD2BD0", VA = "0x185FD3FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4450", Offset = "0x5FD3050", VA = "0x185FD4450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CNOLMBFOHPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1D60", Offset = "0x5FD0960", VA = "0x185FD1D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1F70", Offset = "0x5FD0B70", VA = "0x185FD1F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct KOCHBPCKMGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public JJLIFCJECBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CGBNIGLGOJM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7E20", Offset = "0x5FD6A20", VA = "0x185FD7E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD80E0", Offset = "0x5FD6CE0", VA = "0x185FD80E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct PJJOLLHCHAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public JJLIFCJECBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public CGBNIGLGOJM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB0B0", Offset = "0x5FD9CB0", VA = "0x185FDB0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB480", Offset = "0x5FDA080", VA = "0x185FDB480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ELDLAIJKCNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public JJLIFCJECBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public string experimentName;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public ELDLAIJKCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3E10", Offset = "0x5FD2A10", VA = "0x185FD3E10")]
		internal void MFDFHAGAFIA(string key, object value, bool hasOverride)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class HPAEILFILNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public JJLIFCJECBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public ENJDNONEGMG layer;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public HPAEILFILNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5FD50E0", Offset = "0x5FD3CE0", VA = "0x185FD50E0")]
		internal void POIFBMLBDLI(string key, object value, bool hasOverride)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly IReadOnlyDictionary<string, IMMCELLOLPN> DIBGOMLFLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool FFGBODGFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HIBLOMCALBE AKHEGLKKIJE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string IGILMJCBHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5FC0", Offset = "0x5FD4BC0", VA = "0x185FD5FC0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FPPJDKAIPML ABAECBIFGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7460", Offset = "0x5FD6060", VA = "0x185FD7460", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BNLDGEBACCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6F60", Offset = "0x5FD5B60", VA = "0x185FD6F60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7A00", Offset = "0x5FD6600", VA = "0x185FD7A00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action CKFPJHHKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6D70", Offset = "0x5FD5970", VA = "0x185FD6D70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6E10", Offset = "0x5FD5A10", VA = "0x185FD6E10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<string, string, object, bool> CLAPGFAGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5FD68E0", Offset = "0x5FD54E0", VA = "0x185FD68E0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5F10", Offset = "0x5FD4B10", VA = "0x185FD5F10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<string, string, object, bool> PPKGDPAHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6EB0", Offset = "0x5FD5AB0", VA = "0x185FD6EB0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5FD71F0", Offset = "0x5FD5DF0", VA = "0x185FD71F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7000", Offset = "0x5FD5C00", VA = "0x185FD7000", Slot = "12")]
	[AsyncStateMachine(typeof(FLPJAJDFHCM))]
	public Task HAJAGMDCLHL(string LPNBHEJOLIF, string LCCFFCEPJIF, [Optional] CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7140", Offset = "0x5FD5D40", VA = "0x185FD7140", Slot = "21")]
	[AsyncStateMachine(typeof(CNOLMBFOHPD))]
	public Task IBDOIEDDAFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7500", Offset = "0x5FD6100", VA = "0x185FD7500", Slot = "16")]
	[AsyncStateMachine(typeof(KOCHBPCKMGG))]
	public Task LCIBHMDILAI(CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6B50", Offset = "0x5FD5750", VA = "0x185FD6B50", Slot = "17")]
	[AsyncStateMachine(typeof(PJJOLLHCHAK))]
	public Task CJKPEILDJLD(CGBNIGLGOJM GFPEKPHBLHB, Dictionary<string, string> FCLAJCGNMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7970", Offset = "0x5FD6570", VA = "0x185FD7970", Slot = "18")]
	public bool OJGLLFJMFBM(string FMCJNJFLIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FD75F0", Offset = "0x5FD61F0", VA = "0x185FD75F0", Slot = "19")]
	public CPEBGKKDOBC LGECCJEHHPL(string CFJCHOMLCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6990", Offset = "0x5FD5590", VA = "0x185FD6990")]
	private PFMHKEIJELF CCDIAGDMBGC(string CFJCHOMLCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5FD72A0", Offset = "0x5FD5EA0", VA = "0x185FD72A0", Slot = "20")]
	public GFAHGLKNGMN KDAIIHLCFMO(string BANFCDLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7AA0", Offset = "0x5FD66A0", VA = "0x185FD7AA0")]
	private ENJDNONEGMG PLCOCHNIJKD(string BANFCDLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5FD0", Offset = "0x5FD4BD0", VA = "0x185FD5FD0")]
	private AGHMIBGMMKF BEGHHGDPEKE(CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5FD77C0", Offset = "0x5FD63C0", VA = "0x185FD77C0")]
	private GOLBKHLIIHD MIGIHAOFPLO(string LCCFFCEPJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6C60", Offset = "0x5FD5860", VA = "0x185FD6C60")]
	private void COKFKDOINCC(string CFJCHOMLCOA, PFMHKEIJELF LCKLFNLGOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JJLIFCJECBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DDKKHPJMBBM : HIGGBJHAIJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct LANPEOBJIGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public DDKKHPJMBBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CGBNIGLGOJM userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8140", Offset = "0x5FD6D40", VA = "0x185FD8140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8890", Offset = "0x5FD7490", VA = "0x185FD8890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private HIGGBJHAIJL NJHPOJHGIEI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HIGGBJHAIJL GBBJIHOCAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2CF0", Offset = "0x5FD18F0", VA = "0x185FD2CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2A40", Offset = "0x5FD1640", VA = "0x185FD2A40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string IGILMJCBHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2080", Offset = "0x5FD0C80", VA = "0x185FD2080", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FPPJDKAIPML ABAECBIFGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2980", Offset = "0x5FD1580", VA = "0x185FD2980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BNLDGEBACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2490", Offset = "0x5FD1090", VA = "0x185FD2490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2E10", Offset = "0x5FD1A10", VA = "0x185FD2E10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action CKFPJHHKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5FD22A0", Offset = "0x5FD0EA0", VA = "0x185FD22A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2340", Offset = "0x5FD0F40", VA = "0x185FD2340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<string, string, object, bool> CLAPGFAGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD20D0", Offset = "0x5FD0CD0", VA = "0x185FD20D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1FD0", Offset = "0x5FD0BD0", VA = "0x185FD1FD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<string, string, object, bool> PPKGDPAHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD23E0", Offset = "0x5FD0FE0", VA = "0x185FD23E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2820", Offset = "0x5FD1420", VA = "0x185FD2820", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[UnityEngine.Scripting.Preserve]
	public DDKKHPJMBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2AC0", Offset = "0x5FD16C0", VA = "0x185FD2AC0")]
	[JDFNDIEGGDI(COFBNFOEGIB.GameOnly)]
	private static void KPHMLLKABCG(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2530", Offset = "0x5FD1130", VA = "0x185FD2530")]
	[JDFNDIEGGDI(COFBNFOEGIB.EditorOnly)]
	private static void HADPKOKNAHM(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD25A0", Offset = "0x5FD11A0", VA = "0x185FD25A0", Slot = "12")]
	[AsyncStateMachine(typeof(LANPEOBJIGC))]
	public Task HAJAGMDCLHL(string LPNBHEJOLIF, string LCCFFCEPJIF, [Optional] CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2B30", Offset = "0x5FD1730", VA = "0x185FD2B30", Slot = "16")]
	public Task LCIBHMDILAI(CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2180", Offset = "0x5FD0D80", VA = "0x185FD2180", Slot = "17")]
	public Task CJKPEILDJLD(CGBNIGLGOJM GFPEKPHBLHB, Dictionary<string, string> FCLAJCGNMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2D60", Offset = "0x5FD1960", VA = "0x185FD2D60", Slot = "18")]
	public bool OJGLLFJMFBM(string FMCJNJFLIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2C40", Offset = "0x5FD1840", VA = "0x185FD2C40", Slot = "19")]
	public CPEBGKKDOBC LGECCJEHHPL(string CFJCHOMLCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5FD28D0", Offset = "0x5FD14D0", VA = "0x185FD28D0", Slot = "20")]
	public GFAHGLKNGMN KDAIIHLCFMO(string BANFCDLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5FD26E0", Offset = "0x5FD12E0", VA = "0x185FD26E0", Slot = "21")]
	public Task IBDOIEDDAFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAF0", Offset = "0x7FA6F0", VA = "0x1807FBAF0")]
	[CompilerGenerated]
	private void NODBJABCIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x823220", Offset = "0x821E20", VA = "0x180823220")]
	[CompilerGenerated]
	private void PIGFLLPFMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2A90", Offset = "0x5FD1690", VA = "0x185FD2A90")]
	[CompilerGenerated]
	private void KPBELNPCNAL(string MPGNMPAPHDB, string CGGNJKGENIH, object BLKAHBIJBJO, bool EPOOBNNHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD27F0", Offset = "0x5FD13F0", VA = "0x185FD27F0")]
	[CompilerGenerated]
	private void IMFNCJGKBIK(string MPGNMPAPHDB, string CGGNJKGENIH, object BLKAHBIJBJO, bool EPOOBNNHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class OFENEAIDKCF : GFAHGLKNGMN, IOEPBMNNAND
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void FKOMBNCOBBA(string CGGNJKGENIH, object BLKAHBIJBJO, bool EPOOBNNHCEA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly FKOMBNCOBBA JACOCHDLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly ENJDNONEGMG PBNBHDDOKHO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string KNHBEFIGINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1A4E0C0", Offset = "0x1A4CCC0", VA = "0x181A4E0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x536B4E0", Offset = "0x536A0E0", VA = "0x18536B4E0")]
	public OFENEAIDKCF(ENJDNONEGMG LCLEPNJJEPM, [Optional] FKOMBNCOBBA GCMPDCGFLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2935400", Offset = "0x2934000", VA = "0x182935400", Slot = "5")]
	public T CPPPHMALPOD<T>(string CGGNJKGENIH, T FCKGAANHHID)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OJNCOAPCPCB
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class LIBGOGEEHGL : OJNCOAPCPCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly PDLGPIFCDNF KPAFKFDMCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly List<NAKOHPPJIMJ> MOFBIHKPOJF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5FD91F0", Offset = "0x5FD7DF0", VA = "0x185FD91F0")]
	[JDFNDIEGGDI(EEILJHHLCPL.Session, COFBNFOEGIB.GameOnly)]
	[UsedImplicitly]
	private static void NOGKHDMNIHD(OJEGDOKHPNO JEAKPHJODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9260", Offset = "0x5FD7E60", VA = "0x185FD9260")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LIBGOGEEHGL([NotNull][NNEMKPMNJAE(null)] PDLGPIFCDNF KPAFKFDMCJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JHELPNCCIGI : HIGGBJHAIJL
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool OANKOMELEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string IGILMJCBHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FPPJDKAIPML ABAECBIFGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action BNLDGEBACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5A30", Offset = "0x5FD4630", VA = "0x185FD5A30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5E70", Offset = "0x5FD4A70", VA = "0x185FD5E70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action CKFPJHHKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5840", Offset = "0x5FD4440", VA = "0x185FD5840", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD58E0", Offset = "0x5FD44E0", VA = "0x185FD58E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<string, string, object, bool> CLAPGFAGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5700", Offset = "0x5FD4300", VA = "0x185FD5700", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5650", Offset = "0x5FD4250", VA = "0x185FD5650", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<string, string, object, bool> PPKGDPAHEHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5980", Offset = "0x5FD4580", VA = "0x185FD5980", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5FD5BF0", Offset = "0x5FD47F0", VA = "0x185FD5BF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	[RecRoom.NoEngine.Common.Preserve]
	public JHELPNCCIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5AD0", Offset = "0x5FD46D0", VA = "0x185FD5AD0", Slot = "12")]
	public Task HAJAGMDCLHL(string LPNBHEJOLIF, string LCCFFCEPJIF, [Optional] CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5D30", Offset = "0x5FD4930", VA = "0x185FD5D30", Slot = "16")]
	public Task LCIBHMDILAI(CGBNIGLGOJM GFPEKPHBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5FD57B0", Offset = "0x5FD43B0", VA = "0x185FD57B0", Slot = "17")]
	public Task CJKPEILDJLD(CGBNIGLGOJM GFPEKPHBLHB, Dictionary<string, string> FCLAJCGNMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "18")]
	public bool OJGLLFJMFBM(string FMCJNJFLIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5DC0", Offset = "0x5FD49C0", VA = "0x185FD5DC0", Slot = "19")]
	public CPEBGKKDOBC LGECCJEHHPL(string CFJCHOMLCOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5CA0", Offset = "0x5FD48A0", VA = "0x185FD5CA0", Slot = "20")]
	public GFAHGLKNGMN KDAIIHLCFMO(string BANFCDLOHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5B60", Offset = "0x5FD4760", VA = "0x185FD5B60", Slot = "21")]
	public Task IBDOIEDDAFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class HIBLOMCALBE : FPPJDKAIPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly AGHMIBGMMKF AKHEGLKKIJE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> CIGKPHIIJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x10A11B0", Offset = "0x109FDB0", VA = "0x1810A11B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
	public HIBLOMCALBE(AGHMIBGMMKF PDOCIKMKNAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BEJBMMEFJIB
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPDBGLCGHCD KILENEHCIII(string INOHEDGPION);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CAAKFJJOJHB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum EMPCCHFBCGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long NPODABNLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string HOLHBCCKDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string LLABPOMKMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string LOKKLDPJJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string NGJECMDBAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool GOOONMNJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long PAJBFJIAGMB();

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COEEAIJDPMM(long GFAPMFNAAFO, bool BAIAGGBGCCI = true);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCGEJBJGBIJ(string LAMCDJBBCDK, string EFEEDBFBEPD, string JKMKEAKDBDG);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FAHFCOBNEAG(string LAMCDJBBCDK);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GKHBCEBCCOG(string LAMCDJBBCDK, string JKOADEEIPIA, string JGCAIBKDPML);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LAAOKMMFEFP(string KHJIEAFENDF, object DOCKKEBPDEC, object CIFPMONBNPK);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOLFGJPFGJI(EMPCCHFBCGL IHOMENHANIJ, int AIMJKOABHLL, [Optional] LKGOILFFEBB IMGGOAJMGDJ, [Optional] string NHFFLDDFDCN, [Optional] string JDDBJGCFGMI);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LACGMBBLBON(LKGOILFFEBB IMGGOAJMGDJ, long FDPKJLPEALK, long BLPCDMFPACP, int IEFCJNHGOKD, string NHFFLDDFDCN, int AIMJKOABHLL);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KFCKCFHIEFJ(LKGOILFFEBB IMGGOAJMGDJ, bool DHFBKAPIONA, [Optional] string JDDBJGCFGMI);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LLMHNOHKGDC(LKGOILFFEBB IMGGOAJMGDJ, bool DHFBKAPIONA, [Optional] string JDDBJGCFGMI);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BBGOBELNLPF(LKGOILFFEBB IMGGOAJMGDJ, bool DHFBKAPIONA, [Optional] string JDDBJGCFGMI);
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
