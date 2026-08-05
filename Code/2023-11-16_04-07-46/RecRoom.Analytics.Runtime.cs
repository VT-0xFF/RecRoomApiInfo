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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D020E0", Offset = "0x5D010E0", VA = "0x185D020E0")]
		public NullableAttribute(byte P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
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
		public AmplitudeAnalyticsClient.Settings ICFFAPDKKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KNAFIBADMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x774F30", Offset = "0x773F30", VA = "0x180774F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum DEOLOGPOLBE
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class EKHKMMMGGFB
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class OJEMDPCEEAB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int OLJPCCNANBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> PGEEPGHFJKC;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
				public OJEMDPCEEAB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class AEAIALBCFIG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
				public AEAIALBCFIG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5CF2D70", Offset = "0x5CF1D70", VA = "0x185CF2D70")]
				internal bool HLFHJPKOBII(OJEMDPCEEAB item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string AGDCLNILCAC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string JDDFHOGGEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<OJEMDPCEEAB> CLJAFGMKGMP;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? BGAKAAAOKEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5CFD010", Offset = "0x5CFC010", VA = "0x185CFD010")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5CFDA30", Offset = "0x5CFCA30", VA = "0x185CFDA30")]
			internal EKHKMMMGGFB(string LDKPPCKHJPA, string BPAMDFIBJNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD880", Offset = "0x5CFC880", VA = "0x185CFD880")]
			public int PPBJDLIGCAF([Optional] int? BDHBDJNBFHJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC770", Offset = "0x5CFB770", VA = "0x185CFC770")]
			public List<Dictionary<string, object>> COKJFPFIHAA(int NHPGHIKOKLL, int? BDHBDJNBFHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5CFCAF0", Offset = "0x5CFBAF0", VA = "0x185CFCAF0")]
			public void EGMBHADGKMD(AmplitudeAnalyticsIdentifyMessage GPCHHCACPPJ, bool ABIGOMLEMFA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5CFCB90", Offset = "0x5CFBB90", VA = "0x185CFCB90")]
			public void EGMBHADGKMD(Dictionary<string, object> GPCHHCACPPJ, bool ABIGOMLEMFA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD6F0", Offset = "0x5CFC6F0", VA = "0x185CFD6F0")]
			public void OMIPKANHHGJ(params Dictionary<string, object>[] AIAOOFLMLKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD0B0", Offset = "0x5CFC0B0", VA = "0x185CFD0B0")]
			public void NJCHPJMHNFD(List<Dictionary<string, object>> HBJHKOODHLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5CFC9E0", Offset = "0x5CFB9E0", VA = "0x185CFC9E0")]
			private void EGBKKLKOJPG(Dictionary<string, object> GPCHHCACPPJ, bool ABIGOMLEMFA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5CFCDD0", Offset = "0x5CFBDD0", VA = "0x185CFCDD0")]
			public void MAMPGKENJHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5CFD300", Offset = "0x5CFC300", VA = "0x185CFD300")]
			private void NLIEMFJJNMN([Optional] string FJCOFLAALBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5CFCCA0", Offset = "0x5CFBCA0", VA = "0x185CFCCA0")]
			private static string HJBNPIOHNPL(string APPJEOKOGAK, string BGNGIHJEFLM)
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
			[Cpp2IlInjected.Address(RVA = "0x5D03140", Offset = "0x5D02140", VA = "0x185D03140")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct NEAOENOFPEB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int PABOAINBMFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string PCOEAEAIKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T LIHHGMIBHOI;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NJJEAIBJLBO : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public NJJEAIBJLBO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5D00940", Offset = "0x5CFF940", VA = "0x185D00940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5D01100", Offset = "0x5D00100", VA = "0x185D01100", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NGEOEJMLNBN : IEnumerator<object>, IEnumerator, IDisposable
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
			public NLHOOGKAONG quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public NGEOEJMLNBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5D005E0", Offset = "0x5CFF5E0", VA = "0x185D005E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5D006F0", Offset = "0x5CFF6F0", VA = "0x185D006F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MOFBGLLDNKD : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public MOFBGLLDNKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5D00420", Offset = "0x5CFF420", VA = "0x185D00420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5D00590", Offset = "0x5CFF590", VA = "0x185D00590", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KBOPIBDGJGJ : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public KBOPIBDGJGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5CFF630", Offset = "0x5CFE630", VA = "0x185CFF630", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5CFF8B0", Offset = "0x5CFE8B0", VA = "0x185CFF8B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CIBMLPIOIBL : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public CIBMLPIOIBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5CFA120", Offset = "0x5CF9120", VA = "0x185CFA120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5CFA3B0", Offset = "0x5CF93B0", VA = "0x185CFA3B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MFGHGPILEAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public EKHKMMMGGFB cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public MFGHGPILEAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5D00100", Offset = "0x5CFF100", VA = "0x185D00100")]
			internal void PHNMIIFNFBA(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5CFFCB0", Offset = "0x5CFECB0", VA = "0x185CFFCB0")]
			internal void GJFGFIDBIGA(NEAOENOFPEB<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class IMFMCNFJMKG : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public EKHKMMMGGFB cache;

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
			private MFGHGPILEAL <>8__1;

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
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public IMFMCNFJMKG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5CFEBE0", Offset = "0x5CFDBE0", VA = "0x185CFEBE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5CFF430", Offset = "0x5CFE430", VA = "0x185CFF430", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class AEGLADDPMDK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public AEGLADDPMDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x34DE7C0", Offset = "0x34DD7C0", VA = "0x1834DE7C0")]
			internal NEAOENOFPEB<T> IONAMEMIIJK(AEKIIIMDGLO postResponse)
			{
				return default(NEAOENOFPEB<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class KGBMGBPCJHK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public KGBMGBPCJHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x34DE7C0", Offset = "0x34DD7C0", VA = "0x1834DE7C0")]
			internal NEAOENOFPEB<T> MJJOLFHPEFH(AEKIIIMDGLO postResponse)
			{
				return default(NEAOENOFPEB<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private KIMAMHDMBAE JOMELGKJKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CKHMFGAMFCM> INKILMNKIDP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string FCLFJECBMML = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string GMLFCJAKLIL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string HDFPLHHHGIB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int MFJMIMDNNGK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int HCLEJFHIJHP = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int JHADNEDOLNA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float BLGDNALNMIO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long LIPEMKJMCCB = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PMFENNGMHBJ = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string AACNOFDIJBI = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool BEOHEPLIFGG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool DOIOLLHLDHH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int NIAAOLGEHCN;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int FJOPBKNLGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private PBCKHPHMCEN PBEFFLGAJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CFENOKGKJMM HJFGHMDNJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private FFFPBKKKBIP ANHHPBGNHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DAGMKIDADKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float ABBMOBLNFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float BKPJCOLDFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int EKBEANLIJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int GBFGPOGMCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? DHCOHFCCMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? IGLPKLACICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long HFGJAOJGHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string FIGFBOLKFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool EMCDMKHOFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long APNNLNGOPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string CEADGJNMEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string GPFCHEIMPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> BDBGHLOMABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DEOLOGPOLBE FCNMOIHMKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int BPMLDFNMCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int BOODMEONLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float GHDMKLGMNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool HHMMAKPLIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MNKLKHNCOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private EKHKMMMGGFB FKCIBOAALKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private EKHKMMMGGFB KGCGKEPHGFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private EKHKMMMGGFB KHKFKNLAPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> IOJKIJDLFOB;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo EBFDPAMCCEN;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string INHPFOBILGC;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string MJMKIANOGJJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string GEOMEBIHCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string BJJMALMGFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string HJDHMJLAAEG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private KIMAMHDMBAE IOKMKFJKABN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5CF4B20", Offset = "0x5CF3B20", VA = "0x185CF4B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CKHMFGAMFCM LBGOKDAAPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5CF6120", Offset = "0x5CF5120", VA = "0x185CF6120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int AOLNHCPHKNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5CF6CB0", Offset = "0x5CF5CB0", VA = "0x185CF6CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long JOGODKFGOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8980", Offset = "0x5CF7980", VA = "0x185CF8980")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8AA0", Offset = "0x5CF7AA0", VA = "0x185CF8AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string BOGNBLOLOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8920", Offset = "0x5CF7920", VA = "0x185CF8920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string OEICKGDPNJH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8950", Offset = "0x5CF7950", VA = "0x185CF8950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OPOKHIDGAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x81A220", Offset = "0x819220", VA = "0x18081A220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x81A1E0", Offset = "0x8191E0", VA = "0x18081A1E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? IMJFMGJDAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x90A2F0", Offset = "0x9092F0", VA = "0x18090A2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8A90", Offset = "0x5CF7A90", VA = "0x185CF8A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FCKMCGIFBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xE867A0", Offset = "0xE857A0", VA = "0x180E867A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xE86430", Offset = "0xE85430", VA = "0x180E86430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IIGIDIIAGDB
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8820", Offset = "0x5CF7820", VA = "0x185CF8820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> DCNDGOAEMJF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5CF8760", Offset = "0x5CF7760", VA = "0x185CF8760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5CF89D0", Offset = "0x5CF79D0", VA = "0x185CF89D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3F10", Offset = "0x5CF2F10", VA = "0x185CF3F10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4EE0", Offset = "0x5CF3EE0", VA = "0x185CF4EE0")]
		private void FLHBLBIIDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7D40", Offset = "0x5CF6D40", VA = "0x185CF7D40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6F20", Offset = "0x5CF5F20", VA = "0x185CF6F20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF80E0", Offset = "0x5CF70E0", VA = "0x185CF80E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6FE0", Offset = "0x5CF5FE0", VA = "0x185CF6FE0")]
		public LDFABEFGIKK PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6000", Offset = "0x5CF5000", VA = "0x185CF6000")]
		[IteratorStateMachine(typeof(NJJEAIBJLBO))]
		public IEnumerator<DNLJHOFEIAO> Initialize(AmplitudeAnalyticsEvent HOLHKJIONMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8020", Offset = "0x5CF7020", VA = "0x185CF8020")]
		public void UpdateLastKnownInteractionCategory(string EADHDBDOKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7F30", Offset = "0x5CF6F30", VA = "0x185CF7F30")]
		public void UpdateLastAliveTime(float BLKKNAAPMIO = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF56A0", Offset = "0x5CF46A0", VA = "0x185CF56A0")]
		private LDFABEFGIKK HJOBJLPMKOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3AB0", Offset = "0x5CF2AB0", VA = "0x185CF3AB0")]
		private LDFABEFGIKK APEKHELBLOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7790", Offset = "0x5CF6790", VA = "0x185CF7790")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6E90", Offset = "0x5CF5E90", VA = "0x185CF6E90")]
		[IteratorStateMachine(typeof(NGEOEJMLNBN))]
		private IEnumerator NIFDILHFOOC(NLHOOGKAONG MDAODDNGEJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8370", Offset = "0x5CF7370", VA = "0x185CF8370")]
		[IteratorStateMachine(typeof(MOFBGLLDNKD))]
		public IEnumerator WaitForFlush(float HMHJOGKKCIF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7E10", Offset = "0x5CF6E10", VA = "0x185CF7E10")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7D50", Offset = "0x5CF6D50", VA = "0x185CF7D50")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime ICEIPOOCKJL)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5B70", Offset = "0x5CF4B70", VA = "0x185CF5B70")]
		public static DLPJEBEBJLH Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3DA0", Offset = "0x5CF2DA0", VA = "0x185CF3DA0")]
		public static OEEBDCJPFPJ AccountSelectionPostLoginEvent([NotNull] string MHMIEBHLEBG, string PKHFLMMJJIG, bool HCNIKNKAOOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4BE0", Offset = "0x5CF3BE0", VA = "0x185CF4BE0")]
		public static OEEBDCJPFPJ Event([NotNull] string MHMIEBHLEBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7020", Offset = "0x5CF6020", VA = "0x185CF7020")]
		public static OEEBDCJPFPJ PreviousSessionEvent([NotNull] string MHMIEBHLEBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5D20", Offset = "0x5CF4D20", VA = "0x185CF5D20")]
		public static OEEBDCJPFPJ InitializeEvent(string PKHFLMMJJIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7950", Offset = "0x5CF6950", VA = "0x185CF7950")]
		public static OEEBDCJPFPJ StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4760", Offset = "0x5CF3760", VA = "0x185CF4760")]
		public static OEEBDCJPFPJ CreateOutOfSessionEvent(string MHMIEBHLEBG, bool EJLCOCDFELJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF64F0", Offset = "0x5CF54F0", VA = "0x185CF64F0")]
		public static LDFABEFGIKK LogOutOfSessionEvent(OEEBDCJPFPJ GNNDFLKFBNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6270", Offset = "0x5CF5270", VA = "0x185CF6270")]
		public void LogEventAsync(AmplitudeAnalyticsEvent KGLCLLOFMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5CF67E0", Offset = "0x5CF57E0", VA = "0x185CF67E0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent KGLCLLOFMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6920", Offset = "0x5CF5920", VA = "0x185CF6920")]
		public void LogSerializedEventAsync(Dictionary<string, object> HDHNJLDBOJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5CF63B0", Offset = "0x5CF53B0", VA = "0x185CF63B0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BGFHLENDOBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6170", Offset = "0x5CF5170", VA = "0x185CF6170")]
		private void LIEIFHFBCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6A00", Offset = "0x5CF5A00", VA = "0x185CF6A00")]
		private void MCOJOMHBFDE(Dictionary<string, object> BPPBEEPMPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4380", Offset = "0x5CF3380", VA = "0x185CF4380")]
		private void BKLCCFPMIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4590", Offset = "0x5CF3590", VA = "0x185CF4590")]
		private void CLBANDLEDKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5480", Offset = "0x5CF4480", VA = "0x185CF5480")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6090", Offset = "0x5CF5090", VA = "0x185CF6090")]
		[IteratorStateMachine(typeof(KBOPIBDGJGJ))]
		private IEnumerator<DNLJHOFEIAO> JOEFIDJJFEJ(float HMHJOGKKCIF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5510", Offset = "0x5CF4510", VA = "0x185CF5510")]
		[IteratorStateMachine(typeof(CIBMLPIOIBL))]
		private IEnumerator<DNLJHOFEIAO> GBGHFGPJPEF(float HMHJOGKKCIF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF55A0", Offset = "0x5CF45A0", VA = "0x185CF55A0")]
		[IteratorStateMachine(typeof(IMFMCNFJMKG))]
		private IEnumerator<DNLJHOFEIAO> HJHEEPHNGEG(EKHKMMMGGFB LCMBPFCEKII, int? BDHBDJNBFHJ, string FALODAKHIGI, string KGCHEEOKNLL, float HMHJOGKKCIF, Action<int> LPFJFHIFHFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4470", Offset = "0x5CF3470", VA = "0x185CF4470")]
		private static void BNLNGNKAOOJ(bool CNHKGHJKDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5A40", Offset = "0x5CF4A40", VA = "0x185CF5A40")]
		private FFKFAKMNOMC<NEAOENOFPEB<Dictionary<string, object>>> IOBMOMEAFGB(string FALODAKHIGI, string KGCHEEOKNLL, string EHLKPODPIGP, string JCAAFNGHMLG, Dictionary<string, object> LIHHGMIBHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF5760", Offset = "0x5CF4760", VA = "0x185CF5760")]
		private FFKFAKMNOMC<NEAOENOFPEB<List<Dictionary<string, object>>>> IOBMOMEAFGB(string FALODAKHIGI, string KGCHEEOKNLL, string EHLKPODPIGP, string JCAAFNGHMLG, List<Dictionary<string, object>> LIHHGMIBHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B36E30", Offset = "0x2B35E30", VA = "0x182B36E30")]
		private FFKFAKMNOMC<NEAOENOFPEB<T>> PKMHBLHPLOH<T>(string FALODAKHIGI, string KGCHEEOKNLL, string JCAAFNGHMLG, T LIHHGMIBHOI, Dictionary<string, object> DEBGDPAIKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B36AE0", Offset = "0x2B35AE0", VA = "0x182B36AE0")]
		private FFKFAKMNOMC<NEAOENOFPEB<T>> MFKFAIHFJOE<T>(string FALODAKHIGI, string KGCHEEOKNLL, string EHLKPODPIGP, T LIHHGMIBHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4B90", Offset = "0x5CF3B90", VA = "0x185CF4B90")]
		private bool EIALAPIMDGA(float IHDHAPFINBI, float HMHJOGKKCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2DE0", Offset = "0x5CF1DE0", VA = "0x185CF2DE0")]
		private Dictionary<string, object> AEGCMKILPHJ(string KGCHEEOKNLL, Dictionary<string, object> LIHHGMIBHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8460", Offset = "0x5CF7460", VA = "0x185CF8460")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5CF49C0", Offset = "0x5CF39C0", VA = "0x185CF49C0")]
		[CompilerGenerated]
		private long DBPAKHFNFEN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4580", Offset = "0x5CF3580", VA = "0x185CF4580")]
		[CompilerGenerated]
		private void CHGEMIBEIKC(int NPAOCNHAOPN)
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
			[Cpp2IlInjected.Address(RVA = "0x5CF9800", Offset = "0x5CF8800", VA = "0x185CF9800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5CF98E0", Offset = "0x5CF88E0", VA = "0x185CF98E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5CF9840", Offset = "0x5CF8840", VA = "0x185CF9840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5CF9940", Offset = "0x5CF8940", VA = "0x185CF9940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5CF97C0", Offset = "0x5CF87C0", VA = "0x185CF97C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5CF9880", Offset = "0x5CF8880", VA = "0x185CF9880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7793B0", Offset = "0x7783B0", VA = "0x1807793B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8DE0", Offset = "0x5CF7DE0", VA = "0x185CF8DE0")]
		public static OEEBDCJPFPJ BJANKEDJCNP(string CEJKGGNMCNG, [NotNull] string PAHOHKDMMJA, long MIFBDPJMFOD, long IDBOOJOCLAH, string PKHFLMMJJIG, bool HCNIKNKAOOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8C80", Offset = "0x5CF7C80", VA = "0x185CF8C80")]
		public static OEEBDCJPFPJ ANFLHNNFGMJ(string CEJKGGNMCNG, [NotNull] string PAHOHKDMMJA, long MIFBDPJMFOD, long IDBOOJOCLAH, string PKHFLMMJJIG, long FPKPAPGGOOI, bool HCNIKNKAOOI, string LPIMNFMOFLM, string CALPIOOHIMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9630", Offset = "0x5CF8630", VA = "0x185CF9630")]
		private AmplitudeAnalyticsEvent(string CEJKGGNMCNG, [NotNull] string PAHOHKDMMJA, long MIFBDPJMFOD, long IDBOOJOCLAH, string PKHFLMMJJIG, bool HCNIKNKAOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1912F10", Offset = "0x1911F10", VA = "0x181912F10")]
		public void JHNKGIGMPMD(long INFCCHEIMCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9410", Offset = "0x5CF8410", VA = "0x185CF9410", Slot = "5")]
		public override void NHFCBOEPFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8B00", Offset = "0x5CF7B00", VA = "0x185CF8B00", Slot = "6")]
		public override void AKCDPGJPNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CF8EE0", Offset = "0x5CF7EE0", VA = "0x185CF8EE0", Slot = "4")]
		protected override Dictionary<string, object> FAFCKAHBHOB(Dictionary<string, object> GNJJCFCAAFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9520", Offset = "0x5CF8520", VA = "0x185CF9520")]
		private void ONLBDEJMIEB(string BGNGIHJEFLM, string APPJEOKOGAK, bool CGAOAOBJHCH = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5CFC110", Offset = "0x5CFB110", VA = "0x185CFC110")]
			public void APFEEBBFGEJ(Dictionary<string, object> GALIGNOEHHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D02DD0", Offset = "0x5D01DD0", VA = "0x185D02DD0")]
			public void APFEEBBFGEJ(Dictionary<string, object> ODKBNPCLFCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x83E070", Offset = "0x83D070", VA = "0x18083E070")]
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
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9A30", Offset = "0x5CF8A30", VA = "0x185CF9A30")]
		public static DLPJEBEBJLH BJANKEDJCNP(string CEJKGGNMCNG, string PKHFLMMJJIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA060", Offset = "0x5CF9060", VA = "0x185CFA060")]
		protected AmplitudeAnalyticsIdentifyMessage(string CEJKGGNMCNG, string PKHFLMMJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9AF0", Offset = "0x5CF8AF0", VA = "0x185CF9AF0")]
		public Dictionary<string, object> BPEMOJABLFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9B80", Offset = "0x5CF8B80", VA = "0x185CF9B80", Slot = "4")]
		protected virtual Dictionary<string, object> FAFCKAHBHOB(Dictionary<string, object> GNJJCFCAAFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9F30", Offset = "0x5CF8F30", VA = "0x185CF9F30")]
		protected void LOHBILDCFFD(string BGNGIHJEFLM, Dictionary<string, object> ALEMBGJFAMJ, Dictionary<string, object> LBHHEKDJEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9EC0", Offset = "0x5CF8EC0", VA = "0x185CF9EC0")]
		protected void HBHKLLOLPON(string BGNGIHJEFLM, string APPJEOKOGAK, Dictionary<string, object> FCAPAHPHKJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9FD0", Offset = "0x5CF8FD0", VA = "0x185CF9FD0", Slot = "5")]
		public virtual void NHFCBOEPFOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5CF99A0", Offset = "0x5CF89A0", VA = "0x185CF99A0", Slot = "6")]
		public virtual void AKCDPGJPNFM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DLPJEBEBJLH : KHJPPEJEPGJ<AmplitudeAnalyticsIdentifyMessage, DLPJEBEBJLH>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override DLPJEBEBJLH GGHOHHFEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CCHOHMLNPOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC0C0", Offset = "0x5CFB0C0", VA = "0x185CFC0C0")]
	public DLPJEBEBJLH(AmplitudeAnalyticsIdentifyMessage NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC010", Offset = "0x5CFB010", VA = "0x185CFC010", Slot = "4")]
	public override void AKCDPGJPNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OEEBDCJPFPJ : KHJPPEJEPGJ<AmplitudeAnalyticsEvent, OEEBDCJPFPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool ADJCHFKAJCD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override OEEBDCJPFPJ GGHOHHFEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long EIBGCBICPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CA8360", Offset = "0x1CA7360", VA = "0x181CA8360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D008F0", Offset = "0x5CFF8F0", VA = "0x185D008F0")]
	public OEEBDCJPFPJ(AmplitudeAnalyticsEvent NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "5")]
	public override AmplitudeAnalyticsEvent CCHOHMLNPOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D02160", Offset = "0x5D01160", VA = "0x185D02160", Slot = "4")]
	public override void AKCDPGJPNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x26306B0", Offset = "0x262F6B0", VA = "0x1826306B0")]
	public OEEBDCJPFPJ BJIDGHHDFIN<T>(string BHNFFMEOAFJ, T[] APPJEOKOGAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x26306B0", Offset = "0x262F6B0", VA = "0x1826306B0")]
	public OEEBDCJPFPJ BJIDGHHDFIN(string BHNFFMEOAFJ, string[] APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2630400", Offset = "0x262F400", VA = "0x182630400")]
	public OEEBDCJPFPJ BJIDGHHDFIN<T>(string BHNFFMEOAFJ, T APPJEOKOGAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D02200", Offset = "0x5D01200", VA = "0x185D02200")]
	public OEEBDCJPFPJ BJIDGHHDFIN(string BHNFFMEOAFJ, long APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D02280", Offset = "0x5D01280", VA = "0x185D02280")]
	public OEEBDCJPFPJ BJIDGHHDFIN(string BHNFFMEOAFJ, string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D022F0", Offset = "0x5D012F0", VA = "0x185D022F0")]
	public OEEBDCJPFPJ FLMGFMODLLP(string BHNFFMEOAFJ, object? APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D02420", Offset = "0x5D01420", VA = "0x185D02420")]
	public OEEBDCJPFPJ OAOGDIBOLCL(string BHNFFMEOAFJ, string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D02320", Offset = "0x5D01320", VA = "0x185D02320")]
	private OEEBDCJPFPJ IAIHGPDNNKN(string BHNFFMEOAFJ, object APPJEOKOGAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NJEFDFFANAB : OEEBDCJPFPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D008F0", Offset = "0x5CFF8F0", VA = "0x185D008F0")]
	public NJEFDFFANAB(AmplitudeAnalyticsEvent NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D00740", Offset = "0x5CFF740", VA = "0x185D00740", Slot = "4")]
	public override void AKCDPGJPNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class KHJPPEJEPGJ<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : KHJPPEJEPGJ<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M NCBOINMNCHO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR GGHOHHFEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	public KHJPPEJEPGJ(M NCBOINMNCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x396DBB0", Offset = "0x396CBB0", VA = "0x18396DBB0")]
	public BLDR MKMENPBOBDC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EIEBEAGPELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x396DA30", Offset = "0x396CA30", VA = "0x18396DA30")]
	public BLDR IIKIOBHLCBF(AmplitudeAnalyticsIdentifyMessage.RevenueData OJBDFFCFGKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x396D9B0", Offset = "0x396C9B0", VA = "0x18396D9B0")]
	public BLDR ENNAEADMLCF(string BHNFFMEOAFJ, string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2421A80", Offset = "0x2420A80", VA = "0x182421A80")]
	public BLDR ENNAEADMLCF<T>(string BHNFFMEOAFJ, T APPJEOKOGAK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AKCDPGJPNFM();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x396DB80", Offset = "0x396CB80", VA = "0x18396DB80")]
	internal static string MKDOHNNNIDN(string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x396DA80", Offset = "0x396CA80", VA = "0x18396DA80")]
	private BLDR MIKLJHAIFIC(string BHNFFMEOAFJ, object APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CCHOHMLNPOI();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class KMMAFDKLGIP : PBCKHPHMCEN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct PMIDLONNIBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<AEKIIIMDGLO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public KMMAFDKLGIP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D024C0", Offset = "0x5D014C0", VA = "0x185D024C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D02D60", Offset = "0x5D01D60", VA = "0x185D02D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct FHFOMFINBJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<AEKIIIMDGLO> <>t__builder;

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
		public KMMAFDKLGIP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5CFDC20", Offset = "0x5CFCC20", VA = "0x185CFDC20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5CFE650", Offset = "0x5CFD650", VA = "0x185CFE650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient JHGNCJNKFKL;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF900", Offset = "0x5CFE900", VA = "0x185CFF900")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	private static void IMKGEJMAGPO(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFC30", Offset = "0x5CFEC30", VA = "0x185CFFC30")]
	[RecRoom.NoEngine.Common.Preserve]
	public KMMAFDKLGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF970", Offset = "0x5CFE970", VA = "0x185CFF970", Slot = "4")]
	[AsyncStateMachine(typeof(PMIDLONNIBC))]
	public Task<AEKIIIMDGLO> IOBMOMEAFGB(string FALODAKHIGI, Dictionary<string, string> BGCGBFCKKDF, bool GKDAHLLLLIH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFAC0", Offset = "0x5CFEAC0", VA = "0x185CFFAC0", Slot = "5")]
	[AsyncStateMachine(typeof(FHFOMFINBJC))]
	public Task<AEKIIIMDGLO> PIFGBDLKNLB(string FALODAKHIGI, string CBAPGHELHMD, string FAALHHOPIJH, string HEKGFPELKNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JOIALOAHGPM
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> AIHNOOPNKKH;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF480", Offset = "0x5CFE480", VA = "0x185CFF480")]
	internal static bool EGKHJPDFODB(string BGNGIHJEFLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PBCKHPHMCEN
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AEKIIIMDGLO> IOBMOMEAFGB(string FALODAKHIGI, Dictionary<string, string> BGCGBFCKKDF, bool GKDAHLLLLIH = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<AEKIIIMDGLO> PIFGBDLKNLB(string FALODAKHIGI, string CBAPGHELHMD, string FAALHHOPIJH, string HEKGFPELKNI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AEKIIIMDGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int IDNFBJJCHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string BFEKCNBKKPP;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB38FC0", Offset = "0xB37FC0", VA = "0x180B38FC0")]
	public AEKIIIMDGLO(int PABOAINBMFI, string PCOEAEAIKHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum EFBMNMDLBBE
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
public class HEKEBGKIODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long KPCNOIMDNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OEEBDCJPFPJ LEFLKBDFJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool AHPNHMOIPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float BAKJACPHKMF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEA50", Offset = "0x5CFDA50", VA = "0x185CFEA50")]
	public HEKEBGKIODJ(string IGICDAKFBBF, float BAKJACPHKMF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x24FAFE0", Offset = "0x24F9FE0", VA = "0x1824FAFE0")]
	public void BJIDGHHDFIN<T>(string BHNFFMEOAFJ, T APPJEOKOGAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE6C0", Offset = "0x5CFD6C0", VA = "0x185CFE6C0")]
	public void BJIDGHHDFIN(string BHNFFMEOAFJ, string APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE960", Offset = "0x5CFD960", VA = "0x185CFE960")]
	public void PDOABCNMDKD(string GFACFGLNDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE8A0", Offset = "0x5CFD8A0", VA = "0x185CFE8A0")]
	public void MDCPEGCJCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE740", Offset = "0x5CFD740", VA = "0x185CFE740")]
	private void COOEOHJMPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE850", Offset = "0x5CFD850", VA = "0x185CFE850")]
	private bool KFGNKAPKHPC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LOHIMAIEHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string OPOKHIDGAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IPIBLNJDDFN BLNIBDKOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action GBEMOIOBPMA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MILBJCDCEHJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDFABEFGIKK EMCBFDNIFOC(string MBCPOIFDPHN, string BPAMDFIBJNO, [Optional] CFENOKGKJMM HMJMNEFHLFL);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LDFABEFGIKK LBIPKLKDEHC(CFENOKGKJMM HMJMNEFHLFL);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	LDFABEFGIKK AKDOEJOKBEO(CFENOKGKJMM HMJMNEFHLFL, Dictionary<string, string> IHDONIEDDIA);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OEFCANJJEFL(string PKOJJBEDCDH);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BLIIOHJOMAJ NGMFCAKOMDM(string IDDFKNJCCGK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LIODNJELFOC OOEHGFDDINJ(string DEKBKKOJLGP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LDFABEFGIKK EHHGNPCBLBG();
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedStatsigExperimentSegment
	{
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
		private string parameterValue;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D02F40", Offset = "0x5D01F40", VA = "0x185D02F40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class COKODNPHFHC : LOHIMAIEHBA
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, PDBNBAAHIKK> GEMFMHIBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool IHEIGFIOJKB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C4710", Offset = "0x7C3710", VA = "0x1807C4710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string OPOKHIDGAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB780", Offset = "0x5CFA780", VA = "0x185CFB780", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IPIBLNJDDFN BLNIBDKOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB660", Offset = "0x5CFA660", VA = "0x185CFB660", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GBEMOIOBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB5C0", Offset = "0x5CFA5C0", VA = "0x185CFB5C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CFB520", Offset = "0x5CFA520", VA = "0x185CFB520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MILBJCDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5CFAE40", Offset = "0x5CF9E40", VA = "0x185CFAE40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5CFADA0", Offset = "0x5CF9DA0", VA = "0x185CFADA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB030", Offset = "0x5CFA030", VA = "0x185CFB030", Slot = "8")]
	public LDFABEFGIKK EMCBFDNIFOC(string MBCPOIFDPHN, string BPAMDFIBJNO, [Optional] CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAEE0", Offset = "0x5CF9EE0", VA = "0x185CFAEE0", Slot = "17")]
	public LDFABEFGIKK EHHGNPCBLBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB790", Offset = "0x5CFA790", VA = "0x185CFB790", Slot = "12")]
	public LDFABEFGIKK LBIPKLKDEHC(CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAAD0", Offset = "0x5CF9AD0", VA = "0x185CFAAD0", Slot = "13")]
	public LDFABEFGIKK AKDOEJOKBEO(CFENOKGKJMM HMJMNEFHLFL, Dictionary<string, string> IHDONIEDDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBB80", Offset = "0x5CFAB80", VA = "0x185CFBB80", Slot = "14")]
	public bool OEFCANJJEFL(string PKOJJBEDCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB980", Offset = "0x5CFA980", VA = "0x185CFB980", Slot = "15")]
	public BLIIOHJOMAJ NGMFCAKOMDM(string IDDFKNJCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBDC0", Offset = "0x5CFADC0", VA = "0x185CFBDC0", Slot = "16")]
	public LIODNJELFOC OOEHGFDDINJ(string DEKBKKOJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA400", Offset = "0x5CF9400", VA = "0x185CFA400")]
	private IPIBLNJDDFN AHAGOKIGOGD(CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBC10", Offset = "0x5CFAC10", VA = "0x185CFBC10")]
	private PBFEPKGPLKJ OLBNOOGFIKF(string BPAMDFIBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB670", Offset = "0x5CFA670", VA = "0x185CFB670")]
	private void KDDGAHCMBDE(string IDDFKNJCCGK, BLIIOHJOMAJ IBEAHHFJKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public COKODNPHFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA68DF0", Offset = "0xA67DF0", VA = "0x180A68DF0")]
	[CompilerGenerated]
	private void MJJKEFMJENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB4A0", Offset = "0x5CFA4A0", VA = "0x185CFB4A0")]
	[CompilerGenerated]
	private void GFHELGAKDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBE50", Offset = "0x5CFAE50", VA = "0x185CFBE50")]
	[CompilerGenerated]
	private void PEEHDLGPFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class NJKNEEPJLHA : LOHIMAIEHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LOHIMAIEHBA LACHBNHPJCH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private LOHIMAIEHBA FHKOMFPHENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D01F60", Offset = "0x5D00F60", VA = "0x185D01F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D01A90", Offset = "0x5D00A90", VA = "0x185D01A90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string OPOKHIDGAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D01C40", Offset = "0x5D00C40", VA = "0x185D01C40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IPIBLNJDDFN BLNIBDKOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D01B80", Offset = "0x5D00B80", VA = "0x185D01B80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action GBEMOIOBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D01AE0", Offset = "0x5D00AE0", VA = "0x185D01AE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D019F0", Offset = "0x5D009F0", VA = "0x185D019F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MILBJCDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D013F0", Offset = "0x5D003F0", VA = "0x185D013F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D012E0", Offset = "0x5D002E0", VA = "0x185D012E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[UnityEngine.Scripting.Preserve]
	public NJKNEEPJLHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D01380", Offset = "0x5D00380", VA = "0x185D01380")]
	[PKDJMILODMH(OMIAJJHDDGO.GameOnly)]
	private static void DFABGLAHNPD(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D01270", Offset = "0x5D00270", VA = "0x185D01270")]
	[PKDJMILODMH(OMIAJJHDDGO.EditorOnly)]
	private static void BMMIEPAINKB(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D015A0", Offset = "0x5D005A0", VA = "0x185D015A0", Slot = "8")]
	public LDFABEFGIKK EMCBFDNIFOC(string MBCPOIFDPHN, string BPAMDFIBJNO, [Optional] CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D01C90", Offset = "0x5D00C90", VA = "0x185D01C90", Slot = "12")]
	public LDFABEFGIKK LBIPKLKDEHC(CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D01150", Offset = "0x5D00150", VA = "0x185D01150", Slot = "13")]
	public LDFABEFGIKK AKDOEJOKBEO(CFENOKGKJMM HMJMNEFHLFL, Dictionary<string, string> IHDONIEDDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D01EB0", Offset = "0x5D00EB0", VA = "0x185D01EB0", Slot = "14")]
	public bool OEFCANJJEFL(string PKOJJBEDCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D01DA0", Offset = "0x5D00DA0", VA = "0x185D01DA0", Slot = "15")]
	public BLIIOHJOMAJ NGMFCAKOMDM(string IDDFKNJCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D01FD0", Offset = "0x5D00FD0", VA = "0x185D01FD0", Slot = "16")]
	public LIODNJELFOC OOEHGFDDINJ(string DEKBKKOJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D01490", Offset = "0x5D00490", VA = "0x185D01490", Slot = "17")]
	public LDFABEFGIKK EHHGNPCBLBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8F0", Offset = "0x7BC8F0", VA = "0x1807BD8F0")]
	[CompilerGenerated]
	private void CDACMFKJDFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB2F370", Offset = "0xB2E370", VA = "0x180B2F370")]
	[CompilerGenerated]
	private void MIKINAAPMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EDMJFPJIILD : LOHIMAIEHBA
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NPPHNPBCGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string OPOKHIDGAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IPIBLNJDDFN BLNIBDKOKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action GBEMOIOBPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC620", Offset = "0x5CFB620", VA = "0x185CFC620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC580", Offset = "0x5CFB580", VA = "0x185CFC580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MILBJCDCEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC3C0", Offset = "0x5CFB3C0", VA = "0x185CFC3C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC320", Offset = "0x5CFB320", VA = "0x185CFC320", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EDMJFPJIILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC4F0", Offset = "0x5CFB4F0", VA = "0x185CFC4F0", Slot = "8")]
	public LDFABEFGIKK EMCBFDNIFOC(string MBCPOIFDPHN, string BPAMDFIBJNO, [Optional] CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC6C0", Offset = "0x5CFB6C0", VA = "0x185CFC6C0", Slot = "12")]
	public LDFABEFGIKK LBIPKLKDEHC(CFENOKGKJMM HMJMNEFHLFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC290", Offset = "0x5CFB290", VA = "0x185CFC290", Slot = "13")]
	public LDFABEFGIKK AKDOEJOKBEO(CFENOKGKJMM HMJMNEFHLFL, Dictionary<string, string> IHDONIEDDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "14")]
	public bool OEFCANJJEFL(string PKOJJBEDCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC750", Offset = "0x5CFB750", VA = "0x185CFC750", Slot = "15")]
	public BLIIOHJOMAJ NGMFCAKOMDM(string IDDFKNJCCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC760", Offset = "0x5CFB760", VA = "0x185CFC760", Slot = "16")]
	public LIODNJELFOC OOEHGFDDINJ(string DEKBKKOJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC460", Offset = "0x5CFB460", VA = "0x185CFC460", Slot = "17")]
	public LDFABEFGIKK EHHGNPCBLBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface KABPAKLONJN
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HEKEBGKIODJ OFMHNEIHEOH(string IGICDAKFBBF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FFFPBKKKBIP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long PKLHGLBABAE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string HAJDMLKCCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string JMKHPILGDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string CPLHPHDFAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string BCJCKBELBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EDECJDJNACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long LMKOACHEDMF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KPABFJDMHIK(long MIFBDPJMFOD, bool CGAOAOBJHCH = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOFEPMHPEEJ(string ACJODAOHIHK, string HLNAGNAECNJ, string IEBLGEOCPJB);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AOOBOJFJMAE(string ACJODAOHIHK);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIFMGJKJNCF(string ACJODAOHIHK, string APLENGDONPP, string OLGELDAFFKI);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PKMFKGCCBCG(string KHMNDPOMOEK, object IALPMFIFPBI, object LIIDJCAECOI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface CFENOKGKJMM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool APIFGAOGMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool ABIHFDMJLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool COMNMJNGIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? FEFFLGCODPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? IMJFMGJDAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int GKDCFNDPIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string AKGKGMOEJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string GNLIEFLDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string DAFKBEEPMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long PDCMNFKAPDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string IILONIPDIBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string PNPBBDAMBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string MJGMMKBHACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string HBFEILMLKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double KNAMMMJFJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int CFHDOFGCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "15")]
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
