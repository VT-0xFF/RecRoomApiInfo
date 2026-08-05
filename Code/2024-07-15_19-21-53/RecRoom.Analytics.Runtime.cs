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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6756060", Offset = "0x6754860", VA = "0x186756060")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C200", VA = "0x18087DA00")]
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
		public AmplitudeAnalyticsClient.Settings IOLJFFMHHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ALJFEJIJPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x8551B0", VA = "0x1808569B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum JGDLCOHPPNG
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class PHOHBDFCLCL
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class BMGBPIDDJDH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int IFKNCEGLIHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> NLLJGFAOMAM;

				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
				public BMGBPIDDJDH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class AOHCMCBFPAP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
				public AOHCMCBFPAP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x6748000", Offset = "0x6746800", VA = "0x186748000")]
				internal bool ILIHCHFOMKC(BMGBPIDDJDH item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string EGEGBMPNEOE = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string BECGFNBELMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<BMGBPIDDJDH> OGOEEEFCEPA;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? FAFDKOPBNKM
			{
				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6757A50", Offset = "0x6756250", VA = "0x186757A50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6758CE0", Offset = "0x67574E0", VA = "0x186758CE0")]
			internal PHOHBDFCLCL(string AIHHAIMEBLC, string BHAKNEONPBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6757AF0", Offset = "0x67562F0", VA = "0x186757AF0")]
			public int CDPKFPBJHAB([Optional] int? MHEGFPPBPAJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x67583B0", Offset = "0x6756BB0", VA = "0x1867583B0")]
			public List<Dictionary<string, object>> ICEJGCMFHFF(int KIFBFDOJGKD, int? MHEGFPPBPAJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x67589F0", Offset = "0x67571F0", VA = "0x1867589F0")]
			public void LPNBLOGODBN(AmplitudeAnalyticsIdentifyMessage MEAFIMADMKA, bool AGENOFMPEEG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x67588E0", Offset = "0x67570E0", VA = "0x1867588E0")]
			public void LPNBLOGODBN(Dictionary<string, object> MEAFIMADMKA, bool AGENOFMPEEG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6758620", Offset = "0x6756E20", VA = "0x186758620")]
			public void IEDAOEKCPFM(params Dictionary<string, object>[] GLGCFKPNKAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6758A90", Offset = "0x6757290", VA = "0x186758A90")]
			public void MOLELKHIPAI(List<Dictionary<string, object>> KMEJJNKIEBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6758090", Offset = "0x6756890", VA = "0x186758090")]
			private void CKKOHCPBMHF(Dictionary<string, object> MEAFIMADMKA, bool AGENOFMPEEG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x67581A0", Offset = "0x67569A0", VA = "0x1867581A0")]
			public void IANBEEHCIBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6757CA0", Offset = "0x67564A0", VA = "0x186757CA0")]
			private void CJPAAENIKKO([Optional] string FCDJJHECOOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67587B0", Offset = "0x6756FB0", VA = "0x1867587B0")]
			private static string KDKODEMNJPI(string JMDCGOKJIDA, string NDDCLPHCEEO)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6759BE0", Offset = "0x67583E0", VA = "0x186759BE0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct EEBFPECCCOK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int CPDKALIPNKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string NEMBOLBBEHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T NGCAJNJCGKN;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AKPFGNHJIGC : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public AKPFGNHJIGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x67477F0", Offset = "0x6745FF0", VA = "0x1867477F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6747FB0", Offset = "0x67467B0", VA = "0x186747FB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JANJELMPJPF : IEnumerator<object>, IEnumerator, IDisposable
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
			public CNPNGJHMILJ quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public JANJELMPJPF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6751470", Offset = "0x674FC70", VA = "0x186751470", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6751580", Offset = "0x674FD80", VA = "0x186751580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OAABLPLPJIK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public OAABLPLPJIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x67560E0", Offset = "0x67548E0", VA = "0x1867560E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6756250", Offset = "0x6754A50", VA = "0x186756250", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IJGCOMJIIOE : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public IJGCOMJIIOE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x67511C0", Offset = "0x674F9C0", VA = "0x1867511C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6751420", Offset = "0x674FC20", VA = "0x186751420", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OJEBJNEEMEK : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public OJEBJNEEMEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6756860", Offset = "0x6755060", VA = "0x186756860", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6756AC0", Offset = "0x67552C0", VA = "0x186756AC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JCJFKENAAMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public PHOHBDFCLCL cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public JCJFKENAAMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6751A20", Offset = "0x6750220", VA = "0x186751A20")]
			internal void JHPDDMGNHOP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x67515D0", Offset = "0x674FDD0", VA = "0x1867515D0")]
			internal void GNDHEPPAHFI(EEBFPECCCOK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class PGDOPMBDNPB : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public PHOHBDFCLCL cache;

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
			private JCJFKENAAMI <>8__1;

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
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public PGDOPMBDNPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x67571E0", Offset = "0x67559E0", VA = "0x1867571E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6757A00", Offset = "0x6756200", VA = "0x186757A00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class COMMCNAFCCP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public COMMCNAFCCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x51F9B80", Offset = "0x51F8380", VA = "0x1851F9B80")]
			internal EEBFPECCCOK<T> JJPKEBMDIJB(ODAIFCJOECP postResponse)
			{
				return default(EEBFPECCCOK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ACFAMDNJIMF HGOCGHCDIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<ACHEPBEPPLK> MBOAKIOKKBL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string AIPPDKMGNKJ = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string HDILFLCNEJI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string EIBLCLCHNCM = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int FPEBOOBMKPF = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int CNKFAAIFAED = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int HMFHGBHPGDB = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float GDMJGNHHECH = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long IEEAFNOAFBN = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LIODLFDAJIC = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string KMPIEFPMGLN = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string KPBHONEIFHB = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string CAKMAPGJFGB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool ACBCMPDCOIJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool IKBMIIDNFPH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int DDNOBCPJNAM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int LPJAEKJBDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private INNFKPLMHBD IOIOKJBIOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KGDGNCJNJEJ PAEOHDGAHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private AMEKEDOJIOD OECPGAKPKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool GKLBMJAECNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float HPOAMPCPHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float NFILPLBMBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int ENBMLCKKECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KOMIPNBGMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? DNKPLCLIOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? NONLKHDOEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long KJPEJAFDLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string PNMJGLGLAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool EKEHMCAAEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long KJBPDAFECLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string ADFFLIKJOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string DNLKKOGFHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> GDGNPLPLLPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private JGDLCOHPPNG NDMMLCEAHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int DKKAHCFKKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int CLKCIFMDJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float DJPHPLNHAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool IJHEPODMMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool HCAKCKKMFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PHOHBDFCLCL CHCAHEOODPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private PHOHBDFCLCL KBGPJBPIDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private PHOHBDFCLCL LNHDMDMEHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string HPEEAPGMEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> LIEHPBFEKHK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DGKBBNEGIDG;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string FFKKGBLLFAB;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string NOPPLHJPGKM = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string BJKPCHNOKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string BFPCMBBMEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string PJLCPJNFADD;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ACFAMDNJIMF DPPGMNKBJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6748990", Offset = "0x6747190", VA = "0x186748990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ACHEPBEPPLK OBPPBFLNHJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x674A820", Offset = "0x6749020", VA = "0x18674A820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CLFFALKNHEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x674C080", Offset = "0x674A880", VA = "0x18674C080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long HMOJIDFCGNN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x674DE40", Offset = "0x674C640", VA = "0x18674DE40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x674DF50", Offset = "0x674C750", VA = "0x18674DF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string HIHMIGACMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x674DE10", Offset = "0x674C610", VA = "0x18674DE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EIJJEHDHKIP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8BF310", Offset = "0x8BDB10", VA = "0x1808BF310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB93B80", Offset = "0xB92380", VA = "0x180B93B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? BMKBFHAKCHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8BF320", Offset = "0x8BDB20", VA = "0x1808BF320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x16BDD50", Offset = "0x16BC550", VA = "0x1816BDD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LNMLDDAMLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x11218C0", Offset = "0x11200C0", VA = "0x1811218C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x116E610", Offset = "0x116CE10", VA = "0x18116E610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool OGNNMGOHIAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x674DD20", Offset = "0x674C520", VA = "0x18674DD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> NGDDPPKKFPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x674DC60", Offset = "0x674C460", VA = "0x18674DC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x674DE90", Offset = "0x674C690", VA = "0x18674DE90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6748270", Offset = "0x6746A70", VA = "0x186748270", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6749BD0", Offset = "0x67483D0", VA = "0x186749BD0")]
		private void ICGIEHDCEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x674D240", Offset = "0x674BA40", VA = "0x18674D240")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x674BFC0", Offset = "0x674A7C0", VA = "0x18674BFC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x674D5E0", Offset = "0x674BDE0", VA = "0x18674D5E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x674C260", Offset = "0x674AA60", VA = "0x18674C260")]
		public OABICBNODGM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x674A630", Offset = "0x6748E30", VA = "0x18674A630")]
		[IteratorStateMachine(typeof(AKPFGNHJIGC))]
		public IEnumerator<JMPDKMJKKGA> InitializeForLocalAccount(AmplitudeAnalyticsEvent GDBEIJBBFHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x674C9F0", Offset = "0x674B1F0", VA = "0x18674C9F0")]
		public void SendAppEnterEvent(bool JOCNDLNCIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x674D520", Offset = "0x674BD20", VA = "0x18674D520")]
		public void UpdateLastKnownInteractionCategory(string BODGPIJLHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x674D430", Offset = "0x674BC30", VA = "0x18674D430")]
		public void UpdateLastAliveTime(float LDGBKFKPDEK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x674BF00", Offset = "0x674A700", VA = "0x18674BF00")]
		private OABICBNODGM OIDPJEKNPJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x674BC10", Offset = "0x674A410", VA = "0x18674BC10")]
		private OABICBNODGM OEAJKHHNFAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x674CCA0", Offset = "0x674B4A0", VA = "0x18674CCA0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6749B40", Offset = "0x6748340", VA = "0x186749B40")]
		[IteratorStateMachine(typeof(JANJELMPJPF))]
		private IEnumerator HGCGGIHHBKK(CNPNGJHMILJ NDDBPNBBGAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x674D870", Offset = "0x674C070", VA = "0x18674D870")]
		[IteratorStateMachine(typeof(OAABLPLPJIK))]
		public IEnumerator WaitForFlush(float CENAAPAKFCO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x674D310", Offset = "0x674BB10", VA = "0x18674D310")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x674D250", Offset = "0x674BA50", VA = "0x18674D250")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime HDCBOMJHFCH)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x674A170", Offset = "0x6748970", VA = "0x18674A170")]
		public static DHOCKFIOONG Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6748100", Offset = "0x6746900", VA = "0x186748100")]
		public static ELDCPJFKFBD AccountSelectionPostLoginEvent([NotNull] string JBPBBHIGKLO, string DEHMFLPGGBN, bool EHPJAGGDNPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67491A0", Offset = "0x67479A0", VA = "0x1867491A0")]
		public static ELDCPJFKFBD Event([NotNull] string JBPBBHIGKLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x674C2A0", Offset = "0x674AAA0", VA = "0x18674C2A0")]
		public static ELDCPJFKFBD PreviousSessionEvent([NotNull] string JBPBBHIGKLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x674A310", Offset = "0x6748B10", VA = "0x18674A310")]
		public static ELDCPJFKFBD InitializeEvent(string DEHMFLPGGBN, int PDBNNCFDKFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x674CE60", Offset = "0x674B660", VA = "0x18674CE60")]
		public static ELDCPJFKFBD StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6748A00", Offset = "0x6747200", VA = "0x186748A00")]
		public static ELDCPJFKFBD CreateOutOfSessionEvent(string JBPBBHIGKLO, bool PKHEFHBEPPM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x674AAF0", Offset = "0x67492F0", VA = "0x18674AAF0")]
		public static OABICBNODGM LogOutOfSessionEvent(ELDCPJFKFBD INPDBCGFMDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x674A870", Offset = "0x6749070", VA = "0x18674A870")]
		public void LogEventAsync(AmplitudeAnalyticsEvent BDDEINKKEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x674ACC0", Offset = "0x67494C0", VA = "0x18674ACC0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent BDDEINKKEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x674AE00", Offset = "0x6749600", VA = "0x18674AE00")]
		public void LogSerializedEventAsync(Dictionary<string, object> NAPOPNDCOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x674A9B0", Offset = "0x67491B0", VA = "0x18674A9B0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage HOOJBKLLNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67499B0", Offset = "0x67481B0", VA = "0x1867499B0")]
		private void GBJEFMHGHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6749490", Offset = "0x6747C90", VA = "0x186749490")]
		private void FANCCHEHHEF(Dictionary<string, object> IDBCFENKBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6748FA0", Offset = "0x67477A0", VA = "0x186748FA0")]
		private void EFLFCDDDOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6749750", Offset = "0x6747F50", VA = "0x186749750")]
		private void FNKHOHJMGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6749920", Offset = "0x6748120", VA = "0x186749920")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6749AB0", Offset = "0x67482B0", VA = "0x186749AB0")]
		[IteratorStateMachine(typeof(IJGCOMJIIOE))]
		private IEnumerator<JMPDKMJKKGA> GPFKINJJDDN(float CENAAPAKFCO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6748070", Offset = "0x6746870", VA = "0x186748070")]
		[IteratorStateMachine(typeof(OJEBJNEEMEK))]
		private IEnumerator<JMPDKMJKKGA> ABMMLKDHMMH(float CENAAPAKFCO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67488B0", Offset = "0x67470B0", VA = "0x1867488B0")]
		[IteratorStateMachine(typeof(PGDOPMBDNPB))]
		private IEnumerator<JMPDKMJKKGA> CCFKOEFIBOP(PHOHBDFCLCL MGPCCJLLDAM, int? MHEGFPPBPAJ, string ONLMOABMBMN, float CENAAPAKFCO, Action<int> LGPPFJBLBDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6749090", Offset = "0x6747890", VA = "0x186749090")]
		private static void EOHPIEFGGMH(bool HEIPBKLEDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6748C60", Offset = "0x6747460", VA = "0x186748C60")]
		private MAKKFMNHCEA<EEBFPECCCOK<Dictionary<string, object>>> DBIGJBPAIBM(string ONLMOABMBMN, string KDHHLMNDCEK, Dictionary<string, object> NGCAJNJCGKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6748D30", Offset = "0x6747530", VA = "0x186748D30")]
		private MAKKFMNHCEA<EEBFPECCCOK<List<Dictionary<string, object>>>> DBIGJBPAIBM(string ONLMOABMBMN, string KDHHLMNDCEK, List<Dictionary<string, object>> NGCAJNJCGKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3208440", Offset = "0x3206C40", VA = "0x183208440")]
		private MAKKFMNHCEA<EEBFPECCCOK<T>> JGGILHPLGDJ<T>(string JKCCDHOJGCM, string ONLMOABMBMN, string KDHHLMNDCEK, T NGCAJNJCGKN, Dictionary<string, object> CKILGEOBNKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x674BBC0", Offset = "0x674A3C0", VA = "0x18674BBC0")]
		private bool NPGEJKMLIKA(float NCEEMEKPLHO, float CENAAPAKFCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x674AEE0", Offset = "0x67496E0", VA = "0x18674AEE0")]
		private Dictionary<string, object> MILEFMKHOFN(string ONLMOABMBMN, Dictionary<string, object> NGCAJNJCGKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x674D960", Offset = "0x674C160", VA = "0x18674D960")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x674A6C0", Offset = "0x6748EC0", VA = "0x18674A6C0")]
		[CompilerGenerated]
		private long JFGCOAJLNAF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x674BBB0", Offset = "0x674A3B0", VA = "0x18674BBB0")]
		[CompilerGenerated]
		private void MLIDAKNBOOE(int DKPMBDPCHOM)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x674ECA0", Offset = "0x674D4A0", VA = "0x18674ECA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x674ED80", Offset = "0x674D580", VA = "0x18674ED80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x674ECE0", Offset = "0x674D4E0", VA = "0x18674ECE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x674EDE0", Offset = "0x674D5E0", VA = "0x18674EDE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x674EC60", Offset = "0x674D460", VA = "0x18674EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x674ED20", Offset = "0x674D520", VA = "0x18674ED20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x8553A0", VA = "0x180856BA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x674E3A0", Offset = "0x674CBA0", VA = "0x18674E3A0")]
		public static ELDCPJFKFBD JGIIBNEOBDO(string DMDAEILPBHA, [NotNull] string PGCNCKMPHMK, long FICLNKKKDEA, long IPHBIPDLKLF, string DEHMFLPGGBN, bool EHPJAGGDNPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x674DFB0", Offset = "0x674C7B0", VA = "0x18674DFB0")]
		public static ELDCPJFKFBD BJLMNLHLCJI(string DMDAEILPBHA, [NotNull] string PGCNCKMPHMK, long FICLNKKKDEA, long IPHBIPDLKLF, string DEHMFLPGGBN, long PEJNFPINKJA, bool EHPJAGGDNPJ, string DEKFPBGCGLD, string BEPHOHOOGAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x674EAD0", Offset = "0x674D2D0", VA = "0x18674EAD0")]
		private AmplitudeAnalyticsEvent(string DMDAEILPBHA, [NotNull] string PGCNCKMPHMK, long FICLNKKKDEA, long IPHBIPDLKLF, string DEHMFLPGGBN, bool EHPJAGGDNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CC83C0", Offset = "0x1CC6BC0", VA = "0x181CC83C0")]
		public void KGKHMOAKPKP(long CFOGKMIMPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x674E4A0", Offset = "0x674CCA0", VA = "0x18674E4A0", Slot = "5")]
		public override void MLPAINEHDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x674E110", Offset = "0x674C910", VA = "0x18674E110", Slot = "6")]
		public override void HBOECALKMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x674E5A0", Offset = "0x674CDA0", VA = "0x18674E5A0", Slot = "4")]
		protected override Dictionary<string, object> PCJNDIANPGP(Dictionary<string, object> NBGHCBCGOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x674E290", Offset = "0x674CA90", VA = "0x18674E290")]
		private void IMHEFOAFCID(string NDDCLPHCEEO, string JMDCGOKJIDA, bool EBMHHIGHMDN = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6750740", Offset = "0x674EF40", VA = "0x186750740")]
			public void CJMHJGFKIBE(Dictionary<string, object> JGNBKNFEEKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6759860", Offset = "0x6758060", VA = "0x186759860")]
			public void CJMHJGFKIBE(Dictionary<string, object> CGIGAOFLDLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA8ECE0", Offset = "0xA8D4E0", VA = "0x180A8ECE0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x674EFD0", Offset = "0x674D7D0", VA = "0x18674EFD0")]
		public static DHOCKFIOONG JGIIBNEOBDO(string DMDAEILPBHA, string DEHMFLPGGBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x674F4F0", Offset = "0x674DCF0", VA = "0x18674F4F0")]
		protected AmplitudeAnalyticsIdentifyMessage(string DMDAEILPBHA, string DEHMFLPGGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x674F090", Offset = "0x674D890", VA = "0x18674F090")]
		public Dictionary<string, object> LOPEOHJMGKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x674F1B0", Offset = "0x674D9B0", VA = "0x18674F1B0", Slot = "4")]
		protected virtual Dictionary<string, object> PCJNDIANPGP(Dictionary<string, object> NBGHCBCGOBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x674EEB0", Offset = "0x674D6B0", VA = "0x18674EEB0")]
		protected void ECGMANFNLOJ(string NDDCLPHCEEO, Dictionary<string, object> GPEPHMNLCKO, Dictionary<string, object> FOPBLNCGODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x674EE40", Offset = "0x674D640", VA = "0x18674EE40")]
		protected void BBLMDAHCKKE(string NDDCLPHCEEO, string JMDCGOKJIDA, Dictionary<string, object> OAHIBPPNLJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x674F120", Offset = "0x674D920", VA = "0x18674F120", Slot = "5")]
		public virtual void MLPAINEHDIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x674EF50", Offset = "0x674D750", VA = "0x18674EF50", Slot = "6")]
		public virtual void HBOECALKMPA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DHOCKFIOONG : FOLCLCHOCGO<AmplitudeAnalyticsIdentifyMessage, DHOCKFIOONG>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override DHOCKFIOONG PDIFDGBEALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage OOPMEFLEILH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6750520", Offset = "0x674ED20", VA = "0x186750520")]
	public DHOCKFIOONG(AmplitudeAnalyticsIdentifyMessage JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6750480", Offset = "0x674EC80", VA = "0x186750480", Slot = "4")]
	public override void HBOECALKMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ELDCPJFKFBD : FOLCLCHOCGO<AmplitudeAnalyticsEvent, ELDCPJFKFBD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DDAFNHIGBIM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override ELDCPJFKFBD PDIFDGBEALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x91F460", Offset = "0x91DC60", VA = "0x18091F460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long NGFHJHDBNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x67509C0", Offset = "0x674F1C0", VA = "0x1867509C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67477A0", Offset = "0x6745FA0", VA = "0x1867477A0")]
	public ELDCPJFKFBD(AmplitudeAnalyticsEvent JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100", Slot = "5")]
	public override AmplitudeAnalyticsEvent OOPMEFLEILH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6750A80", Offset = "0x674F280", VA = "0x186750A80", Slot = "4")]
	public override void HBOECALKMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x29D8490", Offset = "0x29D6C90", VA = "0x1829D8490")]
	public ELDCPJFKFBD NCAFINDGKBK<T>(string FMACLHMOMLJ, T[] JMDCGOKJIDA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x29D8490", Offset = "0x29D6C90", VA = "0x1829D8490")]
	public ELDCPJFKFBD NCAFINDGKBK(string FMACLHMOMLJ, string[] JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x29D81E0", Offset = "0x29D69E0", VA = "0x1829D81E0")]
	public ELDCPJFKFBD NCAFINDGKBK<T>(string FMACLHMOMLJ, T JMDCGOKJIDA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6750B50", Offset = "0x674F350", VA = "0x186750B50")]
	public ELDCPJFKFBD NCAFINDGKBK(string FMACLHMOMLJ, long JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6750BD0", Offset = "0x674F3D0", VA = "0x186750BD0")]
	public ELDCPJFKFBD NCAFINDGKBK(string FMACLHMOMLJ, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6750B20", Offset = "0x674F320", VA = "0x186750B20")]
	public ELDCPJFKFBD LIEKCBLJEFO(string FMACLHMOMLJ, object? JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67509E0", Offset = "0x674F1E0", VA = "0x1867509E0")]
	public ELDCPJFKFBD EDPLBFIHMNF(string FMACLHMOMLJ, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67508C0", Offset = "0x674F0C0", VA = "0x1867508C0")]
	private ELDCPJFKFBD AOBKAGAKHOC(string FMACLHMOMLJ, object JMDCGOKJIDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AIHANCPBILA : ELDCPJFKFBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67477A0", Offset = "0x6745FA0", VA = "0x1867477A0")]
	public AIHANCPBILA(AmplitudeAnalyticsEvent JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67475F0", Offset = "0x6745DF0", VA = "0x1867475F0", Slot = "4")]
	public override void HBOECALKMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class FOLCLCHOCGO<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : FOLCLCHOCGO<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M JNNDBFGKHHD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR PDIFDGBEALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public FOLCLCHOCGO(M JNNDBFGKHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3C07980", Offset = "0x3C06180", VA = "0x183C07980")]
	public BLDR AKBBDNFKIKK(AmplitudeAnalyticsIdentifyMessage.DeviceInfo KFGHGHAIKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3C07BA0", Offset = "0x3C063A0", VA = "0x183C07BA0")]
	public BLDR NKOCDKHMEMP(AmplitudeAnalyticsIdentifyMessage.RevenueData HLGOCCCABIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3C07A00", Offset = "0x3C06200", VA = "0x183C07A00")]
	public BLDR EGDENMOOJJG(string FMACLHMOMLJ, string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29CD080", Offset = "0x29CB880", VA = "0x1829CD080")]
	public BLDR EGDENMOOJJG<T>(string FMACLHMOMLJ, T JMDCGOKJIDA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HBOECALKMPA();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3C079D0", Offset = "0x3C061D0", VA = "0x183C079D0")]
	internal static string DBEIEJAEBJO(string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3C07AA0", Offset = "0x3C062A0", VA = "0x183C07AA0")]
	private BLDR LIJNACFHPCN(string FMACLHMOMLJ, object JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M OOPMEFLEILH();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class GPFAEHALEHH : INNFKPLMHBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct BJKGFLADJJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<ODAIFCJOECP> <>t__builder;

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
		public GPFAEHALEHH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x674F5B0", Offset = "0x674DDB0", VA = "0x18674F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x674FFE0", Offset = "0x674E7E0", VA = "0x18674FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient LNJDHAPBHCH;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6750F60", Offset = "0x674F760", VA = "0x186750F60")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void AJKOLIOOFJF(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6751140", Offset = "0x674F940", VA = "0x186751140")]
	[RecRoom.NoEngine.Common.Preserve]
	public GPFAEHALEHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6750FD0", Offset = "0x674F7D0", VA = "0x186750FD0", Slot = "4")]
	[AsyncStateMachine(typeof(BJKGFLADJJG))]
	public Task<ODAIFCJOECP> JHIIDIAEJHD(string JKCCDHOJGCM, string OLOCCGFNELG, string LHHEKDIEOLN, string EJLDPPMJGEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class MACMAMILMFO : INNFKPLMHBD
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PKDILAJILCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<ODAIFCJOECP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public PKDILAJILCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6758E50", Offset = "0x6757650", VA = "0x186758E50")]
		internal void JMDNFPAOLPE(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct OINBKFANMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<ODAIFCJOECP> <>t__builder;

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
		private TaskAwaiter<ODAIFCJOECP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67562A0", Offset = "0x6754AA0", VA = "0x1867562A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67567F0", Offset = "0x6754FF0", VA = "0x1867567F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void FENGNGOJILC(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	[RecRoom.NoEngine.Common.Preserve]
	public MACMAMILMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6753860", Offset = "0x6752060", VA = "0x186753860", Slot = "4")]
	[AsyncStateMachine(typeof(OINBKFANMNJ))]
	public Task<ODAIFCJOECP> JHIIDIAEJHD(string JKCCDHOJGCM, string OLOCCGFNELG, string LHHEKDIEOLN, string EJLDPPMJGEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PBAJCPMCEEF
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LJPGGOMGCIE;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6756B10", Offset = "0x6755310", VA = "0x186756B10")]
	internal static bool OELDAMANKLE(string NDDCLPHCEEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface INNFKPLMHBD
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ODAIFCJOECP> JHIIDIAEJHD(string JKCCDHOJGCM, string OLOCCGFNELG, string LHHEKDIEOLN, string EJLDPPMJGEO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ODAIFCJOECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int KPAJMKIHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string LJPKDLLDDHA;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0xD87910", Offset = "0xD86110", VA = "0x180D87910")]
	public ODAIFCJOECP(int CPDKALIPNKN, string NEMBOLBBEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum IFHMHALDBHB
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
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PCMCMDIDFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long FEABHEDNFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private ELDCPJFKFBD AJNPELIKBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool GCOHLKAOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float GFBMBHGLBKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6757050", Offset = "0x6755850", VA = "0x186757050")]
	public PCMCMDIDFOD(string HFGBAPMMPDC, float GFBMBHGLBKJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CC50C0", Offset = "0x2CC38C0", VA = "0x182CC50C0")]
	public void NCAFINDGKBK<T>(string FMACLHMOMLJ, T JMDCGOKJIDA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6756EE0", Offset = "0x67556E0", VA = "0x186756EE0")]
	public void NCAFINDGKBK(string FMACLHMOMLJ, string JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6756F60", Offset = "0x6755760", VA = "0x186756F60")]
	public void PBJMKOMCPCP(string HACPLPIFOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6756D10", Offset = "0x6755510", VA = "0x186756D10")]
	public void JBEKEJEPECJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6756DD0", Offset = "0x67555D0", VA = "0x186756DD0")]
	private void KILOLFCCOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6756CC0", Offset = "0x67554C0", VA = "0x186756CC0")]
	private bool DNCBGFLEAMG()
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
		public enum ADLPDBOAGBK
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
		private ADLPDBOAGBK parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ADLPDBOAGBK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC330", VA = "0x1808CDB30")]
			get
			{
				return default(ADLPDBOAGBK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9C0720", Offset = "0x9BEF20", VA = "0x1809C0720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x67599D0", Offset = "0x67581D0", VA = "0x1867599D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal class ELHJGHGLKEA : CLEEKKAIGLK, GJICFGOPOCI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void PEEEAABGCIB(KPPLEJMELKP NGNFOAPDBNB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly MKPIGAMNLNB KGECMIPEPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly PEEEAABGCIB MIIGNBPGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string HOCCPOCNKIH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string AMPBEHCCFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1204760", Offset = "0x1202F60", VA = "0x181204760", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool EGFLJCLIPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6750C60", Offset = "0x674F460", VA = "0x186750C60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CHHOELBHAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6750C40", Offset = "0x674F440", VA = "0x186750C40", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> DNPIEPOKLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x12045F0", Offset = "0x1202DF0", VA = "0x1812045F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6750C80", Offset = "0x674F480", VA = "0x186750C80")]
	public ELHJGHGLKEA(MKPIGAMNLNB AACIHKHGIHG, string DJFNNDKBEAG, [Optional] PEEEAABGCIB HODIKJLBKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x29D8570", Offset = "0x29D6D70", VA = "0x1829D8570", Slot = "8")]
	public T JMJOGDIBBHK<T>(string NDDCLPHCEEO, T LIAHLPBCKNO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NOPDKKAFENG : NICHJPMKMDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KAHONKCJBIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public KGDGNCJNJEJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public NOPDKKAFENG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6751D40", Offset = "0x6750540", VA = "0x186751D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6752410", Offset = "0x6750C10", VA = "0x186752410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct FHMMMMGDLPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6750CF0", Offset = "0x674F4F0", VA = "0x186750CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6750F00", Offset = "0x674F700", VA = "0x186750F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct LMGFJKFBOHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public KGDGNCJNJEJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NOPDKKAFENG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67533A0", Offset = "0x6751BA0", VA = "0x1867533A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6753800", Offset = "0x6752000", VA = "0x186753800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DFNNALNILOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public NOPDKKAFENG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public KGDGNCJNJEJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6750050", Offset = "0x674E850", VA = "0x186750050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6750420", Offset = "0x674EC20", VA = "0x186750420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, JOGAOJPEKLP> MGKLCCIBAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool ADBGOPMFBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool LOEOAOAPNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> HDJFFEJIJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> LPKNDADMBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private FIFEJOFJNKG HLALDBECMLH;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task MFHDDKDKGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x67543B0", Offset = "0x6752BB0", VA = "0x1867543B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool IDFFHAMIEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A6510", Offset = "0x8A4D10", VA = "0x1808A6510", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DPKNGPNPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xB7F4B0", Offset = "0xB7DCB0", VA = "0x180B7F4B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string EIJJEHDHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6755610", Offset = "0x6753E10", VA = "0x186755610", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public INAOMIPNLOK DKKOCEPBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x67555E0", Offset = "0x6753DE0", VA = "0x1867555E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action HJGDNKJNFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67541E0", Offset = "0x67529E0", VA = "0x1867541E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6755540", Offset = "0x6753D40", VA = "0x186755540", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PCOCPCPIKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6754D10", Offset = "0x6753510", VA = "0x186754D10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6755120", Offset = "0x6753920", VA = "0x186755120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ANMKHOHLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6755BE0", Offset = "0x67543E0", VA = "0x186755BE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67554A0", Offset = "0x6753CA0", VA = "0x1867554A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<KPPLEJMELKP> CECELOEEICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6755D80", Offset = "0x6754580", VA = "0x186755D80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x67556B0", Offset = "0x6753EB0", VA = "0x1867556B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6755380", Offset = "0x6753B80", VA = "0x186755380", Slot = "12")]
	[AsyncStateMachine(typeof(KAHONKCJBIO))]
	public Task HMCGAKKBHMB(string BHAKNEONPBE, [Optional] KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6755070", Offset = "0x6753870", VA = "0x186755070", Slot = "23")]
	[AsyncStateMachine(typeof(FHMMMMGDLPJ))]
	public Task GKKLPGKFKML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6755C80", Offset = "0x6754480", VA = "0x186755C80", Slot = "18")]
	[AsyncStateMachine(typeof(LMGFJKFBOHG))]
	public Task OPDIPKHNHCO(KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6754280", Offset = "0x6752A80", VA = "0x186754280")]
	private void BPLFHKAIHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6755AD0", Offset = "0x67542D0", VA = "0x186755AD0", Slot = "19")]
	[AsyncStateMachine(typeof(DFNNALNILOA))]
	public Task MDANNPIMMDA(KGDGNCJNJEJ BCIFNCCEIDJ, Dictionary<string, string> DCMLBDMBKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6755620", Offset = "0x6753E20", VA = "0x186755620", Slot = "20")]
	public bool KIIAIOAGNAH(string MKMOMHPDOFP, bool BNJFCFIOLHH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6755910", Offset = "0x6754110", VA = "0x186755910", Slot = "21")]
	public CLEEKKAIGLK LKHCDFABPIM(string DJFNNDKBEAG, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67551C0", Offset = "0x67539C0", VA = "0x1867551C0")]
	private MKPIGAMNLNB HLFLOCBIENO(string DJFNNDKBEAG, bool BNJFCFIOLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6755760", Offset = "0x6753F60", VA = "0x186755760", Slot = "22")]
	public CMPBCDIHLEL LKGEJJLGJJE(string KLHDMBDDJJD, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6754320", Offset = "0x6752B20", VA = "0x186754320")]
	private JFNOLDMKAID CLCAEGIOJDB(string KLHDMBDDJJD, bool BNJFCFIOLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6754430", Offset = "0x6752C30", VA = "0x186754430")]
	private NFCNLPFPKIN EDHLGMLPKEF(KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6754DB0", Offset = "0x67535B0", VA = "0x186754DB0")]
	private JOBDAIEOMOJ FNIHMIJOKMN(string BHAKNEONPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6754F60", Offset = "0x6753760", VA = "0x186754F60")]
	private void FOGEMABMOAB(string DJFNNDKBEAG, MKPIGAMNLNB AACIHKHGIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6755FA0", Offset = "0x67547A0", VA = "0x186755FA0")]
	public NOPDKKAFENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x67543F0", Offset = "0x6752BF0", VA = "0x1867543F0")]
	[CompilerGenerated]
	private void HIKMKECKJHP(KPPLEJMELKP DLFEHJOHIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67543F0", Offset = "0x6752BF0", VA = "0x1867543F0")]
	[CompilerGenerated]
	private void DMNJPGPMMGA(KPPLEJMELKP DLFEHJOHIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LEPACJADNPO : NICHJPMKMDF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct NNBAGKLBNOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public LEPACJADNPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public KGDGNCJNJEJ userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x67539C0", Offset = "0x67521C0", VA = "0x1867539C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6754180", Offset = "0x6752980", VA = "0x186754180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NICHJPMKMDF GINIPMCIGKE;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private NICHJPMKMDF AIBPMOMJGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67525B0", Offset = "0x6750DB0", VA = "0x1867525B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DPKNGPNPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6752980", Offset = "0x6751180", VA = "0x186752980", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IDFFHAMIEBH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6752470", Offset = "0x6750C70", VA = "0x186752470", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task MFHDDKDKGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6752560", Offset = "0x6750D60", VA = "0x186752560", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string EIJJEHDHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6752C40", Offset = "0x6751440", VA = "0x186752C40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public INAOMIPNLOK DKKOCEPBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6752B10", Offset = "0x6751310", VA = "0x186752B10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PCOCPCPIKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6752620", Offset = "0x6750E20", VA = "0x186752620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6752760", Offset = "0x6750F60", VA = "0x186752760", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action HJGDNKJNFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67524C0", Offset = "0x6750CC0", VA = "0x1867524C0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6752A70", Offset = "0x6751270", VA = "0x186752A70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action ANMKHOHLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6753140", Offset = "0x6751940", VA = "0x186753140", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x67529D0", Offset = "0x67511D0", VA = "0x1867529D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KPPLEJMELKP> CECELOEEICH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x67532F0", Offset = "0x6751AF0", VA = "0x1867532F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6752DB0", Offset = "0x67515B0", VA = "0x186752DB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	[UnityEngine.Scripting.Preserve]
	public LEPACJADNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6752800", Offset = "0x6751000", VA = "0x186752800")]
	[GDGALFJPCGE(JMIPDAHBNNG.GameOnly)]
	private static void HDHCDDINGJC(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6752BD0", Offset = "0x67513D0", VA = "0x186752BD0")]
	[GDGALFJPCGE(JMIPDAHBNNG.EditorOnly)]
	private static void JFENOIHAEJF(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6752870", Offset = "0x6751070", VA = "0x186752870", Slot = "12")]
	[AsyncStateMachine(typeof(NNBAGKLBNOL))]
	public Task HMCGAKKBHMB(string BHAKNEONPBE, [Optional] KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67531E0", Offset = "0x67519E0", VA = "0x1867531E0", Slot = "18")]
	public Task OPDIPKHNHCO(KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6753020", Offset = "0x6751820", VA = "0x186753020", Slot = "19")]
	public Task MDANNPIMMDA(KGDGNCJNJEJ BCIFNCCEIDJ, Dictionary<string, string> DCMLBDMBKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6752C90", Offset = "0x6751490", VA = "0x186752C90", Slot = "20")]
	public bool KIIAIOAGNAH(string MKMOMHPDOFP, bool BNJFCFIOLHH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6752F60", Offset = "0x6751760", VA = "0x186752F60", Slot = "21")]
	public CLEEKKAIGLK LKHCDFABPIM(string DJFNNDKBEAG, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6752EA0", Offset = "0x67516A0", VA = "0x186752EA0", Slot = "22")]
	public CMPBCDIHLEL LKGEJJLGJJE(string KLHDMBDDJJD, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x67526C0", Offset = "0x6750EC0", VA = "0x1867526C0", Slot = "23")]
	public Task GKKLPGKFKML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x89E890", Offset = "0x89D090", VA = "0x18089E890")]
	[CompilerGenerated]
	private void FEIKCJEEACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x978400", Offset = "0x976C00", VA = "0x180978400")]
	[CompilerGenerated]
	private void OECOHHKAGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x988D40", Offset = "0x987540", VA = "0x180988D40")]
	[CompilerGenerated]
	private void MNNHCFJOHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6752E60", Offset = "0x6751660", VA = "0x186752E60")]
	[CompilerGenerated]
	private void LIMLOOGGABB(KPPLEJMELKP DLFEHJOHIIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal class NFAMIAHEKEM : CMPBCDIHLEL, GJICFGOPOCI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate void FCBFCKDCCKC(KPPLEJMELKP NGNFOAPDBNB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly FCBFCKDCCKC MIIGNBPGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly JFNOLDMKAID FMNPPKPINFK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string AMPBEHCCFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1C59C70", Offset = "0x1C58470", VA = "0x181C59C70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5A91360", Offset = "0x5A8FB60", VA = "0x185A91360")]
	public NFAMIAHEKEM(JFNOLDMKAID JLMHPKHAOHJ, [Optional] FCBFCKDCCKC HODIKJLBKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D730", Offset = "0x2C8BF30", VA = "0x182C8D730", Slot = "5")]
	public T JMJOGDIBBHK<T>(string NDDCLPHCEEO, T LIAHLPBCKNO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface NEFHMKPHBCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[UsedImplicitly]
public class DKHLPNJFIGC : NEFHMKPHBCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly IMAEACHJDFC OGAFEJFFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly List<OBGANFMPDPG> CNMNNLKGGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly string OPIGOGDPKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly string DAMIDLDMMAL;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6750570", Offset = "0x674ED70", VA = "0x186750570")]
	[GDGALFJPCGE(JAFPILLCEJB.Root, JMIPDAHBNNG.GameOnly)]
	[UsedImplicitly]
	private static void CEJDNEABNOB(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67505E0", Offset = "0x674EDE0", VA = "0x1867505E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DKHLPNJFIGC([OMAPKKAGFIL(null)][NotNull] IMAEACHJDFC OGAFEJFFOED, [OMAPKKAGFIL(null)][NotNull] CLPOBOLLADD OANACOIIHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class PLKGCJODGNF : NICHJPMKMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task MFHDDKDKGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6758FD0", Offset = "0x67577D0", VA = "0x186758FD0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool DPKNGPNPNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IDFFHAMIEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EIJJEHDHKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public INAOMIPNLOK DKKOCEPBFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PCOCPCPIKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6759060", Offset = "0x6757860", VA = "0x186759060", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6759190", Offset = "0x6757990", VA = "0x186759190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action HJGDNKJNFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6758F30", Offset = "0x6757730", VA = "0x186758F30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6759360", Offset = "0x6757B60", VA = "0x186759360", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action ANMKHOHLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6759680", Offset = "0x6757E80", VA = "0x186759680", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x67592C0", Offset = "0x6757AC0", VA = "0x1867592C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<KPPLEJMELKP> CECELOEEICH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x67597B0", Offset = "0x6757FB0", VA = "0x1867597B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6759400", Offset = "0x6757C00", VA = "0x186759400", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	[RecRoom.NoEngine.Common.Preserve]
	public PLKGCJODGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6759230", Offset = "0x6757A30", VA = "0x186759230", Slot = "12")]
	public Task HMCGAKKBHMB(string BHAKNEONPBE, [Optional] KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6759720", Offset = "0x6757F20", VA = "0x186759720", Slot = "18")]
	public Task OPDIPKHNHCO(KGDGNCJNJEJ BCIFNCCEIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x67595F0", Offset = "0x6757DF0", VA = "0x1867595F0", Slot = "19")]
	public Task MDANNPIMMDA(KGDGNCJNJEJ BCIFNCCEIDJ, Dictionary<string, string> DCMLBDMBKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "20")]
	public bool KIIAIOAGNAH(string MKMOMHPDOFP, bool BNJFCFIOLHH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6759540", Offset = "0x6757D40", VA = "0x186759540", Slot = "21")]
	public CLEEKKAIGLK LKHCDFABPIM(string DJFNNDKBEAG, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67594B0", Offset = "0x6757CB0", VA = "0x1867594B0", Slot = "22")]
	public CMPBCDIHLEL LKGEJJLGJJE(string KLHDMBDDJJD, bool BNJFCFIOLHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6759100", Offset = "0x6757900", VA = "0x186759100", Slot = "23")]
	public Task GKKLPGKFKML()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal class FIFEJOFJNKG : INAOMIPNLOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly NFCNLPFPKIN DODIOCIEFNO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> NAEFEHFGNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x1204740", Offset = "0x1202F40", VA = "0x181204740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x8519E0", VA = "0x1808531E0")]
	public FIFEJOFJNKG(NFCNLPFPKIN ODBGBHKKBHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CGEHAPPJIPM
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCMCMDIDFOD OPENADAIAPD(string HFGBAPMMPDC);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AMEKEDOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum OCIIIBFDFOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long KEGMDLFONIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string BJCGNBJIDCC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string OEGJKDEKJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool KAKMLAEDDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long CFMALAMLANC();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FBPLAOCHNDP(long FICLNKKKDEA, bool EBMHHIGHMDN = true);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMICCMEMNME(string CNBJCJOALNK, string FDEAIDCELCI, string NHJACOBAADI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IGKIAJHHGCJ(string CNBJCJOALNK);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BIGNCODIKOG(string CNBJCJOALNK, string OAFJGLMCHBM, string GPCHFPFIMIN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLBCPIBGLPG(string ODFKELNLEML, object BMJILGLPPLA, object FKKNFMCBEAG);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JPPMLDJFIHK(OCIIIBFDFOK BPJBMOFKOIP, int KOIONGLECCC, [Optional] DNGJEJMBPBJ LFGEFHMAKGD, [Optional] string PNLLCLELBOC, [Optional] string GGEHLADLJHF);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JHOHMHJEAIB(DNGJEJMBPBJ LFGEFHMAKGD, long NJKJEIPIFHL, long CPDDAEHJOGH, int IBILILNNHKC, string PNLLCLELBOC, int KOIONGLECCC);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IAJLHHBJPBM(DNGJEJMBPBJ LFGEFHMAKGD, bool NPCJOOKKGED, [Optional] string GGEHLADLJHF);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JGPAJBENGOF(DNGJEJMBPBJ LFGEFHMAKGD, bool NPCJOOKKGED, [Optional] string GGEHLADLJHF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PCDAPKMPBAO(DNGJEJMBPBJ LFGEFHMAKGD, bool NPCJOOKKGED, [Optional] string GGEHLADLJHF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPFEDEKGGOP(long DIMOGDCMBFM, string JLCJKHLNGNK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface CHICALNPGKK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string JMFEOLAFFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
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
