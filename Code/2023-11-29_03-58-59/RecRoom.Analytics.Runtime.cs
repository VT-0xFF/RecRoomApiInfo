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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D1F920", Offset = "0x5D1ED20", VA = "0x185D1F920")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
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
		public AmplitudeAnalyticsClient.Settings MMOJENKMGFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BGDKEHLPODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772C20", VA = "0x180773820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum JOOPPJKOLJF
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class HBPDPAGBGJG
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class EAEDMDJAABD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int GPICNHJLHPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> PKNAONFJDFM;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
				public EAEDMDJAABD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class FDFPFEKOFGN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
				public FDFPFEKOFGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5D18A00", Offset = "0x5D17E00", VA = "0x185D18A00")]
				internal bool DHDFPAIAAEI(EAEDMDJAABD item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string GIKGNEFPINL = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string NLAOLIJBIMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<EAEDMDJAABD> ABBHDIBADGM;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? OKFFIAKKBOB
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5D1A5D0", Offset = "0x5D199D0", VA = "0x185D1A5D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5D1B130", Offset = "0x5D1A530", VA = "0x185D1B130")]
			internal HBPDPAGBGJG(string POOKPECIFHF, string FNDDKNHNGIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A8C0", Offset = "0x5D19CC0", VA = "0x185D1A8C0")]
			public int JKJACENIMEM([Optional] int? OCHLNHFHAPL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5D1AEC0", Offset = "0x5D1A2C0", VA = "0x185D1AEC0")]
			public List<Dictionary<string, object>> PPDDFCJAFMK(int LKMEFEBEBGI, int? OCHLNHFHAPL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5D1AB80", Offset = "0x5D19F80", VA = "0x185D1AB80")]
			public void LCILIBKDDLO(AmplitudeAnalyticsIdentifyMessage ECLCDMJMICA, bool OLGMCGEAGJH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5D1AA70", Offset = "0x5D19E70", VA = "0x185D1AA70")]
			public void LCILIBKDDLO(Dictionary<string, object> ECLCDMJMICA, bool OLGMCGEAGJH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5D1AD30", Offset = "0x5D1A130", VA = "0x185D1AD30")]
			public void ODKIPLLOABC(params Dictionary<string, object>[] OAIMBEHJJOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A670", Offset = "0x5D19A70", VA = "0x185D1A670")]
			public void HAJHBPCOBBN(List<Dictionary<string, object>> IDMECNEODIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5D1AC20", Offset = "0x5D1A020", VA = "0x185D1AC20")]
			private void MGEMHANMNDC(Dictionary<string, object> ECLCDMJMICA, bool OLGMCGEAGJH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A260", Offset = "0x5D19660", VA = "0x185D1A260")]
			public void CEMGCJOPNNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5D19E70", Offset = "0x5D19270", VA = "0x185D19E70")]
			private void AFLNGKHJNBB([Optional] string IMBNDIKBPDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5D1A4A0", Offset = "0x5D198A0", VA = "0x185D1A4A0")]
			private static string FIKMIFLCGPL(string NMENOOMOOJP, string MIMFBLPNKOG)
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
			[Cpp2IlInjected.Address(RVA = "0x5D20F90", Offset = "0x5D20390", VA = "0x185D20F90")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct FDMJODIOEID<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int LOFNOOFBCDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string BJGHHEIMGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T EBDFAPJCEAH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FMBNIMHAHDE : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private EIIEDLICJGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public FMBNIMHAHDE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5D18D50", Offset = "0x5D18150", VA = "0x185D18D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5D19510", Offset = "0x5D18910", VA = "0x185D19510", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class PMCMAIECMLJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public JOBBEGCJNAJ quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public PMCMAIECMLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5D1FEC0", Offset = "0x5D1F2C0", VA = "0x185D1FEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5D1FFD0", Offset = "0x5D1F3D0", VA = "0x185D1FFD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MILNBMOGBAP : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public MILNBMOGBAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5D1EB10", Offset = "0x5D1DF10", VA = "0x185D1EB10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5D1EC80", Offset = "0x5D1E080", VA = "0x185D1EC80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DFIDJFEOIAA : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private EIIEDLICJGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public DFIDJFEOIAA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5D185B0", Offset = "0x5D179B0", VA = "0x185D185B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5D18830", Offset = "0x5D17C30", VA = "0x185D18830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FELOALKCHMF : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private EIIEDLICJGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public FELOALKCHMF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5D18A70", Offset = "0x5D17E70", VA = "0x185D18A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5D18D00", Offset = "0x5D18100", VA = "0x185D18D00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class LDBIJKDAFIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public HBPDPAGBGJG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public LDBIJKDAFIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5D1E7F0", Offset = "0x5D1DBF0", VA = "0x185D1E7F0")]
			internal void CFOHNENKNHB(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5D1E3A0", Offset = "0x5D1D7A0", VA = "0x185D1E3A0")]
			internal void BMHMKBKMPHF(FDMJODIOEID<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class POAJBPDDJJE : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private EIIEDLICJGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public HBPDPAGBGJG cache;

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
			private LDBIJKDAFIF <>8__1;

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
			private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public POAJBPDDJJE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5D20380", Offset = "0x5D1F780", VA = "0x185D20380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5D20BD0", Offset = "0x5D1FFD0", VA = "0x185D20BD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class DJJOHECENAA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DJJOHECENAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9BF0", Offset = "0x4DD8FF0", VA = "0x184DD9BF0")]
			internal FDMJODIOEID<T> MHAKMIGNHOG(DLCACNHLAPE postResponse)
			{
				return default(FDMJODIOEID<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class DMONDKEFAJO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public DMONDKEFAJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4DD9BF0", Offset = "0x4DD8FF0", VA = "0x184DD9BF0")]
			internal FDMJODIOEID<T> IIKDPOADDMJ(DLCACNHLAPE postResponse)
			{
				return default(FDMJODIOEID<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private OFEIPEOOHLH EAJJNAFLPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<EJKLLGBGNFI> FPEBHFJEHMM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string FMALLHCGBAM = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string MKPNCPIBKID = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string HIHHNJIAOPP = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int MBOFOFHDFIL = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int NCNKKFJLLDG = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int MKNIEIHDDBF = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float PDNJNMJGEMP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long CGOHPBAIDKP = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LHAKAGJPJJB = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string CLOIODOCNCH = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool PIGOCLCKDNK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ODHKIBGPDKL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int AEKPPDNJCFP;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int ILHJOJANFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private KAPEGCOLHPL CFBFADMFGPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private FLKPKEOPDKC DKOIJAJNFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GKPOCEODCIJ FMMIPFGNFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool IEHJOHPMBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float OEHJGBLPOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float GJHHLLAMJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int CJIPIKIAKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int HOFDMKNCHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? IAALLIONHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? GAFILBHABDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long JDDEGBCKNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string DJDBCFCKLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool HGOHLPKOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long AAKLOIABNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string PNPLBMADNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string KLEGPNGHBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> KJDHALIDAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JOOPPJKOLJF PBALDDNLECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int ONHBILPCAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int EGPGMJMLFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float PHKLGNFAMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool LDDIDAFKCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ILFCGBOMPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HBPDPAGBGJG AHJAPMFANKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private HBPDPAGBGJG CMCECKFMJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private HBPDPAGBGJG BJFINHICNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> CANINAGDPJJ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KJAFHFHLOAF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string MGMFPFJAGPJ;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string KMKBBMAKFPJ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string HFCOBOHAKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string CGKBBFNGGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string CBLLEANHJMO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private OFEIPEOOHLH GDLCHPNBBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5D12340", Offset = "0x5D11740", VA = "0x185D12340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private EJKLLGBGNFI OCLBDBMCMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D120A0", Offset = "0x5D114A0", VA = "0x185D120A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int NJKLPKAABPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5D11330", Offset = "0x5D10730", VA = "0x185D11330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long DOKDMILPJEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5D16760", Offset = "0x5D15B60", VA = "0x185D16760")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5D16880", Offset = "0x5D15C80", VA = "0x185D16880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string HDCMBKOPPPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5D16700", Offset = "0x5D15B00", VA = "0x185D16700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string MHPEEEHDMBI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D16730", Offset = "0x5D15B30", VA = "0x185D16730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BKOAHBGOIPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x83B780", Offset = "0x83AB80", VA = "0x18083B780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83B760", Offset = "0x83AB60", VA = "0x18083B760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? BAMCHJIOBGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9641C0", Offset = "0x9635C0", VA = "0x1809641C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5D16870", Offset = "0x5D15C70", VA = "0x185D16870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AFNGLLLKOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xEBFCA0", Offset = "0xEBF0A0", VA = "0x180EBFCA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xEBF920", Offset = "0xEBED20", VA = "0x180EBF920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IBHADKDNNAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5D16600", Offset = "0x5D15A00", VA = "0x185D16600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> PJEFIHFHCGM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5D16540", Offset = "0x5D15940", VA = "0x185D16540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5D167B0", Offset = "0x5D15BB0", VA = "0x185D167B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D10D30", Offset = "0x5D10130", VA = "0x185D10D30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D11770", Offset = "0x5D10B70", VA = "0x185D11770")]
		private void EFIAECJNANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D15B20", Offset = "0x5D14F20", VA = "0x185D15B20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D14800", Offset = "0x5D13C00", VA = "0x185D14800", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D15EC0", Offset = "0x5D152C0", VA = "0x185D15EC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D14DC0", Offset = "0x5D141C0", VA = "0x185D14DC0")]
		public AIDJGFFPANM PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D12840", Offset = "0x5D11C40", VA = "0x185D12840")]
		[IteratorStateMachine(typeof(FMBNIMHAHDE))]
		public IEnumerator<EIIEDLICJGP> Initialize(AmplitudeAnalyticsEvent CDNMKAHCDOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D15E00", Offset = "0x5D15200", VA = "0x185D15E00")]
		public void UpdateLastKnownInteractionCategory(string EJHCLOBJDOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D15D10", Offset = "0x5D15110", VA = "0x185D15D10")]
		public void UpdateLastAliveTime(float EMIPGAHFJBJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D13930", Offset = "0x5D12D30", VA = "0x185D13930")]
		private AIDJGFFPANM LGEJIBDHOME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D148C0", Offset = "0x5D13CC0", VA = "0x185D148C0")]
		private AIDJGFFPANM PDPLHJLCDKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5D15570", Offset = "0x5D14970", VA = "0x185D15570")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D111A0", Offset = "0x5D105A0", VA = "0x185D111A0")]
		[IteratorStateMachine(typeof(PMCMAIECMLJ))]
		private IEnumerator BMKFFONKAAB(JOBBEGCJNAJ FEONHLBGBKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5D16150", Offset = "0x5D15550", VA = "0x185D16150")]
		[IteratorStateMachine(typeof(MILNBMOGBAP))]
		public IEnumerator WaitForFlush(float GBELJBLENFG = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D15BF0", Offset = "0x5D14FF0", VA = "0x185D15BF0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D15B30", Offset = "0x5D14F30", VA = "0x185D15B30")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime EMHCHPDFFJH)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5D123B0", Offset = "0x5D117B0", VA = "0x185D123B0")]
		public static DEHLCMMHPMJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D10BC0", Offset = "0x5D0FFC0", VA = "0x185D10BC0")]
		public static PMGJIJBLBBC AccountSelectionPostLoginEvent([NotNull] string ALKJCKODIGB, string BBDMLGPBHLI, bool FOFDLCMIILF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D11D10", Offset = "0x5D11110", VA = "0x185D11D10")]
		public static PMGJIJBLBBC Event([NotNull] string ALKJCKODIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D14E00", Offset = "0x5D14200", VA = "0x185D14E00")]
		public static PMGJIJBLBBC PreviousSessionEvent([NotNull] string ALKJCKODIGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D12560", Offset = "0x5D11960", VA = "0x185D12560")]
		public static PMGJIJBLBBC InitializeEvent(string BBDMLGPBHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D15730", Offset = "0x5D14B30", VA = "0x185D15730")]
		public static PMGJIJBLBBC StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D11510", Offset = "0x5D10910", VA = "0x185D11510")]
		public static PMGJIJBLBBC CreateOutOfSessionEvent(string ALKJCKODIGB, bool INIBFCMJJCD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D13E50", Offset = "0x5D13250", VA = "0x185D13E50")]
		public static AIDJGFFPANM LogOutOfSessionEvent(PMGJIJBLBBC AGPKJDKENOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D13BD0", Offset = "0x5D12FD0", VA = "0x185D13BD0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent HIBEBGOPCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D14140", Offset = "0x5D13540", VA = "0x185D14140")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent HIBEBGOPCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D14280", Offset = "0x5D13680", VA = "0x185D14280")]
		public void LogSerializedEventAsync(Dictionary<string, object> FDCGEPPCANN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5D13D10", Offset = "0x5D13110", VA = "0x185D13D10")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BPFMMAEDELD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D14CC0", Offset = "0x5D140C0", VA = "0x185D14CC0")]
		private void PKBBKLGBJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D13630", Offset = "0x5D12A30", VA = "0x185D13630")]
		private void KGAIFELGBCG(Dictionary<string, object> EEBJMMELNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D120F0", Offset = "0x5D114F0", VA = "0x185D120F0")]
		private void GOLLDMAEKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D139F0", Offset = "0x5D12DF0", VA = "0x185D139F0")]
		private void LIPCMMPGHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D12010", Offset = "0x5D11410", VA = "0x185D12010")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D135A0", Offset = "0x5D129A0", VA = "0x185D135A0")]
		[IteratorStateMachine(typeof(DFIDJFEOIAA))]
		private IEnumerator<EIIEDLICJGP> JFOKCEHLMKL(float GBELJBLENFG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D14770", Offset = "0x5D13B70", VA = "0x185D14770")]
		[IteratorStateMachine(typeof(FELOALKCHMF))]
		private IEnumerator<EIIEDLICJGP> MLHGHEGEOFN(float GBELJBLENFG = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D11230", Offset = "0x5D10630", VA = "0x185D11230")]
		[IteratorStateMachine(typeof(POAJBPDDJJE))]
		private IEnumerator<EIIEDLICJGP> CIKBCDOIBJG(HBPDPAGBGJG MNODIPHKNIL, int? OCHLNHFHAPL, string HELNEJJLMMO, string JCMBCAPGCHP, float GBELJBLENFG, Action<int> FAKHODLKAOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D14BB0", Offset = "0x5D13FB0", VA = "0x185D14BB0")]
		private static void PFIHCDOLFCF(bool GLMOLDDCDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D14640", Offset = "0x5D13A40", VA = "0x185D14640")]
		private CJNEKNCGBDK<FDMJODIOEID<Dictionary<string, object>>> MKJGBEOCPHF(string HELNEJJLMMO, string JCMBCAPGCHP, string KNAFAOACHHP, string FKLHAMNKAPK, Dictionary<string, object> EBDFAPJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D14360", Offset = "0x5D13760", VA = "0x185D14360")]
		private CJNEKNCGBDK<FDMJODIOEID<List<Dictionary<string, object>>>> MKJGBEOCPHF(string HELNEJJLMMO, string JCMBCAPGCHP, string KNAFAOACHHP, string FKLHAMNKAPK, List<Dictionary<string, object>> EBDFAPJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A9E0", Offset = "0x2B59DE0", VA = "0x182B5A9E0")]
		private CJNEKNCGBDK<FDMJODIOEID<T>> AKFNAAAHFFD<T>(string HELNEJJLMMO, string JCMBCAPGCHP, string FKLHAMNKAPK, T EBDFAPJCEAH, Dictionary<string, object> PMPINNHKLAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B5ACA0", Offset = "0x2B5A0A0", VA = "0x182B5ACA0")]
		private CJNEKNCGBDK<FDMJODIOEID<T>> CNOKPGIKOLF<T>(string HELNEJJLMMO, string JCMBCAPGCHP, string KNAFAOACHHP, T EBDFAPJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D138E0", Offset = "0x5D12CE0", VA = "0x185D138E0")]
		private bool KGEIMLBNMOM(float GDGJKFLFKCP, float GBELJBLENFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D128D0", Offset = "0x5D11CD0", VA = "0x185D128D0")]
		private Dictionary<string, object> JFICNALCGAC(string JCMBCAPGCHP, Dictionary<string, object> EBDFAPJCEAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D16240", Offset = "0x5D15640", VA = "0x185D16240")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5D121E0", Offset = "0x5D115E0", VA = "0x185D121E0")]
		[CompilerGenerated]
		private long HDECCBOMMIN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D13BC0", Offset = "0x5D12FC0", VA = "0x185D13BC0")]
		[CompilerGenerated]
		private void LJKPCFNENOC(int BEOOFLDAINO)
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
			[Cpp2IlInjected.Address(RVA = "0x5D175E0", Offset = "0x5D169E0", VA = "0x185D175E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5D176C0", Offset = "0x5D16AC0", VA = "0x185D176C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5D17620", Offset = "0x5D16A20", VA = "0x185D17620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5D17720", Offset = "0x5D16B20", VA = "0x185D17720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5D175A0", Offset = "0x5D169A0", VA = "0x185D175A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5D17660", Offset = "0x5D16A60", VA = "0x185D17660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7782C0", Offset = "0x7776C0", VA = "0x1807782C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D16F90", Offset = "0x5D16390", VA = "0x185D16F90")]
		public static PMGJIJBLBBC EBILOFOJHAE(string AJLAIKHEKDH, [NotNull] string BHIGMNFNCGN, long HEPDKOJDNHJ, long LOEHHJCGMHE, string BBDMLGPBHLI, bool FOFDLCMIILF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D171A0", Offset = "0x5D165A0", VA = "0x185D171A0")]
		public static PMGJIJBLBBC LDEDGEOEHCL(string AJLAIKHEKDH, [NotNull] string BHIGMNFNCGN, long HEPDKOJDNHJ, long LOEHHJCGMHE, string BBDMLGPBHLI, long INPDHIDFINP, bool FOFDLCMIILF, string DOGOEEKGKBI, string DFOONADJEDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D17410", Offset = "0x5D16810", VA = "0x185D17410")]
		private AmplitudeAnalyticsEvent(string AJLAIKHEKDH, [NotNull] string BHIGMNFNCGN, long HEPDKOJDNHJ, long LOEHHJCGMHE, string BBDMLGPBHLI, bool FOFDLCMIILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1951F40", Offset = "0x1951340", VA = "0x181951F40")]
		public void MEJODPPCLJO(long HJKDENDHNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D17090", Offset = "0x5D16490", VA = "0x185D17090", Slot = "5")]
		public override void KOMBEKLPFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D168E0", Offset = "0x5D15CE0", VA = "0x185D168E0", Slot = "6")]
		public override void CGLHLBMHIKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D16A60", Offset = "0x5D15E60", VA = "0x185D16A60", Slot = "4")]
		protected override Dictionary<string, object> CONLCDDBPJC(Dictionary<string, object> FIKMEGKDGND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D17300", Offset = "0x5D16700", VA = "0x185D17300")]
		private void MKBLIIDJDIB(string MIMFBLPNKOG, string NMENOOMOOJP, bool CHKNMOJMDKL = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5D18880", Offset = "0x5D17C80", VA = "0x185D18880")]
			public void FIDBMJOFIAD(Dictionary<string, object> DALJINPFHKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
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
			[Cpp2IlInjected.Address(RVA = "0x5D20C20", Offset = "0x5D20020", VA = "0x185D20C20")]
			public void FIDBMJOFIAD(Dictionary<string, object> OKAHNKMNMKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x872200", Offset = "0x871600", VA = "0x180872200")]
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
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D17B50", Offset = "0x5D16F50", VA = "0x185D17B50")]
		public static DEHLCMMHPMJ EBILOFOJHAE(string AJLAIKHEKDH, string BBDMLGPBHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D17E40", Offset = "0x5D17240", VA = "0x185D17E40")]
		protected AmplitudeAnalyticsIdentifyMessage(string AJLAIKHEKDH, string BBDMLGPBHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5D17C80", Offset = "0x5D17080", VA = "0x185D17C80")]
		public Dictionary<string, object> JANPOBNBLCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D17810", Offset = "0x5D16C10", VA = "0x185D17810", Slot = "4")]
		protected virtual Dictionary<string, object> CONLCDDBPJC(Dictionary<string, object> FIKMEGKDGND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D17DA0", Offset = "0x5D171A0", VA = "0x185D17DA0")]
		protected void NELEICKNKAD(string MIMFBLPNKOG, Dictionary<string, object> AAKJGBHMJLJ, Dictionary<string, object> NPKDGEFPDNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D17C10", Offset = "0x5D17010", VA = "0x185D17C10")]
		protected void ENCIMLFNLAM(string MIMFBLPNKOG, string NMENOOMOOJP, Dictionary<string, object> JLKNCAIDBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D17D10", Offset = "0x5D17110", VA = "0x185D17D10", Slot = "5")]
		public virtual void KOMBEKLPFJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D17780", Offset = "0x5D16B80", VA = "0x185D17780", Slot = "6")]
		public virtual void CGLHLBMHIKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DEHLCMMHPMJ : AADFMDPNIKI<AmplitudeAnalyticsIdentifyMessage, DEHLCMMHPMJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override DEHLCMMHPMJ KAFNJHGBNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage ONNFMCJCFFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D18560", Offset = "0x5D17960", VA = "0x185D18560")]
	public DEHLCMMHPMJ(AmplitudeAnalyticsIdentifyMessage KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D184B0", Offset = "0x5D178B0", VA = "0x185D184B0", Slot = "4")]
	public override void CGLHLBMHIKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PMGJIJBLBBC : AADFMDPNIKI<AmplitudeAnalyticsEvent, PMGJIJBLBBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool DAEGEOAJOFE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override PMGJIJBLBBC KAFNJHGBNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x848F60", Offset = "0x848360", VA = "0x180848F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JLCBHKNGCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CA87E0", Offset = "0x1CA7BE0", VA = "0x181CA87E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D180B0", Offset = "0x5D174B0", VA = "0x185D180B0")]
	public PMGJIJBLBBC(AmplitudeAnalyticsEvent KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0", Slot = "5")]
	public override AmplitudeAnalyticsEvent ONNFMCJCFFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5D20110", Offset = "0x5D1F510", VA = "0x185D20110", Slot = "4")]
	public override void CGLHLBMHIKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2670CC0", Offset = "0x26700C0", VA = "0x182670CC0")]
	public PMGJIJBLBBC AGNFLBDFMIE<T>(string PGPOOACGDAP, T[] NMENOOMOOJP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2670CC0", Offset = "0x26700C0", VA = "0x182670CC0")]
	public PMGJIJBLBBC AGNFLBDFMIE(string PGPOOACGDAP, string[] NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2670A10", Offset = "0x266FE10", VA = "0x182670A10")]
	public PMGJIJBLBBC AGNFLBDFMIE<T>(string PGPOOACGDAP, T NMENOOMOOJP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D20020", Offset = "0x5D1F420", VA = "0x185D20020")]
	public PMGJIJBLBBC AGNFLBDFMIE(string PGPOOACGDAP, long NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D200A0", Offset = "0x5D1F4A0", VA = "0x185D200A0")]
	public PMGJIJBLBBC AGNFLBDFMIE(string PGPOOACGDAP, string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D202B0", Offset = "0x5D1F6B0", VA = "0x185D202B0")]
	public PMGJIJBLBBC ICHFOHDCMIH(string PGPOOACGDAP, object? NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D202E0", Offset = "0x5D1F6E0", VA = "0x185D202E0")]
	public PMGJIJBLBBC IENGMINBDOB(string PGPOOACGDAP, string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D201B0", Offset = "0x5D1F5B0", VA = "0x185D201B0")]
	private PMGJIJBLBBC DCEDNHADLKD(string PGPOOACGDAP, object NMENOOMOOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BEGIHPBDLNL : PMGJIJBLBBC
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D180B0", Offset = "0x5D174B0", VA = "0x185D180B0")]
	public BEGIHPBDLNL(AmplitudeAnalyticsEvent KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D17F00", Offset = "0x5D17300", VA = "0x185D17F00", Slot = "4")]
	public override void CGLHLBMHIKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class AADFMDPNIKI<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : AADFMDPNIKI<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M KCFFPPIEBHH;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR KAFNJHGBNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
	public AADFMDPNIKI(M KCFFPPIEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34DF7B0", Offset = "0x34DEBB0", VA = "0x1834DF7B0")]
	public BLDR CMAHGKIJGII(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FCIAMALJMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x34DF930", Offset = "0x34DED30", VA = "0x1834DF930")]
	public BLDR KOHIALGJFJN(AmplitudeAnalyticsIdentifyMessage.RevenueData MKHEDEGKIAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34DF980", Offset = "0x34DED80", VA = "0x1834DF980")]
	public BLDR LFDOOHJFHNJ(string PGPOOACGDAP, string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x20DE510", Offset = "0x20DD910", VA = "0x1820DE510")]
	public BLDR LFDOOHJFHNJ<T>(string PGPOOACGDAP, T NMENOOMOOJP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CGLHLBMHIKH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x34DF900", Offset = "0x34DED00", VA = "0x1834DF900")]
	internal static string KHCDALEBMPN(string NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x34DF800", Offset = "0x34DEC00", VA = "0x1834DF800")]
	private BLDR IAAKJOONOOP(string PGPOOACGDAP, object NMENOOMOOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M ONNFMCJCFFK();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class BMLABONIGHC : KAPEGCOLHPL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GBHJHOECKFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<DLCACNHLAPE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public BMLABONIGHC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D19560", Offset = "0x5D18960", VA = "0x185D19560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E00", Offset = "0x5D19200", VA = "0x185D19E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct NMEEOFAAACJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<DLCACNHLAPE> <>t__builder;

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
		public BMLABONIGHC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5D1EE80", Offset = "0x5D1E280", VA = "0x185D1EE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F8B0", Offset = "0x5D1ECB0", VA = "0x185D1F8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient MIPNAAOCEHG;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D18270", Offset = "0x5D17670", VA = "0x185D18270")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void ILCHAIAJIID(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D18430", Offset = "0x5D17830", VA = "0x185D18430")]
	[RecRoom.NoEngine.Common.Preserve]
	public BMLABONIGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D182E0", Offset = "0x5D176E0", VA = "0x185D182E0", Slot = "4")]
	[AsyncStateMachine(typeof(GBHJHOECKFK))]
	public Task<DLCACNHLAPE> MKJGBEOCPHF(string HELNEJJLMMO, Dictionary<string, string> GNINGEDBFBM, bool PBBIEDHPDKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D18100", Offset = "0x5D17500", VA = "0x185D18100", Slot = "5")]
	[AsyncStateMachine(typeof(NMEEOFAAACJ))]
	public Task<DLCACNHLAPE> HCEOCLJJHJD(string HELNEJJLMMO, string IBOJDMJOFKA, string IMABIIJDGMN, string LEOLPLPEBBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NDCEJNBMBAB
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> MIMGALBJIFJ;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ECD0", Offset = "0x5D1E0D0", VA = "0x185D1ECD0")]
	internal static bool DCLHPLADAFG(string MIMFBLPNKOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KAPEGCOLHPL
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DLCACNHLAPE> MKJGBEOCPHF(string HELNEJJLMMO, Dictionary<string, string> GNINGEDBFBM, bool PBBIEDHPDKH = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DLCACNHLAPE> HCEOCLJJHJD(string HELNEJJLMMO, string IBOJDMJOFKA, string IMABIIJDGMN, string LEOLPLPEBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DLCACNHLAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int AJJNHLMCKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string KDKLEGGMPJJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB65D40", Offset = "0xB65140", VA = "0x180B65D40")]
	public DLCACNHLAPE(int LOFNOOFBCDM, string BJGHHEIMGGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum LGMBHCLHMIF
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
public class OCHJJINDDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long FBJFPMMKEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private PMGJIJBLBBC ECPMEGNDLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool EOCBLPNAHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LEMOLEBOFBD;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FD30", Offset = "0x5D1F130", VA = "0x185D1FD30")]
	public OCHJJINDDOB(string HKPBDMMDAID, float LEMOLEBOFBD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2653320", Offset = "0x2652720", VA = "0x182653320")]
	public void AGNFLBDFMIE<T>(string PGPOOACGDAP, T NMENOOMOOJP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F9A0", Offset = "0x5D1EDA0", VA = "0x185D1F9A0")]
	public void AGNFLBDFMIE(string PGPOOACGDAP, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FC40", Offset = "0x5D1F040", VA = "0x185D1FC40")]
	public void OOCEGBEOOPJ(string HBIJODGIGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FA20", Offset = "0x5D1EE20", VA = "0x185D1FA20")]
	public void AMLIIAMOCOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FB30", Offset = "0x5D1EF30", VA = "0x185D1FB30")]
	private void KKKDMLCGGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FAE0", Offset = "0x5D1EEE0", VA = "0x185D1FAE0")]
	private bool DCANCOKKMAI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EKLGCGNBGGK
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string BKOAHBGOIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	NILPJFJFJGL LMPBHGILKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IGAAEBOKIID;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NCKJLGHIBEA;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIDJGFFPANM GJHPIDDJMKM(string HAPFCGINOEC, string FNDDKNHNGIC, [Optional] FLKPKEOPDKC HFKPLAJAIIK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIDJGFFPANM MHLMKPKBBAK(FLKPKEOPDKC HFKPLAJAIIK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AIDJGFFPANM NIAADIFNIKM(FLKPKEOPDKC HFKPLAJAIIK, Dictionary<string, string> DHNJJMNLJLD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EDDNCFCCKLD(string OIJMBIOBOHJ);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DNENAFPHOAO KNEKCGMJMBG(string PEIPHDMPMCC);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FCJCPAJKBPI AAGLODKKJEJ(string BELGGGNDFEH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AIDJGFFPANM ECEOCBLDGMJ();
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
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D20D90", Offset = "0x5D20190", VA = "0x185D20D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KFOADPFOIAO : EKLGCGNBGGK
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, CAKJLKAOBEE> MFADPKECEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool FNLKDILOPOJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5050", Offset = "0x7C4450", VA = "0x1807C5050", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string BKOAHBGOIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C300", Offset = "0x5D1B700", VA = "0x185D1C300", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NILPJFJFJGL LMPBHGILKEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BD60", Offset = "0x5D1B160", VA = "0x185D1BD60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action IGAAEBOKIID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B930", Offset = "0x5D1AD30", VA = "0x185D1B930", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B890", Offset = "0x5D1AC90", VA = "0x185D1B890", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action NCKJLGHIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C1E0", Offset = "0x5D1B5E0", VA = "0x185D1C1E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CCF0", Offset = "0x5D1C0F0", VA = "0x185D1CCF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BD70", Offset = "0x5D1B170", VA = "0x185D1BD70", Slot = "8")]
	public AIDJGFFPANM GJHPIDDJMKM(string HAPFCGINOEC, string FNDDKNHNGIC, [Optional] FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B9D0", Offset = "0x5D1ADD0", VA = "0x185D1B9D0", Slot = "17")]
	public AIDJGFFPANM ECEOCBLDGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CD90", Offset = "0x5D1C190", VA = "0x185D1CD90", Slot = "12")]
	public AIDJGFFPANM MHLMKPKBBAK(FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CF80", Offset = "0x5D1C380", VA = "0x185D1CF80", Slot = "13")]
	public AIDJGFFPANM NIAADIFNIKM(FLKPKEOPDKC HFKPLAJAIIK, Dictionary<string, string> DHNJJMNLJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB20", Offset = "0x5D1AF20", VA = "0x185D1BB20", Slot = "14")]
	public bool EDDNCFCCKLD(string OIJMBIOBOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C9E0", Offset = "0x5D1BDE0", VA = "0x185D1C9E0", Slot = "15")]
	public DNENAFPHOAO KNEKCGMJMBG(string PEIPHDMPMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B800", Offset = "0x5D1AC00", VA = "0x185D1B800", Slot = "16")]
	public FCJCPAJKBPI AAGLODKKJEJ(string BELGGGNDFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C310", Offset = "0x5D1B710", VA = "0x185D1C310")]
	private NILPJFJFJGL JFFHBPOCFDM(FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BBB0", Offset = "0x5D1AFB0", VA = "0x185D1BBB0")]
	private JKJPNIHMNBK GDOGNIGCFML(string FNDDKNHNGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CBE0", Offset = "0x5D1BFE0", VA = "0x185D1CBE0")]
	private void LBKFBGBBIAH(string PEIPHDMPMCC, DNENAFPHOAO GJAKJAKGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	public KFOADPFOIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA7A0D0", Offset = "0xA794D0", VA = "0x180A7A0D0")]
	[CompilerGenerated]
	private void FKFDKOBDODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D250", Offset = "0x5D1C650", VA = "0x185D1D250")]
	[CompilerGenerated]
	private void PCOLJLAFKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C280", Offset = "0x5D1B680", VA = "0x185D1C280")]
	[CompilerGenerated]
	private void IOCKBAGGLKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KOAKPAMDPLE : EKLGCGNBGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EKLGCGNBGGK BBIMJDAPJHG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private EKLGCGNBGGK NPDNHPEDODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DE90", Offset = "0x5D1D290", VA = "0x185D1DE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D590", Offset = "0x5D1C990", VA = "0x185D1D590", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string BKOAHBGOIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DF00", Offset = "0x5D1D300", VA = "0x185D1DF00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public NILPJFJFJGL LMPBHGILKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D8E0", Offset = "0x5D1CCE0", VA = "0x185D1D8E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IGAAEBOKIID
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D680", Offset = "0x5D1CA80", VA = "0x185D1D680", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D5E0", Offset = "0x5D1C9E0", VA = "0x185D1D5E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action NCKJLGHIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DDF0", Offset = "0x5D1D1F0", VA = "0x185D1DDF0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E060", Offset = "0x5D1D460", VA = "0x185D1E060", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[UnityEngine.Scripting.Preserve]
	public KOAKPAMDPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E330", Offset = "0x5D1D730", VA = "0x185D1E330")]
	[JMGGEKJCAGA(PLCOHLLKCIG.GameOnly)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D520", Offset = "0x5D1C920", VA = "0x185D1D520")]
	[JMGGEKJCAGA(PLCOHLLKCIG.EditorOnly)]
	private static void AKIEGBPLBBN(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D9A0", Offset = "0x5D1CDA0", VA = "0x185D1D9A0", Slot = "8")]
	public AIDJGFFPANM GJHPIDDJMKM(string HAPFCGINOEC, string FNDDKNHNGIC, [Optional] FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E100", Offset = "0x5D1D500", VA = "0x185D1E100", Slot = "12")]
	public AIDJGFFPANM MHLMKPKBBAK(FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E210", Offset = "0x5D1D610", VA = "0x185D1E210", Slot = "13")]
	public AIDJGFFPANM NIAADIFNIKM(FLKPKEOPDKC HFKPLAJAIIK, Dictionary<string, string> DHNJJMNLJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D830", Offset = "0x5D1CC30", VA = "0x185D1D830", Slot = "14")]
	public bool EDDNCFCCKLD(string OIJMBIOBOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DF50", Offset = "0x5D1D350", VA = "0x185D1DF50", Slot = "15")]
	public DNENAFPHOAO KNEKCGMJMBG(string PEIPHDMPMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D410", Offset = "0x5D1C810", VA = "0x185D1D410", Slot = "16")]
	public FCJCPAJKBPI AAGLODKKJEJ(string BELGGGNDFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D720", Offset = "0x5D1CB20", VA = "0x185D1D720", Slot = "17")]
	public AIDJGFFPANM ECEOCBLDGMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF010", Offset = "0x7BE410", VA = "0x1807BF010")]
	[CompilerGenerated]
	private void MHEDMHPCEDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB5B320", Offset = "0xB5A720", VA = "0x180B5B320")]
	[CompilerGenerated]
	private void MHMJHPIGJDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IOMIEGMFJLM : EKLGCGNBGGK
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BKOAHBGOIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NILPJFJFJGL LMPBHGILKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action IGAAEBOKIID
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B3D0", Offset = "0x5D1A7D0", VA = "0x185D1B3D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B330", Offset = "0x5D1A730", VA = "0x185D1B330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action NCKJLGHIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B590", Offset = "0x5D1A990", VA = "0x185D1B590", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B640", Offset = "0x5D1AA40", VA = "0x185D1B640", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOMIEGMFJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B500", Offset = "0x5D1A900", VA = "0x185D1B500", Slot = "8")]
	public AIDJGFFPANM GJHPIDDJMKM(string HAPFCGINOEC, string FNDDKNHNGIC, [Optional] FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B6E0", Offset = "0x5D1AAE0", VA = "0x185D1B6E0", Slot = "12")]
	public AIDJGFFPANM MHLMKPKBBAK(FLKPKEOPDKC HFKPLAJAIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B770", Offset = "0x5D1AB70", VA = "0x185D1B770", Slot = "13")]
	public AIDJGFFPANM NIAADIFNIKM(FLKPKEOPDKC HFKPLAJAIIK, Dictionary<string, string> DHNJJMNLJLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "14")]
	public bool EDDNCFCCKLD(string OIJMBIOBOHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B630", Offset = "0x5D1AA30", VA = "0x185D1B630", Slot = "15")]
	public DNENAFPHOAO KNEKCGMJMBG(string PEIPHDMPMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B320", Offset = "0x5D1A720", VA = "0x185D1B320", Slot = "16")]
	public FCJCPAJKBPI AAGLODKKJEJ(string BELGGGNDFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B470", Offset = "0x5D1A870", VA = "0x185D1B470", Slot = "17")]
	public AIDJGFFPANM ECEOCBLDGMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PIJEDBGEPIL
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCHJJINDDOB EHJMPPFJHGA(string HKPBDMMDAID);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GKPOCEODCIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long NEEBDOGENEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string AMJPNOLCHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MHBEKGLHEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string HMHNCLPMKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string HLNHJIPPCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool NBHMDMFKKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long AFKPAMCFGCM();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIAGJKGHJNN(long HEPDKOJDNHJ, bool CHKNMOJMDKL = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void APFALINEGAN(string LAACBMJOJOJ, string OPMHECAECEO, string NFAILKNPIOM);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JDLPJIMHPHL(string LAACBMJOJOJ);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DPKGMPNHHAB(string LAACBMJOJOJ, string FFNMCPLIAJJ, string PJHHGPOEECM);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LGDAHPKOKIL(string FHAMCMGIGDF, object AKOMNFHJLEP, object OIICLKCAPFD);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface FLKPKEOPDKC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool PIMAMHCHJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool JCIDAHJFBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BPKHILKMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? CAAMNEDAEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? BAMCHJIOBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int BLKNKJFIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string LMJCADKAKOD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string KHKDEPFACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string EMLOEPKAILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long MGOEEPOAPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string MAONOHEBNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string MIGPPCFPNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string NCKPNNGNKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string HHPAHIIDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double ADHPEIKHKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int DFMAHKABIDK
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
