using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x75D57B0", Offset = "0x75D4BB0", VA = "0x1875D57B0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75D49A0", Offset = "0x75D3DA0", VA = "0x1875D49A0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75D75A0", Offset = "0x75D69A0", VA = "0x1875D75A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AmplitudeAnalytics
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
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
		public AmplitudeAnalyticsClient.Settings EKKJCGKAHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HGHEOJHPLIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, OKEGJBDPDCK
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum MMJOJJFEJBK
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class OACNFFFFOAG
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class IMNKJEOIPKI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int JJKKKADPBJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> HDJJCOGKEIN;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
				public IMNKJEOIPKI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class HIIILODCMBH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
				public HIIILODCMBH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x75CF810", Offset = "0x75CEC10", VA = "0x1875CF810")]
				internal bool ICKJNNBLJGF(IMNKJEOIPKI item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string FEIKGEEEJKD = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string PMILCDIBAOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<IMNKJEOIPKI> LGLPGFFDABL;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? BDOEDEPAGKH
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x75D59E0", Offset = "0x75D4DE0", VA = "0x1875D59E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x75D6A80", Offset = "0x75D5E80", VA = "0x1875D6A80")]
			internal OACNFFFFOAG(string LGJKKBJPPAE, string CKKLMPKPEOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x75D5830", Offset = "0x75D4C30", VA = "0x1875D5830")]
			public int BOAKDPGIGGO([Optional] int? KHHAFGIBLAJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x75D5F30", Offset = "0x75D5330", VA = "0x1875D5F30")]
			public List<Dictionary<string, object>> IDJIFHAALDM(int KGHAPMKIGGO, int? KHHAFGIBLAJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75D5C80", Offset = "0x75D5080", VA = "0x1875D5C80")]
			public void GFJBODHECDG(AmplitudeAnalyticsIdentifyMessage HAPOBHMBDHP, bool IMLGLHAODHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x75D5D20", Offset = "0x75D5120", VA = "0x1875D5D20")]
			public void GFJBODHECDG(Dictionary<string, object> HAPOBHMBDHP, bool IMLGLHAODHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x75D6900", Offset = "0x75D5D00", VA = "0x1875D6900")]
			public void OELFKMBMBJL(params Dictionary<string, object>[] LJEBHBDOMPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x75D62C0", Offset = "0x75D56C0", VA = "0x1875D62C0")]
			public void LPJIJHPEGOK(List<Dictionary<string, object>> JNNGDEINAAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75D5E30", Offset = "0x75D5230", VA = "0x1875D5E30")]
			private void HFKILIEFPNE(Dictionary<string, object> HAPOBHMBDHP, bool IMLGLHAODHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x75D5A80", Offset = "0x75D4E80", VA = "0x1875D5A80")]
			public void GCNKNKFIEPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x75D6500", Offset = "0x75D5900", VA = "0x1875D6500")]
			private void NDLEEHMKJNA([Optional] string ICGGHMAANDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x75D61A0", Offset = "0x75D55A0", VA = "0x1875D61A0")]
			private static string JDLFAGKEMJG(string FIIKLGCIAGG, string MCBJECJLDOM)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x75D71C0", Offset = "0x75D65C0", VA = "0x1875D71C0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct BPICMGAGELP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int KOOFGGOMEMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string KEBJDJACAOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T ICHGIGDOGEB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AGOPJLBBIDM : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public AGOPJLBBIDM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x75C3DF0", Offset = "0x75C31F0", VA = "0x1875C3DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x75C4580", Offset = "0x75C3980", VA = "0x1875C4580", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class NKBPFNPEFCD : IEnumerator<object>, IEnumerator, IDisposable
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
			public HBLFBFLDLLK quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public NKBPFNPEFCD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x75D4C70", Offset = "0x75D4070", VA = "0x1875D4C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x75D4D80", Offset = "0x75D4180", VA = "0x1875D4D80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class LBGLIIOHKBD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public LBGLIIOHKBD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x75D47E0", Offset = "0x75D3BE0", VA = "0x1875D47E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x75D4950", Offset = "0x75D3D50", VA = "0x1875D4950", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class AMILNFGBLJN : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public AMILNFGBLJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x75C5110", Offset = "0x75C4510", VA = "0x1875C5110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x75C5370", Offset = "0x75C4770", VA = "0x1875C5370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JDIGBFEIINC : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public JDIGBFEIINC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x75D30D0", Offset = "0x75D24D0", VA = "0x1875D30D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x75D3320", Offset = "0x75D2720", VA = "0x1875D3320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CFGPGKBCKPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public OACNFFFFOAG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public CFGPGKBCKPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x75CD780", Offset = "0x75CCB80", VA = "0x1875CD780")]
			internal void PHOPBPPAHOH(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x75CD330", Offset = "0x75CC730", VA = "0x1875CD330")]
			internal void CJEONINGLCL(BPICMGAGELP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class BDEFNJCNIIJ : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public OACNFFFFOAG cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public float timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private CFGPGKBCKPG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int? earlierThanFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private float <startTime>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private bool <timedOut>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private int <batchSize>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public BDEFNJCNIIJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x75CC8E0", Offset = "0x75CBCE0", VA = "0x1875CC8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x75CD0F0", Offset = "0x75CC4F0", VA = "0x1875CD0F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LPINKGCHNAL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public LPINKGCHNAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4D984B0", Offset = "0x4D978B0", VA = "0x184D984B0")]
			internal BPICMGAGELP<T> OLDHMKMFDIP(MOHDDJLMGGP postResponse)
			{
				return default(BPICMGAGELP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MDABFMCKPEE KOFELCLOADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<APKKGIEKJPO> ICBNCEPMNFL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string CCBPKOOLILD = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string OINCJPNMDMH = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DGJADPEINPB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int MEIEILPFPEG = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int IPCDEOHDNIP = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int JOMACFDPAMC = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float OGDPOEMBLCO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long BOFDJLJLHJH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KMNPBGONDLI = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string KKNMMIOLGNI = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string MANDOPIMOGA = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string EBDGBOBHNJE = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool AGBCADJFPDF;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool IDJGOEBNBMO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int FFBDEEPJFEN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int MGHLJJFMDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PFPNAHGNJNK AFHDEAPJMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DFOGPGCEFIE HDOKEJHCDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private BGFKOEMHHCL DMIKFAKPHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CCHMNAMOLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float KHPKHLAJHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float OPNILKKHJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int AJLBGOFBFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int OMLJNIIEPGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? PCLEGDHKCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? KNNHLEACACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long GCNHIALFPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string GEELPHFHIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string INBBBIBJOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GOHMIJAPKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string ILNOBPIHCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string IKFPHINDMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> FIGHHBLJNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private MMJOJJFEJBK LCNHGAICEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int MCCNLABGBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BPDHFAGOEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float DGNNPGNDENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool JIHFJBNKCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool LGBONENCHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OACNFFFFOAG MNICLIOPICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private OACNFFFFOAG FPCFDJCDHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private OACNFFFFOAG HGCOEOCGNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string COBFLNOMIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JBHGKKGDJCL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo ABMNPHOKMDK;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string PPKOMBMMANP;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string EDLCEDIFIOC = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string KFLHNJCOLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string AAJJNDBCAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string PBDCIEEFKFA;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MDABFMCKPEE AGBIEGPLCLP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x75C66D0", Offset = "0x75C5AD0", VA = "0x1875C66D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private APKKGIEKJPO GLKPMGHONCF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x75C6380", Offset = "0x75C5780", VA = "0x1875C6380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int AAFOLOEJPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x75C6DB0", Offset = "0x75C61B0", VA = "0x1875C6DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long OPBONGIDOAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x75CB210", Offset = "0x75CA610", VA = "0x1875CB210")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x75CB320", Offset = "0x75CA720", VA = "0x1875CB320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string IAJBAOAEPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x75CB1E0", Offset = "0x75CA5E0", VA = "0x1875CB1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OENONAGGDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1326120", Offset = "0x1325520", VA = "0x181326120", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1324190", Offset = "0x1323590", VA = "0x181324190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NJJDJMDMHIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9FDCC0", Offset = "0x9FD0C0", VA = "0x1809FDCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA034D0", Offset = "0xA028D0", VA = "0x180A034D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? NGNDALAADPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA18B50", Offset = "0xA17F50", VA = "0x180A18B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAF5DD0", Offset = "0xAF51D0", VA = "0x180AF5DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NDHFJLNCNJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xD38190", Offset = "0xD37590", VA = "0x180D38190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x11FA860", Offset = "0x11F9C60", VA = "0x1811FA860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool HODGBDMNOKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x75CB0C0", Offset = "0x75CA4C0", VA = "0x1875CB0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> EONBBBBAHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x75CB000", Offset = "0x75CA400", VA = "0x1875CB000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x75CB260", Offset = "0x75CA660", VA = "0x1875CB260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75C5850", Offset = "0x75C4C50", VA = "0x1875C5850", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x75C6880", Offset = "0x75C5C80", VA = "0x1875C6880")]
		private void HDDPNKCECGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x75CA640", Offset = "0x75C9A40", VA = "0x1875CA640")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75C9300", Offset = "0x75C8700", VA = "0x1875C9300", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75CA970", Offset = "0x75C9D70", VA = "0x1875CA970")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75C93C0", Offset = "0x75C87C0", VA = "0x1875C93C0")]
		public KMDOHMPCNFD PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75C8250", Offset = "0x75C7650", VA = "0x1875C8250")]
		[IteratorStateMachine(typeof(AGOPJLBBIDM))]
		public IEnumerator<OAGIBKDGOAG> InitializeForLocalAccount(AmplitudeAnalyticsEvent JIPCHGPIFJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75C9D20", Offset = "0x75C9120", VA = "0x1875C9D20")]
		public void SendAppEnterEvent(bool BOKFKMGIMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75CA8F0", Offset = "0x75C9CF0", VA = "0x1875CA8F0")]
		public void UpdateLastKnownInteractionCategory(string GPCNFDHOEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x75CA840", Offset = "0x75C9C40", VA = "0x1875CA840")]
		public void UpdateLastAliveTime(float NFEBFCGCNJF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75C82E0", Offset = "0x75C76E0", VA = "0x1875C82E0")]
		private KMDOHMPCNFD JHGBBPEJEIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x75C6C40", Offset = "0x75C6040", VA = "0x1875C6C40")]
		private KMDOHMPCNFD HPEMDKOELAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75CA030", Offset = "0x75C9430", VA = "0x1875CA030")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75C67F0", Offset = "0x75C5BF0", VA = "0x1875C67F0")]
		[IteratorStateMachine(typeof(NKBPFNPEFCD))]
		private IEnumerator GIPNJHMNCPC(HBLFBFLDLLK LNIONJLEILP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75CAC00", Offset = "0x75CA000", VA = "0x1875CAC00")]
		[IteratorStateMachine(typeof(LBGLIIOHKBD))]
		public IEnumerator WaitForFlush(float DHENFBPIIKD = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75CA720", Offset = "0x75C9B20", VA = "0x1875CA720")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75CA660", Offset = "0x75C9A60", VA = "0x1875CA660")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime AKIEJPDFOGK)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D60", Offset = "0x75C7160", VA = "0x1875C7D60")]
		public static ALNCOPOJODF Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75C56B0", Offset = "0x75C4AB0", VA = "0x1875C56B0")]
		public static IALBCJDBAAO AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string OCHBAPGBIIB, string ICHOMOMIDAH, PNCMDJGHGEJ FLHIKCJAECA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x75C63D0", Offset = "0x75C57D0", VA = "0x1875C63D0")]
		public static IALBCJDBAAO Event([JetBrains.Annotations.NotNull] string OCHBAPGBIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75C9550", Offset = "0x75C8950", VA = "0x1875C9550")]
		public static IALBCJDBAAO PreviousSessionEvent([JetBrains.Annotations.NotNull] string OCHBAPGBIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x75C7F00", Offset = "0x75C7300", VA = "0x1875C7F00")]
		public static IALBCJDBAAO InitializeEvent(string ICHOMOMIDAH, int DNEDNFCBIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x75CA230", Offset = "0x75C9630", VA = "0x1875CA230")]
		public static IALBCJDBAAO StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75C5EB0", Offset = "0x75C52B0", VA = "0x1875C5EB0")]
		public static IALBCJDBAAO CreateOutOfSessionEvent(string OCHBAPGBIIB, bool JNMOEGKBLOJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x75C85F0", Offset = "0x75C79F0", VA = "0x1875C85F0")]
		public static KMDOHMPCNFD LogOutOfSessionEvent(IALBCJDBAAO LHEMHJPEJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x75C8390", Offset = "0x75C7790", VA = "0x1875C8390")]
		public void LogEventAsync(AmplitudeAnalyticsEvent GBDKNGMACAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x75C87B0", Offset = "0x75C7BB0", VA = "0x1875C87B0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent GBDKNGMACAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75C88E0", Offset = "0x75C7CE0", VA = "0x1875C88E0")]
		public void LogSerializedEventAsync(Dictionary<string, object> CGAAFBDCDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x75C84C0", Offset = "0x75C78C0", VA = "0x1875C84C0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage OHGKGFMPDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75C6280", Offset = "0x75C5680", VA = "0x1875C6280")]
		private void DNHHIJJFALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x75C89C0", Offset = "0x75C7DC0", VA = "0x1875C89C0")]
		private void MENNCBGDCIG(Dictionary<string, object> FIEDJHDADEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75C8FC0", Offset = "0x75C83C0", VA = "0x1875C8FC0")]
		private void NLIIJAJMEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x75C53C0", Offset = "0x75C47C0", VA = "0x1875C53C0")]
		private void ABMNLFCGJEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75C6760", Offset = "0x75C5B60", VA = "0x1875C6760")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x75C5620", Offset = "0x75C4A20", VA = "0x1875C5620")]
		[IteratorStateMachine(typeof(AMILNFGBLJN))]
		private IEnumerator<OAGIBKDGOAG> APLJPOMNOFO(float DHENFBPIIKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75C5590", Offset = "0x75C4990", VA = "0x1875C5590")]
		[IteratorStateMachine(typeof(JDIGBFEIINC))]
		private IEnumerator<OAGIBKDGOAG> AEMJJNONECE(float DHENFBPIIKD = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75C9220", Offset = "0x75C8620", VA = "0x1875C9220")]
		[IteratorStateMachine(typeof(BDEFNJCNIIJ))]
		private IEnumerator<OAGIBKDGOAG> OGMPFIFAGHF(OACNFFFFOAG LPEBEIIGFNF, int? KHHAFGIBLAJ, string LJGMAIPABNB, float DHENFBPIIKD, Action<int> BCHBHIONPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75C6170", Offset = "0x75C5570", VA = "0x1875C6170")]
		private static void DBHGDOIEHNI(bool GKIBCMHKOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x75C8C80", Offset = "0x75C8080", VA = "0x1875C8C80")]
		private COLCOEKKCIF<BPICMGAGELP<Dictionary<string, object>>> MNDADIGFKGF(string LJGMAIPABNB, string LHIONGGCJDI, Dictionary<string, object> ICHGIGDOGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75C8D50", Offset = "0x75C8150", VA = "0x1875C8D50")]
		private COLCOEKKCIF<BPICMGAGELP<List<Dictionary<string, object>>>> MNDADIGFKGF(string LJGMAIPABNB, string LHIONGGCJDI, List<Dictionary<string, object>> ICHGIGDOGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3D9CB10", Offset = "0x3D9BF10", VA = "0x183D9CB10")]
		private COLCOEKKCIF<BPICMGAGELP<T>> LMCOALJMGBD<T>(string NPDDDIAOLAA, string LJGMAIPABNB, string LHIONGGCJDI, T ICHGIGDOGEB, Dictionary<string, object> ANIMNEFJKOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75C6FB0", Offset = "0x75C63B0", VA = "0x1875C6FB0")]
		private bool IEPKMKCBCMB(float DJIHPGNCNNB, float DHENFBPIIKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75C7000", Offset = "0x75C6400", VA = "0x1875C7000")]
		private Dictionary<string, object> IOKAKCJMEOM(string LJGMAIPABNB, Dictionary<string, object> ICHGIGDOGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75CACF0", Offset = "0x75CA0F0", VA = "0x1875CACF0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB30", Offset = "0x9BCF30", VA = "0x1809BDB30", Slot = "6")]
		private bool DBFPPDPFIPJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75C90B0", Offset = "0x75C84B0", VA = "0x1875C90B0")]
		[CompilerGenerated]
		private long OBDDDIHMLOG()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75C93B0", Offset = "0x75C87B0", VA = "0x1875C93B0")]
		[CompilerGenerated]
		private void PKJNJDKHJPA(int FCBIEIHMCLB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly string uuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly string eventType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly long sequenceNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly string assignedUserCrm;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal Dictionary<string, object> eventProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private long time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private long sessionId;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x75CC000", Offset = "0x75CB400", VA = "0x1875CC000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x75CC0D0", Offset = "0x75CB4D0", VA = "0x1875CC0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x75CC040", Offset = "0x75CB440", VA = "0x1875CC040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x75CC120", Offset = "0x75CB520", VA = "0x1875CC120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x75CBFC0", Offset = "0x75CB3C0", VA = "0x1875CBFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x75CC080", Offset = "0x75CB480", VA = "0x1875CC080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x993460", Offset = "0x992860", VA = "0x180993460")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75CB4E0", Offset = "0x75CA8E0", VA = "0x1875CB4E0")]
		public static IALBCJDBAAO DCJNBNANGBG(string DFDKLALNEIC, [JetBrains.Annotations.NotNull] string KBAABECKKLP, long HCKHGINLCBI, long GKKEEAOOOEA, string ICHOMOMIDAH, string FLHIKCJAECA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75CB380", Offset = "0x75CA780", VA = "0x1875CB380")]
		public static IALBCJDBAAO CLCHFOEPPEN(string DFDKLALNEIC, [JetBrains.Annotations.NotNull] string KBAABECKKLP, long HCKHGINLCBI, long GKKEEAOOOEA, string ICHOMOMIDAH, long EEILDBHDCDB, string EGEBDLKGGNA, string DAMECNCDLJJ, string MKIDCKJKLFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x75CBE20", Offset = "0x75CB220", VA = "0x1875CBE20")]
		private AmplitudeAnalyticsEvent(string DFDKLALNEIC, [JetBrains.Annotations.NotNull] string KBAABECKKLP, long HCKHGINLCBI, long GKKEEAOOOEA, string ICHOMOMIDAH, string FLHIKCJAECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xDA2A80", Offset = "0xDA1E80", VA = "0x180DA2A80")]
		public void ELEMHJOHNFC(long JNGCCGPGJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x75CBC10", Offset = "0x75CB010", VA = "0x1875CBC10", Slot = "5")]
		public override void MEFAAHLBLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75CB5E0", Offset = "0x75CA9E0", VA = "0x1875CB5E0", Slot = "6")]
		public override void KJCACHOOBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x75CB750", Offset = "0x75CAB50", VA = "0x1875CB750", Slot = "4")]
		protected override Dictionary<string, object> LLFOPCFDJLF(Dictionary<string, object> FDHJKMHAHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x75CBD10", Offset = "0x75CB110", VA = "0x1875CBD10")]
		private void NEHAHJHFGPD(string MCBJECJLDOM, string FIIKLGCIAGG, bool MKIKKFCEPII = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x75CE7A0", Offset = "0x75CDBA0", VA = "0x1875CE7A0")]
			public void IFCLJAMODCM(Dictionary<string, object> LBEHDMMDOIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x75D6E40", Offset = "0x75D6240", VA = "0x1875D6E40")]
			public void IFCLJAMODCM(Dictionary<string, object> HEBGFLLFMFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x11BEA50", Offset = "0x11BDE50", VA = "0x1811BEA50")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal DeviceInfo deviceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal RevenueData revenueData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly string buildVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly string language;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		internal Dictionary<string, object> userProperties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75CC170", Offset = "0x75CB570", VA = "0x1875CC170")]
		public static ALNCOPOJODF DCJNBNANGBG(string DFDKLALNEIC, string ICHOMOMIDAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x75CC820", Offset = "0x75CBC20", VA = "0x1875CC820")]
		protected AmplitudeAnalyticsIdentifyMessage(string DFDKLALNEIC, string ICHOMOMIDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75CC790", Offset = "0x75CBB90", VA = "0x1875CC790")]
		public Dictionary<string, object> NLBJDEGNPJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75CC320", Offset = "0x75CB720", VA = "0x1875CC320", Slot = "4")]
		protected virtual Dictionary<string, object> LLFOPCFDJLF(Dictionary<string, object> FDHJKMHAHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75CC660", Offset = "0x75CBA60", VA = "0x1875CC660")]
		protected void MCAPBBGFFDG(string MCBJECJLDOM, Dictionary<string, object> ALHGEHLPFGN, Dictionary<string, object> ANOLLBNFKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75CC230", Offset = "0x75CB630", VA = "0x1875CC230")]
		protected void HFNBGJBECAO(string MCBJECJLDOM, string FIIKLGCIAGG, Dictionary<string, object> DBEIPJIGMML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x75CC700", Offset = "0x75CBB00", VA = "0x1875CC700", Slot = "5")]
		public virtual void MEFAAHLBLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x75CC2A0", Offset = "0x75CB6A0", VA = "0x1875CC2A0", Slot = "6")]
		public virtual void KJCACHOOBFA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ALNCOPOJODF : DFNKJCGOGEI<AmplitudeAnalyticsIdentifyMessage, ALNCOPOJODF>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override ALNCOPOJODF AIOJCMLKLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage CCLKJNICOOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75C50C0", Offset = "0x75C44C0", VA = "0x1875C50C0")]
	public ALNCOPOJODF(AmplitudeAnalyticsIdentifyMessage EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x75C5020", Offset = "0x75C4420", VA = "0x1875C5020", Slot = "4")]
	public override void KJCACHOOBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IALBCJDBAAO : DFNKJCGOGEI<AmplitudeAnalyticsEvent, IALBCJDBAAO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool BHJNEJMPKMM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override IALBCJDBAAO AIOJCMLKLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long KAHGODEKOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75D1D90", Offset = "0x75D1190", VA = "0x1875D1D90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x75CD2E0", Offset = "0x75CC6E0", VA = "0x1875CD2E0")]
	public IALBCJDBAAO(AmplitudeAnalyticsEvent EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "5")]
	public override AmplitudeAnalyticsEvent CCLKJNICOOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x75D1CF0", Offset = "0x75D10F0", VA = "0x1875D1CF0", Slot = "4")]
	public override void KJCACHOOBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x364BD50", Offset = "0x364B150", VA = "0x18364BD50")]
	public IALBCJDBAAO ALENPICKODA<T>(string ODLMGDFMFJG, T[] FIIKLGCIAGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x364BD50", Offset = "0x364B150", VA = "0x18364BD50")]
	public IALBCJDBAAO ALENPICKODA(string ODLMGDFMFJG, string[] FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x364BAA0", Offset = "0x364AEA0", VA = "0x18364BAA0")]
	public IALBCJDBAAO ALENPICKODA<T>(string ODLMGDFMFJG, T FIIKLGCIAGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x75D1A60", Offset = "0x75D0E60", VA = "0x1875D1A60")]
	public IALBCJDBAAO ALENPICKODA(string ODLMGDFMFJG, long FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x75D1AE0", Offset = "0x75D0EE0", VA = "0x1875D1AE0")]
	public IALBCJDBAAO ALENPICKODA(string ODLMGDFMFJG, string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x75D1DB0", Offset = "0x75D11B0", VA = "0x1875D1DB0")]
	public IALBCJDBAAO PBOIJGCIFAM(string ODLMGDFMFJG, object? FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x75D1C50", Offset = "0x75D1050", VA = "0x1875D1C50")]
	public IALBCJDBAAO FCJDIELBPCO(string ODLMGDFMFJG, string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x75D1B50", Offset = "0x75D0F50", VA = "0x1875D1B50")]
	private IALBCJDBAAO EEJAPGIFFPN(string ODLMGDFMFJG, object FIIKLGCIAGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CDPJJPMLHKE : IALBCJDBAAO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x75CD2E0", Offset = "0x75CC6E0", VA = "0x1875CD2E0")]
	public CDPJJPMLHKE(AmplitudeAnalyticsEvent EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x75CD140", Offset = "0x75CC540", VA = "0x1875CD140", Slot = "4")]
	public override void KJCACHOOBFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class DFNKJCGOGEI<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : DFNKJCGOGEI<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M EIGJGBPHOMK;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR AIOJCMLKLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public DFNKJCGOGEI(M EIGJGBPHOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x65C4940", Offset = "0x65C3D40", VA = "0x1865C4940")]
	public BLDR OOFJLAKEGGO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo ONFCCEGLMFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x65C4720", Offset = "0x65C3B20", VA = "0x1865C4720")]
	public BLDR DICAHKBDBBC(AmplitudeAnalyticsIdentifyMessage.RevenueData JKLJCCDDNBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x65C48A0", Offset = "0x65C3CA0", VA = "0x1865C48A0")]
	public BLDR NLMEMNMFBKM(string ODLMGDFMFJG, string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x38E1B30", Offset = "0x38E0F30", VA = "0x1838E1B30")]
	public BLDR NLMEMNMFBKM<T>(string ODLMGDFMFJG, T FIIKLGCIAGG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void KJCACHOOBFA();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x65C4870", Offset = "0x65C3C70", VA = "0x1865C4870")]
	internal static string NLCGNMLGKCD(string FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x65C4770", Offset = "0x65C3B70", VA = "0x1865C4770")]
	private BLDR DJOLMNCNDBG(string ODLMGDFMFJG, object FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M CCLKJNICOOA();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class CLMJABCIHAG : PFPNAHGNJNK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct JCCKCOGCAOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<MOHDDJLMGGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CLMJABCIHAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private StringContent <requestBody>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private HttpRequestMessage <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private HttpResponseMessage <httpResponse>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<HttpResponseMessage> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x75D2630", Offset = "0x75D1A30", VA = "0x1875D2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x75D3060", Offset = "0x75D2460", VA = "0x1875D3060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient FAOLDBJJONC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x75CE5D0", Offset = "0x75CD9D0", VA = "0x1875CE5D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void KAJAIPKLMKK(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x75CE640", Offset = "0x75CDA40", VA = "0x1875CE640")]
	[RecRoom.NoEngine.Common.Preserve]
	public CLMJABCIHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x75CE460", Offset = "0x75CD860", VA = "0x1875CE460", Slot = "4")]
	[AsyncStateMachine(typeof(JCCKCOGCAOH))]
	public Task<MOHDDJLMGGP> HDCEOLGDIOI(string NPDDDIAOLAA, string NKKHOLIDACG, string HOHOGECAPNG, string IBMGAAJFCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HODFAJMEDFA : PFPNAHGNJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DHIFBIKJCLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<MOHDDJLMGGP> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DHIFBIKJCLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x75CE6C0", Offset = "0x75CDAC0", VA = "0x1875CE6C0")]
		internal void DCHEILAAKOO(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct AKDAHNOONLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<MOHDDJLMGGP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string bodyJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string url;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string password;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<MOHDDJLMGGP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x75C4A60", Offset = "0x75C3E60", VA = "0x1875C4A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x75C4FB0", Offset = "0x75C43B0", VA = "0x1875C4FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void GEPBLMBFPAD(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[RecRoom.NoEngine.Common.Preserve]
	public HODFAJMEDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x75CF880", Offset = "0x75CEC80", VA = "0x1875CF880", Slot = "4")]
	[AsyncStateMachine(typeof(AKDAHNOONLG))]
	public Task<MOHDDJLMGGP> HDCEOLGDIOI(string NPDDDIAOLAA, string NKKHOLIDACG, string HOHOGECAPNG, string IBMGAAJFCEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OLACLCGFLON
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> BCJLJNBJPAF;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x75D6BF0", Offset = "0x75D5FF0", VA = "0x1875D6BF0")]
	internal static bool IEOGKIFBNLC(string MCBJECJLDOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PFPNAHGNJNK
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MOHDDJLMGGP> HDCEOLGDIOI(string NPDDDIAOLAA, string NKKHOLIDACG, string HOHOGECAPNG, string IBMGAAJFCEA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct MOHDDJLMGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int HIHGGOMGDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string DBBHNLIEMPE;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1522D40", Offset = "0x1522140", VA = "0x181522D40")]
	public MOHDDJLMGGP(int KOOFGGOMEMO, string KEBJDJACAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum KEEPLIEENKC
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PlayerDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	FriendImport,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PlatformFriendInvite,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	PlatformNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	WatchNotification,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	LegacyHomeScreen,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	NavigationBar,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	LegacyChatPage,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MobileHomeChat,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	PlayerProfile,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ShareContent,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HUDHotbarShortcut,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	GameInvite,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	RoomChat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	DebugCommand
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FBHAAJHPNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long IGNEDOMEOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IALBCJDBAAO JGKNDGLLBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool FFCJFAOKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float AALENIBFPNP;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x75CECB0", Offset = "0x75CE0B0", VA = "0x1875CECB0")]
	public FBHAAJHPNEA(string CFOCBGJFFHI, float AALENIBFPNP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x358FA90", Offset = "0x358EE90", VA = "0x18358FA90")]
	public void ALENPICKODA<T>(string ODLMGDFMFJG, T FIIKLGCIAGG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x75CE920", Offset = "0x75CDD20", VA = "0x1875CE920")]
	public void ALENPICKODA(string ODLMGDFMFJG, string FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x75CE9F0", Offset = "0x75CDDF0", VA = "0x1875CE9F0")]
	public void DGDLIJEGEFK(string APODPGCMMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x75CEBF0", Offset = "0x75CDFF0", VA = "0x1875CEBF0")]
	public void PPGOOPEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x75CEAE0", Offset = "0x75CDEE0", VA = "0x1875CEAE0")]
	private void HGBHEKNHKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x75CE9A0", Offset = "0x75CDDA0", VA = "0x1875CE9A0")]
	private bool BDPFJHHNDGJ()
	{
		return default(bool);
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum PJHHBNFFNCM
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private PJHHBNFFNCM parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PJHHBNFFNCM Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0")]
			get
			{
				return default(PJHHBNFFNCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x75D6FB0", Offset = "0x75D63B0", VA = "0x1875D6FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PMCEGLBMGGD<T> : MABDMGJJPBL<T>, MCLBHCOLJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HNAFBHEKIKK JHNCNOHACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string JBHMHOMJPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string KOICFEEEFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private T PKLNGDOJLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly T MBADHELIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool NGLOOFHIDBO;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string ODOIJNJKPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x52F3600", Offset = "0x52F2A00", VA = "0x1852F3600")]
	public PMCEGLBMGGD(HNAFBHEKIKK JHNCNOHACNN, string JBHMHOMJPDO, string KOICFEEEFBC, T MBADHELIPJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x52F3280", Offset = "0x52F2680", VA = "0x1852F3280", Slot = "4")]
	public T IFFONPNJNJH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x52F30F0", Offset = "0x52F24F0", VA = "0x1852F30F0", Slot = "6")]
	public void GAPBPDEBKKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class IOBJEMEAENF : MCLHKOLLAKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct JBHLBBNLEJH : IEquatable<JBHLBBNLEJH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string APNPMHCPCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string JFIJMNHEJFF;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9CA0", Offset = "0x9F90A0", VA = "0x1809F9CA0")]
		public JBHLBBNLEJH(string DBIBJJNJAAB, string BDBBGBMOHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0670", Offset = "0x6DAFA70", VA = "0x186DB0670", Slot = "4")]
		public bool Equals(JBHLBBNLEJH JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x75D2500", Offset = "0x75D1900", VA = "0x1875D2500", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x75D25C0", Offset = "0x75D19C0", VA = "0x1875D25C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private HNAFBHEKIKK JHNCNOHACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<JBHLBBNLEJH, MCLBHCOLJAI> HFIGDFFPDJE;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x75D22D0", Offset = "0x75D16D0", VA = "0x1875D22D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x75D2350", Offset = "0x75D1750", VA = "0x1875D2350")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOBJEMEAENF([System.Diagnostics.CodeAnalysis.NotNull][GKAMHFFOHNI(null)] HNAFBHEKIKK JHNCNOHACNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x75D2020", Offset = "0x75D1420", VA = "0x1875D2020", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x75D2340", Offset = "0x75D1740", VA = "0x1875D2340")]
	private void HJADPPNOMNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x75D2120", Offset = "0x75D1520", VA = "0x1875D2120")]
	private void FBNOBMODMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x365E280", Offset = "0x365D680", VA = "0x18365E280", Slot = "4")]
	public MABDMGJJPBL<T> BKAKNIFIDDJ<T>(string JBHMHOMJPDO, string NAGCBJDPKPC, T MBADHELIPJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class OOIKGMPEHDB : KEMDOGMNHAO, KAEBAMOIHMA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void HBCFEIAFPBJ(ONDEJCIJLCE EKHNFKODMFE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly DEMHBLOFIFD MIFGCCGFNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly HBCFEIAFPBJ NGHFIHGLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly string JCENFMCJPLK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xFE24B0", Offset = "0xFE18B0", VA = "0x180FE24B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string ANCGOJMPOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A03D30", Offset = "0x1A03130", VA = "0x181A03D30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LDGBBEMBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75D6D90", Offset = "0x75D6190", VA = "0x1875D6D90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EJLONAPMODI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x75D6DB0", Offset = "0x75D61B0", VA = "0x1875D6DB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<string> JBKBFPFKCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A041E0", Offset = "0x1A035E0", VA = "0x181A041E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x75D6DD0", Offset = "0x75D61D0", VA = "0x1875D6DD0")]
	public OOIKGMPEHDB(DEMHBLOFIFD EOPBDJJHJJL, string GGJIOMIMOHJ, [Optional] HBCFEIAFPBJ JCAOJOKNEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x37D4060", Offset = "0x37D3460", VA = "0x1837D4060", Slot = "9")]
	public T CNKKCIMLPML<T>(string MCBJECJLDOM, T MBADHELIPJM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class HPMHHCNDLOM : HNAFBHEKIKK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FEJGFANHBLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DFOGPGCEFIE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public HPMHHCNDLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75CEE40", Offset = "0x75CE240", VA = "0x1875CEE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x75CF7B0", Offset = "0x75CEBB0", VA = "0x1875CF7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct NHGOEHECCHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x75D4A30", Offset = "0x75D3E30", VA = "0x1875D4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x75D4C10", Offset = "0x75D4010", VA = "0x1875D4C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct AJKJCEHEGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public DFOGPGCEFIE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public HPMHHCNDLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x75C45D0", Offset = "0x75C39D0", VA = "0x1875C45D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x75C4A00", Offset = "0x75C3E00", VA = "0x1875C4A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ABOHPDLFNKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public HPMHHCNDLOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public DFOGPGCEFIE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x75C39D0", Offset = "0x75C2DD0", VA = "0x1875C39D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x75C3D90", Offset = "0x75C3190", VA = "0x1875C3D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IReadOnlyDictionary<string, FKHGHLGAFBF> NAENFJNDIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool AJCFIKINGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool HPCOAEKHFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private TaskCompletionSource<bool> JIIDKFKBCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> JFHHFHEAMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly SemaphoreSlim NLIFGGCOECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private PDMEMENJMOL LHAHKLMHLFC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task OHKGPOOOHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x75D0FC0", Offset = "0x75D03C0", VA = "0x1875D0FC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Task KLBMHPJIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x75D10A0", Offset = "0x75D04A0", VA = "0x1875D10A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool KMLICLPPBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool CBKIBGLAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xBD2670", Offset = "0xBD1A70", VA = "0x180BD2670", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string NJJDJMDMHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x75D08C0", Offset = "0x75CFCC0", VA = "0x1875D08C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CBIGACLCHPH PHEJJPLJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x75CFDB0", Offset = "0x75CF1B0", VA = "0x1875CFDB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action PHCLHGDBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x75D0C10", Offset = "0x75D0010", VA = "0x1875D0C10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x75D0CB0", Offset = "0x75D00B0", VA = "0x1875D0CB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action MBJAPKACOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x75D1000", Offset = "0x75D0400", VA = "0x1875D1000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x75D13A0", Offset = "0x75D07A0", VA = "0x1875D13A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BCHJNBFPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x75D0E00", Offset = "0x75D0200", VA = "0x1875D0E00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x75D0820", Offset = "0x75CFC20", VA = "0x1875D0820", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<ONDEJCIJLCE> FBMHCHNDEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x75D0D50", Offset = "0x75D0150", VA = "0x1875D0D50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x75CF9E0", Offset = "0x75CEDE0", VA = "0x1875CF9E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x75D0800", Offset = "0x75CFC00", VA = "0x1875D0800", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x75D0EA0", Offset = "0x75D02A0", VA = "0x1875D0EA0", Slot = "12")]
	[AsyncStateMachine(typeof(FEJGFANHBLP))]
	public Task MBHBIOMKKEG(string CKKLMPKPEOJ, [Optional] DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x75D1440", Offset = "0x75D0840", VA = "0x1875D1440", Slot = "24")]
	[AsyncStateMachine(typeof(NHGOEHECCHL))]
	public Task PNPDLKKOPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x75D0700", Offset = "0x75CFB00", VA = "0x1875D0700", Slot = "19")]
	[AsyncStateMachine(typeof(AJKJCEHEGPB))]
	public Task DFDJKFGIGHC(DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x75D09C0", Offset = "0x75CFDC0", VA = "0x1875D09C0")]
	private void KKIJPPAOKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x75CFCA0", Offset = "0x75CF0A0", VA = "0x1875CFCA0", Slot = "20")]
	[AsyncStateMachine(typeof(ABOHPDLFNKH))]
	public Task DAMMFHKJCBP(DFOGPGCEFIE CPLCNCAFBDG, Dictionary<string, string> JLPGHMDHMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x75D08D0", Offset = "0x75CFCD0", VA = "0x1875D08D0", Slot = "21")]
	public bool KFELIIPGEMD(string ODBALFECHAD, bool ELMCNALJHAL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x75D10E0", Offset = "0x75D04E0", VA = "0x1875D10E0", Slot = "22")]
	public KEMDOGMNHAO NHIPOMMIMIB(string GGJIOMIMOHJ, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x75CFA90", Offset = "0x75CEE90", VA = "0x1875CFA90")]
	private DEMHBLOFIFD BNHKKIGKMPJ(string GGJIOMIMOHJ, bool ELMCNALJHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x75D14F0", Offset = "0x75D08F0", VA = "0x1875D14F0", Slot = "23")]
	public ELGMDPHMKGO PNPFKNEIBHJ(string DBIBJJNJAAB, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x75D12A0", Offset = "0x75D06A0", VA = "0x1875D12A0")]
	private HIDNCNGJCGL OOGONHMJKNH(string DBIBJJNJAAB, bool ELMCNALJHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x75CFDE0", Offset = "0x75CF1E0", VA = "0x1875CFDE0")]
	private FLKLFOHBODG DDECHFHGJBB(DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x75D0A60", Offset = "0x75CFE60", VA = "0x1875D0A60")]
	private IBMBLPCKAFA LCMCDKIDKCN(string CKKLMPKPEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x75D16A0", Offset = "0x75D0AA0", VA = "0x1875D16A0")]
	private void POBHPKBOLBP(string GGJIOMIMOHJ, DEMHBLOFIFD EOPBDJJHJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x75D1960", Offset = "0x75D0D60", VA = "0x1875D1960")]
	public HPMHHCNDLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75D06C0", Offset = "0x75CFAC0", VA = "0x1875D06C0")]
	[CompilerGenerated]
	private void DEHJJJAJCBA(ONDEJCIJLCE NAEIDONDAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x75D06C0", Offset = "0x75CFAC0", VA = "0x1875D06C0")]
	[CompilerGenerated]
	private void PIGPEPBHFOD(ONDEJCIJLCE NAEIDONDAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JICLNPKJJOJ : HNAFBHEKIKK, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct NKOFIDNMEEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JICLNPKJJOJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public DFOGPGCEFIE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x75D4DD0", Offset = "0x75D41D0", VA = "0x1875D4DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x75D5750", Offset = "0x75D4B50", VA = "0x1875D5750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct IMAONCNIIFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x75D1DE0", Offset = "0x75D11E0", VA = "0x1875D1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private HPMHHCNDLOM PPALKGEFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private TaskCompletionSource<bool> JIIDKFKBCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> JFHHFHEAMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Task MMGDBLHNOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task NJJOMLEBEOC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private HNAFBHEKIKK NBCLFPBJMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x75D3A40", Offset = "0x75D2E40", VA = "0x1875D3A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CBKIBGLAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x75D3730", Offset = "0x75D2B30", VA = "0x1875D3730", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KMLICLPPBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x75D3960", Offset = "0x75D2D60", VA = "0x1875D3960", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task OHKGPOOOHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x75D4040", Offset = "0x75D3440", VA = "0x1875D4040", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task KLBMHPJIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x75D4180", Offset = "0x75D3580", VA = "0x1875D4180", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NJJDJMDMHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x75D39B0", Offset = "0x75D2DB0", VA = "0x1875D39B0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public CBIGACLCHPH PHEJJPLJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x75D3740", Offset = "0x75D2B40", VA = "0x1875D3740", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action MBJAPKACOGD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x75D40E0", Offset = "0x75D34E0", VA = "0x1875D40E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x75D42E0", Offset = "0x75D36E0", VA = "0x1875D42E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PHCLHGDBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x75D3BD0", Offset = "0x75D2FD0", VA = "0x1875D3BD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x75D3D40", Offset = "0x75D3140", VA = "0x1875D3D40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BCHJNBFPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75D3E90", Offset = "0x75D3290", VA = "0x1875D3E90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x75D38C0", Offset = "0x75D2CC0", VA = "0x1875D38C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ONDEJCIJLCE> FBMHCHNDEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x75D3DE0", Offset = "0x75D31E0", VA = "0x1875D3DE0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x75D3370", Offset = "0x75D2770", VA = "0x1875D3370", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x75D4550", Offset = "0x75D3950", VA = "0x1875D4550")]
	[UnityEngine.Scripting.Preserve]
	public JICLNPKJJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x75D39D0", Offset = "0x75D2DD0", VA = "0x1875D39D0")]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x75D35A0", Offset = "0x75D29A0", VA = "0x1875D35A0")]
	internal static void CIFAHEGPCEM(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x75D3890", Offset = "0x75D2C90", VA = "0x1875D3890", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x75D3F30", Offset = "0x75D3330", VA = "0x1875D3F30", Slot = "12")]
	[AsyncStateMachine(typeof(NKOFIDNMEEG))]
	public Task MBHBIOMKKEG(string CKKLMPKPEOJ, [Optional] DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x75D3780", Offset = "0x75D2B80", VA = "0x1875D3780", Slot = "19")]
	public Task DFDJKFGIGHC(DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x75D3610", Offset = "0x75D2A10", VA = "0x1875D3610", Slot = "20")]
	public Task DAMMFHKJCBP(DFOGPGCEFIE CPLCNCAFBDG, Dictionary<string, string> JLPGHMDHMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x75D3AB0", Offset = "0x75D2EB0", VA = "0x1875D3AB0", Slot = "21")]
	public bool KFELIIPGEMD(string ODBALFECHAD, bool ELMCNALJHAL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x75D4220", Offset = "0x75D3620", VA = "0x1875D4220", Slot = "22")]
	public KEMDOGMNHAO NHIPOMMIMIB(string GGJIOMIMOHJ, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x75D4490", Offset = "0x75D3890", VA = "0x1875D4490", Slot = "23")]
	public ELGMDPHMKGO PNPFKNEIBHJ(string DBIBJJNJAAB, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x75D4380", Offset = "0x75D3780", VA = "0x1875D4380", Slot = "24")]
	public Task PNPDLKKOPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x75D3420", Offset = "0x75D2820", VA = "0x1875D3420")]
	private static void CHGLKDOLHAO(TaskCompletionSource<bool> BAIELHIPCKN, Task PILNFFEDJPD, Task GFAKAEAFOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x75D3C70", Offset = "0x75D3070", VA = "0x1875D3C70")]
	[AsyncStateMachine(typeof(IMAONCNIIFP))]
	private static void LIJOIJPELJJ(Task ALKPEINKLAJ, TaskCompletionSource<bool> BAIELHIPCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xD93B90", Offset = "0xD92F90", VA = "0x180D93B90")]
	[CompilerGenerated]
	private void BBMNPJNOPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xE28AC0", Offset = "0xE27EC0", VA = "0x180E28AC0")]
	[CompilerGenerated]
	private void AEEIBMJLIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xC11F90", Offset = "0xC11390", VA = "0x180C11F90")]
	[CompilerGenerated]
	private void LPNLIJKBOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x75D3970", Offset = "0x75D2D70", VA = "0x1875D3970")]
	[CompilerGenerated]
	private void GELHLNLPFKB(ONDEJCIJLCE NAEIDONDAPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class IKFBIFNLFEI : ELGMDPHMKGO, KAEBAMOIHMA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void BHIFKKIDFGM(ONDEJCIJLCE EKHNFKODMFE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly BHIFKKIDFGM NGHFIHGLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly HIDNCNGJCGL MEGKHGGKAKC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x248F8A0", Offset = "0x248ECA0", VA = "0x18248F8A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string ANCGOJMPOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xD43680", Offset = "0xD42A80", VA = "0x180D43680", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6879710", Offset = "0x6878B10", VA = "0x186879710")]
	public IKFBIFNLFEI(HIDNCNGJCGL JBHMHOMJPDO, [Optional] BHIFKKIDFGM JCAOJOKNEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x365C710", Offset = "0x365BB10", VA = "0x18365C710", Slot = "6")]
	public T CNKKCIMLPML<T>(string MCBJECJLDOM, T MBADHELIPJM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MGDPELLLINJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class JKKLMHEHAIA : MGDPELLLINJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly FGDFKAFKELB JEKHAJKLGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<MGECDIIIMHF> HLFEMBLHKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly string KDGLONABMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string ODDOPGJAIBI;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x75D4610", Offset = "0x75D3A10", VA = "0x1875D4610")]
	[UsedImplicitly]
	[BOBPNFIGGBE.NBDKKMMHNGD.OAOMAIGGIPF]
	internal static void KDIILJNJDKF(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x75D4680", Offset = "0x75D3A80", VA = "0x1875D4680")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JKKLMHEHAIA([GKAMHFFOHNI(null)][JetBrains.Annotations.NotNull] FGDFKAFKELB JEKHAJKLGAM, [GKAMHFFOHNI(null)][JetBrains.Annotations.NotNull] CJFNBKEGPNE FADHDAEHCBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CKFODDAPNEM : HNAFBHEKIKK
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Task OHKGPOOOHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x75CE030", Offset = "0x75CD430", VA = "0x1875CE030", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Task KLBMHPJIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x75CE160", Offset = "0x75CD560", VA = "0x1875CE160", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CBKIBGLAFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KMLICLPPBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string NJJDJMDMHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CBIGACLCHPH PHEJJPLJMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action MBJAPKACOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x75CE0C0", Offset = "0x75CD4C0", VA = "0x1875CE0C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x75CE2A0", Offset = "0x75CD6A0", VA = "0x1875CE2A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action PHCLHGDBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x75CDD10", Offset = "0x75CD110", VA = "0x1875CDD10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x75CDDB0", Offset = "0x75CD1B0", VA = "0x1875CDDB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BCHJNBFPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x75CDF00", Offset = "0x75CD300", VA = "0x1875CDF00", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x75CDC70", Offset = "0x75CD070", VA = "0x1875CDC70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<ONDEJCIJLCE> FBMHCHNDEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x75CDE50", Offset = "0x75CD250", VA = "0x1875CDE50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x75CDAA0", Offset = "0x75CCEA0", VA = "0x1875CDAA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	[RecRoom.NoEngine.Common.Preserve]
	public CKFODDAPNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x75CDFA0", Offset = "0x75CD3A0", VA = "0x1875CDFA0", Slot = "12")]
	public Task MBHBIOMKKEG(string CKKLMPKPEOJ, [Optional] DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x75CDBE0", Offset = "0x75CCFE0", VA = "0x1875CDBE0", Slot = "19")]
	public Task DFDJKFGIGHC(DFOGPGCEFIE CPLCNCAFBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x75CDB50", Offset = "0x75CCF50", VA = "0x1875CDB50", Slot = "20")]
	public Task DAMMFHKJCBP(DFOGPGCEFIE CPLCNCAFBDG, Dictionary<string, string> JLPGHMDHMNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "21")]
	public bool KFELIIPGEMD(string ODBALFECHAD, bool ELMCNALJHAL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x75CE1F0", Offset = "0x75CD5F0", VA = "0x1875CE1F0", Slot = "22")]
	public KEMDOGMNHAO NHIPOMMIMIB(string GGJIOMIMOHJ, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x75CE3D0", Offset = "0x75CD7D0", VA = "0x1875CE3D0", Slot = "23")]
	public ELGMDPHMKGO PNPFKNEIBHJ(string DBIBJJNJAAB, bool ELMCNALJHAL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x75CE340", Offset = "0x75CD740", VA = "0x1875CE340", Slot = "24")]
	public Task PNPDLKKOPHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class PDMEMENJMOL : CBIGACLCHPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FLKLFOHBODG COFLAKMPHHP;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IReadOnlyDictionary<string, object> EBDJHAFKPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xD400B0", Offset = "0xD3F4B0", VA = "0x180D400B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public PDMEMENJMOL(FLKLFOHBODG NJKNMOPLKJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JDLNPPANDEO
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBHAAJHPNEA LHJBFGNMDBE(string CFOCBGJFFHI);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface BGFKOEMHHCL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum EHDHHPJBINN
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	long AHCPANLBINL
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string FFAIPKMOJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string OJEOHJGGJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KBNEELAAIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long LHPINCBJHIJ();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOGMINHDHCB(long HCKHGINLCBI, bool MKIKKFCEPII = true);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHNDGPLBGFO(string PFPNPMCGHHC, string DCBPLLGNODI, string DJAHGFKGEPG);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJKDGAECGMH(string PFPNPMCGHHC);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DHNKDOGHDOI(string PFPNPMCGHHC, string NBPBOGLBGEB, string NOMBCGIKBKD);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EAHOCCENJAE(string FAGNIGAMDJK, object KCLIKBNPANG, object OBAKCCAGPDJ);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NOFLADPNOBF(EHDHHPJBINN NKHBAMDCMGG, int OMDEPJMGLPG, [Optional] BNJAEDHDGMG PLJNBAMNMLF, [Optional] string FBLHPNAKOND, [Optional] string DFEFGBECJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FKOLBCADBPG(BNJAEDHDGMG PLJNBAMNMLF, long GIHJBOMHFAD, long GNHOEELJIHC, int LDHFFGJMKFB, string FBLHPNAKOND, int OMDEPJMGLPG);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IHHDKFPMJKC(BNJAEDHDGMG PLJNBAMNMLF, bool NIGNBIDEMPO, [Optional] string DFEFGBECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MJDPBPGHIGH(BNJAEDHDGMG PLJNBAMNMLF, bool NIGNBIDEMPO, [Optional] string DFEFGBECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PNCKINBNPOK(BNJAEDHDGMG PLJNBAMNMLF, bool NIGNBIDEMPO, [Optional] string DFEFGBECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPALDFGNFBD(long CCHPCHDJHAI, string BDCHHNLMLDP);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface CPDBMPCJDGM
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string MPCMHHOOCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
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
