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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EA2D20", Offset = "0x5EA1720", VA = "0x185EA2D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA5A0", Offset = "0x7B8FA0", VA = "0x1807BA5A0")]
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
		public AmplitudeAnalyticsClient.Settings EKFLNKCAGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MJNPAGLGKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x799120", Offset = "0x797B20", VA = "0x180799120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private enum BJMMABCOGDI
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		internal class ONHDIGDOEOA
		{
			[Cpp2IlInjected.Token(Token = "0x2000009")]
			private class GKCAJLHCNEJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				public int GCALAFJKGFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				public Dictionary<string, object> BNJLBHKHHBG;

				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
				public GKCAJLHCNEJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class CFABMLFPLBA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
				public CFABMLFPLBA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x5E9FB40", Offset = "0x5E9E540", VA = "0x185E9FB40")]
				internal bool FIPECDGMFNK(GKCAJLHCNEJ item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private const string GPGPCPODNCF = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private readonly string FFGOGGNCCME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private List<GKCAJLHCNEJ> JIOACELODAG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? JPFKBPGEEEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5EA40F0", Offset = "0x5EA2AF0", VA = "0x185EA40F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5EA50F0", Offset = "0x5EA3AF0", VA = "0x185EA50F0")]
			internal ONHDIGDOEOA(string PGLPIOEIJHF, string GLOMEFKCEGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3F40", Offset = "0x5EA2940", VA = "0x185EA3F40")]
			public int CCHACHDHIEE([Optional] int? FFNOEPCJLAK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4190", Offset = "0x5EA2B90", VA = "0x185EA4190")]
			public List<Dictionary<string, object>> CGHLJOBEIKJ(int ODOKGIKKFIE, int? FFNOEPCJLAK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4640", Offset = "0x5EA3040", VA = "0x185EA4640")]
			public void JEPEPMDBBFA(AmplitudeAnalyticsIdentifyMessage GKNPKJAGNGH, bool MKDBCDJNPOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA46E0", Offset = "0x5EA30E0", VA = "0x185EA46E0")]
			public void JEPEPMDBBFA(Dictionary<string, object> GKNPKJAGNGH, bool MKDBCDJNPOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4F60", Offset = "0x5EA3960", VA = "0x185EA4F60")]
			public void MBPCANDDELA(params Dictionary<string, object>[] KLDHDIEMLJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4BE0", Offset = "0x5EA35E0", VA = "0x185EA4BE0")]
			public void KCGELHHOFLC(List<Dictionary<string, object>> DMPFNAFNENH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3E30", Offset = "0x5EA2830", VA = "0x185EA3E30")]
			private void AFMHIPFACEE(Dictionary<string, object> GKNPKJAGNGH, bool MKDBCDJNPOC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4400", Offset = "0x5EA2E00", VA = "0x185EA4400")]
			public void EDMFDGELEKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5EA47F0", Offset = "0x5EA31F0", VA = "0x185EA47F0")]
			private void JNDHNNPIOHB([Optional] string JGLDCDPHJOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4E30", Offset = "0x5EA3830", VA = "0x185EA4E30")]
			private static string MBFFPJKLLCL(string BEEGCHJLJFC, string FHLJKJHFEEK)
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
			[Cpp2IlInjected.Address(RVA = "0x5EA7260", Offset = "0x5EA5C60", VA = "0x185EA7260")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct BOPEAGLEJCP<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int DJLDJHNFOAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string BBFNFKMLKHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public T GBGKIIJKDIH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FBPLCAACCOH : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public FBPLCAACCOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1780", Offset = "0x5EA0180", VA = "0x185EA1780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1F40", Offset = "0x5EA0940", VA = "0x185EA1F40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GMABIHCHCMJ : IEnumerator<object>, IEnumerator, IDisposable
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
			public JGJGMCLOHKB quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public GMABIHCHCMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2900", Offset = "0x5EA1300", VA = "0x185EA2900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2A10", Offset = "0x5EA1410", VA = "0x185EA2A10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IMFGMBHPHOH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public IMFGMBHPHOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2A60", Offset = "0x5EA1460", VA = "0x185EA2A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2BD0", Offset = "0x5EA15D0", VA = "0x185EA2BD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OBLAGONMGDI : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public OBLAGONMGDI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2DA0", Offset = "0x5EA17A0", VA = "0x185EA2DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3020", Offset = "0x5EA1A20", VA = "0x185EA3020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class FCMANAGFIBL : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public FCMANAGFIBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1F90", Offset = "0x5EA0990", VA = "0x185EA1F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2220", Offset = "0x5EA0C20", VA = "0x185EA2220", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CAPODOJLENG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public ONHDIGDOEOA cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public CAPODOJLENG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E9D0", Offset = "0x5E9D3D0", VA = "0x185E9E9D0")]
			internal void KFEEHOELFBL(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E580", Offset = "0x5E9CF80", VA = "0x185E9E580")]
			internal void FGIGAHCEHPG(BOPEAGLEJCP<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OJPECABBLHF : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ONHDIGDOEOA cache;

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
			private CAPODOJLENG <>8__1;

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
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public OJPECABBLHF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3590", Offset = "0x5EA1F90", VA = "0x185EA3590", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3DE0", Offset = "0x5EA27E0", VA = "0x185EA3DE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HLHBDKJNLPA<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public HLHBDKJNLPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x373F130", Offset = "0x373DB30", VA = "0x18373F130")]
			internal BOPEAGLEJCP<T> LMIFPLGJJPM(HACDAPPKKKD postResponse)
			{
				return default(BOPEAGLEJCP<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OAKAMLKALJO<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public OAKAMLKALJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x373F130", Offset = "0x373DB30", VA = "0x18373F130")]
			internal BOPEAGLEJCP<T> HPKGBBJFACK(HACDAPPKKKD postResponse)
			{
				return default(BOPEAGLEJCP<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private BHHNAJCLLBA CONHGLEMMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<IKBCEDDLMJI> PLNPFHNOAEL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string CLPMFNPMLKE = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string NFGIIMHFFMB = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string KFCECBBCBKF = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int IILIJOOKIOK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int AGGHGABMPJD = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int FMCGCNDIBNK = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float LHBMPKDEKGJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long NDFGAIBDHLH = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string NIOKICJHOAP = "f1779b982f1c09aed3adb3cca563cbc2";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string NBDBHHJPMEP = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static bool BBNKHAHDCGI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CFIIOOMIDOE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static int JJBBOMKLNPD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static int GJPABCCAJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CDBLMBNNGFF PCKEICEKELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BDCKECENIPO AFPLJCEGIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IAEJLIPIODJ KMONDNANKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BJLEEMNFFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float DNPNDOEKNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float FLICNJIBGHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int JGGBCPBPECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int AHNJBCAPBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int? ONEFDOBKOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int? IJPLPADDILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private long IOLHIJIMGAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private string IBONLELFLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool JDOCKHIBFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private long HDJDLBIKHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string FGBFPNACNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private string NKJKMIHHCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> CFMPNLKLOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BJMMABCOGDI KJMFBJCAJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int IOMENNNFKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int OKABBPCJOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float MLNDKMHKJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private bool FGHCKPPPDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool DLLGKLNGEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private ONHDIGDOEOA HKOFNLEJANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ONHDIGDOEOA NIIGMNNGPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private ONHDIGDOEOA HOGBHPKPDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> JCFACGGLAKD;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo KCHBBFPMHBG;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static string ILNKALBDGLO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const string OEOBFANIEKF = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly string LNBAMEHLAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly string GECDJCELLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly string MKIFMDCJFNO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BHHNAJCLLBA EMGDAGNJOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B020", Offset = "0x5E99A20", VA = "0x185E9B020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private IKBCEDDLMJI AOCEIPBMHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5E98D10", Offset = "0x5E97710", VA = "0x185E98D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CDMGOAMCKGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5E981A0", Offset = "0x5E96BA0", VA = "0x185E981A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long LHEGNPMKGII
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CA30", Offset = "0x5E9B430", VA = "0x185E9CA30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CB50", Offset = "0x5E9B550", VA = "0x185E9CB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string MGKGEIFBHDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C9D0", Offset = "0x5E9B3D0", VA = "0x185E9C9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JGJKKKFHJOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CA00", Offset = "0x5E9B400", VA = "0x185E9CA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PJBNLIILOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x863210", Offset = "0x861C10", VA = "0x180863210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8631E0", Offset = "0x861BE0", VA = "0x1808631E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? BJHGHJELKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x995EA0", Offset = "0x9948A0", VA = "0x180995EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CB40", Offset = "0x5E9B540", VA = "0x185E9CB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LBPNNDJDNEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF10C10", Offset = "0xF0F610", VA = "0x180F10C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF103C0", Offset = "0xF0EDC0", VA = "0x180F103C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LAFEJIKJFHL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C8D0", Offset = "0x5E9B2D0", VA = "0x185E9C8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> HGEFDCGKAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C810", Offset = "0x5E9B210", VA = "0x185E9C810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9CA80", Offset = "0x5E9B480", VA = "0x185E9CA80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E97B80", Offset = "0x5E96580", VA = "0x185E97B80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E972A0", Offset = "0x5E95CA0", VA = "0x185E972A0")]
		private void AIIIDELPMMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BDF0", Offset = "0x5E9A7F0", VA = "0x185E9BDF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AF60", Offset = "0x5E99960", VA = "0x185E9AF60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C190", Offset = "0x5E9AB90", VA = "0x185E9C190")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B090", Offset = "0x5E99A90", VA = "0x185E9B090")]
		public GOACJHIODHI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E991F0", Offset = "0x5E97BF0", VA = "0x185E991F0")]
		[IteratorStateMachine(typeof(FBPLCAACCOH))]
		public IEnumerator<KMDFFEOBLOI> Initialize(AmplitudeAnalyticsEvent BOOHNPCHFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C0D0", Offset = "0x5E9AAD0", VA = "0x185E9C0D0")]
		public void UpdateLastKnownInteractionCategory(string JOAIPDMCIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BFE0", Offset = "0x5E9A9E0", VA = "0x185E9BFE0")]
		public void UpdateLastAliveTime(float HNNKCGDCJIJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E99F50", Offset = "0x5E98950", VA = "0x185E99F50")]
		private GOACJHIODHI JOEHAAGLJBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC70", Offset = "0x5E99670", VA = "0x185E9AC70")]
		private GOACJHIODHI OAMCPDNIKKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B840", Offset = "0x5E9A240", VA = "0x185E9B840")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A010", Offset = "0x5E98A10", VA = "0x185E9A010")]
		[IteratorStateMachine(typeof(GMABIHCHCMJ))]
		private IEnumerator KJKDMHHFPJI(JGJGMCLOHKB OLBGJIJMLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C420", Offset = "0x5E9AE20", VA = "0x185E9C420")]
		[IteratorStateMachine(typeof(IMFGMBHPHOH))]
		public IEnumerator WaitForFlush(float CEEPHBKGJCK = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BEC0", Offset = "0x5E9A8C0", VA = "0x185E9BEC0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BE00", Offset = "0x5E9A800", VA = "0x185E9BE00")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime AFJGHIJFDOD)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E98D60", Offset = "0x5E97760", VA = "0x185E98D60")]
		public static NGEOAPFHAFK Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E97A10", Offset = "0x5E96410", VA = "0x185E97A10")]
		public static BFKHJEFPCMM AccountSelectionPostLoginEvent([NotNull] string CGMICKGLNOA, string CECOAMKIDGD, bool LLJIPCGABMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E98980", Offset = "0x5E97380", VA = "0x185E98980")]
		public static BFKHJEFPCMM Event([NotNull] string CGMICKGLNOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B0D0", Offset = "0x5E99AD0", VA = "0x185E9B0D0")]
		public static BFKHJEFPCMM PreviousSessionEvent([NotNull] string CGMICKGLNOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E98F10", Offset = "0x5E97910", VA = "0x185E98F10")]
		public static BFKHJEFPCMM InitializeEvent(string CECOAMKIDGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA00", Offset = "0x5E9A400", VA = "0x185E9BA00")]
		public static BFKHJEFPCMM StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E98510", Offset = "0x5E96F10", VA = "0x185E98510")]
		public static BFKHJEFPCMM CreateOutOfSessionEvent(string CGMICKGLNOA, bool NJIALGAGPLK = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A410", Offset = "0x5E98E10", VA = "0x185E9A410")]
		public static GOACJHIODHI LogOutOfSessionEvent(BFKHJEFPCMM MKPLOKDIOBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A190", Offset = "0x5E98B90", VA = "0x185E9A190")]
		public void LogEventAsync(AmplitudeAnalyticsEvent MMCBEFBIHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A700", Offset = "0x5E99100", VA = "0x185E9A700")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent MMCBEFBIHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A840", Offset = "0x5E99240", VA = "0x185E9A840")]
		public void LogSerializedEventAsync(Dictionary<string, object> IHJMFBKNPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A2D0", Offset = "0x5E98CD0", VA = "0x185E9A2D0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage CCMLAOENPHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E98880", Offset = "0x5E97280", VA = "0x185E98880")]
		private void EJBMCLBBMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A9C0", Offset = "0x5E993C0", VA = "0x185E9A9C0")]
		private void NGLOJKHJBDD(Dictionary<string, object> ICMMCMPKPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A0A0", Offset = "0x5E98AA0", VA = "0x185E9A0A0")]
		private void LLCFCEDLOOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E97840", Offset = "0x5E96240", VA = "0x185E97840")]
		private void AJAKOBEPCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E98C80", Offset = "0x5E97680", VA = "0x185E98C80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A920", Offset = "0x5E99320", VA = "0x185E9A920")]
		[IteratorStateMachine(typeof(OBLAGONMGDI))]
		private IEnumerator<KMDFFEOBLOI> MCAHNEDDFEH(float CEEPHBKGJCK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E98380", Offset = "0x5E96D80", VA = "0x185E98380")]
		[IteratorStateMachine(typeof(FCMANAGFIBL))]
		private IEnumerator<KMDFFEOBLOI> CEHGKDOJLJH(float CEEPHBKGJCK = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5E98410", Offset = "0x5E96E10", VA = "0x185E98410")]
		[IteratorStateMachine(typeof(OJPECABBLHF))]
		private IEnumerator<KMDFFEOBLOI> CIOEFEOIBMI(ONHDIGDOEOA JOHPOAIIMHB, int? FFNOEPCJLAK, string FPALOBDLIFN, string CAAJJPNNDFJ, float CEEPHBKGJCK, Action<int> IJEMLELFJCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5E98770", Offset = "0x5E97170", VA = "0x185E98770")]
		private static void EEFKJGJCEIA(bool CMDCIPBCNIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E96E90", Offset = "0x5E95890", VA = "0x185E96E90")]
		private HECHONBOMGO<BOPEAGLEJCP<Dictionary<string, object>>> ADDBFKIGEHM(string FPALOBDLIFN, string CAAJJPNNDFJ, string AEEAOLJFJLP, string JAPCFGBPPHC, Dictionary<string, object> GBGKIIJKDIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E96FC0", Offset = "0x5E959C0", VA = "0x185E96FC0")]
		private HECHONBOMGO<BOPEAGLEJCP<List<Dictionary<string, object>>>> ADDBFKIGEHM(string FPALOBDLIFN, string CAAJJPNNDFJ, string AEEAOLJFJLP, string JAPCFGBPPHC, List<Dictionary<string, object>> GBGKIIJKDIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C080", Offset = "0x2C6AA80", VA = "0x182C6C080")]
		private HECHONBOMGO<BOPEAGLEJCP<T>> GKPLPKLPFCB<T>(string FPALOBDLIFN, string CAAJJPNNDFJ, string JAPCFGBPPHC, T GBGKIIJKDIH, Dictionary<string, object> LHAGPEBKNKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2C6C340", Offset = "0x2C6AD40", VA = "0x182C6C340")]
		private HECHONBOMGO<BOPEAGLEJCP<T>> OMBILBLIFNB<T>(string FPALOBDLIFN, string CAAJJPNNDFJ, string AEEAOLJFJLP, T GBGKIIJKDIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E98150", Offset = "0x5E96B50", VA = "0x185E98150")]
		private bool BHBKNNADDJH(float BKCFGHIDDBA, float CEEPHBKGJCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E99280", Offset = "0x5E97C80", VA = "0x185E99280")]
		private Dictionary<string, object> JLLKFFPDGMP(string CAAJJPNNDFJ, Dictionary<string, object> GBGKIIJKDIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C510", Offset = "0x5E9AF10", VA = "0x185E9C510")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E97FF0", Offset = "0x5E969F0", VA = "0x185E97FF0")]
		[CompilerGenerated]
		private long BALBIPAEKCI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A9B0", Offset = "0x5E993B0", VA = "0x185E9A9B0")]
		[CompilerGenerated]
		private void NCLAFNKIJGH(int BJEJAEMKBKP)
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
			[Cpp2IlInjected.Address(RVA = "0x5E9D8B0", Offset = "0x5E9C2B0", VA = "0x185E9D8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D990", Offset = "0x5E9C390", VA = "0x185E9D990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D8F0", Offset = "0x5E9C2F0", VA = "0x185E9D8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D9F0", Offset = "0x5E9C3F0", VA = "0x185E9D9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D870", Offset = "0x5E9C270", VA = "0x185E9D870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D930", Offset = "0x5E9C330", VA = "0x185E9D930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x791C70", Offset = "0x790670", VA = "0x180791C70")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CBB0", Offset = "0x5E9B5B0", VA = "0x185E9CBB0")]
		public static BFKHJEFPCMM CMMJGECCMDN(string BKOLDLDNEOO, [NotNull] string NKPOFBALEFL, long CGALJLIIABC, long IOLEBGJKNIJ, string CECOAMKIDGD, bool LLJIPCGABMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D470", Offset = "0x5E9BE70", VA = "0x185E9D470")]
		public static BFKHJEFPCMM JHNHAAPHDAP(string BKOLDLDNEOO, [NotNull] string NKPOFBALEFL, long CGALJLIIABC, long IOLEBGJKNIJ, string CECOAMKIDGD, long FEJMLHGDIOE, bool LLJIPCGABMP, string PMKLKNGMEDL, string COACNJDCLDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D6E0", Offset = "0x5E9C0E0", VA = "0x185E9D6E0")]
		private AmplitudeAnalyticsEvent(string BKOLDLDNEOO, [NotNull] string NKPOFBALEFL, long CGALJLIIABC, long IOLEBGJKNIJ, string CECOAMKIDGD, bool LLJIPCGABMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19A30F0", Offset = "0x19A1AF0", VA = "0x1819A30F0")]
		public void DBKNHOILKEA(long NGFEHMNLIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CCB0", Offset = "0x5E9B6B0", VA = "0x185E9CCB0", Slot = "5")]
		public override void EMPKGKJLIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D2F0", Offset = "0x5E9BCF0", VA = "0x185E9D2F0", Slot = "6")]
		public override void JHFNKBOAPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CDC0", Offset = "0x5E9B7C0", VA = "0x185E9CDC0", Slot = "4")]
		protected override Dictionary<string, object> HDIGNNEDCOB(Dictionary<string, object> MKHPMPEPKJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D5D0", Offset = "0x5E9BFD0", VA = "0x185E9D5D0")]
		private void OGLOBCIIHKE(string FHLJKJHFEEK, string BEEGCHJLJFC, bool HDBFPPPKEEJ = false)
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
			[Cpp2IlInjected.Address(RVA = "0x5EA0B40", Offset = "0x5E9F540", VA = "0x185EA0B40")]
			public void OCENPIGMNMH(Dictionary<string, object> CEAOENGMFGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EA6EF0", Offset = "0x5EA58F0", VA = "0x185EA6EF0")]
			public void OCENPIGMNMH(Dictionary<string, object> AIPFBMILMEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8A10A0", Offset = "0x89FAA0", VA = "0x1808A10A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DA50", Offset = "0x5E9C450", VA = "0x185E9DA50")]
		public static NGEOAPFHAFK CMMJGECCMDN(string BKOLDLDNEOO, string CECOAMKIDGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E110", Offset = "0x5E9CB10", VA = "0x185E9E110")]
		protected AmplitudeAnalyticsIdentifyMessage(string BKOLDLDNEOO, string CECOAMKIDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E080", Offset = "0x5E9CA80", VA = "0x185E9E080")]
		public Dictionary<string, object> PIOICLGDLJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DC10", Offset = "0x5E9C610", VA = "0x185E9DC10", Slot = "4")]
		protected virtual Dictionary<string, object> HDIGNNEDCOB(Dictionary<string, object> MKHPMPEPKJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DFE0", Offset = "0x5E9C9E0", VA = "0x185E9DFE0")]
		protected void MLDCBOHDJFD(string FHLJKJHFEEK, Dictionary<string, object> ECDFOBIODGE, Dictionary<string, object> FHNFMGIGFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DBA0", Offset = "0x5E9C5A0", VA = "0x185E9DBA0")]
		protected void FDNELEDIMPG(string FHLJKJHFEEK, string BEEGCHJLJFC, Dictionary<string, object> LODKINBFLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DB10", Offset = "0x5E9C510", VA = "0x185E9DB10", Slot = "5")]
		public virtual void EMPKGKJLIEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DF50", Offset = "0x5E9C950", VA = "0x185E9DF50", Slot = "6")]
		public virtual void JHFNKBOAPKH()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NGEOAPFHAFK : BNFLNLHJGGN<AmplitudeAnalyticsIdentifyMessage, NGEOAPFHAFK>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override NGEOAPFHAFK JCMDFABEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage LBCFCALPANH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2CD0", Offset = "0x5EA16D0", VA = "0x185EA2CD0")]
	public NGEOAPFHAFK(AmplitudeAnalyticsIdentifyMessage BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2C20", Offset = "0x5EA1620", VA = "0x185EA2C20", Slot = "4")]
	public override void JHFNKBOAPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BFKHJEFPCMM : BNFLNLHJGGN<AmplitudeAnalyticsEvent, BFKHJEFPCMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool JBKEFIPDBDK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override BFKHJEFPCMM JCMDFABEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870DD0", VA = "0x1808723D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long AMJGOCIIOMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FC30", Offset = "0x1E6E630", VA = "0x181E6FC30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E530", Offset = "0x5E9CF30", VA = "0x185E9E530")]
	public BFKHJEFPCMM(AmplitudeAnalyticsEvent BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "5")]
	public override AmplitudeAnalyticsEvent LBCFCALPANH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E2F0", Offset = "0x5E9CCF0", VA = "0x185E9E2F0", Slot = "4")]
	public override void JHFNKBOAPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x23BC050", Offset = "0x23BAA50", VA = "0x1823BC050")]
	public BFKHJEFPCMM BCKNEAHEIEP<T>(string NPDAMELJOLL, T[] BEEGCHJLJFC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23BC050", Offset = "0x23BAA50", VA = "0x1823BC050")]
	public BFKHJEFPCMM BCKNEAHEIEP(string NPDAMELJOLL, string[] BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x23BBDA0", Offset = "0x23BA7A0", VA = "0x1823BBDA0")]
	public BFKHJEFPCMM BCKNEAHEIEP<T>(string NPDAMELJOLL, T BEEGCHJLJFC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E200", Offset = "0x5E9CC00", VA = "0x185E9E200")]
	public BFKHJEFPCMM BCKNEAHEIEP(string NPDAMELJOLL, long BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E280", Offset = "0x5E9CC80", VA = "0x185E9E280")]
	public BFKHJEFPCMM BCKNEAHEIEP(string NPDAMELJOLL, string BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E1D0", Offset = "0x5E9CBD0", VA = "0x185E9E1D0")]
	public BFKHJEFPCMM ADHIPCOMOFK(string NPDAMELJOLL, object? BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E390", Offset = "0x5E9CD90", VA = "0x185E9E390")]
	public BFKHJEFPCMM PHMPPNDNIHI(string NPDAMELJOLL, string BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E430", Offset = "0x5E9CE30", VA = "0x185E9E430")]
	private BFKHJEFPCMM PMNJJHBGJPK(string NPDAMELJOLL, object BEEGCHJLJFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FDHNBBBLEBH : BFKHJEFPCMM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E530", Offset = "0x5E9CF30", VA = "0x185E9E530")]
	public FDHNBBBLEBH(AmplitudeAnalyticsEvent BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2270", Offset = "0x5EA0C70", VA = "0x185EA2270", Slot = "4")]
	public override void JHFNKBOAPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class BNFLNLHJGGN<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : BNFLNLHJGGN<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	protected M BKNCBJIACBJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR JCMDFABEAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public BNFLNLHJGGN(M BKNCBJIACBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x48FC2B0", Offset = "0x48FACB0", VA = "0x1848FC2B0")]
	public BLDR OOGFCGMCEDO(AmplitudeAnalyticsIdentifyMessage.DeviceInfo FFJAMJNICPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x48FC260", Offset = "0x48FAC60", VA = "0x1848FC260")]
	public BLDR IJDGPADCPJE(AmplitudeAnalyticsIdentifyMessage.RevenueData ABDABELHDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x48FC1E0", Offset = "0x48FABE0", VA = "0x1848FC1E0")]
	public BLDR EGCNEEEBFAP(string NPDAMELJOLL, string BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F148E0", Offset = "0x2F132E0", VA = "0x182F148E0")]
	public BLDR EGCNEEEBFAP<T>(string NPDAMELJOLL, T BEEGCHJLJFC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JHFNKBOAPKH();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x48FC1B0", Offset = "0x48FABB0", VA = "0x1848FC1B0")]
	internal static string CEHLLPDHOBA(string BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x48FC0B0", Offset = "0x48FAAB0", VA = "0x1848FC0B0")]
	private BLDR AONBPIMKFEA(string NPDAMELJOLL, object BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M LBCFCALPANH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class CBGKFNNJKIJ : CDBLMBNNGFF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct EHFKDLNAPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<HACDAPPKKKD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool skipLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Dictionary<string, string> formData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CBGKFNNJKIJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5EA0CC0", Offset = "0x5E9F6C0", VA = "0x185EA0CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1560", Offset = "0x5E9FF60", VA = "0x185EA1560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CCHLDCBIHEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<HACDAPPKKKD> <>t__builder;

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
		public CBGKFNNJKIJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5E9F0A0", Offset = "0x5E9DAA0", VA = "0x185E9F0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FAD0", Offset = "0x5E9E4D0", VA = "0x185E9FAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private HttpClient HMIDFCCAPOJ;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EFB0", Offset = "0x5E9D9B0", VA = "0x185E9EFB0")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	private static void PEIPPNHMLBG(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F020", Offset = "0x5E9DA20", VA = "0x185E9F020")]
	[RecRoom.NoEngine.Common.Preserve]
	public CBGKFNNJKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ECF0", Offset = "0x5E9D6F0", VA = "0x185E9ECF0", Slot = "4")]
	[AsyncStateMachine(typeof(EHFKDLNAPDG))]
	public Task<HACDAPPKKKD> ADDBFKIGEHM(string FPALOBDLIFN, Dictionary<string, string> DJLKMEOEMBA, bool HAGCBOBAAFO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EE40", Offset = "0x5E9D840", VA = "0x185E9EE40", Slot = "5")]
	[AsyncStateMachine(typeof(CCHLDCBIHEB))]
	public Task<HACDAPPKKKD> FJNJAELAFFE(string FPALOBDLIFN, string NBBHMMNDCEM, string LAHMKOHEJOI, string MAKGPIACJFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FBOMACGKLKI
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> JEMIFAHBIIO;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA15D0", Offset = "0x5E9FFD0", VA = "0x185EA15D0")]
	internal static bool NDALOLJDBAC(string FHLJKJHFEEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CDBLMBNNGFF
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HACDAPPKKKD> ADDBFKIGEHM(string FPALOBDLIFN, Dictionary<string, string> DJLKMEOEMBA, bool HAGCBOBAAFO = false);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HACDAPPKKKD> FJNJAELAFFE(string FPALOBDLIFN, string NBBHMMNDCEM, string LAHMKOHEJOI, string MAKGPIACJFN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HACDAPPKKKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly int PAMFNDBOGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly string OICLIMMJMFF;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0xB9F900", Offset = "0xB9E300", VA = "0x180B9F900")]
	public HACDAPPKKKD(int DJLDJHNFOAA, string BBFNFKMLKHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum ILMIPAIGENC
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
public class ODNGOOMHAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private long PHHOFNKGGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private BFKHJEFPCMM EKCMGLKKCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool IDDCGPDLMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float LJJABMJICLO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3400", Offset = "0x5EA1E00", VA = "0x185EA3400")]
	public ODNGOOMHAGF(string BPOOKKAKCNL, float LJJABMJICLO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x276C960", Offset = "0x276B360", VA = "0x18276C960")]
	public void BCKNEAHEIEP<T>(string NPDAMELJOLL, T BEEGCHJLJFC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3070", Offset = "0x5EA1A70", VA = "0x185EA3070")]
	public void BCKNEAHEIEP(string NPDAMELJOLL, string BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3200", Offset = "0x5EA1C00", VA = "0x185EA3200")]
	public void LIEPKFBBHMK(string DHOIFIDEKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3340", Offset = "0x5EA1D40", VA = "0x185EA3340")]
	public void PNNBPHNEENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA30F0", Offset = "0x5EA1AF0", VA = "0x185EA30F0")]
	private void IPALCCPEGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA32F0", Offset = "0x5EA1CF0", VA = "0x185EA32F0")]
	private bool MOOEODEDONL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PHNKKHEMGLI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	string PJBNLIILOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	HFIANIHBGFA KGBPLHPHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action AIJGMGJEIFA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MLBKNNDGPLJ;

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GOACJHIODHI IAMMEFBKIFH(string FLDHGLBOFEJ, string GLOMEFKCEGO, [Optional] BDCKECENIPO KAPEMEGKCFG);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GOACJHIODHI ODCOOPCILAA(BDCKECENIPO KAPEMEGKCFG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GOACJHIODHI IEEEMNAOCJH(BDCKECENIPO KAPEMEGKCFG, Dictionary<string, string> NFPHFONJEIE);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EPHDPEGPLKE(string MAFNHGMOFEP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ILGBHEANFAK BJPNENOGBGG(string OIDDCBHHJLK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NKMALIJMNNL MFIFIACBKMH(string CMELJJKIIFP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GOACJHIODHI PMKHLMFBGCH();
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
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7060", Offset = "0x5EA5A60", VA = "0x185EA7060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PKPGIBGPAAJ : PHNKKHEMGLI
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly IReadOnlyDictionary<string, CMGKPCNNFKN> JBMPGOCACLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool BENDLPKLMJK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E0510", Offset = "0x7DEF10", VA = "0x1807E0510", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string PJBNLIILOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F00", Offset = "0x5EA4900", VA = "0x185EA5F00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public HFIANIHBGFA KGBPLHPHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EA52E0", Offset = "0x5EA3CE0", VA = "0x185EA52E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AIJGMGJEIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA56A0", Offset = "0x5EA40A0", VA = "0x185EA56A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F10", Offset = "0x5EA4910", VA = "0x185EA5F10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action MLBKNNDGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5600", Offset = "0x5EA4000", VA = "0x185EA5600", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6A10", Offset = "0x5EA5410", VA = "0x185EA6A10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA57C0", Offset = "0x5EA41C0", VA = "0x185EA57C0", Slot = "8")]
	public GOACJHIODHI IAMMEFBKIFH(string FLDHGLBOFEJ, string GLOMEFKCEGO, [Optional] BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6AB0", Offset = "0x5EA54B0", VA = "0x185EA6AB0", Slot = "17")]
	public GOACJHIODHI PMKHLMFBGCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6820", Offset = "0x5EA5220", VA = "0x185EA6820", Slot = "12")]
	public GOACJHIODHI ODCOOPCILAA(BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5C30", Offset = "0x5EA4630", VA = "0x185EA5C30", Slot = "13")]
	public GOACJHIODHI IEEEMNAOCJH(BDCKECENIPO KAPEMEGKCFG, Dictionary<string, string> NFPHFONJEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5570", Offset = "0x5EA3F70", VA = "0x185EA5570", Slot = "14")]
	public bool EPHDPEGPLKE(string MAFNHGMOFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5370", Offset = "0x5EA3D70", VA = "0x185EA5370", Slot = "15")]
	public ILGBHEANFAK BJPNENOGBGG(string OIDDCBHHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6790", Offset = "0x5EA5190", VA = "0x185EA6790", Slot = "16")]
	public NKMALIJMNNL MFIFIACBKMH(string CMELJJKIIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5EA60C0", Offset = "0x5EA4AC0", VA = "0x185EA60C0")]
	private HFIANIHBGFA LPJPCJBFDPE(BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6C00", Offset = "0x5EA5600", VA = "0x185EA6C00")]
	private BFLJPADMPLP PONMILKMIGH(string GLOMEFKCEGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5FB0", Offset = "0x5EA49B0", VA = "0x185EA5FB0")]
	private void LFAGALKAJOK(string OIDDCBHHJLK, ILGBHEANFAK LODBFAHDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PKPGIBGPAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA93640", Offset = "0xA92040", VA = "0x180A93640")]
	[CompilerGenerated]
	private void HEGHMBNIJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EA52F0", Offset = "0x5EA3CF0", VA = "0x185EA52F0")]
	[CompilerGenerated]
	private void AJEIMCICMGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5740", Offset = "0x5EA4140", VA = "0x185EA5740")]
	[CompilerGenerated]
	private void HBDBNLAOPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DODJIFPJBEL : PHNKKHEMGLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PHNKKHEMGLI KDMICGDONKN;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private PHNKKHEMGLI DLPENDOGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FE60", Offset = "0x5E9E860", VA = "0x185E9FE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5EA00C0", Offset = "0x5E9EAC0", VA = "0x185EA00C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string PJBNLIILOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0680", Offset = "0x5E9F080", VA = "0x185EA0680", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HFIANIHBGFA KGBPLHPHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FBB0", Offset = "0x5E9E5B0", VA = "0x185E9FBB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action AIJGMGJEIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0020", Offset = "0x5E9EA20", VA = "0x185EA0020", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA06D0", Offset = "0x5E9F0D0", VA = "0x185EA06D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MLBKNNDGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FF80", Offset = "0x5E9E980", VA = "0x185E9FF80", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0990", Offset = "0x5E9F390", VA = "0x185EA0990", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	[UnityEngine.Scripting.Preserve]
	public DODJIFPJBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FD80", Offset = "0x5E9E780", VA = "0x185E9FD80")]
	[BBBFDPEBAMC(HLEKCCEDPHP.GameOnly)]
	private static void CJBKIPIOHMK(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FDF0", Offset = "0x5E9E7F0", VA = "0x185E9FDF0")]
	[BBBFDPEBAMC(HLEKCCEDPHP.EditorOnly)]
	private static void CNHMENCONJK(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0110", Offset = "0x5E9EB10", VA = "0x185EA0110", Slot = "8")]
	public GOACJHIODHI IAMMEFBKIFH(string FLDHGLBOFEJ, string GLOMEFKCEGO, [Optional] BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0880", Offset = "0x5E9F280", VA = "0x185EA0880", Slot = "12")]
	public GOACJHIODHI ODCOOPCILAA(BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0560", Offset = "0x5E9EF60", VA = "0x185EA0560", Slot = "13")]
	public GOACJHIODHI IEEEMNAOCJH(BDCKECENIPO KAPEMEGKCFG, Dictionary<string, string> NFPHFONJEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FED0", Offset = "0x5E9E8D0", VA = "0x185E9FED0", Slot = "14")]
	public bool EPHDPEGPLKE(string MAFNHGMOFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FC70", Offset = "0x5E9E670", VA = "0x185E9FC70", Slot = "15")]
	public ILGBHEANFAK BJPNENOGBGG(string OIDDCBHHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0770", Offset = "0x5E9F170", VA = "0x185EA0770", Slot = "16")]
	public NKMALIJMNNL MFIFIACBKMH(string CMELJJKIIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0A30", Offset = "0x5E9F430", VA = "0x185EA0A30", Slot = "17")]
	public GOACJHIODHI PMKHLMFBGCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7DAE70", Offset = "0x7D9870", VA = "0x1807DAE70")]
	[CompilerGenerated]
	private void GNNPKHENGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xB975C0", Offset = "0xB95FC0", VA = "0x180B975C0")]
	[CompilerGenerated]
	private void OIOGPJFHBHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GHDCAHIEJHL : PHNKKHEMGLI
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NDGHBLBODDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string PJBNLIILOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HFIANIHBGFA KGBPLHPHAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AIJGMGJEIFA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA24D0", Offset = "0x5EA0ED0", VA = "0x185EA24D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2690", Offset = "0x5EA1090", VA = "0x185EA2690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action MLBKNNDGPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2430", Offset = "0x5EA0E30", VA = "0x185EA2430", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EA27D0", Offset = "0x5EA11D0", VA = "0x185EA27D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GHDCAHIEJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2570", Offset = "0x5EA0F70", VA = "0x185EA2570", Slot = "8")]
	public GOACJHIODHI IAMMEFBKIFH(string FLDHGLBOFEJ, string GLOMEFKCEGO, [Optional] BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2740", Offset = "0x5EA1140", VA = "0x185EA2740", Slot = "12")]
	public GOACJHIODHI ODCOOPCILAA(BDCKECENIPO KAPEMEGKCFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2600", Offset = "0x5EA1000", VA = "0x185EA2600", Slot = "13")]
	public GOACJHIODHI IEEEMNAOCJH(BDCKECENIPO KAPEMEGKCFG, Dictionary<string, string> NFPHFONJEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "14")]
	public bool EPHDPEGPLKE(string MAFNHGMOFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2420", Offset = "0x5EA0E20", VA = "0x185EA2420", Slot = "15")]
	public ILGBHEANFAK BJPNENOGBGG(string OIDDCBHHJLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2730", Offset = "0x5EA1130", VA = "0x185EA2730", Slot = "16")]
	public NKMALIJMNNL MFIFIACBKMH(string CMELJJKIIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2870", Offset = "0x5EA1270", VA = "0x185EA2870", Slot = "17")]
	public GOACJHIODHI PMKHLMFBGCH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface EJKDIOHBIHE
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ODNGOOMHAGF EGCFCCGEKJE(string BPOOKKAKCNL);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface IAEJLIPIODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum ICFGCCAJJHD
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	long HIPLHFKENPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string JPENGPEOICA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string MADBGNLLJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string HLDIOEBABHM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string EDMCHMBJBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool HBHAHMDGBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	long HJKNKGILPHE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHNEDMHFLDC(long CGALJLIIABC, bool HDBFPPPKEEJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHEMBGCAOEH(string AGHGCGMHDAO, string LEJNLPLCAEN, string ACJJEGDJIOA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFJBDOEBJLO(string AGHGCGMHDAO);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKBJPCEEBKB(string AGHGCGMHDAO, string KIHFKFMCMND, string KFJIOPPDMHA);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void AKHACOFKGGK(string EDCMOGPOIGP, object FCFDPPMAPIJ, object DLEMKHNMNKM);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MAPJCBMEGCE(ICFGCCAJJHD BAKANINFPBO, int MIOOHAFKDAG, [Optional] OKDGNPGIJIF MLKCEDENFNK, [Optional] string FDLJLMMNNJG, [Optional] string BNFACNGELAB);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HDLDDLAEDOO(OKDGNPGIJIF MLKCEDENFNK, long HPNFEKNPINE, long GDKBNEEBDDM, int IOILKDPANLE, string FDLJLMMNNJG, int MIOOHAFKDAG);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AIFDIAEOGBC(OKDGNPGIJIF MLKCEDENFNK, bool BLMNKHKHBAG, [Optional] string BNFACNGELAB);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MLEFJJMCCDP(OKDGNPGIJIF MLKCEDENFNK, bool BLMNKHKHBAG, [Optional] string BNFACNGELAB);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BKAICCKGJJI(OKDGNPGIJIF MLKCEDENFNK, bool BLMNKHKHBAG, [Optional] string BNFACNGELAB);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BDCKECENIPO
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool KOGPONMODFC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool OMINHHIJLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HAMNGJNCACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool? CLOLCBKOOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	int? BJHGHJELKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	int PLIIJODAOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string KCJKNCJCFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string AKADNHOICNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string KDDIPOAJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	long DHLBMKCGBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string GHKOFLPLFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string KOPCOEPAEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string KAHLPBMLKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string DDCBKCLAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	double BAIGACOPAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int LPHEGFONIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
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
