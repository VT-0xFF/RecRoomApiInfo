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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BB6110", Offset = "0x6BB5510", VA = "0x186BB6110")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BB8450", Offset = "0x6BB7850", VA = "0x186BB8450", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
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
		public AmplitudeAnalyticsClient.Settings NJIPFGMEMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EKEEDHLPOFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FC0", Offset = "0x8A13C0", VA = "0x1808A1FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum JIBLJGPBJKD
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class MIHICDIKIIG
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class NGGLKKHHEFN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int ACEHIAAOKIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> ICGIJGMLPAF;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
				public NGGLKKHHEFN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class CBJDOLCOBBM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
				public CBJDOLCOBBM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6BACE70", Offset = "0x6BAC270", VA = "0x186BACE70")]
				internal bool HCCMNGICOAD(NGGLKKHHEFN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string MAFKDAEHCHP = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string GEAOIIINCOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<NGGLKKHHEFN> CLDOLBKJIGM;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? OHFMDIJFKKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6BB1E80", Offset = "0x6BB1280", VA = "0x186BB1E80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2DE0", Offset = "0x6BB21E0", VA = "0x186BB2DE0")]
			internal MIHICDIKIIG(string JPIMCLIAHEK, string KHDJACBPLGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2050", Offset = "0x6BB1450", VA = "0x186BB2050")]
			public int EPIMJJCLAAK([Optional] int? MIIJNDNFFIB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2450", Offset = "0x6BB1850", VA = "0x186BB2450")]
			public List<Dictionary<string, object>> FNACGJOCGNN(int GMJKKGEABDL, int? MIIJNDNFFIB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB1CD0", Offset = "0x6BB10D0", VA = "0x186BB1CD0")]
			public void ECEIDPOHMAG(AmplitudeAnalyticsIdentifyMessage FAKGLFFOLFI, bool ECOMHGFAFMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB1D70", Offset = "0x6BB1170", VA = "0x186BB1D70")]
			public void ECEIDPOHMAG(Dictionary<string, object> FAKGLFFOLFI, bool ECOMHGFAFMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6BB1B40", Offset = "0x6BB0F40", VA = "0x186BB1B40")]
			public void CFNFGGOPBJG(params Dictionary<string, object>[] GFLKAPJLFKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2200", Offset = "0x6BB1600", VA = "0x186BB2200")]
			public void FHLBBJLMPJM(List<Dictionary<string, object>> AIBHGMFCALN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6BB28D0", Offset = "0x6BB1CD0", VA = "0x186BB28D0")]
			private void MBAIICKGCFM(Dictionary<string, object> FAKGLFFOLFI, bool ECOMHGFAFMM = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6BB26C0", Offset = "0x6BB1AC0", VA = "0x186BB26C0")]
			public void JJEDIAGOEPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6BB29E0", Offset = "0x6BB1DE0", VA = "0x186BB29E0")]
			private void PPHNPJDBMJI([Optional] string FIPBDAKKJHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6BB1F20", Offset = "0x6BB1320", VA = "0x186BB1F20")]
			private static string EOEPDMKPHNF(string PFKKDHPJFEH, string PBFBBOFLBNL)
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
			[Cpp2IlInjected.Address(RVA = "0x6BB8040", Offset = "0x6BB7440", VA = "0x186BB8040")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct CPBMCGCFLOK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int FIJOBGDCFPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string KHGCHFDEBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T OKINDNENBCE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NAIINNABDAG : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public NAIINNABDAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6BB2F50", Offset = "0x6BB2350", VA = "0x186BB2F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6BB36C0", Offset = "0x6BB2AC0", VA = "0x186BB36C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class HFMNJBPBNPO : IEnumerator<object>, IEnumerator, IDisposable
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
			public ONPFBNMJAGM quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public HFMNJBPBNPO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6BAFDF0", Offset = "0x6BAF1F0", VA = "0x186BAFDF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6BAFF00", Offset = "0x6BAF300", VA = "0x186BAFF00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PHBNNFKDMIF : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public PHBNNFKDMIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB6E50", Offset = "0x6BB6250", VA = "0x186BB6E50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB6FC0", Offset = "0x6BB63C0", VA = "0x186BB6FC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JFHBEEBOGEF : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public JFHBEEBOGEF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6BB0580", Offset = "0x6BAF980", VA = "0x186BB0580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6BB07E0", Offset = "0x6BAFBE0", VA = "0x186BB07E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BEGGKFFCDEH : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public BEGGKFFCDEH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6BACA10", Offset = "0x6BABE10", VA = "0x186BACA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6BACC70", Offset = "0x6BAC070", VA = "0x186BACC70", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class CCEAMGMIOMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public MIHICDIKIIG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CCEAMGMIOMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6BAD330", Offset = "0x6BAC730", VA = "0x186BAD330")]
			internal void PGAAEIHDGOL(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6BACEE0", Offset = "0x6BAC2E0", VA = "0x186BACEE0")]
			internal void NNFHDCNEAOD(CPBMCGCFLOK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class NJJOFJMMANI : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public MIHICDIKIIG cache;

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
			private CCEAMGMIOMG <>8__1;

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
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public NJJOFJMMANI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3710", Offset = "0x6BB2B10", VA = "0x186BB3710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3F10", Offset = "0x6BB3310", VA = "0x186BB3F10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DAKCECCLDGB<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public DAKCECCLDGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5BDB940", Offset = "0x5BDAD40", VA = "0x185BDB940")]
			internal CPBMCGCFLOK<T> NKFKPKMOBFA(DEGBAKEHLDI postResponse)
			{
				return default(CPBMCGCFLOK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CNGBPDIKJMG PMKHFAKFGLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<HLLMDEEIOJA> EEHMIJBKBGL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string IHNMIONKHPN = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string HLEBAOFIHGK = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string HPEMBCCKOFJ = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int OGGAHFOGHCA = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int IBNPHGNKBDF = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int AOKAKFLEMNO = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float MLMOOKNBHOA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long JIJOBNCPLNO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string HJELLKMMBJN = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LIDLCHEMGFO = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string OCJEPKPGHPI = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string GKHMIPKEIMC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool PAPBJEBHJIJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool COAFIDAPJGI;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int NIBLFPDEHHB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int HDOPLCELOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private EECOMGNDPBI HBAOJBMHDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DJDKDGDBPJE NKOMCHOBCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FIKBJGAFEKF DEKNLFILPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool BCMKMCCCLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LPIGCKFHEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float BEGPOAKPAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int KDDAFNMGIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int CHGJNPHOJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? BKGNFKMEMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? HPFCOFCPEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long AIEPEFOPNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string MOMFIJPPGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string KINBIFEIANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long LAPAGOEHMPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string LDNOAMKMKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string LMMIOHDMFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> PKPOLNIOMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private JIBLJGPBJKD BBIBCGKLICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LALHHBMBOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IKEJMFFNDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float IHCALIGKGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool MJKMLAPJEGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OMOEGBNLPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MIHICDIKIIG LJBEDGDBGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MIHICDIKIIG HCCGPKKLAEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private MIHICDIKIIG FCLHPAEAOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CGEEKDDGLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FMFJAGGFNKL;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo LHOHFBPMEOB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string LKJPNEAJAKK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string ECIBCLOMGDJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string NCLCBJPBGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string LIAHGKAFIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string LKDLNAAODMN;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CNGBPDIKJMG MPHKDBDFFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6BA7720", Offset = "0x6BA6B20", VA = "0x186BA7720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HLLMDEEIOJA CODHDKNJNBK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6BA6B30", Offset = "0x6BA5F30", VA = "0x186BA6B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int PAIOFHPHFNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6BA6070", Offset = "0x6BA5470", VA = "0x186BA6070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long FPFJPDEJCDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB2F0", Offset = "0x6BAA6F0", VA = "0x186BAB2F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB400", Offset = "0x6BAA800", VA = "0x186BAB400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string DFLJLEJEHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB2C0", Offset = "0x6BAA6C0", VA = "0x186BAB2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EABNDPLDCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E6580", Offset = "0x8E5980", VA = "0x1808E6580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x912AA0", Offset = "0x911EA0", VA = "0x180912AA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? JDAAOJECPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x96CF70", Offset = "0x96C370", VA = "0x18096CF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1B5EEE0", Offset = "0x1B5E2E0", VA = "0x181B5EEE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HIMLOKDAGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9864D0", Offset = "0x9858D0", VA = "0x1809864D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x14B9A10", Offset = "0x14B8E10", VA = "0x1814B9A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool PJMEKDAKPNC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB1D0", Offset = "0x6BAA5D0", VA = "0x186BAB1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> INFOHGNNLOC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB110", Offset = "0x6BAA510", VA = "0x186BAB110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6BAB340", Offset = "0x6BAA740", VA = "0x186BAB340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5A10", Offset = "0x6BA4E10", VA = "0x186BA5A10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7EB0", Offset = "0x6BA72B0", VA = "0x186BA7EB0")]
		private void MOGKKJNAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA750", Offset = "0x6BA9B50", VA = "0x186BAA750")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8710", Offset = "0x6BA7B10", VA = "0x186BA8710", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BAAA70", Offset = "0x6BA9E70", VA = "0x186BAAA70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA94C0", Offset = "0x6BA88C0", VA = "0x186BA94C0")]
		public NNKCIMLKELB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7520", Offset = "0x6BA6920", VA = "0x186BA7520")]
		[IteratorStateMachine(typeof(NAIINNABDAG))]
		public IEnumerator<MLEAAPMIINP> InitializeForLocalAccount(AmplitudeAnalyticsEvent OECAGJCIMAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA9E20", Offset = "0x6BA9220", VA = "0x186BA9E20")]
		public void SendAppEnterEvent(bool JLPINMHFKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA9F0", Offset = "0x6BA9DF0", VA = "0x186BAA9F0")]
		public void UpdateLastKnownInteractionCategory(string DCPLHPKOALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA940", Offset = "0x6BA9D40", VA = "0x186BAA940")]
		public void UpdateLastAliveTime(float FDMAJNEEBEL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6270", Offset = "0x6BA5670", VA = "0x186BA6270")]
		private NNKCIMLKELB CDDOEHJFFJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BA75B0", Offset = "0x6BA69B0", VA = "0x186BA75B0")]
		private NNKCIMLKELB JHCNEKFMKEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA130", Offset = "0x6BA9530", VA = "0x186BAA130")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7E20", Offset = "0x6BA7220", VA = "0x186BA7E20")]
		[IteratorStateMachine(typeof(HFMNJBPBNPO))]
		private IEnumerator MKIKNEPFAHG(ONPFBNMJAGM BGBKLEONEIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6BAAD00", Offset = "0x6BAA100", VA = "0x186BAAD00")]
		[IteratorStateMachine(typeof(PHBNNFKDMIF))]
		public IEnumerator WaitForFlush(float CGABKENFOHF = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA820", Offset = "0x6BA9C20", VA = "0x186BAA820")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA760", Offset = "0x6BA9B60", VA = "0x186BAA760")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HEJHCAGJGFP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7020", Offset = "0x6BA6420", VA = "0x186BA7020")]
		public static AJLCMANGCJI Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5860", Offset = "0x6BA4C60", VA = "0x186BA5860")]
		public static HOIDCKOPCLN AccountSelectionPostLoginEvent([NotNull] string GJHLFFIHCNC, string KBAALDIICEH, DNPKIALDANG MBIACPCDEBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6B80", Offset = "0x6BA5F80", VA = "0x186BA6B80")]
		public static HOIDCKOPCLN Event([NotNull] string GJHLFFIHCNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA9660", Offset = "0x6BA8A60", VA = "0x186BA9660")]
		public static HOIDCKOPCLN PreviousSessionEvent([NotNull] string GJHLFFIHCNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA71C0", Offset = "0x6BA65C0", VA = "0x186BA71C0")]
		public static HOIDCKOPCLN InitializeEvent(string KBAALDIICEH, int CGLEGACECBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA330", Offset = "0x6BA9730", VA = "0x186BAA330")]
		public static HOIDCKOPCLN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6430", Offset = "0x6BA5830", VA = "0x186BA6430")]
		public static HOIDCKOPCLN CreateOutOfSessionEvent(string GJHLFFIHCNC, bool HJMJKKCKKJI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7A30", Offset = "0x6BA6E30", VA = "0x186BA7A30")]
		public static NNKCIMLKELB LogOutOfSessionEvent(HOIDCKOPCLN PMGELEODKCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BA77B0", Offset = "0x6BA6BB0", VA = "0x186BA77B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent CCHEIMCOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7C00", Offset = "0x6BA7000", VA = "0x186BA7C00")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent CCHEIMCOEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7D40", Offset = "0x6BA7140", VA = "0x186BA7D40")]
		public void LogSerializedEventAsync(Dictionary<string, object> BHBMAEAFGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6BA78F0", Offset = "0x6BA6CF0", VA = "0x186BA78F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage EJKKOPOPOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6330", Offset = "0x6BA5730", VA = "0x186BA6330")]
		private void CDOMHFLHOCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8460", Offset = "0x6BA7860", VA = "0x186BA8460")]
		private void OFHDOHMHLPK(Dictionary<string, object> PGHJNJLEBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6E90", Offset = "0x6BA6290", VA = "0x186BA6E90")]
		private void FMJLNPKAPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6710", Offset = "0x6BA5B10", VA = "0x186BA6710")]
		private void DAGABBAPHFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BA6F80", Offset = "0x6BA6380", VA = "0x186BA6F80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8270", Offset = "0x6BA7670", VA = "0x186BA8270")]
		[IteratorStateMachine(typeof(JFHBEEBOGEF))]
		private IEnumerator<MLEAAPMIINP> NAJGFPDAJJH(float CGABKENFOHF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA57D0", Offset = "0x6BA4BD0", VA = "0x186BA57D0")]
		[IteratorStateMachine(typeof(BEGGKFFCDEH))]
		private IEnumerator<MLEAAPMIINP> AKODJALCIPE(float CGABKENFOHF = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA68E0", Offset = "0x6BA5CE0", VA = "0x186BA68E0")]
		[IteratorStateMachine(typeof(NJJOFJMMANI))]
		private IEnumerator<MLEAAPMIINP> EAFBACBFLBI(MIHICDIKIIG CLENOLHAPKH, int? MIIJNDNFFIB, string KOHGOODNIJM, float CGABKENFOHF, Action<int> KHFNJHKMPJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8350", Offset = "0x6BA7750", VA = "0x186BA8350")]
		private static void NIIJKGLIGJE(bool IHDKICAABEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5490", Offset = "0x6BA4890", VA = "0x186BA5490")]
		private ELLFHPNCMJG<CPBMCGCFLOK<Dictionary<string, object>>> ADEJOLJBDKF(string KOHGOODNIJM, string DHJFBNCKABK, Dictionary<string, object> OKINDNENBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5560", Offset = "0x6BA4960", VA = "0x186BA5560")]
		private ELLFHPNCMJG<CPBMCGCFLOK<List<Dictionary<string, object>>>> ADEJOLJBDKF(string KOHGOODNIJM, string DHJFBNCKABK, List<Dictionary<string, object>> OKINDNENBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x36034A0", Offset = "0x36028A0", VA = "0x1836034A0")]
		private ELLFHPNCMJG<CPBMCGCFLOK<T>> BFLFHNPKFMG<T>(string BFDAPDMEHDP, string KOHGOODNIJM, string DHJFBNCKABK, T OKINDNENBCE, Dictionary<string, object> BIDBHALIGMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6BA8300", Offset = "0x6BA7700", VA = "0x186BA8300")]
		private bool NFLBFDOJIFL(float AOKHMGLMKIB, float CGABKENFOHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BA87D0", Offset = "0x6BA7BD0", VA = "0x186BA87D0")]
		private Dictionary<string, object> PFBNBBLFOFO(string KOHGOODNIJM, Dictionary<string, object> OKINDNENBCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BAADF0", Offset = "0x6BAA1F0", VA = "0x186BAADF0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6BA69C0", Offset = "0x6BA5DC0", VA = "0x186BA69C0")]
		[CompilerGenerated]
		private long ECBCFABDOBI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BA7010", Offset = "0x6BA6410", VA = "0x186BA7010")]
		[CompilerGenerated]
		private void HNDEJHHMCFG(int OKCKJJNHDJP)
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
			[Cpp2IlInjected.Address(RVA = "0x6BAC100", Offset = "0x6BAB500", VA = "0x186BAC100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC1E0", Offset = "0x6BAB5E0", VA = "0x186BAC1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC140", Offset = "0x6BAB540", VA = "0x186BAC140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC240", Offset = "0x6BAB640", VA = "0x186BAC240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC0C0", Offset = "0x6BAB4C0", VA = "0x186BAC0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6BAC180", Offset = "0x6BAB580", VA = "0x186BAC180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x89D9A0", Offset = "0x89CDA0", VA = "0x18089D9A0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB460", Offset = "0x6BAA860", VA = "0x186BAB460")]
		public static HOIDCKOPCLN ANJEPJLHJHG(string FCPMNBOKKMJ, [NotNull] string ELIPPFHHNLC, long BDFLMLIOLFG, long DKDEAHEDIHH, string KBAALDIICEH, string MBIACPCDEBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6BABDC0", Offset = "0x6BAB1C0", VA = "0x186BABDC0")]
		public static HOIDCKOPCLN PHBGAOPHAJO(string FCPMNBOKKMJ, [NotNull] string ELIPPFHHNLC, long BDFLMLIOLFG, long DKDEAHEDIHH, string KBAALDIICEH, long ICEAKDLHNLA, string NHMLFHMBHHH, string BCIJFMGKBLL, string DKMFAAPNEAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6BABF20", Offset = "0x6BAB320", VA = "0x186BABF20")]
		private AmplitudeAnalyticsEvent(string FCPMNBOKKMJ, [NotNull] string ELIPPFHHNLC, long BDFLMLIOLFG, long DKDEAHEDIHH, string KBAALDIICEH, string MBIACPCDEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA01F40", Offset = "0xA01340", VA = "0x180A01F40")]
		public void HIDIGKMKAND(long KHMGGAFKMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB560", Offset = "0x6BAA960", VA = "0x186BAB560", Slot = "5")]
		public override void BHHDIPPJOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB660", Offset = "0x6BAAA60", VA = "0x186BAB660", Slot = "6")]
		public override void DBFMGBFMPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB8F0", Offset = "0x6BAACF0", VA = "0x186BAB8F0", Slot = "4")]
		protected override Dictionary<string, object> NEFNNPBDPKA(Dictionary<string, object> JGNDAPNGAAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6BAB7E0", Offset = "0x6BAABE0", VA = "0x186BAB7E0")]
		private void EGEBMLJFILI(string PBFBBOFLBNL, string PFKKDHPJFEH, bool KOOFLMJHMNP = false)
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
			[Cpp2IlInjected.Address(RVA = "0x6BAD730", Offset = "0x6BACB30", VA = "0x186BAD730")]
			public void BBNDNNPOHHK(Dictionary<string, object> GAGKENAEBCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BB7CD0", Offset = "0x6BB70D0", VA = "0x186BB7CD0")]
			public void BBNDNNPOHHK(Dictionary<string, object> NMELHPKKHCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDE9C90", Offset = "0xDE9090", VA = "0x180DE9C90")]
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
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC2A0", Offset = "0x6BAB6A0", VA = "0x186BAC2A0")]
		public static AJLCMANGCJI ANJEPJLHJHG(string FCPMNBOKKMJ, string KBAALDIICEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC950", Offset = "0x6BABD50", VA = "0x186BAC950")]
		protected AmplitudeAnalyticsIdentifyMessage(string FCPMNBOKKMJ, string KBAALDIICEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC4E0", Offset = "0x6BAB8E0", VA = "0x186BAC4E0")]
		public Dictionary<string, object> INFHJNAMBBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC610", Offset = "0x6BABA10", VA = "0x186BAC610", Slot = "4")]
		protected virtual Dictionary<string, object> NEFNNPBDPKA(Dictionary<string, object> JGNDAPNGAAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC570", Offset = "0x6BAB970", VA = "0x186BAC570")]
		protected void LPJKNBILEHC(string PBFBBOFLBNL, Dictionary<string, object> FAIBLHHMOJD, Dictionary<string, object> LAOLBKJBDCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC470", Offset = "0x6BAB870", VA = "0x186BAC470")]
		protected void GMMNHBHFHMG(string PBFBBOFLBNL, string PFKKDHPJFEH, Dictionary<string, object> DBJBLFBNBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC360", Offset = "0x6BAB760", VA = "0x186BAC360", Slot = "5")]
		public virtual void BHHDIPPJOLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BAC3F0", Offset = "0x6BAB7F0", VA = "0x186BAC3F0", Slot = "6")]
		public virtual void DBFMGBFMPLM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AJLCMANGCJI : LOCABAPJLBB<AmplitudeAnalyticsIdentifyMessage, AJLCMANGCJI>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override AJLCMANGCJI CMMACODFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage DEIGGEIJNPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BA5440", Offset = "0x6BA4840", VA = "0x186BA5440")]
	public AJLCMANGCJI(AmplitudeAnalyticsIdentifyMessage NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BA53A0", Offset = "0x6BA47A0", VA = "0x186BA53A0", Slot = "4")]
	public override void DBFMGBFMPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HOIDCKOPCLN : LOCABAPJLBB<AmplitudeAnalyticsEvent, HOIDCKOPCLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LNPCABEOECA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override HOIDCKOPCLN CMMACODFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long MPMKJOGMPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BB02B0", Offset = "0x6BAF6B0", VA = "0x186BB02B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BB02D0", Offset = "0x6BAF6D0", VA = "0x186BB02D0")]
	public HOIDCKOPCLN(AmplitudeAnalyticsEvent NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0", Slot = "5")]
	public override AmplitudeAnalyticsEvent DEIGGEIJNPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFFF0", Offset = "0x6BAF3F0", VA = "0x186BAFFF0", Slot = "4")]
	public override void DBFMGBFMPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1C70", Offset = "0x2ED1070", VA = "0x182ED1C70")]
	public HOIDCKOPCLN JCEHLIMGDMB<T>(string BCPKEGMOEBD, T[] PFKKDHPJFEH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2ED1C70", Offset = "0x2ED1070", VA = "0x182ED1C70")]
	public HOIDCKOPCLN JCEHLIMGDMB(string BCPKEGMOEBD, string[] PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2ED19C0", Offset = "0x2ED0DC0", VA = "0x182ED19C0")]
	public HOIDCKOPCLN JCEHLIMGDMB<T>(string BCPKEGMOEBD, T PFKKDHPJFEH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0090", Offset = "0x6BAF490", VA = "0x186BB0090")]
	public HOIDCKOPCLN JCEHLIMGDMB(string BCPKEGMOEBD, long PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0110", Offset = "0x6BAF510", VA = "0x186BB0110")]
	public HOIDCKOPCLN JCEHLIMGDMB(string BCPKEGMOEBD, string PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0180", Offset = "0x6BAF580", VA = "0x186BB0180")]
	public HOIDCKOPCLN MEOMBCCKEPH(string BCPKEGMOEBD, object? PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFF50", Offset = "0x6BAF350", VA = "0x186BAFF50")]
	public HOIDCKOPCLN DAIFDAIPICJ(string BCPKEGMOEBD, string PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6BB01B0", Offset = "0x6BAF5B0", VA = "0x186BB01B0")]
	private HOIDCKOPCLN NPHKBHDGGHP(string BCPKEGMOEBD, object PFKKDHPJFEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OPOABAGOPJL : HOIDCKOPCLN
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BB02D0", Offset = "0x6BAF6D0", VA = "0x186BB02D0")]
	public OPOABAGOPJL(AmplitudeAnalyticsEvent NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6B40", Offset = "0x6BB5F40", VA = "0x186BB6B40", Slot = "4")]
	public override void DBFMGBFMPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class LOCABAPJLBB<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : LOCABAPJLBB<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M NFKMLKNHFEM;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR CMMACODFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public LOCABAPJLBB(M NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4685A30", Offset = "0x4684E30", VA = "0x184685A30")]
	public BLDR JFKAAGGPCHO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo CCONKHEGOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4685A80", Offset = "0x4684E80", VA = "0x184685A80")]
	public BLDR MELDNPDNAAE(AmplitudeAnalyticsIdentifyMessage.RevenueData NJPCHKBDNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4685990", Offset = "0x4684D90", VA = "0x184685990")]
	public BLDR IAMNIGGMEMJ(string BCPKEGMOEBD, string PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x306A2C0", Offset = "0x30696C0", VA = "0x18306A2C0")]
	public BLDR IAMNIGGMEMJ<T>(string BCPKEGMOEBD, T PFKKDHPJFEH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DBFMGBFMPLM();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4685960", Offset = "0x4684D60", VA = "0x184685960")]
	internal static string BMJLGJKPMJF(string PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4685860", Offset = "0x4684C60", VA = "0x184685860")]
	private BLDR BJJEDFIPDPF(string BCPKEGMOEBD, object PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M DEIGGEIJNPH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class HPCMJGNFBHL : EECOMGNDPBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct PMCOIMJDHIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<DEGBAKEHLDI> <>t__builder;

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
		public HPCMJGNFBHL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6BB7230", Offset = "0x6BB6630", VA = "0x186BB7230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7C60", Offset = "0x6BB7060", VA = "0x186BB7C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient PNMMLNPKACE;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0320", Offset = "0x6BAF720", VA = "0x186BB0320")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void GKHABJCCCCD(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0500", Offset = "0x6BAF900", VA = "0x186BB0500")]
	[RecRoom.NoEngine.Common.Preserve]
	public HPCMJGNFBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0390", Offset = "0x6BAF790", VA = "0x186BB0390", Slot = "4")]
	[AsyncStateMachine(typeof(PMCOIMJDHIH))]
	public Task<DEGBAKEHLDI> MMGEHIAPGNA(string BFDAPDMEHDP, string NLDFIKKIIPN, string AFHBHMANHND, string GHAHCMJGGHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class PCOBBCDHIBJ : EECOMGNDPBI
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DDNECOBOGDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<DEGBAKEHLDI> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DDNECOBOGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD650", Offset = "0x6BACA50", VA = "0x186BAD650")]
		internal void PEONMAEHHJG(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct FELBFKPGHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<DEGBAKEHLDI> <>t__builder;

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
		private TaskAwaiter<DEGBAKEHLDI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6BAD8B0", Offset = "0x6BACCB0", VA = "0x186BAD8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6BADE00", Offset = "0x6BAD200", VA = "0x186BADE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	[GOEIKLHOLGG.KCHBNNLNADK]
	internal static void MHBHFBANKJK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[RecRoom.NoEngine.Common.Preserve]
	public PCOBBCDHIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6CF0", Offset = "0x6BB60F0", VA = "0x186BB6CF0", Slot = "4")]
	[AsyncStateMachine(typeof(FELBFKPGHCP))]
	public Task<DEGBAKEHLDI> MMGEHIAPGNA(string BFDAPDMEHDP, string NLDFIKKIIPN, string AFHBHMANHND, string GHAHCMJGGHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CBAFAKOLCKG
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> HFCECLBCBBL;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6BACCC0", Offset = "0x6BAC0C0", VA = "0x186BACCC0")]
	internal static bool PLJEFHCKMMI(string PBFBBOFLBNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EECOMGNDPBI
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DEGBAKEHLDI> MMGEHIAPGNA(string BFDAPDMEHDP, string NLDFIKKIIPN, string AFHBHMANHND, string GHAHCMJGGHL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct DEGBAKEHLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int ODELHNGDAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string EMJPGNPHGGO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
	public DEGBAKEHLDI(int FIJOBGDCFPD, string KHGCHFDEBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum KFJONOHJLGB
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
public class FEMAKIOPNHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long MCEAAEKLBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private HOIDCKOPCLN MELKJBKLNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool JAJJMLDOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float BJLOGCPKCDD;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE200", Offset = "0x6BAD600", VA = "0x186BAE200")]
	public FEMAKIOPNHI(string LLFIBDHGBMN, float BJLOGCPKCDD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CF60", Offset = "0x2E9C360", VA = "0x182E9CF60")]
	public void JCEHLIMGDMB<T>(string BCPKEGMOEBD, T PFKKDHPJFEH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE090", Offset = "0x6BAD490", VA = "0x186BAE090")]
	public void JCEHLIMGDMB(string BCPKEGMOEBD, string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE110", Offset = "0x6BAD510", VA = "0x186BAE110")]
	public void JCMOHFNPNDC(string PKCPPLCLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6BADFD0", Offset = "0x6BAD3D0", VA = "0x186BADFD0")]
	public void DMNLDAOILJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6BADE70", Offset = "0x6BAD270", VA = "0x186BADE70")]
	private void DHHHOLDONGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6BADF80", Offset = "0x6BAD380", VA = "0x186BADF80")]
	private bool DKPLOKHNCNH()
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
		public enum EKPMMADPGAI
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
		private EKPMMADPGAI parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EKPMMADPGAI Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
			get
			{
				return default(EKPMMADPGAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x953920", Offset = "0x952D20", VA = "0x180953920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB7E40", Offset = "0x6BB7240", VA = "0x186BB7E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class HFBJGONOGKD : NPKPIDLHIHG, PDPDLDKLCAK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void AEOGBOAALCG(EKJOGAEIMAH GICHGNHCGPG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly BHOOEADJHCD NPNIHFKELIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly AEOGBOAALCG GDEKLAOHFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string IPBGHFFCDGB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string FLMLNILMENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x15652B0", Offset = "0x15646B0", VA = "0x1815652B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool OAKFFPKGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BAFD60", Offset = "0x6BAF160", VA = "0x186BAFD60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FCDGIJHMEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6BAFD40", Offset = "0x6BAF140", VA = "0x186BAFD40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> OFHHPKNLOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x15655D0", Offset = "0x15649D0", VA = "0x1815655D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFD80", Offset = "0x6BAF180", VA = "0x186BAFD80")]
	public HFBJGONOGKD(BHOOEADJHCD CPMOJDMDHNC, string INOMFGBIBAN, [Optional] AEOGBOAALCG BCDPFPJFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2EC9900", Offset = "0x2EC8D00", VA = "0x182EC9900", Slot = "8")]
	public T GEKLBPFDDHO<T>(string PBFBBOFLBNL, T POOOEFHFGKB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NLKDHBNIEEH : KOFDFCJMCJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OBMOCKHIAMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public DJDKDGDBPJE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public NLKDHBNIEEH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6BB6190", Offset = "0x6BB5590", VA = "0x186BB6190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB6AE0", Offset = "0x6BB5EE0", VA = "0x186BB6AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct PJBHIGFPINO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6BB7010", Offset = "0x6BB6410", VA = "0x186BB7010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB71D0", Offset = "0x6BB65D0", VA = "0x186BB71D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct AAEAFLKAEGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public DJDKDGDBPJE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public NLKDHBNIEEH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6BA4F30", Offset = "0x6BA4330", VA = "0x186BA4F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6BA5340", Offset = "0x6BA4740", VA = "0x186BA5340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct GELCCNIOBOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public NLKDHBNIEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public DJDKDGDBPJE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6BAF6F0", Offset = "0x6BAEAF0", VA = "0x186BAF6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6BAFAA0", Offset = "0x6BAEEA0", VA = "0x186BAFAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, AHJBILDAGCH> KJIDMHJDCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool KKFIHKOMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool MDDGLHICPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> EAGKMBMAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> BBHAGKHJCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly SemaphoreSlim NILEFLPAJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private KPNIGIDPJMP CEPGMLKKKIA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task OONEOPHFGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4900", Offset = "0x6BB3D00", VA = "0x186BB4900", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool BGAGFEFIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x931420", Offset = "0x930820", VA = "0x180931420", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AFMAAKFKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xEA3F30", Offset = "0xEA3330", VA = "0x180EA3F30", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string EABNDPLDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4C70", Offset = "0x6BB4070", VA = "0x186BB4C70", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LOOKHIBLIDO FLCAPNACMDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4D30", Offset = "0x6BB4130", VA = "0x186BB4D30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MEFOMHMGJBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4BD0", Offset = "0x6BB3FD0", VA = "0x186BB4BD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4470", Offset = "0x6BB3870", VA = "0x186BB4470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action IPFEMDCFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4940", Offset = "0x6BB3D40", VA = "0x186BB4940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4170", Offset = "0x6BB3570", VA = "0x186BB4170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action CLIKIJOFPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3F60", Offset = "0x6BB3360", VA = "0x186BB3F60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4210", Offset = "0x6BB3610", VA = "0x186BB4210", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<EKJOGAEIMAH> GODPCHJDIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB46A0", Offset = "0x6BB3AA0", VA = "0x186BB46A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4000", Offset = "0x6BB3400", VA = "0x186BB4000", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4680", Offset = "0x6BB3A80", VA = "0x186BB4680", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BB59C0", Offset = "0x6BB4DC0", VA = "0x186BB59C0", Slot = "12")]
	[AsyncStateMachine(typeof(OBMOCKHIAMJ))]
	public Task NOCOEJHJFAP(string KHDJACBPLGA, [Optional] DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4C80", Offset = "0x6BB4080", VA = "0x186BB4C80", Slot = "23")]
	[AsyncStateMachine(typeof(PJBHIGFPINO))]
	public Task IMEEJDELEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6BB58C0", Offset = "0x6BB4CC0", VA = "0x186BB58C0", Slot = "18")]
	[AsyncStateMachine(typeof(AAEAFLKAEGH))]
	public Task NJLMIGMMLEF(DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6BB45E0", Offset = "0x6BB39E0", VA = "0x186BB45E0")]
	private void DLLGKEEONCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BB56A0", Offset = "0x6BB4AA0", VA = "0x186BB56A0", Slot = "19")]
	[AsyncStateMachine(typeof(GELCCNIOBOA))]
	public Task KODBEKEOBBL(DJDKDGDBPJE DELDIDDNALP, Dictionary<string, string> PNBHDIMDAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BB40B0", Offset = "0x6BB34B0", VA = "0x186BB40B0", Slot = "20")]
	public bool BIDNDJGDKBK(string CICMEKNNFLA, bool ADEBFBENACI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6BB42B0", Offset = "0x6BB36B0", VA = "0x186BB42B0", Slot = "21")]
	public NPKPIDLHIHG CNKOLGLJJJG(string INOMFGBIBAN, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5AE0", Offset = "0x6BB4EE0", VA = "0x186BB5AE0")]
	private BHOOEADJHCD PKGBLLNENEI(string INOMFGBIBAN, bool ADEBFBENACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4A20", Offset = "0x6BB3E20", VA = "0x186BB4A20", Slot = "22")]
	public MOBFMCMMEBH HIOGLKBCGCG(string INMDJPLJIPK, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4510", Offset = "0x6BB3910", VA = "0x186BB4510")]
	private HFMNBMEIMMK DJIBDMPCIKJ(string INMDJPLJIPK, bool ADEBFBENACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4D60", Offset = "0x6BB4160", VA = "0x186BB4D60")]
	private KJGPLHOLNJM JOPNAGPJEFJ(DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4750", Offset = "0x6BB3B50", VA = "0x186BB4750")]
	private FMFMHAOOKEF FKOMBPPMBLI(string KHDJACBPLGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6BB57B0", Offset = "0x6BB4BB0", VA = "0x186BB57B0")]
	private void NCFNBBPLOPM(string INOMFGBIBAN, BHOOEADJHCD CPMOJDMDHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5E40", Offset = "0x6BB5240", VA = "0x186BB5E40")]
	public NLKDHBNIEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BB49E0", Offset = "0x6BB3DE0", VA = "0x186BB49E0")]
	[CompilerGenerated]
	private void KFFLLEMFEMM(EKJOGAEIMAH AKMABNIDADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB49E0", Offset = "0x6BB3DE0", VA = "0x186BB49E0")]
	[CompilerGenerated]
	private void GCCKKOBJGEK(EKJOGAEIMAH AKMABNIDADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class FLLGOJCBJJG : KOFDFCJMCJL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct LOJPGDNGNBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public FLLGOJCBJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public DJDKDGDBPJE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0830", Offset = "0x6BAFC30", VA = "0x186BB0830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6BB11B0", Offset = "0x6BB05B0", VA = "0x186BB11B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HCBOINLGBGP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6BAFB00", Offset = "0x6BAEF00", VA = "0x186BAFB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8E9810", Offset = "0x8E8C10", VA = "0x1808E9810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NLKDHBNIEEH OLOGNNCNMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> EAGKMBMAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> BBHAGKHJCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task KDOHCPGMBLD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private KOFDFCJMCJL MHKIBMGFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEE60", Offset = "0x6BAE260", VA = "0x186BAEE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AFMAAKFKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEAC0", Offset = "0x6BADEC0", VA = "0x186BAEAC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BGAGFEFIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6BAF2E0", Offset = "0x6BAE6E0", VA = "0x186BAF2E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task OONEOPHFGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEBC0", Offset = "0x6BADFC0", VA = "0x186BAEBC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string EABNDPLDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6BAF030", Offset = "0x6BAE430", VA = "0x186BAF030", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LOOKHIBLIDO FLCAPNACMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6BAF160", Offset = "0x6BAE560", VA = "0x186BAF160", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IPFEMDCFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEDC0", Offset = "0x6BAE1C0", VA = "0x186BAEDC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE780", Offset = "0x6BADB80", VA = "0x186BAE780", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MEFOMHMGJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEF90", Offset = "0x6BAE390", VA = "0x186BAEF90", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE980", Offset = "0x6BADD80", VA = "0x186BAE980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action CLIKIJOFPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE510", Offset = "0x6BAD910", VA = "0x186BAE510", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE820", Offset = "0x6BADC20", VA = "0x186BAE820", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<EKJOGAEIMAH> GODPCHJDIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6BAEB10", Offset = "0x6BADF10", VA = "0x186BAEB10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6BAE5B0", Offset = "0x6BAD9B0", VA = "0x186BAE5B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF630", Offset = "0x6BAEA30", VA = "0x186BAF630")]
	[UnityEngine.Scripting.Preserve]
	public FLLGOJCBJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEA20", Offset = "0x6BADE20", VA = "0x186BAEA20")]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	internal static void DJNFEGBLBOB(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF1A0", Offset = "0x6BAE5A0", VA = "0x186BAF1A0")]
	internal static void JFEOOJGOCMD(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEA90", Offset = "0x6BADE90", VA = "0x186BAEA90", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF520", Offset = "0x6BAE920", VA = "0x186BAF520", Slot = "12")]
	[AsyncStateMachine(typeof(LOJPGDNGNBP))]
	public Task NOCOEJHJFAP(string KHDJACBPLGA, [Optional] DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF410", Offset = "0x6BAE810", VA = "0x186BAF410", Slot = "18")]
	public Task NJLMIGMMLEF(DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF2F0", Offset = "0x6BAE6F0", VA = "0x186BAF2F0", Slot = "19")]
	public Task KODBEKEOBBL(DJDKDGDBPJE DELDIDDNALP, Dictionary<string, string> PNBHDIMDAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE660", Offset = "0x6BADA60", VA = "0x186BAE660", Slot = "20")]
	public bool BIDNDJGDKBK(string CICMEKNNFLA, bool ADEBFBENACI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE8C0", Offset = "0x6BADCC0", VA = "0x186BAE8C0", Slot = "21")]
	public NPKPIDLHIHG CNKOLGLJJJG(string INOMFGBIBAN, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEED0", Offset = "0x6BAE2D0", VA = "0x186BAEED0", Slot = "22")]
	public MOBFMCMMEBH HIOGLKBCGCG(string INMDJPLJIPK, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF050", Offset = "0x6BAE450", VA = "0x186BAF050", Slot = "23")]
	public Task IMEEJDELEHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6BAE390", Offset = "0x6BAD790", VA = "0x186BAE390")]
	private static void AIMGFIEHBNA(TaskCompletionSource<bool> AEJJDMNDMNA, Task FJLKMMCFODI, Task ADNJDODOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF210", Offset = "0x6BAE610", VA = "0x186BAF210")]
	[AsyncStateMachine(typeof(HCBOINLGBGP))]
	private static void KFBMEIOJBFO(Task FFKGFPJNCFN, TaskCompletionSource<bool> AEJJDMNDMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA732C0", Offset = "0xA726C0", VA = "0x180A732C0")]
	[CompilerGenerated]
	private void MCDHKHOFFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9EF140", Offset = "0x9EE540", VA = "0x1809EF140")]
	[CompilerGenerated]
	private void FIDBGPHHLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x938E70", Offset = "0x938270", VA = "0x180938E70")]
	[CompilerGenerated]
	private void BBIBKEFFIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6BAEAD0", Offset = "0x6BADED0", VA = "0x186BAEAD0")]
	[CompilerGenerated]
	private void FBJBJEKJIEG(EKJOGAEIMAH AKMABNIDADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class DDJJCONFBBF : MOBFMCMMEBH, PDPDLDKLCAK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void BPOEKIAFEHF(EKJOGAEIMAH GICHGNHCGPG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly BPOEKIAFEHF GDEKLAOHFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly HFMNBMEIMMK OGHMNCGLODG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string FLMLNILMENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x990050", Offset = "0x98F450", VA = "0x180990050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2CF0", Offset = "0x5ED20F0", VA = "0x185ED2CF0")]
	public DDJJCONFBBF(HFMNBMEIMMK BOJMNCJMGLC, [Optional] BPOEKIAFEHF BCDPFPJFLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2CE1960", Offset = "0x2CE0D60", VA = "0x182CE1960", Slot = "5")]
	public T GEKLBPFDDHO<T>(string PBFBBOFLBNL, T POOOEFHFGKB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface FCNIMAHEHOB
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class NMIGNJLKIHH : FCNIMAHEHOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly DHDIHPDGFCI ECOAEGFAJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<MHDFKDJGFLL> DBDGJKAOMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string EIDBOGNNHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string MGAKEDLBJNL;

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5F40", Offset = "0x6BB5340", VA = "0x186BB5F40")]
	[UsedImplicitly]
	[GOEIKLHOLGG.KCHBNNLNADK.IBDMBHIFIDC]
	internal static void LHFLNIJFEKK(MCLDCOGKKML HOCJPKACMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5FB0", Offset = "0x6BB53B0", VA = "0x186BB5FB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NMIGNJLKIHH([NDMEANGLJKD(null)][NotNull] DHDIHPDGFCI ECOAEGFAJAI, [NDMEANGLJKD(null)][NotNull] DMMFDJPDPFA NGLJOPEPKJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LPGFLABGLFP : KOFDFCJMCJL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task OONEOPHFGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6BB16A0", Offset = "0x6BB0AA0", VA = "0x186BB16A0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool AFMAAKFKMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BGAGFEFIMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8B6510", Offset = "0x8B5910", VA = "0x1808B6510", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EABNDPLDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LOOKHIBLIDO FLCAPNACMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action IPFEMDCFHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1730", Offset = "0x6BB0B30", VA = "0x186BB1730", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1360", Offset = "0x6BB0760", VA = "0x186BB1360", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action MEFOMHMGJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1860", Offset = "0x6BB0C60", VA = "0x186BB1860", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1550", Offset = "0x6BB0950", VA = "0x186BB1550", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action CLIKIJOFPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1210", Offset = "0x6BB0610", VA = "0x186BB1210", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1400", Offset = "0x6BB0800", VA = "0x186BB1400", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<EKJOGAEIMAH> GODPCHJDIMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6BB15F0", Offset = "0x6BB09F0", VA = "0x186BB15F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6BB12B0", Offset = "0x6BB06B0", VA = "0x186BB12B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	[RecRoom.NoEngine.Common.Preserve]
	public LPGFLABGLFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1AB0", Offset = "0x6BB0EB0", VA = "0x186BB1AB0", Slot = "12")]
	public Task NOCOEJHJFAP(string KHDJACBPLGA, [Optional] DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1A20", Offset = "0x6BB0E20", VA = "0x186BB1A20", Slot = "18")]
	public Task NJLMIGMMLEF(DJDKDGDBPJE DELDIDDNALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1990", Offset = "0x6BB0D90", VA = "0x186BB1990", Slot = "19")]
	public Task KODBEKEOBBL(DJDKDGDBPJE DELDIDDNALP, Dictionary<string, string> PNBHDIMDAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "20")]
	public bool BIDNDJGDKBK(string CICMEKNNFLA, bool ADEBFBENACI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB14A0", Offset = "0x6BB08A0", VA = "0x186BB14A0", Slot = "21")]
	public NPKPIDLHIHG CNKOLGLJJJG(string INOMFGBIBAN, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6BB17D0", Offset = "0x6BB0BD0", VA = "0x186BB17D0", Slot = "22")]
	public MOBFMCMMEBH HIOGLKBCGCG(string INMDJPLJIPK, bool ADEBFBENACI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1900", Offset = "0x6BB0D00", VA = "0x186BB1900", Slot = "23")]
	public Task IMEEJDELEHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class KPNIGIDPJMP : LOOKHIBLIDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly KJGPLHOLNJM IMEGOBFAANC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> FAGFLCFBIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x98A9E0", Offset = "0x989DE0", VA = "0x18098A9E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	public KPNIGIDPJMP(KJGPLHOLNJM HPALKGMLBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface CEGIGDBMGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FEMAKIOPNHI KECCAALKEPD(string LLFIBDHGBMN);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FIKBJGAFEKF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum LONIMEMKOMM
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long EFAKEOLJMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string OIGDIACMHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string ENCOJMDNMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool GMDIDMNGAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long APEKACJPEOC();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELLONMHEODK(long BDFLMLIOLFG, bool KOOFLMJHMNP = true);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPHDKMELDPI(string EPLPPJHJIIM, string MEMLHACPINH, string KCKIJPIPFAO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONLBOMGKFOH(string EPLPPJHJIIM);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPHBOLHIIBG(string EPLPPJHJIIM, string NCCHBMKMDLE, string IMEHBAFJPEJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PFJHOAELABI(string NJNIIEFNNGN, object OFMGKDHHAJC, object LMGKJNKMCOB);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JNKMCEIPPCI(LONIMEMKOMM KKHKNDHPJIF, int LBJJAOIKGCM, [Optional] GFMLPMHGMOD OCCLOMHLGEB, [Optional] string AGGBMGNIPJI, [Optional] string IBDGAGPHJHE);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PANPJGNCOJO(GFMLPMHGMOD OCCLOMHLGEB, long EEPJGCLBEAH, long NFOGMJHFPIO, int FJKMBEJCCLI, string AGGBMGNIPJI, int LBJJAOIKGCM);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OMKLAIDNEJP(GFMLPMHGMOD OCCLOMHLGEB, bool PFAIALOBFLL, [Optional] string IBDGAGPHJHE);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HPCFLMCMCGE(GFMLPMHGMOD OCCLOMHLGEB, bool PFAIALOBFLL, [Optional] string IBDGAGPHJHE);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EOPFAHFIMIC(GFMLPMHGMOD OCCLOMHLGEB, bool PFAIALOBFLL, [Optional] string IBDGAGPHJHE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EJACNJCNPKJ(long HLKBDGNJMKK, string EPJHNHOPBEG);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface CJHHGDKBMFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string FHEDBLIKCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
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
