using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AmplitudeAnalytics;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using UnityEngine;
using UnityEngine.Networking;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A25320", Offset = "0x6A23D20", VA = "0x186A25320")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A277F0", Offset = "0x6A261F0", VA = "0x186A277F0", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
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
		public AmplitudeAnalyticsClient.Settings BMPLJOMCPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FDDILBCKLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x891450", Offset = "0x88FE50", VA = "0x180891450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum MKNEDEGOAEP
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class GNKFFCKFFGI
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class BBJPNGCMNFP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int OENMJPLKAAF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> CJIAKLBOIBJ;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public BBJPNGCMNFP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class MBLKMAFHFOE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
				public MBLKMAFHFOE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6A24630", Offset = "0x6A23030", VA = "0x186A24630")]
				internal bool OFDGFADDDKE(BBJPNGCMNFP item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string KCLGLHPJAAC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string FNGJKHBMPIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<BBJPNGCMNFP> KMAHJBENEMF;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? DAMKHOIPOFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6A205F0", Offset = "0x6A1EFF0", VA = "0x186A205F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6A20690", Offset = "0x6A1F090", VA = "0x186A20690")]
			internal GNKFFCKFFGI(string MFPPDJOIBHB, string DLMGJHEHIOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6A201C0", Offset = "0x6A1EBC0", VA = "0x186A201C0")]
			public int MBFPMHPICPJ([Optional] int? FHOHMFGILFB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F9B0", Offset = "0x6A1E3B0", VA = "0x186A1F9B0")]
			public List<Dictionary<string, object>> DDCKGCJJMJK(int KFDMDBHILHL, int? FHOHMFGILFB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6A20010", Offset = "0x6A1EA10", VA = "0x186A20010")]
			public void KDDABMKLJMB(AmplitudeAnalyticsIdentifyMessage GIGIFGONEAO, bool AIJEIBEEBMJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6A200B0", Offset = "0x6A1EAB0", VA = "0x186A200B0")]
			public void KDDABMKLJMB(Dictionary<string, object> GIGIFGONEAO, bool AIJEIBEEBMJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A20370", Offset = "0x6A1ED70", VA = "0x186A20370")]
			public void MPHOGBBJBJG(params Dictionary<string, object>[] CDBICIOBLAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F770", Offset = "0x6A1E170", VA = "0x186A1F770")]
			public void CNLCMALMECK(List<Dictionary<string, object>> EJAKGMMEBKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A204F0", Offset = "0x6A1EEF0", VA = "0x186A204F0")]
			private void ODBLBAPAFOD(Dictionary<string, object> GIGIFGONEAO, bool AIJEIBEEBMJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F570", Offset = "0x6A1DF70", VA = "0x186A1F570")]
			public void BNLDAODMLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6A1FC20", Offset = "0x6A1E620", VA = "0x186A1FC20")]
			private void FDLOEEBDHMK([Optional] string HAMNIHMLMIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F450", Offset = "0x6A1DE50", VA = "0x186A1F450")]
			private static string BGDHMCLCPGG(string CLMKDBDPNNH, string JODEIIFHAPK)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6A27410", Offset = "0x6A25E10", VA = "0x186A27410")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct PGCFIHNPIDO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int JNKFKNAOPEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string HFNLNGHILNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T NDMINKCJKML;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NALJOMAKNDA : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public NALJOMAKNDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6A24B60", Offset = "0x6A23560", VA = "0x186A24B60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A252D0", Offset = "0x6A23CD0", VA = "0x186A252D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OKNJLHNCKOM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public EOBCPEOLCKN quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public OKNJLHNCKOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6A25E60", Offset = "0x6A24860", VA = "0x186A25E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6A25F70", Offset = "0x6A24970", VA = "0x186A25F70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class JPCAPPJFHPO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006D")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public JPCAPPJFHPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6A21490", Offset = "0x6A1FE90", VA = "0x186A21490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6A21600", Offset = "0x6A20000", VA = "0x186A21600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KJODCPCKPPB : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public KJODCPCKPPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6A21C10", Offset = "0x6A20610", VA = "0x186A21C10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A21E70", Offset = "0x6A20870", VA = "0x186A21E70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class FPOIGNHAGII : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public FPOIGNHAGII(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F1B0", Offset = "0x6A1DBB0", VA = "0x186A1F1B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F400", Offset = "0x6A1DE00", VA = "0x186A1F400", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class BFHIPCPIPGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GNKFFCKFFGI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public BFHIPCPIPGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6A1C380", Offset = "0x6A1AD80", VA = "0x186A1C380")]
			internal void LGLFEGMMDFL(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6A1BF40", Offset = "0x6A1A940", VA = "0x186A1BF40")]
			internal void HFEDGGEDJAB(PGCFIHNPIDO<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JNAFGEHLPLN : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GNKFFCKFFGI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private BFHIPCPIPGP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public JNAFGEHLPLN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A20C30", Offset = "0x6A1F630", VA = "0x186A20C30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A21440", Offset = "0x6A1FE40", VA = "0x186A21440", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class GFMMCFLIFJB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public GFMMCFLIFJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3E0DF30", Offset = "0x3E0C930", VA = "0x183E0DF30")]
			internal PGCFIHNPIDO<T> JNOKCDANMMH(PPPEHIKEDAA postResponse)
			{
				return default(PGCFIHNPIDO<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private HGJBNCNJFDG DHOBFHELKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<INEBAIGJMLF> NABPFFCHHMG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string IDGIFHICCKC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string KALEJEGLGGI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string OLICGEHIDMK = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CJEHIBOIEAO = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int NHLBAOILJHE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int GBABNDLGFON = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float MLEIJPACPJL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long GJACPHMAOIE = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string ANNJODONILB = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string MAOHNAIFDLI = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string HOCKKIEGMAL = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string BLIAAHABGGF = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool PFKBGDKHHAC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool JLHKIMDNGNH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int LMHECDHBEBK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int ONHIGIEHGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PBBBIHLGGAG FFLLEKOODAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DEJALLNNAMD JONNKJILOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LEOKDMFNADP PFNPNFEKNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool AJEBGLOHFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LCADJIMKKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float HKKMIKDAJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int IIBKCACFHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int HGIDHJBIGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? MMEDEGLLLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? BCMPDFDDFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long OCONBAPLBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string KOOKCMBGJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string GLCGJBDHNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long OMNAGKEIEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string FBPGLPFJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string AJKPJKJBICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> FEBDAHMFBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MKNEDEGOAEP KFKLPEHPPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int EFHLLEBFAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int GCEJKAMDIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float INFJNMPNMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool KPKCKKOPBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool PEDDOIBGOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GNKFFCKFFGI HOHMBBIBOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private GNKFFCKFFGI EEGFHHBCNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private GNKFFCKFFGI KKHGIMLCPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string EOKPDCNIKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> DCJGADHBMNE;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JMLIGPCNIJM;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string DEBKGKEHKFC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string FFBCBLKDJJL = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string NJGNMHBLJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string OIOLLFEPENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string CGJEFKHAHFE;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HGJBNCNJFDG JNKFGHNDAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6A15CF0", Offset = "0x6A146F0", VA = "0x186A15CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private INEBAIGJMLF DFPAHOOCKPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6A17CC0", Offset = "0x6A166C0", VA = "0x186A17CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BIOEEIOBEKB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6A17310", Offset = "0x6A15D10", VA = "0x186A17310")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long IOBGHBDOEPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A860", Offset = "0x6A19260", VA = "0x186A1A860")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A970", Offset = "0x6A19370", VA = "0x186A1A970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string NNEDGFECCPH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A830", Offset = "0x6A19230", VA = "0x186A1A830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FBGDPBDMEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CEEE0", Offset = "0x8CD8E0", VA = "0x1808CEEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD17B70", Offset = "0xD16570", VA = "0x180D17B70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? BLHCMIAHDGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA3E420", Offset = "0xA3CE20", VA = "0x180A3E420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1901130", Offset = "0x18FFB30", VA = "0x181901130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JADHJICFINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x12E2C20", Offset = "0x12E1620", VA = "0x1812E2C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x130D3B0", Offset = "0x130BDB0", VA = "0x18130D3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool GGEIHIJNHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A700", Offset = "0x6A19100", VA = "0x186A1A700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> FINHILIGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A640", Offset = "0x6A19040", VA = "0x186A1A640")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6A1A8B0", Offset = "0x6A192B0", VA = "0x186A1A8B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A14FB0", Offset = "0x6A139B0", VA = "0x186A14FB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A14A40", Offset = "0x6A13440", VA = "0x186A14A40")]
		private void AKNJCFJGAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A19C90", Offset = "0x6A18690", VA = "0x186A19C90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A17B10", Offset = "0x6A16510", VA = "0x186A17B10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A19FB0", Offset = "0x6A189B0", VA = "0x186A19FB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6A189E0", Offset = "0x6A173E0", VA = "0x186A189E0")]
		public MFAPHLCBHHA PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A168A0", Offset = "0x6A152A0", VA = "0x186A168A0")]
		[IteratorStateMachine(typeof(NALJOMAKNDA))]
		public IEnumerator<IHLHBLBKNMF> InitializeForLocalAccount(AmplitudeAnalyticsEvent EFPFJOKJAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A19360", Offset = "0x6A17D60", VA = "0x186A19360")]
		public void SendAppEnterEvent(bool CFGGGIIDNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A19F30", Offset = "0x6A18930", VA = "0x186A19F30")]
		public void UpdateLastKnownInteractionCategory(string HAGKECDCPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A19E80", Offset = "0x6A18880", VA = "0x186A19E80")]
		public void UpdateLastAliveTime(float OMPPDBKHEPB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A16200", Offset = "0x6A14C00", VA = "0x186A16200")]
		private MFAPHLCBHHA GLAOPKBIMAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A159B0", Offset = "0x6A143B0", VA = "0x186A159B0")]
		private MFAPHLCBHHA DMNHNMLAJOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A19670", Offset = "0x6A18070", VA = "0x186A19670")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A17170", Offset = "0x6A15B70", VA = "0x186A17170")]
		[IteratorStateMachine(typeof(OKNJLHNCKOM))]
		private IEnumerator NIMAIKCDBJL(EOBCPEOLCKN FDDPENKEKNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A240", Offset = "0x6A18C40", VA = "0x186A1A240")]
		[IteratorStateMachine(typeof(JPCAPPJFHPO))]
		public IEnumerator WaitForFlush(float FDABJAMIIEL = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A19D60", Offset = "0x6A18760", VA = "0x186A19D60")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A19CA0", Offset = "0x6A186A0", VA = "0x186A19CA0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MNHDOCAHHMO)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A163A0", Offset = "0x6A14DA0", VA = "0x186A163A0")]
		public static ADHJHBKKJHP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A14E00", Offset = "0x6A13800", VA = "0x186A14E00")]
		public static KMKLNFFCCMG AccountSelectionPostLoginEvent([NotNull] string CMBBAIEHAAF, string OJALFDDIFCK, AJJGLGCKMHP EEHLIGOOLMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A15DD0", Offset = "0x6A147D0", VA = "0x186A15DD0")]
		public static KMKLNFFCCMG Event([NotNull] string CMBBAIEHAAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A18B70", Offset = "0x6A17570", VA = "0x186A18B70")]
		public static KMKLNFFCCMG PreviousSessionEvent([NotNull] string CMBBAIEHAAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A16540", Offset = "0x6A14F40", VA = "0x186A16540")]
		public static KMKLNFFCCMG InitializeEvent(string OJALFDDIFCK, int GHLFHLBGBFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A19870", Offset = "0x6A18270", VA = "0x186A19870")]
		public static KMKLNFFCCMG StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A156F0", Offset = "0x6A140F0", VA = "0x186A156F0")]
		public static KMKLNFFCCMG CreateOutOfSessionEvent(string CMBBAIEHAAF, bool KHCNCDMBLJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A16C30", Offset = "0x6A15630", VA = "0x186A16C30")]
		public static MFAPHLCBHHA LogOutOfSessionEvent(KMKLNFFCCMG KODPJBIOJDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A169D0", Offset = "0x6A153D0", VA = "0x186A169D0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent FCGHOJIKKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A16E00", Offset = "0x6A15800", VA = "0x186A16E00")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent FCGHOJIKKKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A16F30", Offset = "0x6A15930", VA = "0x186A16F30")]
		public void LogSerializedEventAsync(Dictionary<string, object> ELFFFDIEGPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6A16B00", Offset = "0x6A15500", VA = "0x186A16B00")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CAHJNMBKMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A17BC0", Offset = "0x6A165C0", VA = "0x186A17BC0")]
		private void PIEJCDENBEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A17850", Offset = "0x6A16250", VA = "0x186A17850")]
		private void OKBKJPBHGNF(Dictionary<string, object> BLCAHGBMEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A162B0", Offset = "0x6A14CB0", VA = "0x186A162B0")]
		private void HHFLKANEKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A15B20", Offset = "0x6A14520", VA = "0x186A15B20")]
		private void DPLHABABDFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A16170", Offset = "0x6A14B70", VA = "0x186A16170")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A16940", Offset = "0x6A15340", VA = "0x186A16940")]
		[IteratorStateMachine(typeof(KJODCPCKPPB))]
		private IEnumerator<IHLHBLBKNMF> KNKJCGPKHOL(float FDABJAMIIEL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A160E0", Offset = "0x6A14AE0", VA = "0x186A160E0")]
		[IteratorStateMachine(typeof(FPOIGNHAGII))]
		private IEnumerator<IHLHBLBKNMF> FDBPFLLBFGE(float FDABJAMIIEL = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A15610", Offset = "0x6A14010", VA = "0x186A15610")]
		[IteratorStateMachine(typeof(JNAFGEHLPLN))]
		private IEnumerator<IHLHBLBKNMF> BEONODLHLNN(GNKFFCKFFGI INKPCFGBNLA, int? FHOHMFGILFB, string CIHJAFBLEMN, float FDABJAMIIEL, Action<int> NPIOEMLOHNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A17200", Offset = "0x6A15C00", VA = "0x186A17200")]
		private static void NNACJFPCDLK(bool CJLMNFFIAOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A17780", Offset = "0x6A16180", VA = "0x186A17780")]
		private CAPIMDIPLHM<PGCFIHNPIDO<Dictionary<string, object>>> OBBMCJKAPON(string CIHJAFBLEMN, string DJGALHFJGHO, Dictionary<string, object> NDMINKCJKML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A17510", Offset = "0x6A15F10", VA = "0x186A17510")]
		private CAPIMDIPLHM<PGCFIHNPIDO<List<Dictionary<string, object>>>> OBBMCJKAPON(string CIHJAFBLEMN, string DJGALHFJGHO, List<Dictionary<string, object>> NDMINKCJKML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x33B0E80", Offset = "0x33AF880", VA = "0x1833B0E80")]
		private CAPIMDIPLHM<PGCFIHNPIDO<T>> AMGOKOOGPHM<T>(string CEIOMGECOAE, string CIHJAFBLEMN, string DJGALHFJGHO, T NDMINKCJKML, Dictionary<string, object> MELPGMAFGFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A15D80", Offset = "0x6A14780", VA = "0x186A15D80")]
		private bool EBONBJKODHB(float HLDGEKPMJKO, float FDABJAMIIEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A17D10", Offset = "0x6A16710", VA = "0x186A17D10")]
		private Dictionary<string, object> POHDEFKDEPG(string CIHJAFBLEMN, Dictionary<string, object> NDMINKCJKML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A330", Offset = "0x6A18D30", VA = "0x186A1A330")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A17010", Offset = "0x6A15A10", VA = "0x186A17010")]
		[CompilerGenerated]
		private long MDIHNKNALMO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A16930", Offset = "0x6A15330", VA = "0x186A16930")]
		[CompilerGenerated]
		private void JGADOLIOLHB(int PILHIIECBAH)
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
		private readonly string assignedUserCrm;

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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B660", Offset = "0x6A1A060", VA = "0x186A1B660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B730", Offset = "0x6A1A130", VA = "0x186A1B730")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B6A0", Offset = "0x6A1A0A0", VA = "0x186A1B6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B780", Offset = "0x6A1A180", VA = "0x186A1B780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B620", Offset = "0x6A1A020", VA = "0x186A1B620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6A1B6E0", Offset = "0x6A1A0E0", VA = "0x186A1B6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x88E810", Offset = "0x88D210", VA = "0x18088E810")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1ACB0", Offset = "0x6A196B0", VA = "0x186A1ACB0")]
		public static KMKLNFFCCMG IFAFEFDLIPC(string DHAIIPINBBD, [NotNull] string CPNMNFEEDIG, long HEJPJBAPELP, long DAGJBMILDHF, string OJALFDDIFCK, string EEHLIGOOLMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AB50", Offset = "0x6A19550", VA = "0x186A1AB50")]
		public static KMKLNFFCCMG EKGHAFFMFAK(string DHAIIPINBBD, [NotNull] string CPNMNFEEDIG, long HEJPJBAPELP, long DAGJBMILDHF, string OJALFDDIFCK, long GPDILEFMIEP, string PMKLBBFKCEE, string OIGACNDLEDG, string CCEGPCAFMEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B480", Offset = "0x6A19E80", VA = "0x186A1B480")]
		private AmplitudeAnalyticsEvent(string DHAIIPINBBD, [NotNull] string CPNMNFEEDIG, long HEJPJBAPELP, long DAGJBMILDHF, string OJALFDDIFCK, string EEHLIGOOLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1EFA710", Offset = "0x1EF9110", VA = "0x181EFA710")]
		public void JEAPOHEGCJB(long IENOHHJJOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A1ADB0", Offset = "0x6A197B0", VA = "0x186A1ADB0", Slot = "5")]
		public override void JFNPEJGBIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A9D0", Offset = "0x6A193D0", VA = "0x186A1A9D0", Slot = "6")]
		public override void CINKPDPAHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AEB0", Offset = "0x6A198B0", VA = "0x186A1AEB0", Slot = "4")]
		protected override Dictionary<string, object> JKJDIMAKBLA(Dictionary<string, object> LEGBFNJMPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B370", Offset = "0x6A19D70", VA = "0x186A1B370")]
		private void NAAFMFFMAKG(string JODEIIFHAPK, string CLMKDBDPNNH, bool MNJDDJDNLGN = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6A1EE90", Offset = "0x6A1D890", VA = "0x186A1EE90")]
			public void DKOAAKNFBBF(Dictionary<string, object> BADGDOAJEDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6A27090", Offset = "0x6A25A90", VA = "0x186A27090")]
			public void DKOAAKNFBBF(Dictionary<string, object> AKBNGPDGJDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC4B360", Offset = "0xC49D60", VA = "0x180C4B360")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B8F0", Offset = "0x6A1A2F0", VA = "0x186A1B8F0")]
		public static ADHJHBKKJHP IFAFEFDLIPC(string DHAIIPINBBD, string OJALFDDIFCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BE80", Offset = "0x6A1A880", VA = "0x186A1BE80")]
		protected AmplitudeAnalyticsIdentifyMessage(string DHAIIPINBBD, string OJALFDDIFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BDF0", Offset = "0x6A1A7F0", VA = "0x186A1BDF0")]
		public Dictionary<string, object> LONOKLEKLEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BA40", Offset = "0x6A1A440", VA = "0x186A1BA40", Slot = "4")]
		protected virtual Dictionary<string, object> JKJDIMAKBLA(Dictionary<string, object> LEGBFNJMPDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B850", Offset = "0x6A1A250", VA = "0x186A1B850")]
		protected void EEIKLEBBJAP(string JODEIIFHAPK, Dictionary<string, object> JAEDECPNPOB, Dictionary<string, object> CLHNEJCNNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BD80", Offset = "0x6A1A780", VA = "0x186A1BD80")]
		protected void LIOMLPMBACC(string JODEIIFHAPK, string CLMKDBDPNNH, Dictionary<string, object> LLONIOCMDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B9B0", Offset = "0x6A1A3B0", VA = "0x186A1B9B0", Slot = "5")]
		public virtual void JFNPEJGBIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B7D0", Offset = "0x6A1A1D0", VA = "0x186A1B7D0", Slot = "6")]
		public virtual void CINKPDPAHFN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ADHJHBKKJHP : JHFHDJEPEKA<AmplitudeAnalyticsIdentifyMessage, ADHJHBKKJHP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override ADHJHBKKJHP EFBGJAJHOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage DPHGIHPFCNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A14710", Offset = "0x6A13110", VA = "0x186A14710")]
	public ADHJHBKKJHP(AmplitudeAnalyticsIdentifyMessage MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A14670", Offset = "0x6A13070", VA = "0x186A14670", Slot = "4")]
	public override void CINKPDPAHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KMKLNFFCCMG : JHFHDJEPEKA<AmplitudeAnalyticsEvent, KMKLNFFCCMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool HBNOPLOFCHI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override KMKLNFFCCMG EFBGJAJHOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long HLKPPGPCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A22000", Offset = "0x6A20A00", VA = "0x186A22000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A14910", Offset = "0x6A13310", VA = "0x186A14910")]
	public KMKLNFFCCMG(AmplitudeAnalyticsEvent MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "5")]
	public override AmplitudeAnalyticsEvent DPHGIHPFCNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A21EC0", Offset = "0x6A208C0", VA = "0x186A21EC0", Slot = "4")]
	public override void CINKPDPAHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D37190", Offset = "0x2D35B90", VA = "0x182D37190")]
	public KMKLNFFCCMG IIGBAGNCBDB<T>(string FMKCBFNEFEH, T[] CLMKDBDPNNH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D37190", Offset = "0x2D35B90", VA = "0x182D37190")]
	public KMKLNFFCCMG IIGBAGNCBDB(string FMKCBFNEFEH, string[] CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D36EE0", Offset = "0x2D358E0", VA = "0x182D36EE0")]
	public KMKLNFFCCMG IIGBAGNCBDB<T>(string FMKCBFNEFEH, T CLMKDBDPNNH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A22090", Offset = "0x6A20A90", VA = "0x186A22090")]
	public KMKLNFFCCMG IIGBAGNCBDB(string FMKCBFNEFEH, long CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A22020", Offset = "0x6A20A20", VA = "0x186A22020")]
	public KMKLNFFCCMG IIGBAGNCBDB(string FMKCBFNEFEH, string CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A22110", Offset = "0x6A20B10", VA = "0x186A22110")]
	public KMKLNFFCCMG KOADGPINPPI(string FMKCBFNEFEH, object? CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A21F60", Offset = "0x6A20960", VA = "0x186A21F60")]
	public KMKLNFFCCMG FCKMPHBHGGJ(string FMKCBFNEFEH, string CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A22140", Offset = "0x6A20B40", VA = "0x186A22140")]
	private KMKLNFFCCMG KPLBEBHLNPG(string FMKCBFNEFEH, object CLMKDBDPNNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AKLGKLINNED : KMKLNFFCCMG
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A14910", Offset = "0x6A13310", VA = "0x186A14910")]
	public AKLGKLINNED(AmplitudeAnalyticsEvent MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A14760", Offset = "0x6A13160", VA = "0x186A14760", Slot = "4")]
	public override void CINKPDPAHFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class JHFHDJEPEKA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : JHFHDJEPEKA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M MEBLNPKEJMN;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR EFBGJAJHOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public JHFHDJEPEKA(M MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4212270", Offset = "0x4210C70", VA = "0x184212270")]
	public BLDR LKDJNJDLBNB(AmplitudeAnalyticsIdentifyMessage.DeviceInfo HBCEAIJMLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4212220", Offset = "0x4210C20", VA = "0x184212220")]
	public BLDR FEIOBIBHJAN(AmplitudeAnalyticsIdentifyMessage.RevenueData NOLMGCKNJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x42123C0", Offset = "0x4210DC0", VA = "0x1842123C0")]
	public BLDR PDANKFAPBLO(string FMKCBFNEFEH, string CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C9BE40", Offset = "0x2C9A840", VA = "0x182C9BE40")]
	public BLDR PDANKFAPBLO<T>(string FMKCBFNEFEH, T CLMKDBDPNNH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CINKPDPAHFN();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x42121F0", Offset = "0x4210BF0", VA = "0x1842121F0")]
	internal static string BJKFOIMPEEE(string CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x42122C0", Offset = "0x4210CC0", VA = "0x1842122C0")]
	private BLDR PABADFLPFNJ(string FMKCBFNEFEH, object CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M DPHGIHPFCNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class JAOGIGJGJMB : PBBBIHLGGAG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct BMFELMCKCHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<PPPEHIKEDAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public JAOGIGJGJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C6A0", Offset = "0x6A1B0A0", VA = "0x186A1C6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D0C0", Offset = "0x6A1BAC0", VA = "0x186A1D0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient PBMPLFKBGCA;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6A20B40", Offset = "0x6A1F540", VA = "0x186A20B40")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void NONFMKIFPMN(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6A20BB0", Offset = "0x6A1F5B0", VA = "0x186A20BB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JAOGIGJGJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6A209D0", Offset = "0x6A1F3D0", VA = "0x186A209D0", Slot = "4")]
	[AsyncStateMachine(typeof(BMFELMCKCHL))]
	public Task<PPPEHIKEDAA> BEBMHJLEHMN(string CEIOMGECOAE, string JKGJBNGENME, string IBCDEPBINOP, string CEOHDLGLBGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DNONBPKAEKJ : PBBBIHLGGAG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class AMDLPNKFCLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<PPPEHIKEDAA> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AMDLPNKFCLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A14960", Offset = "0x6A13360", VA = "0x186A14960")]
		internal void FOGLAOKGNFC(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct KICDANJMDOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<PPPEHIKEDAA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<PPPEHIKEDAA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A21650", Offset = "0x6A20050", VA = "0x186A21650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6A21BA0", Offset = "0x6A205A0", VA = "0x186A21BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	[POCMGODEOKB.GGOFPJDKHFE]
	internal static void IHCCCBNDOCE(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	[RecRoom.NoEngine.Common.Preserve]
	public DNONBPKAEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A1ED30", Offset = "0x6A1D730", VA = "0x186A1ED30", Slot = "4")]
	[AsyncStateMachine(typeof(KICDANJMDOO))]
	public Task<PPPEHIKEDAA> BEBMHJLEHMN(string CEIOMGECOAE, string JKGJBNGENME, string IBCDEPBINOP, string CEOHDLGLBGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EDDDDFJBBEA
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> CKGMCNIAHKG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F010", Offset = "0x6A1DA10", VA = "0x186A1F010")]
	internal static bool HBFLFGEKDFB(string JODEIIFHAPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PBBBIHLGGAG
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PPPEHIKEDAA> BEBMHJLEHMN(string CEIOMGECOAE, string JKGJBNGENME, string IBCDEPBINOP, string CEOHDLGLBGM);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PPPEHIKEDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int GOKJNBILINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string LCHNNALCCMM;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0xF46960", Offset = "0xF45360", VA = "0x180F46960")]
	public PPPEHIKEDAA(int JNKFKNAOPEN, string HFNLNGHILNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum PJOCFOGGAEK
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LMOMPGDJCOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long HILIKGPFNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private KMKLNFFCCMG AKKJJAGDDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool JJHHEADDICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float DMDEDNDMLFC;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A225D0", Offset = "0x6A20FD0", VA = "0x186A225D0")]
	public LMOMPGDJCOL(string IEKAONGPIJO, float DMDEDNDMLFC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2D42670", Offset = "0x2D41070", VA = "0x182D42670")]
	public void IIGBAGNCBDB<T>(string FMKCBFNEFEH, T CLMKDBDPNNH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6A223F0", Offset = "0x6A20DF0", VA = "0x186A223F0")]
	public void IIGBAGNCBDB(string FMKCBFNEFEH, string CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A22300", Offset = "0x6A20D00", VA = "0x186A22300")]
	public void GFKMEBIMBDJ(string GCKFJCOONPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A22240", Offset = "0x6A20C40", VA = "0x186A22240")]
	public void EJLJAJNECMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A22470", Offset = "0x6A20E70", VA = "0x186A22470")]
	private void JDKBBEBPBIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A22580", Offset = "0x6A20F80", VA = "0x186A22580")]
	private bool MLBKBIFAOIE()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum IFCGGFOPEHE
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private IFCGGFOPEHE parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IFCGGFOPEHE Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
			get
			{
				return default(IFCGGFOPEHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xB75510", Offset = "0xB73F10", VA = "0x180B75510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A27200", Offset = "0x6A25C00", VA = "0x186A27200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class OALABODNIMF : JLMPBCLECDO, NNIKNCMHGFA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void DINDIKOPNBC(EDMHPLJLGNC BBHAFDFMLFI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JEALKIBIAJG JGNEGEILENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly DINDIKOPNBC DDJFOAIHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string OFMOFHPHBEC;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string CNHHKCKFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x13CB650", Offset = "0x13CA050", VA = "0x1813CB650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool ABOCDGMMJGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A253A0", Offset = "0x6A23DA0", VA = "0x186A253A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OPEFMONCBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A253C0", Offset = "0x6A23DC0", VA = "0x186A253C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> EHNLNNBDGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x13CB630", Offset = "0x13CA030", VA = "0x1813CB630", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A253E0", Offset = "0x6A23DE0", VA = "0x186A253E0")]
	public OALABODNIMF(JEALKIBIAJG KNPAPMCPMPB, string CJDPLHDPJGI, [Optional] DINDIKOPNBC KPEIAMBDOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2DF9210", Offset = "0x2DF7C10", VA = "0x182DF9210", Slot = "8")]
	public T PHNOCPFLPNG<T>(string JODEIIFHAPK, T PEMAOEALEHB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LNBDCHABMBH : MADEEJNOHNA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OEOFAJMMLJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DEJALLNNAMD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public LNBDCHABMBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A25450", Offset = "0x6A23E50", VA = "0x186A25450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A25E00", Offset = "0x6A24800", VA = "0x186A25E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PCPLGIELPAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6A26200", Offset = "0x6A24C00", VA = "0x186A26200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6A26410", Offset = "0x6A24E10", VA = "0x186A26410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MNOBNINBGKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DEJALLNNAMD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public LNBDCHABMBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6A246A0", Offset = "0x6A230A0", VA = "0x186A246A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6A24B00", Offset = "0x6A23500", VA = "0x186A24B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PDDHJHOCMLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public LNBDCHABMBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public DEJALLNNAMD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A26470", Offset = "0x6A24E70", VA = "0x186A26470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A26840", Offset = "0x6A25240", VA = "0x186A26840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, EMCEBCKINFG> LNOPBDPEIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool CJCMKPGNJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool ABPOECMDCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> DPNNEEDIILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> FLBHEAKIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly SemaphoreSlim EOGBKIMMFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private CPFDGFOHOCE GAOMBOGLFFD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task OECNCJKFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A22C90", Offset = "0x6A21690", VA = "0x186A22C90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NMAKAAGANOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F70D0", VA = "0x1809F86D0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MHBINHLIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD03B10", Offset = "0xD02510", VA = "0x180D03B10", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string FBGDPBDMEKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A23CD0", Offset = "0x6A226D0", VA = "0x186A23CD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BFCMCKHFFCA LBMKDEFNHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A23CA0", Offset = "0x6A226A0", VA = "0x186A23CA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MGFELCFMJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6A24170", Offset = "0x6A22B70", VA = "0x186A24170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A235B0", Offset = "0x6A21FB0", VA = "0x186A235B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JPOEACIKKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A23890", Offset = "0x6A22290", VA = "0x186A23890", Slot = "23")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A23DF0", Offset = "0x6A227F0", VA = "0x186A23DF0", Slot = "24")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DJOFKOPAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A24020", Offset = "0x6A22A20", VA = "0x186A24020", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6A22760", Offset = "0x6A21160", VA = "0x186A22760", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<EDMHPLJLGNC> APJLKMOMPIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A22A00", Offset = "0x6A21400", VA = "0x186A22A00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A240C0", Offset = "0x6A22AC0", VA = "0x186A240C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A22C70", Offset = "0x6A21670", VA = "0x186A22C70", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6A242B0", Offset = "0x6A22CB0", VA = "0x186A242B0", Slot = "10")]
	[AsyncStateMachine(typeof(OEOFAJMMLJJ))]
	public Task PCEEADECCDH(string DLMGJHEHIOC, [Optional] DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A22BC0", Offset = "0x6A215C0", VA = "0x186A22BC0", Slot = "21")]
	[AsyncStateMachine(typeof(PCPLGIELPAL))]
	public Task DOIEEPPEDBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6A23F20", Offset = "0x6A22920", VA = "0x186A23F20", Slot = "16")]
	[AsyncStateMachine(typeof(MNOBNINBGKP))]
	public Task LICOBKCMBHK(DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A24210", Offset = "0x6A22C10", VA = "0x186A24210")]
	private void OJDKNAGLFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A22AB0", Offset = "0x6A214B0", VA = "0x186A22AB0", Slot = "17")]
	[AsyncStateMachine(typeof(PDDHJHOCMLK))]
	public Task DAFGNIDAOKJ(DEJALLNNAMD OINGFEKIDHI, Dictionary<string, string> BLCLGJBKPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A23E90", Offset = "0x6A22890", VA = "0x186A23E90", Slot = "18")]
	public bool KPPHMDBOIEM(string PGMNHHGAMHN, bool MMAGDDHOOCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6A23AE0", Offset = "0x6A224E0", VA = "0x186A23AE0", Slot = "19")]
	public JLMPBCLECDO INLJBGOGDNL(string CJDPLHDPJGI, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A22840", Offset = "0x6A21240", VA = "0x186A22840")]
	private JEALKIBIAJG BMPNHAHAAJL(string CJDPLHDPJGI, bool MMAGDDHOOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A236E0", Offset = "0x6A220E0", VA = "0x186A236E0", Slot = "20")]
	public DMLBFNHAKCL HENBCBPDJNC(string INFMCMFOJDE, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A23650", Offset = "0x6A22050", VA = "0x186A23650")]
	private LNHEJEANMOB GLKKAIONIOL(string INFMCMFOJDE, bool MMAGDDHOOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A22CD0", Offset = "0x6A216D0", VA = "0x186A22CD0")]
	private PHKBEJNPJOH FLJAFNOKDJM(DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A23930", Offset = "0x6A22330", VA = "0x186A23930")]
	private EGGJNFCIJHG INJCHBKINNP(string DLMGJHEHIOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A23CE0", Offset = "0x6A226E0", VA = "0x186A23CE0")]
	private void KHHMHDGOMAP(string CJDPLHDPJGI, JEALKIBIAJG KNPAPMCPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A24530", Offset = "0x6A22F30", VA = "0x186A24530")]
	public LNBDCHABMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A22800", Offset = "0x6A21200", VA = "0x186A22800")]
	[CompilerGenerated]
	private void BMOJIHIFFDD(EDMHPLJLGNC FJIOIPCNGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A22800", Offset = "0x6A21200", VA = "0x186A22800")]
	[CompilerGenerated]
	private void OCICNMNIFLC(EDMHPLJLGNC FJIOIPCNGKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class DJOPMIICGCJ : MADEEJNOHNA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct CMLGPNIGNKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public DJOPMIICGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DEJALLNNAMD userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D130", Offset = "0x6A1BB30", VA = "0x186A1D130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DAB0", Offset = "0x6A1C4B0", VA = "0x186A1DAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct OLKEBJLGFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A25FC0", Offset = "0x6A249C0", VA = "0x186A25FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB9ACE0", Offset = "0xB996E0", VA = "0x180B9ACE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private LNBDCHABMBH HKMNNJIPOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[CompilerGenerated]
	private Action JPOEACIKKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> DPNNEEDIILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> FLBHEAKIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task MBFNHKMFCBJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private MADEEJNOHNA DBLNPODEKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E730", Offset = "0x6A1D130", VA = "0x186A1E730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MHBINHLIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E380", Offset = "0x6A1CD80", VA = "0x186A1E380", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NMAKAAGANOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6A1EC20", Offset = "0x6A1D620", VA = "0x186A1EC20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task OECNCJKFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DF90", Offset = "0x6A1C990", VA = "0x186A1DF90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string FBGDPBDMEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E5F0", Offset = "0x6A1CFF0", VA = "0x186A1E5F0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public BFCMCKHFFCA LBMKDEFNHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E5B0", Offset = "0x6A1CFB0", VA = "0x186A1E5B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MGFELCFMJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A1EA70", Offset = "0x6A1D470", VA = "0x186A1EA70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E390", Offset = "0x6A1CD90", VA = "0x186A1E390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DJOFKOPAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E8B0", Offset = "0x6A1D2B0", VA = "0x186A1E8B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DB10", Offset = "0x6A1C510", VA = "0x186A1DB10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<EDMHPLJLGNC> APJLKMOMPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DBB0", Offset = "0x6A1C5B0", VA = "0x186A1DBB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E9C0", Offset = "0x6A1D3C0", VA = "0x186A1E9C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EC70", Offset = "0x6A1D670", VA = "0x186A1EC70")]
	[UnityEngine.Scripting.Preserve]
	public DJOPMIICGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E310", Offset = "0x6A1CD10", VA = "0x186A1E310")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	internal static void FIDEIEBMMOH(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E950", Offset = "0x6A1D350", VA = "0x186A1E950")]
	internal static void MJKGBPGDOFA(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DF60", Offset = "0x6A1C960", VA = "0x186A1DF60", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EB10", Offset = "0x6A1D510", VA = "0x186A1EB10", Slot = "10")]
	[AsyncStateMachine(typeof(CMLGPNIGNKM))]
	public Task PCEEADECCDH(string DLMGJHEHIOC, [Optional] DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E7A0", Offset = "0x6A1D1A0", VA = "0x186A1E7A0", Slot = "16")]
	public Task LICOBKCMBHK(DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DC60", Offset = "0x6A1C660", VA = "0x186A1DC60", Slot = "17")]
	public Task DAFGNIDAOKJ(DEJALLNNAMD OINGFEKIDHI, Dictionary<string, string> BLCLGJBKPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E610", Offset = "0x6A1D010", VA = "0x186A1E610", Slot = "18")]
	public bool KPPHMDBOIEM(string PGMNHHGAMHN, bool MMAGDDHOOCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E4F0", Offset = "0x6A1CEF0", VA = "0x186A1E4F0", Slot = "19")]
	public JLMPBCLECDO INLJBGOGDNL(string CJDPLHDPJGI, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E430", Offset = "0x6A1CE30", VA = "0x186A1E430", Slot = "20")]
	public DMLBFNHAKCL HENBCBPDJNC(string INFMCMFOJDE, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DE50", Offset = "0x6A1C850", VA = "0x186A1DE50", Slot = "21")]
	public Task DOIEEPPEDBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1E190", Offset = "0x6A1CB90", VA = "0x186A1E190")]
	private static void FHEMCEOHCMI(TaskCompletionSource<bool> LEENFLIPNGA, Task NMLCKPCCPMB, Task IGIOJHOHAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DD80", Offset = "0x6A1C780", VA = "0x186A1DD80")]
	[AsyncStateMachine(typeof(OLKEBJLGFLN))]
	private static void DIFLNHPOONI(Task CCAACFNOONL, TaskCompletionSource<bool> LEENFLIPNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9053F0", Offset = "0x903DF0", VA = "0x1809053F0")]
	[CompilerGenerated]
	private void DOJIKDBHCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9050C0", Offset = "0x903AC0", VA = "0x1809050C0")]
	[CompilerGenerated]
	private void BILPJBKAIDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x904640", Offset = "0x903040", VA = "0x180904640")]
	[CompilerGenerated]
	private void GFJFCNJHLHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EC30", Offset = "0x6A1D630", VA = "0x186A1EC30")]
	[CompilerGenerated]
	private void PKMINDFHIGJ(EDMHPLJLGNC FJIOIPCNGKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class AMECDPDONHB : DMLBFNHAKCL, NNIKNCMHGFA
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void NABMDBLBJNB(EDMHPLJLGNC BBHAFDFMLFI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly NABMDBLBJNB DDJFOAIHFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly LNHEJEANMOB CKEKFBGCPGE;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string CNHHKCKFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1EBBA80", Offset = "0x1EBA480", VA = "0x181EBBA80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D61710", Offset = "0x5D60110", VA = "0x185D61710")]
	public AMECDPDONHB(LNHEJEANMOB MMOIPMHDPJP, [Optional] NABMDBLBJNB KPEIAMBDOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x336B000", Offset = "0x3369A00", VA = "0x18336B000", Slot = "5")]
	public T PHNOCPFLPNG<T>(string JODEIIFHAPK, T PEMAOEALEHB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface IICHMKFIJIM
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class HNPIEAONGDO : IICHMKFIJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly CCBAJIONNDN PKANMGDDPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<OGFGBOAFFPF> FMAHHINMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string AAKHPBPBFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string IPNBOLDDADB;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6A20800", Offset = "0x6A1F200", VA = "0x186A20800")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	[UsedImplicitly]
	internal static void JIHNHODNBNJ(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A20870", Offset = "0x6A1F270", VA = "0x186A20870")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HNPIEAONGDO([NotNull][CNNDHKODGDP(null)] CCBAJIONNDN PKANMGDDPJD, [CNNDHKODGDP(null)][NotNull] LGINBECLNGJ BLNABIACOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PFJDLKEEDPO : MADEEJNOHNA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task OECNCJKFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6A26B10", Offset = "0x6A25510", VA = "0x186A26B10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool MHBINHLIJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NMAKAAGANOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string FBGDPBDMEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BFCMCKHFFCA LBMKDEFNHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MGFELCFMJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6A26F60", Offset = "0x6A25960", VA = "0x186A26F60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6A26BA0", Offset = "0x6A255A0", VA = "0x186A26BA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action DJOFKOPAIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6A26E10", Offset = "0x6A25810", VA = "0x186A26E10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6A268A0", Offset = "0x6A252A0", VA = "0x186A268A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<EDMHPLJLGNC> APJLKMOMPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6A26940", Offset = "0x6A25340", VA = "0x186A26940", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6A26EB0", Offset = "0x6A258B0", VA = "0x186A26EB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	[RecRoom.NoEngine.Common.Preserve]
	public PFJDLKEEDPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6A27000", Offset = "0x6A25A00", VA = "0x186A27000", Slot = "10")]
	public Task PCEEADECCDH(string DLMGJHEHIOC, [Optional] DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A26D80", Offset = "0x6A25780", VA = "0x186A26D80", Slot = "16")]
	public Task LICOBKCMBHK(DEJALLNNAMD OINGFEKIDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A269F0", Offset = "0x6A253F0", VA = "0x186A269F0", Slot = "17")]
	public Task DAFGNIDAOKJ(DEJALLNNAMD OINGFEKIDHI, Dictionary<string, string> BLCLGJBKPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "18")]
	public bool KPPHMDBOIEM(string PGMNHHGAMHN, bool MMAGDDHOOCO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6A26CD0", Offset = "0x6A256D0", VA = "0x186A26CD0", Slot = "19")]
	public JLMPBCLECDO INLJBGOGDNL(string CJDPLHDPJGI, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A26C40", Offset = "0x6A25640", VA = "0x186A26C40", Slot = "20")]
	public DMLBFNHAKCL HENBCBPDJNC(string INFMCMFOJDE, bool MMAGDDHOOCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A26A80", Offset = "0x6A25480", VA = "0x186A26A80", Slot = "21")]
	public Task DOIEEPPEDBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class CPFDGFOHOCE : BFCMCKHFFCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly PHKBEJNPJOH EHLMCDMBOMM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> EHBINAJHBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x13CB6A0", Offset = "0x13CA0A0", VA = "0x1813CB6A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	public CPFDGFOHOCE(PHKBEJNPJOH FALHHCLLBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CCHMEDPNJND
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMOMPGDJCOL BHDNEOMANCA(string IEKAONGPIJO);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface LEOKDMFNADP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum FOJJGAENJCF
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long IOPJDEDMKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string EJJAKIJMBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string JBHJIDNEHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool AGJJNALMILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long IEGNEOGDABO();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LACOCHFMOII(long HEJPJBAPELP, bool MNJDDJDNLGN = true);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPJNKHICHCJ(string GJGBLLHIOAC, string IFMOANIIDIA, string CJKHGJMGAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDIAFGCOIJE(string GJGBLLHIOAC);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NODDIGILAPI(string GJGBLLHIOAC, string CHCODBMCIAJ, string HICEOJDKCLG);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ENGNLDCOOFG(string DFBDLGMNPNM, object JKBEFAIKLOB, object EMGOHBOADOG);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBGOEOKKLDN(FOJJGAENJCF CKKCDOIHDEP, int CBMKMKAFNOB, [Optional] KJIGBDEBKIL AFBDEBCPPFK, [Optional] string EDOGLICBGNJ, [Optional] string DMBOCOKFCJF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OJABOKEADDH(KJIGBDEBKIL AFBDEBCPPFK, long FHEGDKEFKGG, long LGKHJBIJNCP, int HBJNNOFKEKK, string EDOGLICBGNJ, int CBMKMKAFNOB);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EPOOMCCMFBB(KJIGBDEBKIL AFBDEBCPPFK, bool HDPGMPGBGCM, [Optional] string DMBOCOKFCJF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AGMGMHAEGAH(KJIGBDEBKIL AFBDEBCPPFK, bool HDPGMPGBGCM, [Optional] string DMBOCOKFCJF);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MCFKCEJGMLC(KJIGBDEBKIL AFBDEBCPPFK, bool HDPGMPGBGCM, [Optional] string DMBOCOKFCJF);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EKDAPFJOKNI(long NDAIANNJONA, string BAJFAOLKMDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface LJGNCKPMJKD
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string BPHOKFLNBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
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
