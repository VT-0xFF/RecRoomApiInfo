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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ACB870", Offset = "0x6ACA270", VA = "0x186ACB870")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ACDE30", Offset = "0x6ACC830", VA = "0x186ACDE30", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
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
		public AmplitudeAnalyticsClient.Settings IEGHJKMBBBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JEJCEMPNJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x899870", Offset = "0x898270", VA = "0x180899870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum PKJALLLCAPM
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class MMOPPIHBJEI
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class NNCEENINOPH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				public int JEKAFHLNFKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public Dictionary<string, object> CLMCAGJLPJN;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
				public NNCEENINOPH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class HNOKBCACDPD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
				public HNOKBCACDPD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6AC8650", Offset = "0x6AC7050", VA = "0x186AC8650")]
				internal bool KJGFAKPNIEA(NNCEENINOPH item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private const string EOPDAHDCOJH = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private readonly string BICLBBDNKCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private List<NNCEENINOPH> FBFNFAELNBM;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public int? HBGDODJIFJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x6ACAB40", Offset = "0x6AC9540", VA = "0x186ACAB40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB380", Offset = "0x6AC9D80", VA = "0x186ACB380")]
			internal MMOPPIHBJEI(string FNNMMOFHBMB, string PNPNBGGJHIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA870", Offset = "0x6AC9270", VA = "0x186ACA870")]
			public int BIFEBFLJJAH([Optional] int? EPONENBNJMK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAD90", Offset = "0x6AC9790", VA = "0x186ACAD90")]
			public List<Dictionary<string, object>> HGKEHLLAMIL(int IIFKNHNOPOF, int? EPONENBNJMK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6ACABE0", Offset = "0x6AC95E0", VA = "0x186ACABE0")]
			public void DKDMNNKEAIO(AmplitudeAnalyticsIdentifyMessage GHMNBJIOGAM, bool MLLHCGEPLJF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAC80", Offset = "0x6AC9680", VA = "0x186ACAC80")]
			public void DKDMNNKEAIO(Dictionary<string, object> GHMNBJIOGAM, bool MLLHCGEPLJF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB000", Offset = "0x6AC9A00", VA = "0x186ACB000")]
			public void MJLHLEHBDBD(params Dictionary<string, object>[] OBEOHOHOLKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA530", Offset = "0x6AC8F30", VA = "0x186ACA530")]
			public void AJCLJEEKAOC(List<Dictionary<string, object>> NBKOPNGPNEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA770", Offset = "0x6AC9170", VA = "0x186ACA770")]
			private void BBNKAMKOMHK(Dictionary<string, object> GHMNBJIOGAM, bool MLLHCGEPLJF = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6ACB180", Offset = "0x6AC9B80", VA = "0x186ACB180")]
			public void NLEKPMAMHKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA140", Offset = "0x6AC8B40", VA = "0x186ACA140")]
			private void AHCGLOPOLEF([Optional] string OGKMFEFKCFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6ACAA20", Offset = "0x6AC9420", VA = "0x186ACAA20")]
			private static string BIFIBLFPNIE(string KLABJGGMBGH, string LFOBGDLOPID)
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
			[Cpp2IlInjected.Address(RVA = "0x6ACDA50", Offset = "0x6ACC450", VA = "0x186ACDA50")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct LHPCMHLDLFP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public int HCBGAMPIGHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public string GOFJHAFGAKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T CGDPOGCOHPH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PILBCJPHNGA : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public PILBCJPHNGA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC960", Offset = "0x6ACB360", VA = "0x186ACC960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6ACD0D0", Offset = "0x6ACBAD0", VA = "0x186ACD0D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FGFMPCMDKDJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public IKMBNOHICPK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public FGFMPCMDKDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7B40", Offset = "0x6AC6540", VA = "0x186AC7B40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7C50", Offset = "0x6AC6650", VA = "0x186AC7C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MHMJIILBHAK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public MHMJIILBHAK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC9F80", Offset = "0x6AC8980", VA = "0x186AC9F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6ACA0F0", Offset = "0x6AC8AF0", VA = "0x186ACA0F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FDEACGKPDKA : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public FDEACGKPDKA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7890", Offset = "0x6AC6290", VA = "0x186AC7890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7AF0", Offset = "0x6AC64F0", VA = "0x186AC7AF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IABAOLKIBBI : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public IABAOLKIBBI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC86C0", Offset = "0x6AC70C0", VA = "0x186AC86C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC8910", Offset = "0x6AC7310", VA = "0x186AC8910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class GBHECGDBILA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public MMOPPIHBJEI cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public GBHECGDBILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6AC80E0", Offset = "0x6AC6AE0", VA = "0x186AC80E0")]
			internal void MICIHAGIJPP(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6AC7CA0", Offset = "0x6AC66A0", VA = "0x186AC7CA0")]
			internal void DJLLCENGDLO(LHPCMHLDLFP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class OPAAHGBFCMN : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public MMOPPIHBJEI cache;

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
			private GBHECGDBILA <>8__1;

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
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
			[DebuggerHidden]
			public OPAAHGBFCMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC100", Offset = "0x6ACAB00", VA = "0x186ACC100", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6ACC910", Offset = "0x6ACB310", VA = "0x186ACC910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class APICBDAHNIH<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public APICBDAHNIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x410AF50", Offset = "0x4109950", VA = "0x18410AF50")]
			internal LHPCMHLDLFP<T> PLLDNMHCCDI(MEEHAMAPIAE postResponse)
			{
				return default(LHPCMHLDLFP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private OLBLMMDLAHJ CGCGLAMKKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<NEIIMNIBCIO> GNLMMALHCHP;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string BGIGNKJOIPD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string IMEBFKLJFIL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string EBJEAOBMHKB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int KAAECHHGCBP = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int BMPBENOBFLI = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int AGKOOLIFIPA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float IFGPJOOIPFK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long HFGIKLOKOCC = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string MKPPFLPFBKI = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string MKEAMBOPCNJ = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string CJPPKDCAOIP = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string NKCNFLHALCO = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool JIGAADHGKBA;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool GOHOMPCOEGL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int ACKLLOALECG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int JCHLFGABKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MBGPMNNFOCD HBGKBODJHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KEHDOLDMJHN HIDJLJKMKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private BDCICANMNGP JFNPAFENPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool GPACAAOPKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float JKHGJGNNKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float JMFJKHBPJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int NDFMLILNGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int NHKEOGPGLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? DIJIJKEPOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LGMKLJJJGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long FBAJNKIJEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string GCGKPDBCANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string OPNEEMBJOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long JGPOLDLBKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string BPFHKLAMFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string IFOOBAJJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> MLPNPADBNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private PKJALLLCAPM FPEGCCPKCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int IBBABKMJIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int NJAPEBGKECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float BJEGMHKIPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool BPHPPJFMHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool DNDJOPCKBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private MMOPPIHBJEI PLHNICJNKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private MMOPPIHBJEI GLAANKIIIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private MMOPPIHBJEI CLPKKMFJNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string HKFCHGNOFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OIBAFMBPNOK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo FCJIGAJBBPK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static string ILHOKODAJAM;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const string INCEGADAEHK = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly string FEPDFGJBGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string HMBACEMMIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string DPLABBPMEKE;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OLBLMMDLAHJ MONDKJJNAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6ABD310", Offset = "0x6ABBD10", VA = "0x186ABD310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NEIIMNIBCIO IEAFMPACAIL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6ABDEE0", Offset = "0x6ABC8E0", VA = "0x186ABDEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int NCHHDGDKJMF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEA70", Offset = "0x6ABD470", VA = "0x186ABEA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long ADKOIBAMDEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0AF0", Offset = "0x6ABF4F0", VA = "0x186AC0AF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0C00", Offset = "0x6ABF600", VA = "0x186AC0C00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string MLGOHLEGKBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0AC0", Offset = "0x6ABF4C0", VA = "0x186AC0AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EGECODOHBJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E2C20", Offset = "0x8E1620", VA = "0x1808E2C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xDEEC90", Offset = "0xDED690", VA = "0x180DEEC90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int? PKDNGKCGKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x96BF40", Offset = "0x96A940", VA = "0x18096BF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1A3D690", Offset = "0x1A3C090", VA = "0x181A3D690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MDMMLHNICDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1391620", Offset = "0x1390020", VA = "0x181391620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x13BD530", Offset = "0x13BBF30", VA = "0x1813BD530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool JCLMIEPOKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0990", Offset = "0x6ABF390", VA = "0x186AC0990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> CBFGOGLMEMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6AC08D0", Offset = "0x6ABF2D0", VA = "0x186AC08D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6AC0B40", Offset = "0x6ABF540", VA = "0x186AC0B40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAE90", Offset = "0x6AB9890", VA = "0x186ABAE90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD430", Offset = "0x6ABBE30", VA = "0x186ABD430")]
		private void IBGPJDJBBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFF20", Offset = "0x6ABE920", VA = "0x186ABFF20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE910", Offset = "0x6ABD310", VA = "0x186ABE910", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0240", Offset = "0x6ABEC40", VA = "0x186AC0240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC70", Offset = "0x6ABD670", VA = "0x186ABEC70")]
		public EOHNLEPDLDE PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDE50", Offset = "0x6ABC850", VA = "0x186ABDE50")]
		[IteratorStateMachine(typeof(PILBCJPHNGA))]
		public IEnumerator<GJDHNIMFMOA> InitializeForLocalAccount(AmplitudeAnalyticsEvent DCIHLIBOPJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF5F0", Offset = "0x6ABDFF0", VA = "0x186ABF5F0")]
		public void SendAppEnterEvent(bool HGOLAHBNPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC01C0", Offset = "0x6ABEBC0", VA = "0x186AC01C0")]
		public void UpdateLastKnownInteractionCategory(string IAMBDICGGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0110", Offset = "0x6ABEB10", VA = "0x186AC0110")]
		public void UpdateLastAliveTime(float BKOJCILPMLI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE9C0", Offset = "0x6ABD3C0", VA = "0x186ABE9C0")]
		private EOHNLEPDLDE PCJAKHEBFHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBB90", Offset = "0x6ABA590", VA = "0x186ABBB90")]
		private EOHNLEPDLDE EHEONPCFPME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF900", Offset = "0x6ABE300", VA = "0x186ABF900")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB4F0", Offset = "0x6AB9EF0", VA = "0x186ABB4F0")]
		[IteratorStateMachine(typeof(FGFMPCMDKDJ))]
		private IEnumerator BAAJOMHDBOE(IKMBNOHICPK BNMLGKBINEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AC04D0", Offset = "0x6ABEED0", VA = "0x186AC04D0")]
		[IteratorStateMachine(typeof(MHMJIILBHAK))]
		public IEnumerator WaitForFlush(float PFFHGEAHJBE = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFFF0", Offset = "0x6ABE9F0", VA = "0x186ABFFF0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFF30", Offset = "0x6ABE930", VA = "0x186ABFF30")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime IMAGIDBPDMM)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD950", Offset = "0x6ABC350", VA = "0x186ABD950")]
		public static LJJENBCNCMG Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6ABACE0", Offset = "0x6AB96E0", VA = "0x186ABACE0")]
		public static NBGHMJCFJGN AccountSelectionPostLoginEvent([NotNull] string MKAFHBDBNDL, string FBCNKAADCGD, BJINABDIOMD MDPDNHLEPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBD00", Offset = "0x6ABA700", VA = "0x186ABBD00")]
		public static NBGHMJCFJGN Event([NotNull] string MKAFHBDBNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEE00", Offset = "0x6ABD800", VA = "0x186ABEE00")]
		public static NBGHMJCFJGN PreviousSessionEvent([NotNull] string MKAFHBDBNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDAF0", Offset = "0x6ABC4F0", VA = "0x186ABDAF0")]
		public static NBGHMJCFJGN InitializeEvent(string FBCNKAADCGD, int PDAFBBDCNFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABFB00", Offset = "0x6ABE500", VA = "0x186ABFB00")]
		public static NBGHMJCFJGN StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB6E0", Offset = "0x6ABA0E0", VA = "0x186ABB6E0")]
		public static NBGHMJCFJGN CreateOutOfSessionEvent(string MKAFHBDBNDL, bool IPDFHEPBAGC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE1A0", Offset = "0x6ABCBA0", VA = "0x186ABE1A0")]
		public static EOHNLEPDLDE LogOutOfSessionEvent(NBGHMJCFJGN DEEEINJJFKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDF40", Offset = "0x6ABC940", VA = "0x186ABDF40")]
		public void LogEventAsync(AmplitudeAnalyticsEvent JOKHMNMDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE370", Offset = "0x6ABCD70", VA = "0x186ABE370")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent JOKHMNMDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE4A0", Offset = "0x6ABCEA0", VA = "0x186ABE4A0")]
		public void LogSerializedEventAsync(Dictionary<string, object> DEGEHFMEIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE070", Offset = "0x6ABCA70", VA = "0x186ABE070")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage GONFKBJJFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB9A0", Offset = "0x6ABA3A0", VA = "0x186ABB9A0")]
		private void DLNHHIGPELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE660", Offset = "0x6ABD060", VA = "0x186ABE660")]
		private void OMEODONNLPF(Dictionary<string, object> NMJDKOJJLOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBAA0", Offset = "0x6ABA4A0", VA = "0x186ABBAA0")]
		private void EGEJLHAFPFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC010", Offset = "0x6ABAA10", VA = "0x186ABC010")]
		private void FCOGKIOAICL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCEB0", Offset = "0x6ABB8B0", VA = "0x186ABCEB0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD3A0", Offset = "0x6ABBDA0", VA = "0x186ABD3A0")]
		[IteratorStateMachine(typeof(FDEACGKPDKA))]
		private IEnumerator<GJDHNIMFMOA> HGPKPPBJBFK(float PFFHGEAHJBE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCF40", Offset = "0x6ABB940", VA = "0x186ABCF40")]
		[IteratorStateMachine(typeof(IABAOLKIBBI))]
		private IEnumerator<GJDHNIMFMOA> GIDDHNAEGON(float PFFHGEAHJBE = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE580", Offset = "0x6ABCF80", VA = "0x186ABE580")]
		[IteratorStateMachine(typeof(OPAAHGBFCMN))]
		private IEnumerator<GJDHNIMFMOA> NHOPHFLMLPG(MMOPPIHBJEI DNNINLMOCPD, int? EPONENBNJMK, string HOCOFBBNLOD, float PFFHGEAHJBE, Action<int> DNPFAEFANJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB5D0", Offset = "0x6AB9FD0", VA = "0x186ABB5D0")]
		private static void BGBPCCKBEPL(bool JMAMNHOIDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD240", Offset = "0x6ABBC40", VA = "0x186ABD240")]
		private JAGIEECCCMP<LHPCMHLDLFP<Dictionary<string, object>>> HEKAOHBDILM(string HOCOFBBNLOD, string BOAMIKNHBFF, Dictionary<string, object> CGDPOGCOHPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCFD0", Offset = "0x6ABB9D0", VA = "0x186ABCFD0")]
		private JAGIEECCCMP<LHPCMHLDLFP<List<Dictionary<string, object>>>> HEKAOHBDILM(string HOCOFBBNLOD, string BOAMIKNHBFF, List<Dictionary<string, object>> CGDPOGCOHPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x347DFD0", Offset = "0x347C9D0", VA = "0x18347DFD0")]
		private JAGIEECCCMP<LHPCMHLDLFP<T>> EHELHCCHFED<T>(string KILKLMPPFIM, string HOCOFBBNLOD, string BOAMIKNHBFF, T CGDPOGCOHPH, Dictionary<string, object> AIBKDGHIOPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB580", Offset = "0x6AB9F80", VA = "0x186ABB580")]
		private bool BCOLAMIHOBI(float APGBJJBOFJM, float PFFHGEAHJBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC1E0", Offset = "0x6ABABE0", VA = "0x186ABC1E0")]
		private Dictionary<string, object> FLMGJGOGJLB(string HOCOFBBNLOD, Dictionary<string, object> CGDPOGCOHPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AC05C0", Offset = "0x6ABEFC0", VA = "0x186AC05C0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD7F0", Offset = "0x6ABC1F0", VA = "0x186ABD7F0")]
		[CompilerGenerated]
		private long IKNGOMDFGNJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDF30", Offset = "0x6ABC930", VA = "0x186ABDF30")]
		[CompilerGenerated]
		private void LGKAAGLFBDB(int CKPOFNNACJI)
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
			[Cpp2IlInjected.Address(RVA = "0x6AC18F0", Offset = "0x6AC02F0", VA = "0x186AC18F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6AC19C0", Offset = "0x6AC03C0", VA = "0x186AC19C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1930", Offset = "0x6AC0330", VA = "0x186AC1930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1A10", Offset = "0x6AC0410", VA = "0x186AC1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6AC18B0", Offset = "0x6AC02B0", VA = "0x186AC18B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6AC1970", Offset = "0x6AC0370", VA = "0x186AC1970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC13A0", Offset = "0x6ABFDA0", VA = "0x186AC13A0")]
		public static NBGHMJCFJGN GMDNOGMNFLF(string CJEHFDAEGCE, [NotNull] string BGEIDKDDNAG, long LHJFCKGLOBG, long COJIIEPOCKB, string FBCNKAADCGD, string MDPDNHLEPIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AC14A0", Offset = "0x6ABFEA0", VA = "0x186AC14A0")]
		public static NBGHMJCFJGN LMDCPPNJPPP(string CJEHFDAEGCE, [NotNull] string BGEIDKDDNAG, long LHJFCKGLOBG, long COJIIEPOCKB, string FBCNKAADCGD, long JKPFHIJKHEN, string HLJNCMMODAJ, string IKGHOFFDANL, string CIPFJMMBOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1710", Offset = "0x6AC0110", VA = "0x186AC1710")]
		private AmplitudeAnalyticsEvent(string CJEHFDAEGCE, [NotNull] string BGEIDKDDNAG, long LHJFCKGLOBG, long COJIIEPOCKB, string FBCNKAADCGD, string MDPDNHLEPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x928330", Offset = "0x926D30", VA = "0x180928330")]
		public void ADNICEOAHAM(long JMIEHIDHOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0C60", Offset = "0x6ABF660", VA = "0x186AC0C60", Slot = "5")]
		public override void CDKKPEIDLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0D60", Offset = "0x6ABF760", VA = "0x186AC0D60", Slot = "6")]
		public override void FCOCIKKNLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0EE0", Offset = "0x6ABF8E0", VA = "0x186AC0EE0", Slot = "4")]
		protected override Dictionary<string, object> GHGGBBAGLEI(Dictionary<string, object> INJFJFCNEMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1600", Offset = "0x6AC0000", VA = "0x186AC1600")]
		private void NGNJDBEENEL(string LFOBGDLOPID, string KLABJGGMBGH, bool FINCLKCLAML = false)
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
			[Cpp2IlInjected.Address(RVA = "0x6AC5550", Offset = "0x6AC3F50", VA = "0x186AC5550")]
			public void BGPHOOJJCMG(Dictionary<string, object> JKCKNBOJFIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6ACD6E0", Offset = "0x6ACC0E0", VA = "0x186ACD6E0")]
			public void BGPHOOJJCMG(Dictionary<string, object> FIMECMHFAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD08790", Offset = "0xD07190", VA = "0x180D08790")]
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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1FB0", Offset = "0x6AC09B0", VA = "0x186AC1FB0")]
		public static LJJENBCNCMG GMDNOGMNFLF(string CJEHFDAEGCE, string FBCNKAADCGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2110", Offset = "0x6AC0B10", VA = "0x186AC2110")]
		protected AmplitudeAnalyticsIdentifyMessage(string CJEHFDAEGCE, string FBCNKAADCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1B60", Offset = "0x6AC0560", VA = "0x186AC1B60")]
		public Dictionary<string, object> ELMELEKMPCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1C70", Offset = "0x6AC0670", VA = "0x186AC1C70", Slot = "4")]
		protected virtual Dictionary<string, object> GHGGBBAGLEI(Dictionary<string, object> INJFJFCNEMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2070", Offset = "0x6AC0A70", VA = "0x186AC2070")]
		protected void MGALBNENJOF(string LFOBGDLOPID, Dictionary<string, object> BMPOBEJJIIP, Dictionary<string, object> NCJLKBNKGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1A60", Offset = "0x6AC0460", VA = "0x186AC1A60")]
		protected void AEJKPFJGJDK(string LFOBGDLOPID, string KLABJGGMBGH, Dictionary<string, object> GEFMDANGIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1AD0", Offset = "0x6AC04D0", VA = "0x186AC1AD0", Slot = "5")]
		public virtual void CDKKPEIDLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC1BF0", Offset = "0x6AC05F0", VA = "0x186AC1BF0", Slot = "6")]
		public virtual void FCOCIKKNLAM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LJJENBCNCMG : DMKCOKEAHJP<AmplitudeAnalyticsIdentifyMessage, LJJENBCNCMG>
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public override LJJENBCNCMG FKDPMOFBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage HPOGLODEOJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9F30", Offset = "0x6AC8930", VA = "0x186AC9F30")]
	public LJJENBCNCMG(AmplitudeAnalyticsIdentifyMessage KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9E90", Offset = "0x6AC8890", VA = "0x186AC9E90", Slot = "4")]
	public override void FCOCIKKNLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NBGHMJCFJGN : DMKCOKEAHJP<AmplitudeAnalyticsEvent, NBGHMJCFJGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PHIJDGLGPMA;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override NBGHMJCFJGN FKDPMOFBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public long PONCDDFBAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB850", Offset = "0x6ACA250", VA = "0x186ACB850")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9E40", Offset = "0x6AC8840", VA = "0x186AC9E40")]
	public NBGHMJCFJGN(AmplitudeAnalyticsEvent KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "5")]
	public override AmplitudeAnalyticsEvent HPOGLODEOJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB4F0", Offset = "0x6AC9EF0", VA = "0x186ACB4F0", Slot = "4")]
	public override void FCOCIKKNLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2EDEF20", Offset = "0x2EDD920", VA = "0x182EDEF20")]
	public NBGHMJCFJGN GOPKJLCFEDI<T>(string PKFJNPAMFMB, T[] KLABJGGMBGH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2EDEF20", Offset = "0x2EDD920", VA = "0x182EDEF20")]
	public NBGHMJCFJGN GOPKJLCFEDI(string PKFJNPAMFMB, string[] KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2EDEC70", Offset = "0x2EDD670", VA = "0x182EDEC70")]
	public NBGHMJCFJGN GOPKJLCFEDI<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB5C0", Offset = "0x6AC9FC0", VA = "0x186ACB5C0")]
	public NBGHMJCFJGN GOPKJLCFEDI(string PKFJNPAMFMB, long KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB640", Offset = "0x6ACA040", VA = "0x186ACB640")]
	public NBGHMJCFJGN GOPKJLCFEDI(string PKFJNPAMFMB, string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB590", Offset = "0x6AC9F90", VA = "0x186ACB590")]
	public NBGHMJCFJGN GBKBFGGBLEM(string PKFJNPAMFMB, object? KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB7B0", Offset = "0x6ACA1B0", VA = "0x186ACB7B0")]
	public NBGHMJCFJGN NJPFFKCBMIK(string PKFJNPAMFMB, string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6ACB6B0", Offset = "0x6ACA0B0", VA = "0x186ACB6B0")]
	private NBGHMJCFJGN NJKBCCGKAAK(string PKFJNPAMFMB, object KLABJGGMBGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LCGGJKCFHHP : NBGHMJCFJGN
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9E40", Offset = "0x6AC8840", VA = "0x186AC9E40")]
	public LCGGJKCFHHP(AmplitudeAnalyticsEvent KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9C90", Offset = "0x6AC8690", VA = "0x186AC9C90", Slot = "4")]
	public override void FCOCIKKNLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class DMKCOKEAHJP<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : DMKCOKEAHJP<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M KFAOBDLOMDC;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public abstract BLDR FKDPMOFBJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public DMKCOKEAHJP(M KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5B562E0", Offset = "0x5B54CE0", VA = "0x185B562E0")]
	public BLDR LNOCCGFIIPP(AmplitudeAnalyticsIdentifyMessage.DeviceInfo EECCOLKPKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5B56260", Offset = "0x5B54C60", VA = "0x185B56260")]
	public BLDR JMCIHCLAKNA(AmplitudeAnalyticsIdentifyMessage.RevenueData EBIHJMDNIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5B561B0", Offset = "0x5B54BB0", VA = "0x185B561B0")]
	public BLDR GDHECGMJCEF(string PKFJNPAMFMB, string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B02B20", Offset = "0x2B01520", VA = "0x182B02B20")]
	public BLDR GDHECGMJCEF<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FCOCIKKNLAM();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5B562B0", Offset = "0x5B54CB0", VA = "0x185B562B0")]
	internal static string KNEHAJPHMNO(string KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5B56330", Offset = "0x5B54D30", VA = "0x185B56330")]
	private BLDR MOKNMLIGMJE(string PKFJNPAMFMB, object KLABJGGMBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M HPOGLODEOJP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class GFAJNPKLGIF : MBGPMNNFOCD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct BAHJOHNEIIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder<MEEHAMAPIAE> <>t__builder;

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
		public GFAJNPKLGIF <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6AC21D0", Offset = "0x6AC0BD0", VA = "0x186AC21D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AC2BF0", Offset = "0x6AC15F0", VA = "0x186AC2BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient FDOHJLAOAND;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6AC83F0", Offset = "0x6AC6DF0", VA = "0x186AC83F0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void GLJCBIMMIGM(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC85D0", Offset = "0x6AC6FD0", VA = "0x186AC85D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GFAJNPKLGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC8460", Offset = "0x6AC6E60", VA = "0x186AC8460", Slot = "4")]
	[AsyncStateMachine(typeof(BAHJOHNEIIA))]
	public Task<MEEHAMAPIAE> LLCLCNCCBCO(string KILKLMPPFIM, string JHKGDIMENBN, string CFIFLGJLOLF, string BCGDHMNJPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class CCKCMKCLMCN : MBGPMNNFOCD
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OKEABLANFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public TaskCompletionSource<MEEHAMAPIAE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OKEABLANFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6ACB8F0", Offset = "0x6ACA2F0", VA = "0x186ACB8F0")]
		internal void LMEBGOMJKAI(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct PMMNKKHBECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder<MEEHAMAPIAE> <>t__builder;

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
		private TaskAwaiter<MEEHAMAPIAE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD120", Offset = "0x6ACBB20", VA = "0x186ACD120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD670", Offset = "0x6ACC070", VA = "0x186ACD670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void GEIDDHOAJNE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CCKCMKCLMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2E00", Offset = "0x6AC1800", VA = "0x186AC2E00", Slot = "4")]
	[AsyncStateMachine(typeof(PMMNKKHBECA))]
	public Task<MEEHAMAPIAE> LLCLCNCCBCO(string KILKLMPPFIM, string JHKGDIMENBN, string CFIFLGJLOLF, string BCGDHMNJPNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BNNKHKMMDEF
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> FNEHNICJMKG;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2C60", Offset = "0x6AC1660", VA = "0x186AC2C60")]
	internal static bool EIAPBBEEPPE(string LFOBGDLOPID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface MBGPMNNFOCD
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEEHAMAPIAE> LLCLCNCCBCO(string KILKLMPPFIM, string JHKGDIMENBN, string CFIFLGJLOLF, string BCGDHMNJPNF);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MEEHAMAPIAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly int OLHNECLOPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string IBDDDADDMCN;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1012BB0", Offset = "0x10115B0", VA = "0x181012BB0")]
	public MEEHAMAPIAE(int HCBGAMPIGHI, string GOFJHAFGAKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum IEOMEALMCOF
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
public class KNGBLHABDHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private long LMBMPGBGHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NBGHMJCFJGN PCIJKBOCLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool AFOKBDJPNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float FBGCCBOHLPG;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9B00", Offset = "0x6AC8500", VA = "0x186AC9B00")]
	public KNGBLHABDHO(string CFKAHBIFEAM, float FBGCCBOHLPG = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BC10", Offset = "0x2E4A610", VA = "0x182E4BC10")]
	public void GOPKJLCFEDI<T>(string PKFJNPAMFMB, T KLABJGGMBGH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9940", Offset = "0x6AC8340", VA = "0x186AC9940")]
	public void GOPKJLCFEDI(string PKFJNPAMFMB, string KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6AC99C0", Offset = "0x6AC83C0", VA = "0x186AC99C0")]
	public void MCIMDCOHOLD(string IBLDJFPLGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9770", Offset = "0x6AC8170", VA = "0x186AC9770")]
	public void AIOIJNJEHDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9830", Offset = "0x6AC8230", VA = "0x186AC9830")]
	private void CAJOLBIGKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC9AB0", Offset = "0x6AC84B0", VA = "0x186AC9AB0")]
	private bool NCJKPLBKJFJ()
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
		public enum OKALGMGFHOF
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
		private OKALGMGFHOF parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public OKALGMGFHOF Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880")]
			get
			{
				return default(OKALGMGFHOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6ACD850", Offset = "0x6ACC250", VA = "0x186ACD850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class EEEFIAKOPBC : AKIEELGBHCO, JAEFKOGEDIK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void AJOEDNNEKLA(PNGFELKBGAE KGFHMHEHKJL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly CMENKDKLOLC KPDFLPNKNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly AJOEDNNEKLA LKPLOEFJEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string CGBNOFBIIPA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string LOAKOGPEEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x147BB60", Offset = "0x147A560", VA = "0x18147BB60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LCBMBODDADN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AC56F0", Offset = "0x6AC40F0", VA = "0x186AC56F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MFLGHAEELLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AC56D0", Offset = "0x6AC40D0", VA = "0x186AC56D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IReadOnlyList<string> FCNAEHCOHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x147BF30", Offset = "0x147A930", VA = "0x18147BF30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5710", Offset = "0x6AC4110", VA = "0x186AC5710")]
	public EEEFIAKOPBC(CMENKDKLOLC JNHFGLCOILM, string EMDGFEFICLO, [Optional] AJOEDNNEKLA LACICCBOFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BED570", Offset = "0x2BEBF70", VA = "0x182BED570", Slot = "8")]
	public T PBGHNKGJFJB<T>(string LFOBGDLOPID, T MCAGMGIJFIA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ENDJHBINDPJ : CDCHCDMFJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct CPMKDHDJHCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public KEHDOLDMJHN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public ENDJHBINDPJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6AC4970", Offset = "0x6AC3370", VA = "0x186AC4970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5320", Offset = "0x6AC3D20", VA = "0x186AC5320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct OOJCDLAMPLG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6ACB9D0", Offset = "0x6ACA3D0", VA = "0x186ACB9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6ACBBE0", Offset = "0x6ACA5E0", VA = "0x186ACBBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct OOOCBDJFLJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public KEHDOLDMJHN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ENDJHBINDPJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6ACBC40", Offset = "0x6ACA640", VA = "0x186ACBC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6ACC0A0", Offset = "0x6ACAAA0", VA = "0x186ACC0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IMGOJIKCCLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ENDJHBINDPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public KEHDOLDMJHN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8960", Offset = "0x6AC7360", VA = "0x186AC8960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8D30", Offset = "0x6AC7730", VA = "0x186AC8D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly IReadOnlyDictionary<string, BLKGJELKHNB> GGPBNLCGNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool OGPFCJCDGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool ABLPCPKJJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private TaskCompletionSource<bool> BCJNCPGOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> FBHFCEJPBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly SemaphoreSlim GOFIJBMHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MKCCECBCKCN GMLDFBHEHNO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Task OMDOHGKCLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7150", Offset = "0x6AC5B50", VA = "0x186AC7150", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AEFMCAKKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AHFCPHCFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD60", Offset = "0xDDC760", VA = "0x180DDDD60", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string EGECODOHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6AC61A0", Offset = "0x6AC4BA0", VA = "0x186AC61A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FMCDJICEAJN DKPFKDGNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6AC5E40", Offset = "0x6AC4840", VA = "0x186AC5E40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LICLEDJPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6100", Offset = "0x6AC4B00", VA = "0x186AC6100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6650", Offset = "0x6AC5050", VA = "0x186AC6650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BIKLIGCOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AC7590", Offset = "0x6AC5F90", VA = "0x186AC7590", Slot = "23")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AC70B0", Offset = "0x6AC5AB0", VA = "0x186AC70B0", Slot = "24")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action PGFBKNOGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6FD0", Offset = "0x6AC59D0", VA = "0x186AC6FD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6410", Offset = "0x6AC4E10", VA = "0x186AC6410", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<PNGFELKBGAE> BFAMKLMJIMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AC61B0", Offset = "0x6AC4BB0", VA = "0x186AC61B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AC6050", Offset = "0x6AC4A50", VA = "0x186AC6050", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6030", Offset = "0x6AC4A30", VA = "0x186AC6030", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5A60", Offset = "0x6AC4460", VA = "0x186AC5A60", Slot = "10")]
	[AsyncStateMachine(typeof(CPMKDHDJHCE))]
	public Task AIFHKOLJDOL(string PNPNBGGJHIL, [Optional] KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5E70", Offset = "0x6AC4870", VA = "0x186AC5E70", Slot = "21")]
	[AsyncStateMachine(typeof(OOJCDLAMPLG))]
	public Task CNJPPBMNIGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5D40", Offset = "0x6AC4740", VA = "0x186AC5D40", Slot = "16")]
	[AsyncStateMachine(typeof(OOOCBDJFLJO))]
	public Task BMOGLLPBDCJ(KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AC59C0", Offset = "0x6AC43C0", VA = "0x186AC59C0")]
	private void ADJCOEGIEJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5F20", Offset = "0x6AC4920", VA = "0x186AC5F20", Slot = "17")]
	[AsyncStateMachine(typeof(IMGOJIKCCLI))]
	public Task DCFPJLFGMHB(KEHDOLDMJHN KHBHLJCCBLL, Dictionary<string, string> HJCNLGFNLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7500", Offset = "0x6AC5F00", VA = "0x186AC7500", Slot = "18")]
	public bool PDKAJGGBKMN(string IPHLPCHEHCP, bool PNJKAODDNJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7190", Offset = "0x6AC5B90", VA = "0x186AC7190", Slot = "19")]
	public AKIEELGBHCO OGFAAEBKJJK(string EMDGFEFICLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5B80", Offset = "0x6AC4580", VA = "0x186AC5B80")]
	private CMENKDKLOLC AOCGHKMFCCN(string EMDGFEFICLO, bool PNJKAODDNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6260", Offset = "0x6AC4C60", VA = "0x186AC6260", Slot = "20")]
	public JBIFPJJEMHJ HEIOPLKHIOH(string GPKPDGINOLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AC64B0", Offset = "0x6AC4EB0", VA = "0x186AC64B0")]
	private BCOGLJLBHLF IJJJMABLEKN(string GPKPDGINOLO, bool PNJKAODDNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6AC66F0", Offset = "0x6AC50F0", VA = "0x186AC66F0")]
	private DDMIJDHINBJ KADJAFONAKK(KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7350", Offset = "0x6AC5D50", VA = "0x186AC7350")]
	private MMJFDEKAMBG OHEDDGBLJDG(string PNPNBGGJHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AC6540", Offset = "0x6AC4F40", VA = "0x186AC6540")]
	private void JGKJGMNPFDD(string EMDGFEFICLO, CMENKDKLOLC JNHFGLCOILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7790", Offset = "0x6AC6190", VA = "0x186AC7790")]
	public ENDJHBINDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7070", Offset = "0x6AC5A70", VA = "0x186AC7070")]
	[CompilerGenerated]
	private void LKDMOHKFELE(PNGFELKBGAE CGJIPKMEOFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC7070", Offset = "0x6AC5A70", VA = "0x186AC7070")]
	[CompilerGenerated]
	private void OGMDPOBBDJJ(PNGFELKBGAE CGJIPKMEOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class CKCBKKCGBBB : CDCHCDMFJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct JLONAEGCPKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public CKCBKKCGBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public KEHDOLDMJHN userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6AC8D90", Offset = "0x6AC7790", VA = "0x186AC8D90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6AC9710", Offset = "0x6AC8110", VA = "0x186AC9710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ELJBOKOOIKM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6AC5780", Offset = "0x6AC4180", VA = "0x186AC5780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private ENDJHBINDPJ MEHDMPONLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[CompilerGenerated]
	private Action BIKLIGCOHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private TaskCompletionSource<bool> BCJNCPGOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> FBHFCEJPBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Task LFPMKDOHBCG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	private CDCHCDMFJJO GLLFIKGKNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4840", Offset = "0x6AC3240", VA = "0x186AC4840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool AHFCPHCFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4410", Offset = "0x6AC2E10", VA = "0x186AC4410", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool AEFMCAKKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4180", Offset = "0x6AC2B80", VA = "0x186AC4180", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Task OMDOHGKCLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4420", Offset = "0x6AC2E20", VA = "0x186AC4420", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string EGECODOHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3DD0", Offset = "0x6AC27D0", VA = "0x186AC3DD0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FMCDJICEAJN DKPFKDGNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6AC39E0", Offset = "0x6AC23E0", VA = "0x186AC39E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LICLEDJPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3D30", Offset = "0x6AC2730", VA = "0x186AC3D30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4260", Offset = "0x6AC2C60", VA = "0x186AC4260", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PGFBKNOGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6AC4370", Offset = "0x6AC2D70", VA = "0x186AC4370", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6AC40E0", Offset = "0x6AC2AE0", VA = "0x186AC40E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<PNGFELKBGAE> BFAMKLMJIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3DF0", Offset = "0x6AC27F0", VA = "0x186AC3DF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3C80", Offset = "0x6AC2680", VA = "0x186AC3C80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6AC48B0", Offset = "0x6AC32B0", VA = "0x186AC48B0")]
	[UnityEngine.Scripting.Preserve]
	public CKCBKKCGBBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3750", Offset = "0x6AC2150", VA = "0x186AC3750")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	internal static void ABFKOJMEBJE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4300", Offset = "0x6AC2D00", VA = "0x186AC4300")]
	internal static void KFKANKGCKOJ(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3C50", Offset = "0x6AC2650", VA = "0x186AC3C50", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6AC37C0", Offset = "0x6AC21C0", VA = "0x186AC37C0", Slot = "10")]
	[AsyncStateMachine(typeof(JLONAEGCPKJ))]
	public Task AIFHKOLJDOL(string PNPNBGGJHIL, [Optional] KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AC38D0", Offset = "0x6AC22D0", VA = "0x186AC38D0", Slot = "16")]
	public Task BMOGLLPBDCJ(KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3B30", Offset = "0x6AC2530", VA = "0x186AC3B30", Slot = "17")]
	public Task DCFPJLFGMHB(KEHDOLDMJHN KHBHLJCCBLL, Dictionary<string, string> HJCNLGFNLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4720", Offset = "0x6AC3120", VA = "0x186AC4720", Slot = "18")]
	public bool PDKAJGGBKMN(string IPHLPCHEHCP, bool PNJKAODDNJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4660", Offset = "0x6AC3060", VA = "0x186AC4660", Slot = "19")]
	public AKIEELGBHCO OGFAAEBKJJK(string EMDGFEFICLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3EA0", Offset = "0x6AC28A0", VA = "0x186AC3EA0", Slot = "20")]
	public JBIFPJJEMHJ HEIOPLKHIOH(string GPKPDGINOLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3A20", Offset = "0x6AC2420", VA = "0x186AC3A20", Slot = "21")]
	public Task CNJPPBMNIGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3F60", Offset = "0x6AC2960", VA = "0x186AC3F60")]
	private static void HKCKKHKCNOD(TaskCompletionSource<bool> NKDMIPFFBGD, Task OEEEKPDHCKN, Task BFJGEHLEPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4190", Offset = "0x6AC2B90", VA = "0x186AC4190")]
	[AsyncStateMachine(typeof(ELJBOKOOIKM))]
	private static void JEEOKJHDEBL(Task KECDGIGMBNG, TaskCompletionSource<bool> NKDMIPFFBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9A57D0", Offset = "0x9A41D0", VA = "0x1809A57D0")]
	[CompilerGenerated]
	private void MCEOEFNFEOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9555D0", Offset = "0x953FD0", VA = "0x1809555D0")]
	[CompilerGenerated]
	private void FMKMOAAFEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x9A59D0", Offset = "0x9A43D0", VA = "0x1809A59D0")]
	[CompilerGenerated]
	private void PEKEGJAMNAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6AC4620", Offset = "0x6AC3020", VA = "0x186AC4620")]
	[CompilerGenerated]
	private void NKAKDGLNCCO(PNGFELKBGAE CGJIPKMEOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class NAFEOLJNECN : JBIFPJJEMHJ, JAEFKOGEDIK
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void IPLEHKCDNBM(PNGFELKBGAE KGFHMHEHKJL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly IPLEHKCDNBM LKPLOEFJEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly BCOGLJLBHLF IFAALHDPPOP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string LOAKOGPEEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1FFC480", Offset = "0x1FFAE80", VA = "0x181FFC480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5E10410", Offset = "0x5E0EE10", VA = "0x185E10410")]
	public NAFEOLJNECN(BCOGLJLBHLF CEEMGDGDBHO, [Optional] IPLEHKCDNBM LACICCBOFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2EDBF50", Offset = "0x2EDA950", VA = "0x182EDBF50", Slot = "5")]
	public T PBGHNKGJFJB<T>(string LFOBGDLOPID, T MCAGMGIJFIA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface EOMBNEDMIJN
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class DLHNCDLIFCH : EOMBNEDMIJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly IFIPMOJBIEJ LJFMOAGOJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<GONHMCHADCD> HNLAGMOJLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly string DMOOMOPOLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string NNIOEGBOEDD;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6AC5380", Offset = "0x6AC3D80", VA = "0x186AC5380")]
	[DJINMBCHLNM.LIHKMGLKGEL.LIKIBBIAMKP]
	[UsedImplicitly]
	internal static void MNJJOBMFJLK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC53F0", Offset = "0x6AC3DF0", VA = "0x186AC53F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DLHNCDLIFCH([NotNull][OLJNBPOCBCJ(null)] IFIPMOJBIEJ LJFMOAGOJNH, [OLJNBPOCBCJ(null)][NotNull] CKFENHFHANO DELCMGOGKGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CIKCKLCDOPM : CDCHCDMFJJO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task OMDOHGKCLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3610", Offset = "0x6AC2010", VA = "0x186AC3610", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool AHFCPHCFGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool AEFMCAKKEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string EGECODOHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FMCDJICEAJN DKPFKDGNLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action LICLEDJPOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3250", Offset = "0x6AC1C50", VA = "0x186AC3250", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6AC34D0", Offset = "0x6AC1ED0", VA = "0x186AC34D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action PGFBKNOGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3570", Offset = "0x6AC1F70", VA = "0x186AC3570", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6AC3430", Offset = "0x6AC1E30", VA = "0x186AC3430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<PNGFELKBGAE> BFAMKLMJIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6AC32F0", Offset = "0x6AC1CF0", VA = "0x186AC32F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6AC31A0", Offset = "0x6AC1BA0", VA = "0x186AC31A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CIKCKLCDOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2F60", Offset = "0x6AC1960", VA = "0x186AC2F60", Slot = "10")]
	public Task AIFHKOLJDOL(string PNPNBGGJHIL, [Optional] KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AC2FF0", Offset = "0x6AC19F0", VA = "0x186AC2FF0", Slot = "16")]
	public Task BMOGLLPBDCJ(KEHDOLDMJHN KHBHLJCCBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3110", Offset = "0x6AC1B10", VA = "0x186AC3110", Slot = "17")]
	public Task DCFPJLFGMHB(KEHDOLDMJHN KHBHLJCCBLL, Dictionary<string, string> HJCNLGFNLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "18")]
	public bool PDKAJGGBKMN(string IPHLPCHEHCP, bool PNJKAODDNJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC36A0", Offset = "0x6AC20A0", VA = "0x186AC36A0", Slot = "19")]
	public AKIEELGBHCO OGFAAEBKJJK(string EMDGFEFICLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AC33A0", Offset = "0x6AC1DA0", VA = "0x186AC33A0", Slot = "20")]
	public JBIFPJJEMHJ HEIOPLKHIOH(string GPKPDGINOLO, bool PNJKAODDNJM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AC3080", Offset = "0x6AC1A80", VA = "0x186AC3080", Slot = "21")]
	public Task CNJPPBMNIGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class MKCCECBCKCN : FMCDJICEAJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly DDMIJDHINBJ NBDIHOCAMHE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IReadOnlyDictionary<string, object> JEJFCADAMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x147BF10", Offset = "0x147A910", VA = "0x18147BF10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public MKCCECBCKCN(DDMIJDHINBJ FBPJMALFLNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface HOGIPBDJLBM
{
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KNGBLHABDHO BDCPFHNAGCP(string CFKAHBIFEAM);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BDCICANMNGP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum GMHILFDHNNA
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
	long KOEJAMDLGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	string PDIPPFKMNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string FEAPJFADEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FOODKEGNPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long DDNEJKFJGCO();

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ALHIPPPOHKO(long LHJFCKGLOBG, bool FINCLKCLAML = true);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCMNEIPDPIC(string EIGKPCONJCB, string KDLMHFLAFNO, string PHDBCHOADLP);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NIDDOLIHOJO(string EIGKPCONJCB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PKAAODBOGPE(string EIGKPCONJCB, string CIOBGCNDGLO, string KOJJCKPOJDJ);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LMNOFIAAMAB(string MANKBKONOGI, object GBGGAGHKFEK, object ABOBCDDIOMH);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PMGDBJINJJL(GMHILFDHNNA MCEKMKHIJGE, int OGKJJPEBIOK, [Optional] MBADDKCFDLI PACBBFMGBPL, [Optional] string BOHJMMJDHCK, [Optional] string ENDMINEHNJK);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BPCDDCLIIMD(MBADDKCFDLI PACBBFMGBPL, long AFJAOLLGGIJ, long FJDDELEGNAC, int CONPOJOOKEO, string BOHJMMJDHCK, int OGKJJPEBIOK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOEPGDNJAOM(MBADDKCFDLI PACBBFMGBPL, bool PPGNMKCJKAG, [Optional] string ENDMINEHNJK);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BONLKJCLJKD(MBADDKCFDLI PACBBFMGBPL, bool PPGNMKCJKAG, [Optional] string ENDMINEHNJK);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KOOFGJBHPNN(MBADDKCFDLI PACBBFMGBPL, bool PPGNMKCJKAG, [Optional] string ENDMINEHNJK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KCKGNPCLAKE(long FNKMOIJJLLC, string PJMJFJDOAMI);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BALMHIJFFMO
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string ECLJLGBGNLJ
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
