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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x72CC9C0", Offset = "0x72CAFC0", VA = "0x1872CC9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72CC640", Offset = "0x72CAC40", VA = "0x1872CC640", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x72CD5C0", Offset = "0x72CBBC0", VA = "0x1872CD5C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
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
		public AmplitudeAnalyticsClient.Settings CEEBFCJCMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IDAHFHEHFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, NFEDKEMNHKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum EMHAEMLDHMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class CAKGDIEFIAC
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class FIFBCDCFDMN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int AMFHKOGJHMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> BMGCPCAAMMK;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
				public FIFBCDCFDMN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class BNOAEAAEGLB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
				public BNOAEAAEGLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x72C19A0", Offset = "0x72BFFA0", VA = "0x1872C19A0")]
				internal bool FNEPALNAMFN(FIFBCDCFDMN item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string KHLGHHGPLEN = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string DPEONNMDCPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<FIFBCDCFDMN> IHJONEAIBPC;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? GNOLFJHLKEK
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x72C2490", Offset = "0x72C0A90", VA = "0x1872C2490")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72C2CB0", Offset = "0x72C12B0", VA = "0x1872C2CB0")]
			internal CAKGDIEFIAC(string FAFGFLIKMPD, string OPOKIOPOKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72C22E0", Offset = "0x72C08E0", VA = "0x1872C22E0")]
			public int HNHPHAMMNGN([Optional] int? COFHJDFKIHC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x72C2A40", Offset = "0x72C1040", VA = "0x1872C2A40")]
			public List<Dictionary<string, object>> PAPJNKPHMAK(int PMIIGEJODGI, int? COFHJDFKIHC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72C1F20", Offset = "0x72C0520", VA = "0x1872C1F20")]
			public void GHMEBLPFNDN(AmplitudeAnalyticsIdentifyMessage GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x72C1FC0", Offset = "0x72C05C0", VA = "0x1872C1FC0")]
			public void GHMEBLPFNDN(Dictionary<string, object> GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72C28B0", Offset = "0x72C0EB0", VA = "0x1872C28B0")]
			public void OAMHDLNAPFG(params Dictionary<string, object>[] APMBBMICOIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x72C2660", Offset = "0x72C0C60", VA = "0x1872C2660")]
			public void LPEBCBCLEME(List<Dictionary<string, object>> OGPOOIHMBGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x72C1E10", Offset = "0x72C0410", VA = "0x1872C1E10")]
			private void DLJJGCJHHCC(Dictionary<string, object> GMFKPONAANG, bool PNHGOEEGDOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x72C20D0", Offset = "0x72C06D0", VA = "0x1872C20D0")]
			public void HLMPNIBBIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72C1A10", Offset = "0x72C0010", VA = "0x1872C1A10")]
			private void DANAENKPGNB([Optional] string DAJOPLFHCAI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x72C2530", Offset = "0x72C0B30", VA = "0x1872C2530")]
			private static string LLHCHKBMKGH(string KBGCCIOIGBD, string LKMGECEEGEE)
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
			[Cpp2IlInjected.Address(RVA = "0x72CD1B0", Offset = "0x72CB7B0", VA = "0x1872CD1B0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct EIALOPGOLNL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int AOPCFCKPJNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string HFLOHBLDMJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T MIJMEPGCMNN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class ADDLDIBMBJC : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public ADDLDIBMBJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72B9830", Offset = "0x72B7E30", VA = "0x1872B9830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x72B9FC0", Offset = "0x72B85C0", VA = "0x1872B9FC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PGEBIGDCIDA : IEnumerator<object>, IEnumerator, IDisposable
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
			public NKJHMBFDFON quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public PGEBIGDCIDA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x72CCCD0", Offset = "0x72CB2D0", VA = "0x1872CCCD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x72CCDE0", Offset = "0x72CB3E0", VA = "0x1872CCDE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HKIBMJJGNKL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public HKIBMJJGNKL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72C76C0", Offset = "0x72C5CC0", VA = "0x1872C76C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x72C7830", Offset = "0x72C5E30", VA = "0x1872C7830", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class JJMKIFODGIK : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public JJMKIFODGIK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x72C9240", Offset = "0x72C7840", VA = "0x1872C9240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x72C94A0", Offset = "0x72C7AA0", VA = "0x1872C94A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LGHGKBJMJIM : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public LGHGKBJMJIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x72CBDB0", Offset = "0x72CA3B0", VA = "0x1872CBDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x72CC010", Offset = "0x72CA610", VA = "0x1872CC010", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JLHNGLEJKON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CAKGDIEFIAC cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public JLHNGLEJKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x72C94F0", Offset = "0x72C7AF0", VA = "0x1872C94F0")]
			internal void HOCMLNPCNDB(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x72C9810", Offset = "0x72C7E10", VA = "0x1872C9810")]
			internal void JMICNOCDAFA(EIALOPGOLNL<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IKMODMPKNHN : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CAKGDIEFIAC cache;

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
			private JLHNGLEJKON <>8__1;

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
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public IKMODMPKNHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72C8330", Offset = "0x72C6930", VA = "0x1872C8330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x72C8B50", Offset = "0x72C7150", VA = "0x1872C8B50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class FHCGBCCBHBL<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public FHCGBCCBHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4422790", Offset = "0x4420D90", VA = "0x184422790")]
			internal EIALOPGOLNL<T> CCMFHKDLOPO(EEBJIOCNPOE postResponse)
			{
				return default(EIALOPGOLNL<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private CDIHIOEBGKL HFGMMHMEBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<IJIECKPLCLG> DOFFFOGMIMJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string OMFDHNHBKHF = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string INLHKPBFIPL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string IDGBMPOIPJL = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BNODPDLKHOK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int LKBIMHEEPMB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int DONGOBFAGMH = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float ANPMKLMHHFF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long LLPKOAICEHG = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string JOLILAFKPNG = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string GENFMMIDMFK = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string GBPKFCANAJJ = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string PDALDEOAACN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool NPPHCJJHKFL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool JLAADJIKEMA;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int GMGMIFDHOCN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int FDKGBLJJGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DBKOIMNCEMC BJJAGPNFBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JEPPADOHMNE JJOIDHPLDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private AKPEKCLMGOC JJFLHFANALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool HDDBEEAIPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float BNIFNEPIEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float JFHFLPMELJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int EFPKGPGEOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int KDAJJKHFNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? PMMHCIPGDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? LOPPJIFEMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long PLGIFNFJFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string PPNGDFGFFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string AKFMGMHANPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long BCJOICCILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string GOLDBPOGKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string BOFFPBHLJIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> AIBIGOEHAKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private EMHAEMLDHMD BHPPEOBJFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int JJDPIFNPEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int KDIDGANFIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float DMGAKHJPOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool DKLBCOGGMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool OFBKADHOMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CAKGDIEFIAC FNGHIIGOOFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CAKGDIEFIAC LDNJODCCFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CAKGDIEFIAC MPKJKPLHDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string NCMLDLFEHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> FONJFKJLPGP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JGDAOMADFFE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string EEKKMOFMDPA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string FDGIGGAAIPN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string ICDHKEGPEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string FAKMBFJKKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string LDLCDJHKMEN;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CDIHIOEBGKL COBMNPFDHDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x72BBF40", Offset = "0x72BA540", VA = "0x1872BBF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IJIECKPLCLG EABOLPIPJON
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x72BBB10", Offset = "0x72BA110", VA = "0x1872BBB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BBGOMJOKFGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72BC5B0", Offset = "0x72BABB0", VA = "0x1872BC5B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long GONENKMEILN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x72BFF00", Offset = "0x72BE500", VA = "0x1872BFF00")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x72C0010", Offset = "0x72BE610", VA = "0x1872C0010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string FPNFHDDJMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x72BFED0", Offset = "0x72BE4D0", VA = "0x1872BFED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x125A510", Offset = "0x1258B10", VA = "0x18125A510", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1258AE0", Offset = "0x12570E0", VA = "0x181258AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BAMGPKONIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3C830", Offset = "0xA3AE30", VA = "0x180A3C830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA42B10", Offset = "0xA41110", VA = "0x180A42B10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? PEEACNGAJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA3C840", Offset = "0xA3AE40", VA = "0x180A3C840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA42580", Offset = "0xA40B80", VA = "0x180A42580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OFENFMLBBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xC94E40", Offset = "0xC93440", VA = "0x180C94E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1141290", Offset = "0x113F890", VA = "0x181141290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LKFFBDIBKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x72BFDE0", Offset = "0x72BE3E0", VA = "0x1872BFDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KONICEPMBAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72BFD20", Offset = "0x72BE320", VA = "0x1872BFD20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72BFF50", Offset = "0x72BE550", VA = "0x1872BFF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72BA250", Offset = "0x72B8850", VA = "0x1872BA250", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72BA8B0", Offset = "0x72B8EB0", VA = "0x1872BA8B0")]
		private void CLDBAHNEIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72BF350", Offset = "0x72BD950", VA = "0x1872BF350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72BD130", Offset = "0x72BB730", VA = "0x1872BD130", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72BF680", Offset = "0x72BDC80", VA = "0x1872BF680")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72BE0C0", Offset = "0x72BC6C0", VA = "0x1872BE0C0")]
		public HJOKANJAKGB PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72BC520", Offset = "0x72BAB20", VA = "0x1872BC520")]
		[IteratorStateMachine(typeof(ADDLDIBMBJC))]
		public IEnumerator<FBLKJCIOKGP> InitializeForLocalAccount(AmplitudeAnalyticsEvent KNJENBHEMKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72BEA20", Offset = "0x72BD020", VA = "0x1872BEA20")]
		public void SendAppEnterEvent(bool BGIFJFGPBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72BF600", Offset = "0x72BDC00", VA = "0x1872BF600")]
		public void UpdateLastKnownInteractionCategory(string EKGJIJBOMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72BF550", Offset = "0x72BDB50", VA = "0x1872BF550")]
		public void UpdateLastAliveTime(float HIBCBLOKLEA = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72BB730", Offset = "0x72B9D30", VA = "0x1872BB730")]
		private HJOKANJAKGB EOEJDHCICMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72BD1F0", Offset = "0x72BB7F0", VA = "0x1872BD1F0")]
		private HJOKANJAKGB PFHADKLJIIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72BED30", Offset = "0x72BD330", VA = "0x1872BED30")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72BC7B0", Offset = "0x72BADB0", VA = "0x1872BC7B0")]
		[IteratorStateMachine(typeof(PGEBIGDCIDA))]
		private IEnumerator KLHIPEEBFAP(NKJHMBFDFON KAFODDCOHJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72BF910", Offset = "0x72BDF10", VA = "0x1872BF910")]
		[IteratorStateMachine(typeof(HKIBMJJGNKL))]
		public IEnumerator WaitForFlush(float GAOGFDNIHEO = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72BF430", Offset = "0x72BDA30", VA = "0x1872BF430")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72BF370", Offset = "0x72BD970", VA = "0x1872BF370")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime KGDKBIOOEOP)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72BC020", Offset = "0x72BA620", VA = "0x1872BC020")]
		public static HLFNENDJOGP Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72BA0A0", Offset = "0x72B86A0", VA = "0x1872BA0A0")]
		public static LIIGBNJFBAA AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string NCHMBDMAKLI, string PNHEMONCBEB, BPHJFMHKELH EEPPLAEHENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72BB7F0", Offset = "0x72B9DF0", VA = "0x1872BB7F0")]
		public static LIIGBNJFBAA Event([JetBrains.Annotations.NotNull] string NCHMBDMAKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72BE260", Offset = "0x72BC860", VA = "0x1872BE260")]
		public static LIIGBNJFBAA PreviousSessionEvent([JetBrains.Annotations.NotNull] string NCHMBDMAKLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72BC1C0", Offset = "0x72BA7C0", VA = "0x1872BC1C0")]
		public static LIIGBNJFBAA InitializeEvent(string PNHEMONCBEB, int BIOKOOFIJDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72BEF30", Offset = "0x72BD530", VA = "0x1872BEF30")]
		public static LIIGBNJFBAA StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72BAD50", Offset = "0x72B9350", VA = "0x1872BAD50")]
		public static LIIGBNJFBAA CreateOutOfSessionEvent(string NCHMBDMAKLI, bool HLCCAFKJBCH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72BCAC0", Offset = "0x72BB0C0", VA = "0x1872BCAC0")]
		public static HJOKANJAKGB LogOutOfSessionEvent(LIIGBNJFBAA BAKMDMHMEFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72BC840", Offset = "0x72BAE40", VA = "0x1872BC840")]
		public void LogEventAsync(AmplitudeAnalyticsEvent LOLIGDPJGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72BCC90", Offset = "0x72BB290", VA = "0x1872BCC90")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent LOLIGDPJGMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72BCDD0", Offset = "0x72BB3D0", VA = "0x1872BCDD0")]
		public void LogSerializedEventAsync(Dictionary<string, object> NCLOBOFGNGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72BC980", Offset = "0x72BAF80", VA = "0x1872BC980")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage DOLLNIEACCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72BB030", Offset = "0x72B9630", VA = "0x1872BB030")]
		private void DGNKMLDGKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72BB470", Offset = "0x72B9A70", VA = "0x1872BB470")]
		private void DNEOIMAFKGA(Dictionary<string, object> DMGPEODFGGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72BBE50", Offset = "0x72BA450", VA = "0x1872BBE50")]
		private void IJFBCLHHJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72BBC80", Offset = "0x72BA280", VA = "0x1872BBC80")]
		private void HAEGPDOOHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72BBB60", Offset = "0x72BA160", VA = "0x1872BBB60")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72BA010", Offset = "0x72B8610", VA = "0x1872BA010")]
		[IteratorStateMachine(typeof(JJMKIFODGIK))]
		private IEnumerator<FBLKJCIOKGP> ADLMKACPAMH(float GAOGFDNIHEO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72BBBF0", Offset = "0x72BA1F0", VA = "0x1872BBBF0")]
		[IteratorStateMachine(typeof(LGHGKBJMJIM))]
		private IEnumerator<FBLKJCIOKGP> GOFJAOEIFNG(float GAOGFDNIHEO = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC70", Offset = "0x72B9270", VA = "0x1872BAC70")]
		[IteratorStateMachine(typeof(IKMODMPKNHN))]
		private IEnumerator<FBLKJCIOKGP> CNEANFLEPAP(CAKGDIEFIAC HIDLDGNDFHN, int? COFHJDFKIHC, string OFOFNJEGEMM, float GAOGFDNIHEO, Action<int> LLOCECLHKNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72BD020", Offset = "0x72BB620", VA = "0x1872BD020")]
		private static void OBLIEPBKFPH(bool FLFKOMGIOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72BB130", Offset = "0x72B9730", VA = "0x1872BB130")]
		private NEEPBAPEEOL<EIALOPGOLNL<Dictionary<string, object>>> DKCLCGOLCKD(string OFOFNJEGEMM, string LNDJMFKPPJJ, Dictionary<string, object> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72BB200", Offset = "0x72B9800", VA = "0x1872BB200")]
		private NEEPBAPEEOL<EIALOPGOLNL<List<Dictionary<string, object>>>> DKCLCGOLCKD(string OFOFNJEGEMM, string LNDJMFKPPJJ, List<Dictionary<string, object>> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1CF0", Offset = "0x3BB02F0", VA = "0x183BB1CF0")]
		private NEEPBAPEEOL<EIALOPGOLNL<T>> JHLKLIIPHFP<T>(string PIBKKLOLEJD, string OFOFNJEGEMM, string LNDJMFKPPJJ, T MIJMEPGCMNN, Dictionary<string, object> FEBEFFBOBJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72BBFD0", Offset = "0x72BA5D0", VA = "0x1872BBFD0")]
		private bool IPHLBMBMOOI(float LCHOJPBPMKM, float GAOGFDNIHEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72BD360", Offset = "0x72BB960", VA = "0x1872BD360")]
		private Dictionary<string, object> PPMHKNFJKAF(string OFOFNJEGEMM, Dictionary<string, object> MIJMEPGCMNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72BFA00", Offset = "0x72BE000", VA = "0x1872BFA00")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0", Slot = "6")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72BCEB0", Offset = "0x72BB4B0", VA = "0x1872BCEB0")]
		[CompilerGenerated]
		private long MKMJCDGNAJD()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72BBB00", Offset = "0x72BA100", VA = "0x1872BBB00")]
		[CompilerGenerated]
		private void FIPLELMLHKB(int LEBKLHMKLCG)
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
			[Cpp2IlInjected.Address(RVA = "0x72C0D10", Offset = "0x72BF310", VA = "0x1872C0D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x72C0DF0", Offset = "0x72BF3F0", VA = "0x1872C0DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x72C0D50", Offset = "0x72BF350", VA = "0x1872C0D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x72C0E50", Offset = "0x72BF450", VA = "0x1872C0E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x72C0CD0", Offset = "0x72BF2D0", VA = "0x1872C0CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x72C0D90", Offset = "0x72BF390", VA = "0x1872C0D90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x956D00", Offset = "0x955300", VA = "0x180956D00")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x72C0A30", Offset = "0x72BF030", VA = "0x1872C0A30")]
		public static LIIGBNJFBAA OILMBKHFGKP(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, string EEPPLAEHENM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x72C0650", Offset = "0x72BEC50", VA = "0x1872C0650")]
		public static LIIGBNJFBAA MAPMCHPNPIK(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, long DGEHFIPAHGK, string AGFLAALGMLA, string FLNLMBKDKAL, string JLJDNLPPMGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x72C0B30", Offset = "0x72BF130", VA = "0x1872C0B30")]
		private AmplitudeAnalyticsEvent(string EPKMALKPPHD, [JetBrains.Annotations.NotNull] string AFCDMPICECP, long JKHDHJCLOPL, long FBCPCGEBMHM, string PNHEMONCBEB, string EEPPLAEHENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xD00020", Offset = "0xCFE620", VA = "0x180D00020")]
		public void ELKEGAOJMNN(long GKLNOKLILDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x72C0930", Offset = "0x72BEF30", VA = "0x1872C0930", Slot = "5")]
		public override void NIFAKHLGPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72C07B0", Offset = "0x72BEDB0", VA = "0x1872C07B0", Slot = "6")]
		public override void NBOIDEIKMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72C0180", Offset = "0x72BE780", VA = "0x1872C0180", Slot = "4")]
		protected override Dictionary<string, object> FBAOMFBPHAG(Dictionary<string, object> HDPFACLFLHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72C0070", Offset = "0x72BE670", VA = "0x1872C0070")]
		private void BOBMDPKNGED(string LKMGECEEGEE, string KBGCCIOIGBD, bool IDNIBGLEFJO = false)
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
			[Cpp2IlInjected.Address(RVA = "0x72C4EA0", Offset = "0x72C34A0", VA = "0x1872C4EA0")]
			public void KMFGOACMBCL(Dictionary<string, object> PHMILIIDFEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72CCE30", Offset = "0x72CB430", VA = "0x1872CCE30")]
			public void KMFGOACMBCL(Dictionary<string, object> FOBKBHKAHFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1104070", Offset = "0x1102670", VA = "0x181104070")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x72C14A0", Offset = "0x72BFAA0", VA = "0x1872C14A0")]
		public static HLFNENDJOGP OILMBKHFGKP(string EPKMALKPPHD, string PNHEMONCBEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72C1560", Offset = "0x72BFB60", VA = "0x1872C1560")]
		protected AmplitudeAnalyticsIdentifyMessage(string EPKMALKPPHD, string PNHEMONCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72C0EB0", Offset = "0x72BF4B0", VA = "0x1872C0EB0")]
		public Dictionary<string, object> BFAJHHBOIPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x72C0F40", Offset = "0x72BF540", VA = "0x1872C0F40", Slot = "4")]
		protected virtual Dictionary<string, object> FBAOMFBPHAG(Dictionary<string, object> HDPFACLFLHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x72C1280", Offset = "0x72BF880", VA = "0x1872C1280")]
		protected void HOLEDIEPDIN(string LKMGECEEGEE, Dictionary<string, object> OAIFAEMAENK, Dictionary<string, object> OCMDMHAAKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x72C1320", Offset = "0x72BF920", VA = "0x1872C1320")]
		protected void KHDBNKOIJHC(string LKMGECEEGEE, string KBGCCIOIGBD, Dictionary<string, object> CFFOECLBAEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x72C1410", Offset = "0x72BFA10", VA = "0x1872C1410", Slot = "5")]
		public virtual void NIFAKHLGPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x72C1390", Offset = "0x72BF990", VA = "0x1872C1390", Slot = "6")]
		public virtual void NBOIDEIKMKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HLFNENDJOGP : MPHAKAKBMMF<AmplitudeAnalyticsIdentifyMessage, HLFNENDJOGP>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override HLFNENDJOGP MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage MLDFNPPIBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72C7920", Offset = "0x72C5F20", VA = "0x1872C7920")]
	public HLFNENDJOGP(AmplitudeAnalyticsIdentifyMessage MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72C7880", Offset = "0x72C5E80", VA = "0x1872C7880", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIIGBNJFBAA : MPHAKAKBMMF<AmplitudeAnalyticsEvent, LIIGBNJFBAA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool JHOJIEGKKLD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override LIIGBNJFBAA MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long NPELFIOBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x72CC390", Offset = "0x72CA990", VA = "0x1872CC390")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72C6C90", Offset = "0x72C5290", VA = "0x1872C6C90")]
	public LIIGBNJFBAA(AmplitudeAnalyticsEvent MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "5")]
	public override AmplitudeAnalyticsEvent MLDFNPPIBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72CC250", Offset = "0x72CA850", VA = "0x1872CC250", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x34CB470", Offset = "0x34C9A70", VA = "0x1834CB470")]
	public LIIGBNJFBAA HHDHNPBMKNK<T>(string KKCCAKAEMAH, T[] KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x34CB470", Offset = "0x34C9A70", VA = "0x1834CB470")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, string[] KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x34CB1C0", Offset = "0x34C97C0", VA = "0x1834CB1C0")]
	public LIIGBNJFBAA HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x72CC1D0", Offset = "0x72CA7D0", VA = "0x1872CC1D0")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, long KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x72CC160", Offset = "0x72CA760", VA = "0x1872CC160")]
	public LIIGBNJFBAA HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x72CC3B0", Offset = "0x72CA9B0", VA = "0x1872CC3B0")]
	public LIIGBNJFBAA NLDMCDIANLJ(string KKCCAKAEMAH, object? KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x72CC2F0", Offset = "0x72CA8F0", VA = "0x1872CC2F0")]
	public LIIGBNJFBAA NKDONHPINJF(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x72CC060", Offset = "0x72CA660", VA = "0x1872CC060")]
	private LIIGBNJFBAA GIAHDAJOALA(string KKCCAKAEMAH, object KBGCCIOIGBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FIJFFPIEDKJ : LIIGBNJFBAA
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x72C6C90", Offset = "0x72C5290", VA = "0x1872C6C90")]
	public FIJFFPIEDKJ(AmplitudeAnalyticsEvent MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x72C6AE0", Offset = "0x72C50E0", VA = "0x1872C6AE0", Slot = "4")]
	public override void NBOIDEIKMKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class MPHAKAKBMMF<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : MPHAKAKBMMF<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M MIALAMIFNLM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR MJDGFBDIKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public MPHAKAKBMMF(M MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B700", Offset = "0x4E39D00", VA = "0x184E3B700")]
	public BLDR CNAPEFLPKFA(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LHMKPPICIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B880", Offset = "0x4E39E80", VA = "0x184E3B880")]
	public BLDR PIFGIPJOMLI(AmplitudeAnalyticsIdentifyMessage.RevenueData COPGFNOCBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B660", Offset = "0x4E39C60", VA = "0x184E3B660")]
	public BLDR AKOEGLHJNIA(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x35A13A0", Offset = "0x359F9A0", VA = "0x1835A13A0")]
	public BLDR AKOEGLHJNIA<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NBOIDEIKMKH();

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B850", Offset = "0x4E39E50", VA = "0x184E3B850")]
	internal static string JKKOHKBHDHJ(string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B750", Offset = "0x4E39D50", VA = "0x184E3B750")]
	private BLDR IJGGHPEBFPI(string KKCCAKAEMAH, object KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M MLDFNPPIBHP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LOIIALDGJBB : DBKOIMNCEMC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EGONBCBEENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<EEBJIOCNPOE> <>t__builder;

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
		public LOIIALDGJBB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x72C5020", Offset = "0x72C3620", VA = "0x1872C5020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x72C5A50", Offset = "0x72C4050", VA = "0x1872C5A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient ONBEKOKGEPN;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x72CC3E0", Offset = "0x72CA9E0", VA = "0x1872CC3E0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void CALJOAEMNPO(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x72CC5C0", Offset = "0x72CABC0", VA = "0x1872CC5C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public LOIIALDGJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x72CC450", Offset = "0x72CAA50", VA = "0x1872CC450", Slot = "4")]
	[AsyncStateMachine(typeof(EGONBCBEENH))]
	public Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class OOLLEGIFILA : DBKOIMNCEMC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JGHICCKOKKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<EEBJIOCNPOE> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public JGHICCKOKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72C9160", Offset = "0x72C7760", VA = "0x1872C9160")]
		internal void NAIBGGMJNLM(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private struct IPKBJJJILLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<EEBJIOCNPOE> <>t__builder;

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
		private TaskAwaiter<EEBJIOCNPOE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x72C8BA0", Offset = "0x72C71A0", VA = "0x1872C8BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x72C90F0", Offset = "0x72C76F0", VA = "0x1872C90F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void BGLCLKPENLI(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OOLLEGIFILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x72CCB70", Offset = "0x72CB170", VA = "0x1872CCB70", Slot = "4")]
	[AsyncStateMachine(typeof(IPKBJJJILLE))]
	public Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BGGDEPLIDAC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EJEBOGMCFIK;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x72C1620", Offset = "0x72BFC20", VA = "0x1872C1620")]
	internal static bool GBKKLMJDFDB(string LKMGECEEGEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DBKOIMNCEMC
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEBJIOCNPOE> INNIGHKJABD(string PIBKKLOLEJD, string GKDEEIMJHJE, string AOELHHBCGDL, string ELKJHFICEJN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EEBJIOCNPOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int MENEGJBMHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string KDLJBDKMDPC;

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1445330", Offset = "0x1443930", VA = "0x181445330")]
	public EEBJIOCNPOE(int AOPCFCKPJNP, string HFLOHBLDMJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum CKEOJGLICPC
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
public class HLJCPGKDMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long BGEKIGECJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private LIIGBNJFBAA BGJAJNGKGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool DENGCBIELFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float EFCJBGBKNBH;

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x72C7D00", Offset = "0x72C6300", VA = "0x1872C7D00")]
	public HLJCPGKDMOP(string NLKJMGFMOOO, float EFCJBGBKNBH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x33EE510", Offset = "0x33ECB10", VA = "0x1833EE510")]
	public void HHDHNPBMKNK<T>(string KKCCAKAEMAH, T KBGCCIOIGBD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x72C79C0", Offset = "0x72C5FC0", VA = "0x1872C79C0")]
	public void HHDHNPBMKNK(string KKCCAKAEMAH, string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x72C7B00", Offset = "0x72C6100", VA = "0x1872C7B00")]
	public void LLBKKCFGCFM(string EFCBHOMGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x72C7A40", Offset = "0x72C6040", VA = "0x1872C7A40")]
	public void KEKDMCFDIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x72C7BF0", Offset = "0x72C61F0", VA = "0x1872C7BF0")]
	private void OFGJKOMMBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x72C7970", Offset = "0x72C5F70", VA = "0x1872C7970")]
	private bool HDJBNKBLHAE()
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
		public enum OANNIEMOBOO
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
		private OANNIEMOBOO parameterType;

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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OANNIEMOBOO Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
			get
			{
				return default(OANNIEMOBOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72CCFA0", Offset = "0x72CB5A0", VA = "0x1872CCFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EBCMOFDKENM<T> : OIDCKCMADGE<T>, AALJPNGCHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly string GKKHJGBAALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string PHJNOPPOOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private T FOAKCJPCPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly T IDJBNLNBJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool FBCJILJJNFL;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BGHCFMNFCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4048760", Offset = "0x4046D60", VA = "0x184048760")]
	public EBCMOFDKENM(CHDNBFGGGBI DIKLELHCODJ, string GKKHJGBAALN, string PHJNOPPOOGL, T IDJBNLNBJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4048540", Offset = "0x4046B40", VA = "0x184048540", Slot = "4")]
	public T KBDHOHCCAKN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x40486C0", Offset = "0x4046CC0", VA = "0x1840486C0", Slot = "6")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
public class KCAJKADIIJC : IIJAMPALPOL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OKNGOJKAEOH : IEquatable<OKNGOJKAEOH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly string DDJNILIEBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public readonly string NGNJOGCLOJN;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B2EC0", Offset = "0x9B14C0", VA = "0x1809B2EC0")]
		public OKNGOJKAEOH(string GICEEKIGHOI, string COEFLNHDFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6ADBE60", Offset = "0x6ADA460", VA = "0x186ADBE60", Slot = "4")]
		public bool Equals(OKNGOJKAEOH OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x72CCA40", Offset = "0x72CB040", VA = "0x1872CCA40", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x72CCB00", Offset = "0x72CB100", VA = "0x1872CCB00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CHDNBFGGGBI DIKLELHCODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<OKNGOJKAEOH, AALJPNGCHAL> JMLGDFMCDMI;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x72CAF00", Offset = "0x72C9500", VA = "0x1872CAF00")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x72CB230", Offset = "0x72C9830", VA = "0x1872CB230")]
	[RecRoom.NoEngine.Common.Preserve]
	public KCAJKADIIJC([System.Diagnostics.CodeAnalysis.NotNull][IBJCGEMJMJL(null)] CHDNBFGGGBI DIKLELHCODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x72CAF70", Offset = "0x72C9570", VA = "0x1872CAF70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x72CB070", Offset = "0x72C9670", VA = "0x1872CB070")]
	private void ICOJAMIIJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x72CB080", Offset = "0x72C9680", VA = "0x1872CB080")]
	private void PMJMPONEDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3497CE0", Offset = "0x34962E0", VA = "0x183497CE0", Slot = "4")]
	public OIDCKCMADGE<T> BGIICOEBEKO<T>(string GKKHJGBAALN, string HNEPLMNAGFC, T IDJBNLNBJCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal class MCKGOHFBAMM : ELDEJEIMAMA, FNPMEOKMMHG
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void IFNACIAINBG(ECDLMPFAGKE PDGKKPABECG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly OKGKFGHFJND OPLCAJEGNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly IFNACIAINBG AMAHLLDLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly string MDNNIPLIIAP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string HKEMBBKOJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1926730", Offset = "0x1924D30", VA = "0x181926730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool IHPLGLEAALA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x72CC6D0", Offset = "0x72CACD0", VA = "0x1872CC6D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LDBDMNBACFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72CC6F0", Offset = "0x72CACF0", VA = "0x1872CC6F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IReadOnlyList<string> OGDFNKLPALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1926710", Offset = "0x1924D10", VA = "0x181926710", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x72CC710", Offset = "0x72CAD10", VA = "0x1872CC710")]
	public MCKGOHFBAMM(OKGKFGHFJND HIGIOODIHPF, string JDJLOLIGKPL, [Optional] IFNACIAINBG BJIGOKGLJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3502D20", Offset = "0x3501320", VA = "0x183502D20", Slot = "8")]
	public T NPPDIJEBOHO<T>(string LKMGECEEGEE, T IDJBNLNBJCD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class DGPNNGHFCFM : CHDNBFGGGBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KFCLPNNAECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x72CB3E0", Offset = "0x72C99E0", VA = "0x1872CB3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD50", Offset = "0x72CA350", VA = "0x1872CBD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct MJPAHOFFGOE : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x72CC780", Offset = "0x72CAD80", VA = "0x1872CC780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x72CC960", Offset = "0x72CAF60", VA = "0x1872CC960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ICMOCOIBCJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x72C7E90", Offset = "0x72C6490", VA = "0x1872C7E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x72C82D0", Offset = "0x72C68D0", VA = "0x1872C82D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct FFDMNHEEDNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public DGPNNGHFCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x72C66C0", Offset = "0x72C4CC0", VA = "0x1872C66C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x72C6A80", Offset = "0x72C5080", VA = "0x1872C6A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly IReadOnlyDictionary<string, EOOAIADNMHL> DBDOMAKIAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private bool JDODMFGIFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool FCJLKLOFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private TaskCompletionSource<bool> MGMKDOOHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private TaskCompletionSource<bool> PCOCBIAIKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly SemaphoreSlim AKFKMIIGNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private IPBHPEAPBBB EBOBJMCCBON;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x72C4A70", Offset = "0x72C3070", VA = "0x1872C4A70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x72C4AB0", Offset = "0x72C30B0", VA = "0x1872C4AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB459D0", Offset = "0xB43FD0", VA = "0x180B459D0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xB45090", Offset = "0xB43690", VA = "0x180B45090", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x72C4250", Offset = "0x72C2850", VA = "0x1872C4250", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x72C3680", Offset = "0x72C1C80", VA = "0x1872C3680", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x72C4790", Offset = "0x72C2D90", VA = "0x1872C4790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x72C4920", Offset = "0x72C2F20", VA = "0x1872C4920", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x72C2EC0", Offset = "0x72C14C0", VA = "0x1872C2EC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x72C2E20", Offset = "0x72C1420", VA = "0x1872C2E20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x72C4640", Offset = "0x72C2C40", VA = "0x1872C4640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x72C3270", Offset = "0x72C1870", VA = "0x1872C3270", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x72C46E0", Offset = "0x72C2CE0", VA = "0x1872C46E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x72C49C0", Offset = "0x72C2FC0", VA = "0x1872C49C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x72C3250", Offset = "0x72C1850", VA = "0x1872C3250", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x72C4470", Offset = "0x72C2A70", VA = "0x1872C4470", Slot = "12")]
	[AsyncStateMachine(typeof(KFCLPNNAECA))]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x72C4590", Offset = "0x72C2B90", VA = "0x1872C4590", Slot = "24")]
	[AsyncStateMachine(typeof(MJPAHOFFGOE))]
	public Task JLIOHLLGMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x72C4AF0", Offset = "0x72C30F0", VA = "0x1872C4AF0", Slot = "19")]
	[AsyncStateMachine(typeof(ICMOCOIBCJI))]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x72C31B0", Offset = "0x72C17B0", VA = "0x1872C31B0")]
	private void DFGKBFAMJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x72C4140", Offset = "0x72C2740", VA = "0x1872C4140", Slot = "20")]
	[AsyncStateMachine(typeof(FFDMNHEEDNN))]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x72C4830", Offset = "0x72C2E30", VA = "0x1872C4830", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x72C34C0", Offset = "0x72C1AC0", VA = "0x1872C34C0", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x72C2F60", Offset = "0x72C1560", VA = "0x1872C2F60")]
	private OKGKFGHFJND BGCLHAJLHJJ(string JDJLOLIGKPL, bool FJOGPKKCMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x72C3310", Offset = "0x72C1910", VA = "0x1872C3310", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x72C4370", Offset = "0x72C2970", VA = "0x1872C4370")]
	private PBOMDEJLLNE HBEIJEAIPCF(string GICEEKIGHOI, bool FJOGPKKCMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x72C3860", Offset = "0x72C1E60", VA = "0x1872C3860")]
	private MMGHLBONINL FOHIBEBOKPA(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x72C36B0", Offset = "0x72C1CB0", VA = "0x1872C36B0")]
	private NLDONJHGGEC FNMIBLKMKGL(string OPOKIOPOKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x72C4260", Offset = "0x72C2860", VA = "0x1872C4260")]
	private void GFAOJHECAOH(string JDJLOLIGKPL, OKGKFGHFJND HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x72C4DA0", Offset = "0x72C33A0", VA = "0x1872C4DA0")]
	public DGPNNGHFCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x72C3170", Offset = "0x72C1770", VA = "0x1872C3170")]
	[CompilerGenerated]
	private void NMAAGDGOPKB(ECDLMPFAGKE FBIKENCMLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x72C3170", Offset = "0x72C1770", VA = "0x1872C3170")]
	[CompilerGenerated]
	private void BLHPKCPFOOI(ECDLMPFAGKE FBIKENCMLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JNMDGFBFLCI : CHDNBFGGGBI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FMIHEMFPNPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public JNMDGFBFLCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public JEPPADOHMNE userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x72C6CE0", Offset = "0x72C52E0", VA = "0x1872C6CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x72C7660", Offset = "0x72C5C60", VA = "0x1872C7660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct EJOCCDOHFMH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x72C5AC0", Offset = "0x72C40C0", VA = "0x1872C5AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DGPNNGHFCFM CNCEOJIABCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private TaskCompletionSource<bool> MGMKDOOHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private TaskCompletionSource<bool> PCOCBIAIKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Task NPMHHCGCIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Task FHJALGGBLIH;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private CHDNBFGGGBI NBIHMNBOAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x72C9E50", Offset = "0x72C8450", VA = "0x1872C9E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x72CA260", Offset = "0x72C8860", VA = "0x1872CA260", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x72C9D00", Offset = "0x72C8300", VA = "0x1872C9D00", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x72CABF0", Offset = "0x72C91F0", VA = "0x1872CABF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x72CAC90", Offset = "0x72C9290", VA = "0x1872CAC90", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x72CA240", Offset = "0x72C8840", VA = "0x1872CA240", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x72CA0E0", Offset = "0x72C86E0", VA = "0x1872CA0E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72C9D80", Offset = "0x72C8380", VA = "0x1872C9D80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x72C9C60", Offset = "0x72C8260", VA = "0x1872C9C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x72CA8E0", Offset = "0x72C8EE0", VA = "0x1872CA8E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x72CAAA0", Offset = "0x72C90A0", VA = "0x1872CAAA0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x72CA5D0", Offset = "0x72C8BD0", VA = "0x1872CA5D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x72C9EC0", Offset = "0x72C84C0", VA = "0x1872C9EC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x72CA830", Offset = "0x72C8E30", VA = "0x1872CA830", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72CAB40", Offset = "0x72C9140", VA = "0x1872CAB40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x72CAE40", Offset = "0x72C9440", VA = "0x1872CAE40")]
	[UnityEngine.Scripting.Preserve]
	public JNMDGFBFLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x72C9D10", Offset = "0x72C8310", VA = "0x1872C9D10")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x72CA380", Offset = "0x72C8980", VA = "0x1872CA380")]
	internal static void JBPADDGJIME(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x72C9E20", Offset = "0x72C8420", VA = "0x1872C9E20", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x72CA270", Offset = "0x72C8870", VA = "0x1872CA270", Slot = "12")]
	[AsyncStateMachine(typeof(FMIHEMFPNPG))]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x72CAD30", Offset = "0x72C9330", VA = "0x1872CAD30", Slot = "19")]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72CA120", Offset = "0x72C8720", VA = "0x1872CA120", Slot = "20")]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72CA980", Offset = "0x72C8F80", VA = "0x1872CA980", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72CA020", Offset = "0x72C8620", VA = "0x1872CA020", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72C9F60", Offset = "0x72C8560", VA = "0x1872C9F60", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x72CA4C0", Offset = "0x72C8AC0", VA = "0x1872CA4C0", Slot = "24")]
	public Task JLIOHLLGMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x72CA6B0", Offset = "0x72C8CB0", VA = "0x1872CA6B0")]
	private static void MFDFODOLKAO(TaskCompletionSource<bool> KDHLGIELGNK, Task AJKKKJPOLGN, Task MHLDMFINCIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x72CA3F0", Offset = "0x72C89F0", VA = "0x1872CA3F0")]
	[AsyncStateMachine(typeof(EJOCCDOHFMH))]
	private static void JKGNIGGOJJK(Task CBPINBDBDCO, TaskCompletionSource<bool> KDHLGIELGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xCFBCA0", Offset = "0xCFA2A0", VA = "0x180CFBCA0")]
	[CompilerGenerated]
	private void MEBMKJJJMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0xD551C0", Offset = "0xD537C0", VA = "0x180D551C0")]
	[CompilerGenerated]
	private void OGIBFKBBOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xB71380", Offset = "0xB6F980", VA = "0x180B71380")]
	[CompilerGenerated]
	private void LNEDCGFKFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x72CA670", Offset = "0x72C8C70", VA = "0x1872CA670")]
	[CompilerGenerated]
	private void LNHDKFLINLC(ECDLMPFAGKE FBIKENCMLKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal class LGEKGFOGLKJ : EDOBDFIPKNK, FNPMEOKMMHG
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate void DNNIIAMKCOD(ECDLMPFAGKE PDGKKPABECG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly DNNIIAMKCOD AMAHLLDLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly PBOMDEJLLNE NEEJKDEDHPL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string HKEMBBKOJKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xC9CAD0", Offset = "0xC9B0D0", VA = "0x180C9CAD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xD92610", Offset = "0xD90C10", VA = "0x180D92610")]
	public LGEKGFOGLKJ(PBOMDEJLLNE GKKHJGBAALN, [Optional] DNNIIAMKCOD BJIGOKGLJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x34C9170", Offset = "0x34C7770", VA = "0x1834C9170", Slot = "5")]
	public T NPPDIJEBOHO<T>(string LKMGECEEGEE, T IDJBNLNBJCD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IHKILNDGGHI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[UsedImplicitly]
public class BJCBGNDNHKK : IHKILNDGGHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly AHHIBBAIEPC EBBMEKOBJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly List<HPFFGCNAFME> PNBDCICEDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly string ILNOHDILPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string HLMEDGNEBBE;

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x72C17D0", Offset = "0x72BFDD0", VA = "0x1872C17D0")]
	[UsedImplicitly]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void HBMGFBHOMDP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x72C1840", Offset = "0x72BFE40", VA = "0x1872C1840")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BJCBGNDNHKK([IBJCGEMJMJL(null)][JetBrains.Annotations.NotNull] AHHIBBAIEPC EBBMEKOBJAL, [IBJCGEMJMJL(null)][JetBrains.Annotations.NotNull] IFMJIDCGCLC LJMNLKENKGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FANFLDFAIDN : CHDNBFGGGBI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Task NMNAHMFGEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x72C6510", Offset = "0x72C4B10", VA = "0x1872C6510", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Task FBCFFFFIENH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x72C65A0", Offset = "0x72C4BA0", VA = "0x1872C65A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HLBAPFPPFNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GGMMNIKGNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string BAMGPKONIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GJEABAFLEFD CGAHNJILCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action KIKAHCLAMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72C5DA0", Offset = "0x72C43A0", VA = "0x1872C5DA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72C5D00", Offset = "0x72C4300", VA = "0x1872C5D00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action GIJELINNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x72C6320", Offset = "0x72C4920", VA = "0x1872C6320", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x72C63C0", Offset = "0x72C49C0", VA = "0x1872C63C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action BFMIDNLNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x72C61D0", Offset = "0x72C47D0", VA = "0x1872C61D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x72C5E40", Offset = "0x72C4440", VA = "0x1872C5E40", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<ECDLMPFAGKE> LMCIIMGNACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x72C6270", Offset = "0x72C4870", VA = "0x1872C6270", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x72C6460", Offset = "0x72C4A60", VA = "0x1872C6460", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FANFLDFAIDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72C60B0", Offset = "0x72C46B0", VA = "0x1872C60B0", Slot = "12")]
	public Task HPHCPPKCEKM(string OPOKIOPOKBE, [Optional] JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x72C6630", Offset = "0x72C4C30", VA = "0x1872C6630", Slot = "19")]
	public Task POBCLMOILMG(JEPPADOHMNE AGOFGEFAJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x72C6020", Offset = "0x72C4620", VA = "0x1872C6020", Slot = "20")]
	public Task GAHHFBNPFPK(JEPPADOHMNE AGOFGEFAJDM, Dictionary<string, string> GDLLGFFMPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "21")]
	public bool NGGEOBINKCB(string FNBHEIHNCOL, bool FJOGPKKCMDC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x72C5F70", Offset = "0x72C4570", VA = "0x1872C5F70", Slot = "22")]
	public ELDEJEIMAMA FHCKJNCCMCG(string JDJLOLIGKPL, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x72C5EE0", Offset = "0x72C44E0", VA = "0x1872C5EE0", Slot = "23")]
	public EDOBDFIPKNK FFBMDHNLDIK(string GICEEKIGHOI, bool FJOGPKKCMDC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x72C6140", Offset = "0x72C4740", VA = "0x1872C6140", Slot = "24")]
	public Task JLIOHLLGMND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class IPBHPEAPBBB : GJEABAFLEFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly MMGHLBONINL OHGPLAOENJA;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IReadOnlyDictionary<string, object> DAANDHOFMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xC93660", Offset = "0xC91C60", VA = "0x180C93660", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x958BA0", Offset = "0x9571A0", VA = "0x180958BA0")]
	public IPBHPEAPBBB(MMGHLBONINL GBIDKKGJIIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface KCGPGKIBMPE
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLJCPGKDMOP ILAEMIICJOL(string NLKJMGFMOOO);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface AKPEKCLMGOC
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JIDBKLJICEH
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

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long GIOILMPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string GFAMGBCLJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string HGJABGKCKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CBALJHFLJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long PPKKMDMKDMF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPHOHJBOGOP(long JKHDHJCLOPL, bool IDNIBGLEFJO = true);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IOBPEBMKDBH(string BPPCEJGCMKA, string PAKCJCEHNIE, string LCLGMIAMOOG);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBDOLAFKDBE(string BPPCEJGCMKA);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ODPFOJJHIKG(string BPPCEJGCMKA, string CBELMNGFMOM, string KNFKEHFIINA);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FGMOHIIHGCM(string BPDGMLOBIKL, object EPFPJPNDGFM, object JIFCGPEGHHA);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DAFNGCNFOMC(JIDBKLJICEH KPGDKMCLGLI, int IAKJCHAJGGI, [Optional] DODDCJEJIJO LBGNNMKOLFI, [Optional] string MBBMFJLOHJL, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MAOKPDJHGHO(DODDCJEJIJO LBGNNMKOLFI, long EKHGBODBJDL, long OPMJALDBIEP, int OIKCKMHNIIJ, string MBBMFJLOHJL, int IAKJCHAJGGI);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void POJKGDCCAAH(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JDOABNKABNL(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIGLACPCFIG(DODDCJEJIJO LBGNNMKOLFI, bool JHGFMOPHGIB, [Optional] string IFMHONGNKHP);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DDLHJMGJNFH(long FFFLOIOFAMB, string JPAOAPOJHJC);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface COINPGOHHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string PEEDGMBEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
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
