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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EADDA0", Offset = "0x5EACBA0", VA = "0x185EADDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
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
		public AmplitudeAnalyticsClient.Settings AADAOOKCNGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LCDPHHAADFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum LCNKBEKPMDH
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class BGLOFHOEMLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class KNLNPOFCADC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int BBMHGIKJDAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> MNJNLGKEDBL;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
				public KNLNPOFCADC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class OJJOKCJAEIJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
				public OJJOKCJAEIJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5EADE20", Offset = "0x5EACC20", VA = "0x185EADE20")]
				internal bool ADEGLCFIACB(KNLNPOFCADC item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string JCGGILHJDLH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string CIPMAAMIEBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<KNLNPOFCADC> FMNDDNKBMBM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? HIDGLMHGPEO
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5EA8C90", Offset = "0x5EA7A90", VA = "0x185EA8C90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5EA93A0", Offset = "0x5EA81A0", VA = "0x185EA93A0")]
			internal BGLOFHOEMLH(string NLEFFIFJOJG, string IGPHCGEAIPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8F80", Offset = "0x5EA7D80", VA = "0x185EA8F80")]
			public int KKEKJEJKONP([Optional] int? KECMLEHMLJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9130", Offset = "0x5EA7F30", VA = "0x185EA9130")]
			public List<Dictionary<string, object>> OMAIAHNDPKC(int BGDCMMNFKAH, int? KECMLEHMLJB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8380", Offset = "0x5EA7180", VA = "0x185EA8380")]
			public void BGAGKOBCJDC(AmplitudeAnalyticsIdentifyMessage NHLNHJGAONN, bool NJANACJJGLK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8270", Offset = "0x5EA7070", VA = "0x185EA8270")]
			public void BGAGKOBCJDC(Dictionary<string, object> NHLNHJGAONN, bool NJANACJJGLK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA80E0", Offset = "0x5EA6EE0", VA = "0x185EA80E0")]
			public void ABAJGJCLJOD(params Dictionary<string, object>[] MIIMDAHFFAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8D30", Offset = "0x5EA7B30", VA = "0x185EA8D30")]
			public void INDJDDAMJOM(List<Dictionary<string, object>> BLCEJFOGCGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8B80", Offset = "0x5EA7980", VA = "0x185EA8B80")]
			private void FINKCCNCGPM(Dictionary<string, object> NHLNHJGAONN, bool NJANACJJGLK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8810", Offset = "0x5EA7610", VA = "0x185EA8810")]
			public void CHDFHIPMCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8420", Offset = "0x5EA7220", VA = "0x185EA8420")]
			private void CECEJGFIFNJ([Optional] string LKEDABJCIIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8A50", Offset = "0x5EA7850", VA = "0x185EA8A50")]
			private static string DHGANPGKPCI(string NKKIECLCEML, string JCMGBFKGKLO)
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
			[Cpp2IlInjected.Address(RVA = "0x5EAE990", Offset = "0x5EAD790", VA = "0x185EAE990")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct OKNCEMCEAKD<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int PKPPOOFOMAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string CLHBNLAKIMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T CIBEMHOEKCA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HKHMDJEAIMP : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private FOAIHJNBGIP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public HKHMDJEAIMP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EAB9C0", Offset = "0x5EAA7C0", VA = "0x185EAB9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EAC180", Offset = "0x5EAAF80", VA = "0x185EAC180", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LPHHJPNAOPP : IEnumerator<object>, IEnumerator, IDisposable
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
			public ANGKAGKCEHL quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public LPHHJPNAOPP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5EADC40", Offset = "0x5EACA40", VA = "0x185EADC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5EADD50", Offset = "0x5EACB50", VA = "0x185EADD50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AFLGFDAFEOB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public AFLGFDAFEOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F780", Offset = "0x5E9E580", VA = "0x185E9F780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F8F0", Offset = "0x5E9E6F0", VA = "0x185E9F8F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IPBLABEKLLP : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private FOAIHJNBGIP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public IPBLABEKLLP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5EAC310", Offset = "0x5EAB110", VA = "0x185EAC310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5EAC590", Offset = "0x5EAB390", VA = "0x185EAC590", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class APFGMOFMIIB : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private FOAIHJNBGIP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public APFGMOFMIIB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F940", Offset = "0x5E9E740", VA = "0x185E9F940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FBD0", Offset = "0x5E9E9D0", VA = "0x185E9FBD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HJLHLOCEPIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public BGLOFHOEMLH cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public HJLHLOCEPIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5EAB6A0", Offset = "0x5EAA4A0", VA = "0x185EAB6A0")]
			internal void NKKKMGDNHCN(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5EAB250", Offset = "0x5EAA050", VA = "0x185EAB250")]
			internal void GDGGAKLJAHP(OKNCEMCEAKD<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ABFBJHDHJLD : IEnumerator<FOAIHJNBGIP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private FOAIHJNBGIP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public BGLOFHOEMLH cache;

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
			private HJLHLOCEPIL <>8__1;

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
			private FOAIHJNBGIP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
			[DebuggerHidden]
			public ABFBJHDHJLD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D6D0", Offset = "0x5E9C4D0", VA = "0x185E9D6D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5E9DF80", Offset = "0x5E9CD80", VA = "0x185E9DF80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CBBHOMBPBGF<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public CBBHOMBPBGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x38435C0", Offset = "0x38423C0", VA = "0x1838435C0")]
			internal OKNCEMCEAKD<T> JEFJKEDAAAE(JJCPOFKHGDN postResponse)
			{
				return default(OKNCEMCEAKD<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class ICNMBNICHHA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public ICNMBNICHHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x38435C0", Offset = "0x38423C0", VA = "0x1838435C0")]
			internal OKNCEMCEAKD<T> OMBLGFNAPOO(JJCPOFKHGDN postResponse)
			{
				return default(OKNCEMCEAKD<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private HFAMIEFFJOH KBBBIKNOPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<NICMMJBEPIA> IJIEJBIIFME;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string JFMILBGHNCO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string NHHMNIGMPIN = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string NFKPDPOKKGE = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CMKBCEJKJBJ = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int GMOIIEHEBBG = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int JGBKBBFAIKK = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float OFCMEDNEAEH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long IFCBHHNCNHF = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string IGMGKOJNOLN = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string HBGIOHDLOMA = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool CFLFLMNCMLG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool PKGCCKOGNHJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int GPDKBBNOECL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int LFAJADNPDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private EEJAAPEDOLN KJJKFHFNHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MKOEHDNOPLE MDLEDGGLPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private OGIDGGHNIHC DDOAIEIAION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BEIDEAFICOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float FMPBPBDBPEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float FDKCAPMNFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int GIBJACANMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int OGNPIKGCNIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? IENEMPLENNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? MGNBADBNIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long AOHMLPDFKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string FKDINCJCFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool OBIFIAJBBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long JFGADANBIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string AIDBPIJBHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string GLICJOGDKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> GMNJGEAEPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LCNKBEKPMDH EANBJHJMMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int BHNDAFBHDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int ICFABHDBCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float BDAKJHBOADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool HDCLFJDJOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool HKMEKAMIGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private BGLOFHOEMLH JJENECKJMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private BGLOFHOEMLH BLALBFOFFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BGLOFHOEMLH ADGEBCHODBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> KODBJIJPFOE;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BKBIBGIPPNL;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string IPLBCDGLCPE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string KNLBGKEBOPO = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string EDDCHBFIMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string OBNNHFDKIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string NDHCPINEOEH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HFAMIEFFJOH BMMECOPCBAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1110", Offset = "0x5E9FF10", VA = "0x185EA1110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NICMMJBEPIA MLMHDJMEIAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3CC0", Offset = "0x5EA2AC0", VA = "0x185EA3CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OBOAFKBLIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2B90", Offset = "0x5EA1990", VA = "0x185EA2B90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OJNBIEEENNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA57C0", Offset = "0x5EA45C0", VA = "0x185EA57C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA58E0", Offset = "0x5EA46E0", VA = "0x185EA58E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string OKNAFFHGPEH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5760", Offset = "0x5EA4560", VA = "0x185EA5760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string DBIJEHDFOPB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5790", Offset = "0x5EA4590", VA = "0x185EA5790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PJAHLIHHFKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x867FA0", Offset = "0x866DA0", VA = "0x180867FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x867FC0", Offset = "0x866DC0", VA = "0x180867FC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? DICMJKCGDBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8950A0", Offset = "0x893EA0", VA = "0x1808950A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5EA58D0", Offset = "0x5EA46D0", VA = "0x185EA58D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DCLJBOMEJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF189E0", Offset = "0xF177E0", VA = "0x180F189E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF18A90", Offset = "0xF17890", VA = "0x180F18A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool MIOGJLNFJPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5660", Offset = "0x5EA4460", VA = "0x185EA5660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JODIMBLNDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA55A0", Offset = "0x5EA43A0", VA = "0x185EA55A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA5810", Offset = "0x5EA4610", VA = "0x185EA5810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0080", Offset = "0x5E9EE80", VA = "0x185EA0080", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0650", Offset = "0x5E9F450", VA = "0x185EA0650")]
		private void BBMJBIFIBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4B80", Offset = "0x5EA3980", VA = "0x185EA4B80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3D60", Offset = "0x5EA2B60", VA = "0x185EA3D60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4F20", Offset = "0x5EA3D20", VA = "0x185EA4F20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3E20", Offset = "0x5EA2C20", VA = "0x185EA3E20")]
		public AJKHGLHHDGH PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2A00", Offset = "0x5EA1800", VA = "0x185EA2A00")]
		[IteratorStateMachine(typeof(HKHMDJEAIMP))]
		public IEnumerator<FOAIHJNBGIP> Initialize(AmplitudeAnalyticsEvent GIKEEIHDDEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4E60", Offset = "0x5EA3C60", VA = "0x185EA4E60")]
		public void UpdateLastKnownInteractionCategory(string GLIOGKABBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4D70", Offset = "0x5EA3B70", VA = "0x185EA4D70")]
		public void UpdateLastAliveTime(float KNBDFHCBHGA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3C00", Offset = "0x5EA2A00", VA = "0x185EA3C00")]
		private AJKHGLHHDGH NJPLDIKFJHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FC20", Offset = "0x5E9EA20", VA = "0x185E9FC20")]
		private AJKHGLHHDGH ANGLEPEGOBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5EA45D0", Offset = "0x5EA33D0", VA = "0x185EA45D0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1180", Offset = "0x5E9FF80", VA = "0x185EA1180")]
		[IteratorStateMachine(typeof(LPHHJPNAOPP))]
		private IEnumerator DOGAPLFALEC(ANGKAGKCEHL OFMJMBHGKKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5EA51B0", Offset = "0x5EA3FB0", VA = "0x185EA51B0")]
		[IteratorStateMachine(typeof(AFLGFDAFEOB))]
		public IEnumerator WaitForFlush(float GAODDMEEHFK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4C50", Offset = "0x5EA3A50", VA = "0x185EA4C50")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4B90", Offset = "0x5EA3990", VA = "0x185EA4B90")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime JKFFGJGCLAE)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2570", Offset = "0x5EA1370", VA = "0x185EA2570")]
		public static IALFAMDPIOG Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FF10", Offset = "0x5E9ED10", VA = "0x185E9FF10")]
		public static EEBEJFIIEKO AccountSelectionPostLoginEvent([NotNull] string HKPACKMOMHA, string HNCMMELDDJD, bool EOPFFJIFMBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1210", Offset = "0x5EA0010", VA = "0x185EA1210")]
		public static EEBEJFIIEKO Event([NotNull] string HKPACKMOMHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3E60", Offset = "0x5EA2C60", VA = "0x185EA3E60")]
		public static EEBEJFIIEKO PreviousSessionEvent([NotNull] string HKPACKMOMHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2720", Offset = "0x5EA1520", VA = "0x185EA2720")]
		public static EEBEJFIIEKO InitializeEvent(string HNCMMELDDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4790", Offset = "0x5EA3590", VA = "0x185EA4790")]
		public static EEBEJFIIEKO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0C00", Offset = "0x5E9FA00", VA = "0x185EA0C00")]
		public static EEBEJFIIEKO CreateOutOfSessionEvent(string HKPACKMOMHA, bool GIIMBNINHND = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3250", Offset = "0x5EA2050", VA = "0x185EA3250")]
		public static AJKHGLHHDGH LogOutOfSessionEvent(EEBEJFIIEKO PGMABGPIOEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2FD0", Offset = "0x5EA1DD0", VA = "0x185EA2FD0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent OCMBNAOKGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3540", Offset = "0x5EA2340", VA = "0x185EA3540")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent OCMBNAOKGFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3680", Offset = "0x5EA2480", VA = "0x185EA3680")]
		public void LogSerializedEventAsync(Dictionary<string, object> CKNLPGCPMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3110", Offset = "0x5EA1F10", VA = "0x185EA3110")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage AADMCDLNHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2A90", Offset = "0x5EA1890", VA = "0x185EA2A90")]
		private void JOLENNCNMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0E60", Offset = "0x5E9FC60", VA = "0x185EA0E60")]
		private void DFNAGHPNCHK(Dictionary<string, object> ECAHKGEBDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2480", Offset = "0x5EA1280", VA = "0x185EA2480")]
		private void HEKAPAGHPFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2D70", Offset = "0x5EA1B70", VA = "0x185EA2D70")]
		private void LLHPJGMHMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1720", Offset = "0x5EA0520", VA = "0x185EA1720")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2F40", Offset = "0x5EA1D40", VA = "0x185EA2F40")]
		[IteratorStateMachine(typeof(IPBLABEKLLP))]
		private IEnumerator<FOAIHJNBGIP> LPCHCLNIPFH(float GAODDMEEHFK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3B70", Offset = "0x5EA2970", VA = "0x185EA3B70")]
		[IteratorStateMachine(typeof(APFGMOFMIIB))]
		private IEnumerator<FOAIHJNBGIP> NGOJKGABOMF(float GAODDMEEHFK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1620", Offset = "0x5EA0420", VA = "0x185EA1620")]
		[IteratorStateMachine(typeof(ABFBJHDHJLD))]
		private IEnumerator<FOAIHJNBGIP> FOPJLDPOIPA(BGLOFHOEMLH FNFFBGBDPIP, int? KECMLEHMLJB, string KCHGOIKJPKL, string OIJKFOGMFCF, float GAODDMEEHFK, Action<int> JMANHPLEKLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1510", Offset = "0x5EA0310", VA = "0x185EA1510")]
		private static void FGMPMEFDPBK(bool KHJOCJICPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3760", Offset = "0x5EA2560", VA = "0x185EA3760")]
		private DOPLGHLIBGN<OKNCEMCEAKD<Dictionary<string, object>>> NCJMNMHFCNA(string KCHGOIKJPKL, string OIJKFOGMFCF, string NLCIFBAHGHH, string NDJHPMJIJIK, Dictionary<string, object> CIBEMHOEKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3890", Offset = "0x5EA2690", VA = "0x185EA3890")]
		private DOPLGHLIBGN<OKNCEMCEAKD<List<Dictionary<string, object>>>> NCJMNMHFCNA(string KCHGOIKJPKL, string OIJKFOGMFCF, string NLCIFBAHGHH, string NDJHPMJIJIK, List<Dictionary<string, object>> CIBEMHOEKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC960", Offset = "0x2CEB760", VA = "0x182CEC960")]
		private DOPLGHLIBGN<OKNCEMCEAKD<T>> GAJGNPIHPGL<T>(string KCHGOIKJPKL, string OIJKFOGMFCF, string NDJHPMJIJIK, T CIBEMHOEKCA, Dictionary<string, object> KFNPKPAEDLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2CECC20", Offset = "0x2CEBA20", VA = "0x182CECC20")]
		private DOPLGHLIBGN<OKNCEMCEAKD<T>> IHKMIDOBIPD<T>(string KCHGOIKJPKL, string OIJKFOGMFCF, string NLCIFBAHGHH, T CIBEMHOEKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3D10", Offset = "0x5EA2B10", VA = "0x185EA3D10")]
		private bool NMPDENJGGPM(float LDECMGDMHAF, float GAODDMEEHFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EA17B0", Offset = "0x5EA05B0", VA = "0x185EA17B0")]
		private Dictionary<string, object> HDBBNHHFLCB(string OIJKFOGMFCF, Dictionary<string, object> CIBEMHOEKCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EA52A0", Offset = "0x5EA40A0", VA = "0x185EA52A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EA04F0", Offset = "0x5E9F2F0", VA = "0x185EA04F0")]
		[CompilerGenerated]
		private long BBGIAAOGDPD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0BF0", Offset = "0x5E9F9F0", VA = "0x185EA0BF0")]
		[CompilerGenerated]
		private void BHOFIECMBFO(int CBLLOOKOKLF)
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
			[Cpp2IlInjected.Address(RVA = "0x5EA6640", Offset = "0x5EA5440", VA = "0x185EA6640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6720", Offset = "0x5EA5520", VA = "0x185EA6720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6680", Offset = "0x5EA5480", VA = "0x185EA6680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6780", Offset = "0x5EA5580", VA = "0x185EA6780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA6600", Offset = "0x5EA5400", VA = "0x185EA6600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA66C0", Offset = "0x5EA54C0", VA = "0x185EA66C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5BB0", Offset = "0x5EA49B0", VA = "0x185EA5BB0")]
		public static EEBEJFIIEKO IKNJBMGGGFK(string ILCLKBNEPAJ, [NotNull] string EIPJHIINIAJ, long LLHHLGJOCAN, long AAJOFFBNIIN, string HNCMMELDDJD, bool EOPFFJIFMBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5940", Offset = "0x5EA4740", VA = "0x185EA5940")]
		public static EEBEJFIIEKO AFOIONPGECB(string ILCLKBNEPAJ, [NotNull] string EIPJHIINIAJ, long LLHHLGJOCAN, long AAJOFFBNIIN, string HNCMMELDDJD, long OEGGIPOFEGG, bool EOPFFJIFMBG, string JDOFFOKOCBC, string GGBKHCGMNFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6470", Offset = "0x5EA5270", VA = "0x185EA6470")]
		private AmplitudeAnalyticsEvent(string ILCLKBNEPAJ, [NotNull] string EIPJHIINIAJ, long LLHHLGJOCAN, long AAJOFFBNIIN, string HNCMMELDDJD, bool EOPFFJIFMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1A001B0", Offset = "0x19FEFB0", VA = "0x181A001B0")]
		public void EKMCAMKPCAC(long MOLNKCDLPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5AA0", Offset = "0x5EA48A0", VA = "0x185EA5AA0", Slot = "5")]
		public override void GLGPDBKIENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5CB0", Offset = "0x5EA4AB0", VA = "0x185EA5CB0", Slot = "6")]
		public override void JFAPAPGHGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5E30", Offset = "0x5EA4C30", VA = "0x185EA5E30", Slot = "4")]
		protected override Dictionary<string, object> LIGJJPFNHDK(Dictionary<string, object> NGCGBPAJPDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6360", Offset = "0x5EA5160", VA = "0x185EA6360")]
		private void OGLBGOMMLGH(string JCMGBFKGKLO, string NKKIECLCEML, bool ACEMNKBHDEC = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5EAA770", Offset = "0x5EA9570", VA = "0x185EAA770")]
			public void ADAEKKBCNLL(Dictionary<string, object> DPHMNLAMECC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EAE620", Offset = "0x5EAD420", VA = "0x185EAE620")]
			public void ADAEKKBCNLL(Dictionary<string, object> MBGCHCGFLKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B02B0", Offset = "0x8AF0B0", VA = "0x1808B02B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6900", Offset = "0x5EA5700", VA = "0x185EA6900")]
		public static IALFAMDPIOG IKNJBMGGGFK(string ILCLKBNEPAJ, string HNCMMELDDJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6EA0", Offset = "0x5EA5CA0", VA = "0x185EA6EA0")]
		protected AmplitudeAnalyticsIdentifyMessage(string ILCLKBNEPAJ, string HNCMMELDDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA67E0", Offset = "0x5EA55E0", VA = "0x185EA67E0")]
		public Dictionary<string, object> EEBBGMILNAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6A50", Offset = "0x5EA5850", VA = "0x185EA6A50", Slot = "4")]
		protected virtual Dictionary<string, object> LIGJJPFNHDK(Dictionary<string, object> NGCGBPAJPDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6D90", Offset = "0x5EA5B90", VA = "0x185EA6D90")]
		protected void LMKMPBBKJBB(string JCMGBFKGKLO, Dictionary<string, object> DMAMCKDFKNC, Dictionary<string, object> PBNGFBJICEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6E30", Offset = "0x5EA5C30", VA = "0x185EA6E30")]
		protected void PBGBFFEIIKK(string JCMGBFKGKLO, string NKKIECLCEML, Dictionary<string, object> NCHBILLKCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6870", Offset = "0x5EA5670", VA = "0x185EA6870", Slot = "5")]
		public virtual void GLGPDBKIENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA69C0", Offset = "0x5EA57C0", VA = "0x185EA69C0", Slot = "6")]
		public virtual void JFAPAPGHGOG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IALFAMDPIOG : EPKAPIOBJEA<AmplitudeAnalyticsIdentifyMessage, IALFAMDPIOG>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override IALFAMDPIOG OCPDLEAAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage FJNCFODPMFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC280", Offset = "0x5EAB080", VA = "0x185EAC280")]
	public IALFAMDPIOG(AmplitudeAnalyticsIdentifyMessage EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC1D0", Offset = "0x5EAAFD0", VA = "0x185EAC1D0", Slot = "4")]
	public override void JFAPAPGHGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EEBEJFIIEKO : EPKAPIOBJEA<AmplitudeAnalyticsEvent, EEBEJFIIEKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool HAOOCCAGGJF;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override EEBEJFIIEKO OCPDLEAAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long MDOCCOONAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA990", Offset = "0x5EA9790", VA = "0x185EAA990")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA720", Offset = "0x5EA9520", VA = "0x185EAA720")]
	public EEBEJFIIEKO(AmplitudeAnalyticsEvent EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "5")]
	public override AmplitudeAnalyticsEvent FJNCFODPMFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA9B0", Offset = "0x5EA97B0", VA = "0x185EAA9B0", Slot = "4")]
	public override void JFAPAPGHGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x25C65F0", Offset = "0x25C53F0", VA = "0x1825C65F0")]
	public EEBEJFIIEKO NBMHPNAMELP<T>(string EDANCLIIPKG, T[] NKKIECLCEML) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x25C65F0", Offset = "0x25C53F0", VA = "0x1825C65F0")]
	public EEBEJFIIEKO NBMHPNAMELP(string EDANCLIIPKG, string[] NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x25C6340", Offset = "0x25C5140", VA = "0x1825C6340")]
	public EEBEJFIIEKO NBMHPNAMELP<T>(string EDANCLIIPKG, T NKKIECLCEML) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAB50", Offset = "0x5EA9950", VA = "0x185EAAB50")]
	public EEBEJFIIEKO NBMHPNAMELP(string EDANCLIIPKG, long NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAABD0", Offset = "0x5EA99D0", VA = "0x185EAABD0")]
	public EEBEJFIIEKO NBMHPNAMELP(string EDANCLIIPKG, string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAC40", Offset = "0x5EA9A40", VA = "0x185EAAC40")]
	public EEBEJFIIEKO PNCNFLLIOGA(string EDANCLIIPKG, object? NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA8F0", Offset = "0x5EA96F0", VA = "0x185EAA8F0")]
	public EEBEJFIIEKO CMNEGLCDBBN(string EDANCLIIPKG, string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAA50", Offset = "0x5EA9850", VA = "0x185EAAA50")]
	private EEBEJFIIEKO MANKIAOCGHN(string EDANCLIIPKG, object NKKIECLCEML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DLNAOEAGKBP : EEBEJFIIEKO
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA720", Offset = "0x5EA9520", VA = "0x185EAA720")]
	public DLNAOEAGKBP(AmplitudeAnalyticsEvent EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA570", Offset = "0x5EA9370", VA = "0x185EAA570", Slot = "4")]
	public override void JFAPAPGHGOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class EPKAPIOBJEA<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : EPKAPIOBJEA<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M EMKENBOOEOH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR OCPDLEAAKND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public EPKAPIOBJEA(M EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x326F380", Offset = "0x326E180", VA = "0x18326F380")]
	public BLDR DHMCIEBEGOL(AmplitudeAnalyticsIdentifyMessage.DeviceInfo NPOGHMJLJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x326F3D0", Offset = "0x326E1D0", VA = "0x18326F3D0")]
	public BLDR MHECMOMNFGB(AmplitudeAnalyticsIdentifyMessage.RevenueData MDGEPAOFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x326F300", Offset = "0x326E100", VA = "0x18326F300")]
	public BLDR BAAADLKOIGI(string EDANCLIIPKG, string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x240F4F0", Offset = "0x240E2F0", VA = "0x18240F4F0")]
	public BLDR BAAADLKOIGI<T>(string EDANCLIIPKG, T NKKIECLCEML) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JFAPAPGHGOG();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x326F520", Offset = "0x326E320", VA = "0x18326F520")]
	internal static string PGHOGHMDNPJ(string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x326F420", Offset = "0x326E220", VA = "0x18326F420")]
	private BLDR NLOHGMJBAEO(string EDANCLIIPKG, object NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M FJNCFODPMFE();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class DBAPODEMHPA : EEJAAPEDOLN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CDFOCGHKIEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<JJCPOFKHGDN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public DBAPODEMHPA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5EA9590", Offset = "0x5EA8390", VA = "0x185EA9590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9E30", Offset = "0x5EA8C30", VA = "0x185EA9E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct KPCLHMGPCIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<JJCPOFKHGDN> <>t__builder;

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
		public DBAPODEMHPA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5EAD1A0", Offset = "0x5EABFA0", VA = "0x185EAD1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EADBD0", Offset = "0x5EAC9D0", VA = "0x185EADBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient NDLLACDJJJO;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA1C0", Offset = "0x5EA8FC0", VA = "0x185EAA1C0")]
	[NAAAALLPNIA(PBKIGNPNCFO.None)]
	private static void EGJDAEJDEBN(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA4F0", Offset = "0x5EA92F0", VA = "0x185EAA4F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public DBAPODEMHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA230", Offset = "0x5EA9030", VA = "0x185EAA230", Slot = "4")]
	[AsyncStateMachine(typeof(CDFOCGHKIEL))]
	public Task<JJCPOFKHGDN> NCJMNMHFCNA(string KCHGOIKJPKL, Dictionary<string, string> FJMHMEDAALI, bool EJDDIEJJJGI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA380", Offset = "0x5EA9180", VA = "0x185EAA380", Slot = "5")]
	[AsyncStateMachine(typeof(KPCLHMGPCIF))]
	public Task<JJCPOFKHGDN> PMJCEHLECAI(string KCHGOIKJPKL, string MKLJEDABMLF, string DLOEODIGMHO, string MBLDJGILPOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FGPCHOADIHK
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> HKCPOGLOBJG;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAC70", Offset = "0x5EA9A70", VA = "0x185EAAC70")]
	internal static bool DBNKPKDGKOM(string JCMGBFKGKLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EEJAAPEDOLN
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<JJCPOFKHGDN> NCJMNMHFCNA(string KCHGOIKJPKL, Dictionary<string, string> FJMHMEDAALI, bool EJDDIEJJJGI = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<JJCPOFKHGDN> PMJCEHLECAI(string KCHGOIKJPKL, string MKLJEDABMLF, string DLOEODIGMHO, string MBLDJGILPOG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JJCPOFKHGDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int JJCGNCIPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string KHBLHLHGEIM;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xBA8D80", Offset = "0xBA7B80", VA = "0x180BA8D80")]
	public JJCPOFKHGDN(int PKPPOOFOMAJ, string CLHBNLAKIMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum BBBAAHBMNEE
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
public class OMGBFPDANHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long BENEBMKJFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private EEBEJFIIEKO HIMGEPKPMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FCMOJCBMJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float CCDJMNCOFOC;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE220", Offset = "0x5EAD020", VA = "0x185EAE220")]
	public OMGBFPDANHP(string NBDCKBDCMDN, float CCDJMNCOFOC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2858AE0", Offset = "0x28578E0", VA = "0x182858AE0")]
	public void NBMHPNAMELP<T>(string EDANCLIIPKG, T NKKIECLCEML) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE1A0", Offset = "0x5EACFA0", VA = "0x185EAE1A0")]
	public void NBMHPNAMELP(string EDANCLIIPKG, string NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EADE90", Offset = "0x5EACC90", VA = "0x185EADE90")]
	public void CPPLGOIBNOD(string GBOEIJONGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE0E0", Offset = "0x5EACEE0", VA = "0x185EAE0E0")]
	public void KOLHOLBFBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5EADFD0", Offset = "0x5EACDD0", VA = "0x185EADFD0")]
	private void HJJBBKPKPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5EADF80", Offset = "0x5EACD80", VA = "0x185EADF80")]
	private bool HAGDBGHNILM()
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
		public enum ADCCGPMLCFF
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
		private ADCCGPMLCFF parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ADCCGPMLCFF Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
			get
			{
				return default(ADCCGPMLCFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x800F00", Offset = "0x7FFD00", VA = "0x180800F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE790", Offset = "0x5EAD590", VA = "0x185EAE790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class IGLIAFMMLOE : BKMMOIEDEAL, MKKJBLCDNMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly KCCAOGHCMNL OLCEFOADHLK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string LOAKDDGDANA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10088D0", Offset = "0x10076D0", VA = "0x1810088D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AFLGINNPEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC2F0", Offset = "0x5EAB0F0", VA = "0x185EAC2F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FGGCAMOEBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC2D0", Offset = "0x5EAB0D0", VA = "0x185EAC2D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> NKAHFCGDKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1008520", Offset = "0x1007320", VA = "0x181008520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public IGLIAFMMLOE(KCCAOGHCMNL LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x26F47D0", Offset = "0x26F35D0", VA = "0x1826F47D0", Slot = "8")]
	public T IKJEAFPPDKF<T>(string JCMGBFKGKLO, T IDLIOJCDHNC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class AEFINBECDGA : LPDDOMPGFNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KHBPHKBBKJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AEFINBECDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MKOEHDNOPLE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EACCC0", Offset = "0x5EABAC0", VA = "0x185EACCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD140", Offset = "0x5EABF40", VA = "0x185EAD140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PKJEIJCBOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE3B0", Offset = "0x5EAD1B0", VA = "0x185EAE3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE5C0", Offset = "0x5EAD3C0", VA = "0x185EAE5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct COMJIGFKLJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AEFINBECDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MKOEHDNOPLE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9EA0", Offset = "0x5EA8CA0", VA = "0x185EA9EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA160", Offset = "0x5EA8F60", VA = "0x185EAA160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct HHEGNCCGNLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AEFINBECDGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public MKOEHDNOPLE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAE20", Offset = "0x5EA9C20", VA = "0x185EAAE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB1F0", Offset = "0x5EA9FF0", VA = "0x185EAB1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly IReadOnlyDictionary<string, NDDMEENNDFP> EDFDNCIFMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool KHEJBIMIKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private KBFOKLOOEMH FJAAEMMJPJG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string PJAHLIHHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E970", Offset = "0x5E9D770", VA = "0x185E9E970", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EEBOGCBDPLP GNMDCKIGNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EA20", Offset = "0x5E9D820", VA = "0x185E9EA20", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AGDDLFPBNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EAC0", Offset = "0x5E9D8C0", VA = "0x185E9EAC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EC70", Offset = "0x5E9DA70", VA = "0x185E9EC70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JBDMNOENIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E2A0", Offset = "0x5E9D0A0", VA = "0x185E9E2A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E980", Offset = "0x5E9D780", VA = "0x185E9E980", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E630", Offset = "0x5E9D430", VA = "0x185E9E630", Slot = "8")]
	[AsyncStateMachine(typeof(KHBPHKBBKJF))]
	public Task FCIFMHNEBDM(string IFOEIMOAJAH, string IGPHCGEAIPC, [Optional] MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E580", Offset = "0x5E9D380", VA = "0x185E9E580", Slot = "17")]
	[AsyncStateMachine(typeof(PKJEIJCBOBC))]
	public Task ENOKKABCJNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E800", Offset = "0x5E9D600", VA = "0x185E9E800", Slot = "12")]
	[AsyncStateMachine(typeof(COMJIGFKLJI))]
	public Task HIACMKCJMNF(MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E190", Offset = "0x5E9CF90", VA = "0x185E9E190", Slot = "13")]
	[AsyncStateMachine(typeof(HHEGNCCGNLL))]
	public Task AAOLFNMBPAH(MKOEHDNOPLE PHFNNADJJGH, Dictionary<string, string> EJDEBPAGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E340", Offset = "0x5E9D140", VA = "0x185E9E340", Slot = "14")]
	public bool BOEJCBGJNMO(string KLPMOMFGLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E8F0", Offset = "0x5E9D6F0", VA = "0x185E9E8F0", Slot = "15")]
	public BKMMOIEDEAL HJKJFEPHGKD(string KPNBFDDMNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9DFD0", Offset = "0x5E9CDD0", VA = "0x185E9DFD0")]
	private KCCAOGHCMNL AAENBHPEPDE(string KPNBFDDMNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F5C0", Offset = "0x5E9E3C0", VA = "0x185E9F5C0", Slot = "16")]
	public AGBEBGNLOJO PICEKEGCBOL(string AIMEEGKBNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E770", Offset = "0x5E9D570", VA = "0x185E9E770")]
	private MIDNKEDAAIF GGMNIAIKEAO(string AIMEEGKBNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ED10", Offset = "0x5E9DB10", VA = "0x185E9ED10")]
	private MIAJNLPPOBF PBFLEBMPBME(MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E3D0", Offset = "0x5E9D1D0", VA = "0x185E9E3D0")]
	private DAIEMIIHAOM COIABGNAOBB(string IGPHCGEAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EB60", Offset = "0x5E9D960", VA = "0x185E9EB60")]
	private void LPJAPHICGKL(string KPNBFDDMNMH, KCCAOGHCMNL LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public AEFINBECDGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class BCMLKAIHMJM : LPDDOMPGFNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JDNIIKFMFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public BCMLKAIHMJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public MKOEHDNOPLE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string clientSdkKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC5E0", Offset = "0x5EAB3E0", VA = "0x185EAC5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EACC60", Offset = "0x5EABA60", VA = "0x185EACC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LPDDOMPGFNK AJEPMIJBNBG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private LPDDOMPGFNK AJLKPLFIPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5EA71D0", Offset = "0x5EA5FD0", VA = "0x185EA71D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7490", Offset = "0x5EA6290", VA = "0x185EA7490", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string PJAHLIHHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EA76A0", Offset = "0x5EA64A0", VA = "0x185EA76A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EEBOGCBDPLP GNMDCKIGNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7790", Offset = "0x5EA6590", VA = "0x185EA7790", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGDDLFPBNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7850", Offset = "0x5EA6650", VA = "0x185EA7850", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA78F0", Offset = "0x5EA66F0", VA = "0x185EA78F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action JBDMNOENIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7080", Offset = "0x5EA5E80", VA = "0x185EA7080", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5EA76F0", Offset = "0x5EA64F0", VA = "0x185EA76F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[UnityEngine.Scripting.Preserve]
	public BCMLKAIHMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7AB0", Offset = "0x5EA68B0", VA = "0x185EA7AB0")]
	[NAAAALLPNIA(PBKIGNPNCFO.GameOnly)]
	private static void PMDBOALDHOL(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7990", Offset = "0x5EA6790", VA = "0x185EA7990")]
	[NAAAALLPNIA(PBKIGNPNCFO.EditorOnly)]
	private static void MPOKDMIKMNJ(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7350", Offset = "0x5EA6150", VA = "0x185EA7350", Slot = "8")]
	[AsyncStateMachine(typeof(JDNIIKFMFMI))]
	public Task FCIFMHNEBDM(string IFOEIMOAJAH, string IGPHCGEAIPC, [Optional] MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EA74E0", Offset = "0x5EA62E0", VA = "0x185EA74E0", Slot = "12")]
	public Task HIACMKCJMNF(MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6F60", Offset = "0x5EA5D60", VA = "0x185EA6F60", Slot = "13")]
	public Task AAOLFNMBPAH(MKOEHDNOPLE PHFNNADJJGH, Dictionary<string, string> EJDEBPAGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7120", Offset = "0x5EA5F20", VA = "0x185EA7120", Slot = "14")]
	public bool BOEJCBGJNMO(string KLPMOMFGLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EA75F0", Offset = "0x5EA63F0", VA = "0x185EA75F0", Slot = "15")]
	public BKMMOIEDEAL HJKJFEPHGKD(string KPNBFDDMNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7A00", Offset = "0x5EA6800", VA = "0x185EA7A00", Slot = "16")]
	public AGBEBGNLOJO PICEKEGCBOL(string AIMEEGKBNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7240", Offset = "0x5EA6040", VA = "0x185EA7240", Slot = "17")]
	public Task ENOKKABCJNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8E4890", Offset = "0x8E3690", VA = "0x1808E4890")]
	[CompilerGenerated]
	private void LOMHOEBAGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0xBB1B70", Offset = "0xBB0970", VA = "0x180BB1B70")]
	[CompilerGenerated]
	private void MIPFOOICEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class GJLJAHCFDLJ : AGBEBGNLOJO, MKKJBLCDNMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly MIDNKEDAAIF EDLENHJLHDD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string LOAKDDGDANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1008770", Offset = "0x1007570", VA = "0x181008770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public GJLJAHCFDLJ(MIDNKEDAAIF HDLBMFBCCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x26F47D0", Offset = "0x26F35D0", VA = "0x1826F47D0", Slot = "5")]
	public T IKJEAFPPDKF<T>(string JCMGBFKGKLO, T IDLIOJCDHNC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class BEJALAKPPBJ : LPDDOMPGFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string PJAHLIHHFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EEBOGCBDPLP GNMDCKIGNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action AGDDLFPBNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7F20", Offset = "0x5EA6D20", VA = "0x185EA7F20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7FC0", Offset = "0x5EA6DC0", VA = "0x185EA7FC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JBDMNOENIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7BB0", Offset = "0x5EA69B0", VA = "0x185EA7BB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7E80", Offset = "0x5EA6C80", VA = "0x185EA7E80", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BEJALAKPPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7CE0", Offset = "0x5EA6AE0", VA = "0x185EA7CE0", Slot = "8")]
	public Task FCIFMHNEBDM(string IFOEIMOAJAH, string IGPHCGEAIPC, [Optional] MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7D70", Offset = "0x5EA6B70", VA = "0x185EA7D70", Slot = "12")]
	public Task HIACMKCJMNF(MKOEHDNOPLE PHFNNADJJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7B20", Offset = "0x5EA6920", VA = "0x185EA7B20", Slot = "13")]
	public Task AAOLFNMBPAH(MKOEHDNOPLE PHFNNADJJGH, Dictionary<string, string> EJDEBPAGFMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "14")]
	public bool BOEJCBGJNMO(string KLPMOMFGLMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7E00", Offset = "0x5EA6C00", VA = "0x185EA7E00", Slot = "15")]
	public BKMMOIEDEAL HJKJFEPHGKD(string KPNBFDDMNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8060", Offset = "0x5EA6E60", VA = "0x185EA8060", Slot = "16")]
	public AGBEBGNLOJO PICEKEGCBOL(string AIMEEGKBNGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7C50", Offset = "0x5EA6A50", VA = "0x185EA7C50", Slot = "17")]
	public Task ENOKKABCJNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal class KBFOKLOOEMH : EEBOGCBDPLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly MIAJNLPPOBF FJAAEMMJPJG;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IReadOnlyDictionary<string, object> EJFFGGEONDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1008770", Offset = "0x1007570", VA = "0x181008770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public KBFOKLOOEMH(MIAJNLPPOBF CJAGNFFJHJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface HPMPAKIADIL
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMGBFPDANHP IFNLDPNMOMM(string NBDCKBDCMDN);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface OGIDGGHNIHC
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum JPAKMGOFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	long MBBALGFNBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string PDNJEBOJJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string LIKEMKHLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string KNFEPFPFCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	string MHBNBLINEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IPKFEPBJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long ALDFOMMEELD();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHGMGAIIOML(long LLHHLGJOCAN, bool ACEMNKBHDEC = true);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AGIDPFMFOIM(string HOLFPPNPJAH, string DGBADOOLHJG, string AANOPMOEPIO);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LBNCKPBNGHC(string HOLFPPNPJAH);

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DIPIBBHFHLG(string HOLFPPNPJAH, string NLLNMCENNDM, string LPGDOLMOENP);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OGOFEPFGCED(string IDNKFILIEMP, object ICDDEAPJHKM, object IGPCHCDBCNJ);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LIGLGHPKIND(JPAKMGOFOKJ JCIDCNDAKFD, int LBCEMAMCEGO, [Optional] FMBMDIHMAAF MABALBDICBH, [Optional] string FCIEOFLLLDL, [Optional] string OLGJDMIGDKI);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFDEIKPBNBH(FMBMDIHMAAF MABALBDICBH, long OKAOHPGOHIB, long BAEIOIMPBPE, int GDPIKLBFKNE, string FCIEOFLLLDL, int LBCEMAMCEGO);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LFPMIHMBBJO(FMBMDIHMAAF MABALBDICBH, bool BECNKAICFJI, [Optional] string OLGJDMIGDKI);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DEHCHJCHNBM(FMBMDIHMAAF MABALBDICBH, bool BECNKAICFJI, [Optional] string OLGJDMIGDKI);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GOMLIFKLMBM(FMBMDIHMAAF MABALBDICBH, bool BECNKAICFJI, [Optional] string OLGJDMIGDKI);
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
