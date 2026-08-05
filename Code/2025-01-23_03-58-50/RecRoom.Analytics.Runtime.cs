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
using RecRoom.DataLayer.Registration;
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BD10", Offset = "0x6D6A510", VA = "0x186D6BD10")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D6E040", Offset = "0x6D6C840", VA = "0x186D6E040", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
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
		public AmplitudeAnalyticsClient.Settings OCJPDHEEEJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PEBDIGCCFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8B9830", VA = "0x1808BB030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, DLKJMFLDODE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum CAKNCLIPEOP
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		internal class CPOBLFIINEH
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class BBCONFLNKLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int BHLOHICMHGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> BLOFPALKEEG;

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				public BBCONFLNKLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class OMHFNKKHNJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				public int? earlierThanFrame;

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
				public OMHFNKKHNJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x6D6BD90", Offset = "0x6D6A590", VA = "0x186D6BD90")]
				internal bool ANGGKJAABPK(BBCONFLNKLE item)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string FPKMEFMCMBG = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string EDMHAMLCOLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<BBCONFLNKLE> ICDAKMNCBFG;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? GKLKNPOIHDE
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x6D677B0", Offset = "0x6D65FB0", VA = "0x186D677B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D67850", Offset = "0x6D66050", VA = "0x186D67850")]
			internal CPOBLFIINEH(string BFBNLKENGPG, string ILMGIEMLOCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D673F0", Offset = "0x6D65BF0", VA = "0x186D673F0")]
			public int KHBEDFJGGLM([Optional] int? IIKFKDJNLAF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D666C0", Offset = "0x6D64EC0", VA = "0x186D666C0")]
			public List<Dictionary<string, object>> AEFFLEBGBGM(int MKMABHNOHCM, int? IIKFKDJNLAF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D66B70", Offset = "0x6D65370", VA = "0x186D66B70")]
			public void CHIJHIAJLKH(AmplitudeAnalyticsIdentifyMessage INCBEIDOHDO, bool GAGICFCDLCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6D66A60", Offset = "0x6D65260", VA = "0x186D66A60")]
			public void CHIJHIAJLKH(Dictionary<string, object> INCBEIDOHDO, bool GAGICFCDLCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D67260", Offset = "0x6D65A60", VA = "0x186D67260")]
			public void JFDJFEFFEOJ(params Dictionary<string, object>[] MPDDNMJGACE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D66C10", Offset = "0x6D65410", VA = "0x186D66C10")]
			public void EMBKEMPMFND(List<Dictionary<string, object>> NDAPOBFNHOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6D665B0", Offset = "0x6D64DB0", VA = "0x186D665B0")]
			private void AEAMFGDNEFD(Dictionary<string, object> INCBEIDOHDO, bool GAGICFCDLCK = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D675A0", Offset = "0x6D65DA0", VA = "0x186D675A0")]
			public void LCMDBGKANEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D66E60", Offset = "0x6D65660", VA = "0x186D66E60")]
			private void ENOEONOEOND([Optional] string EBNPKEEFCLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D66930", Offset = "0x6D65130", VA = "0x186D66930")]
			private static string BGEIHDPBHOH(string INDENPJBLHO, string KCGKBDGKIOP)
			{
				return null;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float BatchIntervalSeconds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public bool verboseLogging;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6D6DC30", Offset = "0x6D6C430", VA = "0x186D6DC30")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct PCCCPLGLEPK<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int FOLJEJAHGHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string GJMFGDIDLME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T DLKPPMMFMCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GKALPBGDILO : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AmplitudeAnalyticsEvent initialEvent;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public GKALPBGDILO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6D68270", Offset = "0x6D66A70", VA = "0x186D68270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6D68A00", Offset = "0x6D67200", VA = "0x186D68A00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EODGCLOAHOD : IEnumerator<object>, IEnumerator, IDisposable
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
			public CGKMABONNJI quitCompletePromise;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public EODGCLOAHOD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6D67DF0", Offset = "0x6D665F0", VA = "0x186D67DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6D67F00", Offset = "0x6D66700", VA = "0x186D67F00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class FCJPFEDJLPB : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public FCJPFEDJLPB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D67F50", Offset = "0x6D66750", VA = "0x186D67F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6D680C0", Offset = "0x6D668C0", VA = "0x186D680C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CELIOEKHCJJ : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public CELIOEKHCJJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6D66300", Offset = "0x6D64B00", VA = "0x186D66300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6D66560", Offset = "0x6D64D60", VA = "0x186D66560", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class DGCDDPBMPFN : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public float timeout;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000080")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public DGCDDPBMPFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6D679C0", Offset = "0x6D661C0", VA = "0x186D679C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6D67C20", Offset = "0x6D66420", VA = "0x186D67C20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class LGGOAEOELLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public bool erroredOut;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public List<Dictionary<string, object>> batch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CPOBLFIINEH cache;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public Action<int> onBatchSent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public LGGOAEOELLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6D6A7E0", Offset = "0x6D68FE0", VA = "0x186D6A7E0")]
			internal void INHCMIJDKGO(string error)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6D6A390", Offset = "0x6D68B90", VA = "0x186D6A390")]
			internal void GMHNGAAEHPI(PCCCPLGLEPK<List<Dictionary<string, object>>> eventResponse)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class JDJBKEAAHAO : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CPOBLFIINEH cache;

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
			private LGGOAEOELLA <>8__1;

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
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public JDJBKEAAHAO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6D69010", Offset = "0x6D67810", VA = "0x186D69010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D69810", Offset = "0x6D68010", VA = "0x186D69810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PJJPFDNHOOG<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public T eventParams;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public PJJPFDNHOOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4C70FB0", Offset = "0x4C6F7B0", VA = "0x184C70FB0")]
			internal PCCCPLGLEPK<T> HOEJPLDMIIG(AJNJHKDDHCJ postResponse)
			{
				return default(PCCCPLGLEPK<T>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private IMIAAEOJJBO NFGAGDFMEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<NGIPGGIIHJM> DACMIHJIIHL;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string CHMGJKDIFMC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string NEJLGEJDODF = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string PHEPDANLNHB = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int BJJFNODLPNG = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int HMGCOCABHEC = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int PPLGJOCKPMO = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float MPJBJNFHHMN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long DNACJEMGCLJ = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string KOPICABGFNO = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string HMDBKADKIGI = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string NEAMNMGCMAG = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string DFLMFJFPBND = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool MDKHOHFGOEO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool PFEKGJPAPIL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int DPHKDGNEDPI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int GGOPNPHDBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JPCCNIJJLHG OKAGOMHOBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private AHCEOCKOIIG GLKNFKLEKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private KEKAPCFDNME IPNAMIAMHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool OCHMGKIKNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float BMFNECJBCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float BHFJPPFELHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int APBDHLKEOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int BDBGKJLINOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? BAPCAGDKHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? EOCLKDJNBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long KLNEEBGHBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string KBIHDFOLFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string HBHOOPPLHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long LBJCBJGCKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string FFMJDHGIKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string KLKIBBLJELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> KBLHOBPIGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private CAKNCLIPEOP ANDFKELMHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int BGBLFJDCEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int GGDPMOBACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float HPIELBFFCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool OGHHPJNJHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool EIBPDBJMAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CPOBLFIINEH POLNLOENLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CPOBLFIINEH DPIFGBCCLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CPOBLFIINEH CAGMGIJMLJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string HIOIBDILMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> MIMJBHBMDFG;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo JJBJFEDABEH;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string KJLGNOCMHMH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string CDEBBFIDNKN = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string MPBDODHGLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string OAHMCJOKLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string PKMGLKLAGHD;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private IMIAAEOJJBO MGIGPBOEMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D5D3E0", Offset = "0x6D5BBE0", VA = "0x186D5D3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private NGIPGGIIHJM APLBLJHHIDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CAF0", Offset = "0x6D5B2F0", VA = "0x186D5CAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BDMOKKECBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D5FB00", Offset = "0x6D5E300", VA = "0x186D5FB00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long CBKJFDEILEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6D628B0", Offset = "0x6D610B0", VA = "0x186D628B0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6D629C0", Offset = "0x6D611C0", VA = "0x186D629C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string DFIPLCMCNKL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D62880", Offset = "0x6D61080", VA = "0x186D62880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DALNJCHFIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xFA55E0", Offset = "0xFA3DE0", VA = "0x180FA55E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xFA4070", Offset = "0xFA2870", VA = "0x180FA4070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JEKNDBLIDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9DB3F0", Offset = "0x9D9BF0", VA = "0x1809DB3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xF68340", Offset = "0xF66B40", VA = "0x180F68340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? OANCDJKNPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9016B0", Offset = "0x8FFEB0", VA = "0x1809016B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC5E790", Offset = "0xC5CF90", VA = "0x180C5E790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ANKDNCBNGPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9F4300", Offset = "0x9F2B00", VA = "0x1809F4300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEA2E20", Offset = "0xEA1620", VA = "0x180EA2E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LOOOGDLFEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D62790", Offset = "0x6D60F90", VA = "0x186D62790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> IFOJPBHEHNN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D626D0", Offset = "0x6D60ED0", VA = "0x186D626D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6D62900", Offset = "0x6D61100", VA = "0x186D62900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CCF0", Offset = "0x6D5B4F0", VA = "0x186D5CCF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EEC0", Offset = "0x6D5D6C0", VA = "0x186D5EEC0")]
		private void GIFJCLBDEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D61D00", Offset = "0x6D60500", VA = "0x186D61D00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D609B0", Offset = "0x6D5F1B0", VA = "0x186D609B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D62030", Offset = "0x6D60830", VA = "0x186D62030")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D60A70", Offset = "0x6D5F270", VA = "0x186D60A70")]
		public MOPOHKAGKCI PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F8F0", Offset = "0x6D5E0F0", VA = "0x186D5F8F0")]
		[IteratorStateMachine(typeof(GKALPBGDILO))]
		public IEnumerator<IJKEOMMDACC> InitializeForLocalAccount(AmplitudeAnalyticsEvent LBNPKFCKNDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D613D0", Offset = "0x6D5FBD0", VA = "0x186D613D0")]
		public void SendAppEnterEvent(bool EBDDJEPFOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D61FB0", Offset = "0x6D607B0", VA = "0x186D61FB0")]
		public void UpdateLastKnownInteractionCategory(string KIBMEOKJNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D61F00", Offset = "0x6D60700", VA = "0x186D61F00")]
		public void UpdateLastAliveTime(float HKMEEJMCKCG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D60450", Offset = "0x6D5EC50", VA = "0x186D60450")]
		private MOPOHKAGKCI MFEKLCIEIJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F280", Offset = "0x6D5DA80", VA = "0x186D5F280")]
		private MOPOHKAGKCI HDOEKHDBJHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D616E0", Offset = "0x6D5FEE0", VA = "0x186D616E0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CA60", Offset = "0x6D5B260", VA = "0x186D5CA60")]
		[IteratorStateMachine(typeof(EODGCLOAHOD))]
		private IEnumerator AJODEJMFGPE(CGKMABONNJI MAMABDNIKGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D622C0", Offset = "0x6D60AC0", VA = "0x186D622C0")]
		[IteratorStateMachine(typeof(FCJPFEDJLPB))]
		public IEnumerator WaitForFlush(float DEKMBJOBNGH = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D61DE0", Offset = "0x6D605E0", VA = "0x186D61DE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D61D20", Offset = "0x6D60520", VA = "0x186D61D20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime MHAEBFLONHE)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F3F0", Offset = "0x6D5DBF0", VA = "0x186D5F3F0")]
		public static CBCCGHFNAIJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5CB40", Offset = "0x6D5B340", VA = "0x186D5CB40")]
		public static PEBLDCBBNCF AccountSelectionPostLoginEvent([NotNull] string NPHMIIKLNKG, string DCDLHONMOIF, BCJPPNMGNPJ AEPGFGMLBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D920", Offset = "0x6D5C120", VA = "0x186D5D920")]
		public static PEBLDCBBNCF Event([NotNull] string NPHMIIKLNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D60C10", Offset = "0x6D5F410", VA = "0x186D60C10")]
		public static PEBLDCBBNCF PreviousSessionEvent([NotNull] string NPHMIIKLNKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F590", Offset = "0x6D5DD90", VA = "0x186D5F590")]
		public static PEBLDCBBNCF InitializeEvent(string DCDLHONMOIF, int KNOHFPCJBAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D618E0", Offset = "0x6D600E0", VA = "0x186D618E0")]
		public static PEBLDCBBNCF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D470", Offset = "0x6D5BC70", VA = "0x186D5D470")]
		public static PEBLDCBBNCF CreateOutOfSessionEvent(string NPHMIIKLNKG, bool GBKGGPLLFEM = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6D60060", Offset = "0x6D5E860", VA = "0x186D60060")]
		public static MOPOHKAGKCI LogOutOfSessionEvent(PEBLDCBBNCF EIDJLDLOFMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6D5FDE0", Offset = "0x6D5E5E0", VA = "0x186D5FDE0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent PJGHFJDECDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6D60230", Offset = "0x6D5EA30", VA = "0x186D60230")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent PJGHFJDECDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6D60370", Offset = "0x6D5EB70", VA = "0x186D60370")]
		public void LogSerializedEventAsync(Dictionary<string, object> IADMLDDGBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D5FF20", Offset = "0x6D5E720", VA = "0x186D5FF20")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage BMLDHEPELAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D60510", Offset = "0x6D5ED10", VA = "0x186D60510")]
		private void MNINABKEPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D60610", Offset = "0x6D5EE10", VA = "0x186D60610")]
		private void OLLAKLHDPLP(Dictionary<string, object> ABCBLJADALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D608C0", Offset = "0x6D5F0C0", VA = "0x186D608C0")]
		private void OMIPIFKOLHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D750", Offset = "0x6D5BF50", VA = "0x186D5D750")]
		private void DPHKDFNJKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5ED20", Offset = "0x6D5D520", VA = "0x186D5ED20")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D350", Offset = "0x6D5BB50", VA = "0x186D5D350")]
		[IteratorStateMachine(typeof(CELIOEKHCJJ))]
		private IEnumerator<IJKEOMMDACC> CKEBJJKALKL(float DEKMBJOBNGH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C9D0", Offset = "0x6D5B1D0", VA = "0x186D5C9D0")]
		[IteratorStateMachine(typeof(DGCDDPBMPFN))]
		private IEnumerator<IJKEOMMDACC> AFENIAKCCDJ(float DEKMBJOBNGH = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5FD00", Offset = "0x6D5E500", VA = "0x186D5FD00")]
		[IteratorStateMachine(typeof(JDJBKEAAHAO))]
		private IEnumerator<IJKEOMMDACC> KIFGDNEMDGL(CPOBLFIINEH LFGHKHMKKKD, int? IIKFKDJNLAF, string PAHKLDBPIBA, float DEKMBJOBNGH, Action<int> PBPGJKIKNOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EDB0", Offset = "0x6D5D5B0", VA = "0x186D5EDB0")]
		private static void GDHMJNBJKMC(bool PCIKLJMGDED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E9E0", Offset = "0x6D5D1E0", VA = "0x186D5E9E0")]
		private AKLEHMINLPM<PCCCPLGLEPK<Dictionary<string, object>>> FOHNJNECPEN(string PAHKLDBPIBA, string CCHCCLCCFPP, Dictionary<string, object> DLKPPMMFMCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D5EAB0", Offset = "0x6D5D2B0", VA = "0x186D5EAB0")]
		private AKLEHMINLPM<PCCCPLGLEPK<List<Dictionary<string, object>>>> FOHNJNECPEN(string PAHKLDBPIBA, string CCHCCLCCFPP, List<Dictionary<string, object>> DLKPPMMFMCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x378E710", Offset = "0x378CF10", VA = "0x18378E710")]
		private AKLEHMINLPM<PCCCPLGLEPK<T>> ODEEHAHCGEL<T>(string BDGBAJGFOEP, string PAHKLDBPIBA, string CCHCCLCCFPP, T DLKPPMMFMCJ, Dictionary<string, object> JKFOPPLJCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D5E990", Offset = "0x6D5D190", VA = "0x186D5E990")]
		private bool FNNNAKDKBIC(float MFGGKOGDNHE, float DEKMBJOBNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D5DC30", Offset = "0x6D5C430", VA = "0x186D5DC30")]
		private Dictionary<string, object> FFCAOCPCCLK(string PAHKLDBPIBA, Dictionary<string, object> DLKPPMMFMCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D623B0", Offset = "0x6D60BB0", VA = "0x186D623B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8E2910", Offset = "0x8E1110", VA = "0x1808E2910", Slot = "6")]
		private bool KPBLGHLFFCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D5F980", Offset = "0x6D5E180", VA = "0x186D5F980")]
		[CompilerGenerated]
		private long JAHCDHHPKFC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D5FAF0", Offset = "0x6D5E2F0", VA = "0x186D5FAF0")]
		[CompilerGenerated]
		private void JDFLHAKFNBH(int CHAKHIOEEMG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
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
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6D636C0", Offset = "0x6D61EC0", VA = "0x186D636C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D637A0", Offset = "0x6D61FA0", VA = "0x186D637A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6D63700", Offset = "0x6D61F00", VA = "0x186D63700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6D63800", Offset = "0x6D62000", VA = "0x186D63800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6D63680", Offset = "0x6D61E80", VA = "0x186D63680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6D63740", Offset = "0x6D61F40", VA = "0x186D63740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8B7580", Offset = "0x8B5D80", VA = "0x1808B7580")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D63070", Offset = "0x6D61870", VA = "0x186D63070")]
		public static PEBLDCBBNCF JHEOKMMJDLF(string MAAOIFPNGGJ, [NotNull] string KLIEFOPLHLG, long JJNICACABPB, long AFDMHAAHOEN, string DCDLHONMOIF, string AEPGFGMLBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6D63270", Offset = "0x6D61A70", VA = "0x186D63270")]
		public static PEBLDCBBNCF MGIJOAJKFOD(string MAAOIFPNGGJ, [NotNull] string KLIEFOPLHLG, long JJNICACABPB, long AFDMHAAHOEN, string DCDLHONMOIF, long IICAMBHAPMN, string PDKLCLKIGLN, string LHEFPJNHCBE, string JOGNIJNAAAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D634E0", Offset = "0x6D61CE0", VA = "0x186D634E0")]
		private AmplitudeAnalyticsEvent(string MAAOIFPNGGJ, [NotNull] string KLIEFOPLHLG, long JJNICACABPB, long AFDMHAAHOEN, string DCDLHONMOIF, string AEPGFGMLBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA87F00", Offset = "0xA86700", VA = "0x180A87F00")]
		public void LDJDKGDNMHF(long OOCPIKMBCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6D63170", Offset = "0x6D61970", VA = "0x186D63170", Slot = "5")]
		public override void LOAHGLHIDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6D62EF0", Offset = "0x6D616F0", VA = "0x186D62EF0", Slot = "6")]
		public override void HJBMPCHFGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D62A20", Offset = "0x6D61220", VA = "0x186D62A20", Slot = "4")]
		protected override Dictionary<string, object> EJKKKDILEPO(Dictionary<string, object> FOPDKOLGJBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D633D0", Offset = "0x6D61BD0", VA = "0x186D633D0")]
		private void PIAHPPCBDOO(string KCGKBDGKIOP, string INDENPJBLHO, bool PNFKKGMMLNP = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6D67C70", Offset = "0x6D66470", VA = "0x186D67C70")]
			public void MAOOOOPGBBP(Dictionary<string, object> AKDJJMDGJFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
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

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6D6D8C0", Offset = "0x6D6C0C0", VA = "0x186D6D8C0")]
			public void MAOOOOPGBBP(Dictionary<string, object> BMAEHJBEAIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE65590", Offset = "0xE63D90", VA = "0x180E65590")]
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
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6D63D50", Offset = "0x6D62550", VA = "0x186D63D50")]
		public static CBCCGHFNAIJ JHEOKMMJDLF(string MAAOIFPNGGJ, string DCDLHONMOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D63F10", Offset = "0x6D62710", VA = "0x186D63F10")]
		protected AmplitudeAnalyticsIdentifyMessage(string MAAOIFPNGGJ, string DCDLHONMOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D63900", Offset = "0x6D62100", VA = "0x186D63900")]
		public Dictionary<string, object> BJGIDPENFDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D63990", Offset = "0x6D62190", VA = "0x186D63990", Slot = "4")]
		protected virtual Dictionary<string, object> EJKKKDILEPO(Dictionary<string, object> FOPDKOLGJBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6D63860", Offset = "0x6D62060", VA = "0x186D63860")]
		protected void BIFNODDFMMI(string KCGKBDGKIOP, Dictionary<string, object> OGEIKCEKALK, Dictionary<string, object> DPJEALHOOKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6D63EA0", Offset = "0x6D626A0", VA = "0x186D63EA0")]
		protected void MLNACFGGLAN(string KCGKBDGKIOP, string INDENPJBLHO, Dictionary<string, object> KLLBGHIOONK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D63E10", Offset = "0x6D62610", VA = "0x186D63E10", Slot = "5")]
		public virtual void LOAHGLHIDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D63CD0", Offset = "0x6D624D0", VA = "0x186D63CD0", Slot = "6")]
		public virtual void HJBMPCHFGBB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CBCCGHFNAIJ : LGPLODFNLFL<AmplitudeAnalyticsIdentifyMessage, CBCCGHFNAIJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public override CBCCGHFNAIJ AOLFBHHAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "5")]
	public override AmplitudeAnalyticsIdentifyMessage AIBHLMNDFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D662B0", Offset = "0x6D64AB0", VA = "0x186D662B0")]
	public CBCCGHFNAIJ(AmplitudeAnalyticsIdentifyMessage PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D66210", Offset = "0x6D64A10", VA = "0x186D66210", Slot = "4")]
	public override void HJBMPCHFGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PEBLDCBBNCF : LGPLODFNLFL<AmplitudeAnalyticsEvent, PEBLDCBBNCF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool DJABPAFBLHA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public override PEBLDCBBNCF AOLFBHHAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA85ED0", Offset = "0xA846D0", VA = "0x180A85ED0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long PBPFPKNFNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D540", Offset = "0x6D6BD40", VA = "0x186D6D540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D69A10", Offset = "0x6D68210", VA = "0x186D69A10")]
	public PEBLDCBBNCF(AmplitudeAnalyticsEvent PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "5")]
	public override AmplitudeAnalyticsEvent AIBHLMNDFEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D6F0", Offset = "0x6D6BEF0", VA = "0x186D6D6F0", Slot = "4")]
	public override void HJBMPCHFGBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3225DD0", Offset = "0x32245D0", VA = "0x183225DD0")]
	public PEBLDCBBNCF CBCEOFNIIEL<T>(string MFCFAMOHGBK, T[] INDENPJBLHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3225DD0", Offset = "0x32245D0", VA = "0x183225DD0")]
	public PEBLDCBBNCF CBCEOFNIIEL(string MFCFAMOHGBK, string[] INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3225B20", Offset = "0x3224320", VA = "0x183225B20")]
	public PEBLDCBBNCF CBCEOFNIIEL<T>(string MFCFAMOHGBK, T INDENPJBLHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D560", Offset = "0x6D6BD60", VA = "0x186D6D560")]
	public PEBLDCBBNCF CBCEOFNIIEL(string MFCFAMOHGBK, long INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D5E0", Offset = "0x6D6BDE0", VA = "0x186D6D5E0")]
	public PEBLDCBBNCF CBCEOFNIIEL(string MFCFAMOHGBK, string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D790", Offset = "0x6D6BF90", VA = "0x186D6D790")]
	public PEBLDCBBNCF HLBGIODDPBF(string MFCFAMOHGBK, object? INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D650", Offset = "0x6D6BE50", VA = "0x186D6D650")]
	public PEBLDCBBNCF CMLBKEMELGM(string MFCFAMOHGBK, string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D7C0", Offset = "0x6D6BFC0", VA = "0x186D6D7C0")]
	private PEBLDCBBNCF JNCLONKNPLO(string MFCFAMOHGBK, object INDENPJBLHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JFLBLGGDEEN : PEBLDCBBNCF
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D69A10", Offset = "0x6D68210", VA = "0x186D69A10")]
	public JFLBLGGDEEN(AmplitudeAnalyticsEvent PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6D69860", Offset = "0x6D68060", VA = "0x186D69860", Slot = "4")]
	public override void HJBMPCHFGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class LGPLODFNLFL<M, BLDR> where M : AmplitudeAnalyticsIdentifyMessage where BLDR : LGPLODFNLFL<M, BLDR>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	protected M PJFOMDHJLBF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public abstract BLDR AOLFBHHAMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public LGPLODFNLFL(M PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x47333B0", Offset = "0x4731BB0", VA = "0x1847333B0")]
	public BLDR MIJBLKJDPKC(AmplitudeAnalyticsIdentifyMessage.DeviceInfo LJEICMPAHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4733290", Offset = "0x4731A90", VA = "0x184733290")]
	public BLDR FGJMHFAJMEA(AmplitudeAnalyticsIdentifyMessage.RevenueData IJLKGOBGFAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x47332E0", Offset = "0x4731AE0", VA = "0x1847332E0")]
	public BLDR IDNBEFGGKAE(string MFCFAMOHGBK, string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3147850", Offset = "0x3146050", VA = "0x183147850")]
	public BLDR IDNBEFGGKAE<T>(string MFCFAMOHGBK, T INDENPJBLHO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HJBMPCHFGBB();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4733380", Offset = "0x4731B80", VA = "0x184733380")]
	internal static string LCBKKBMHJPL(string INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4733190", Offset = "0x4731990", VA = "0x184733190")]
	private BLDR AEJLCLJEBBA(string MFCFAMOHGBK, object INDENPJBLHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract M AIBHLMNDFEA();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class BBFELDMJIMH : JPCCNIJJLHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LMOAFNKNNJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<AJNJHKDDHCJ> <>t__builder;

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
		public BBFELDMJIMH <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AF70", Offset = "0x6D69770", VA = "0x186D6AF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B9A0", Offset = "0x6D6A1A0", VA = "0x186D6B9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private HttpClient ICOCNBANFKF;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6D64140", Offset = "0x6D62940", VA = "0x186D64140")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void HNLMCMAGLPA(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6D641B0", Offset = "0x6D629B0", VA = "0x186D641B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BBFELDMJIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D63FD0", Offset = "0x6D627D0", VA = "0x186D63FD0", Slot = "4")]
	[AsyncStateMachine(typeof(LMOAFNKNNJF))]
	public Task<AJNJHKDDHCJ> GPAHAKNMCMB(string BDGBAJGFOEP, string OIOHDIKIFLP, string MHFKHGLKMAE, string AMIMGFNMFAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class GJHJGLDPGPH : JPCCNIJJLHG
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NDKJMPIOEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public UnityWebRequest request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public TaskCompletionSource<AJNJHKDDHCJ> tcs;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public NDKJMPIOEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BA10", Offset = "0x6D6A210", VA = "0x186D6BA10")]
		internal void MJABBIEGFEP(AsyncOperation operation)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct IHLBJLJJFGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder<AJNJHKDDHCJ> <>t__builder;

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
		private TaskAwaiter<AJNJHKDDHCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6D68A50", Offset = "0x6D67250", VA = "0x186D68A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D68FA0", Offset = "0x6D677A0", VA = "0x186D68FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void AOLFAOCPCNB(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[RecRoom.NoEngine.Common.Preserve]
	public GJHJGLDPGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D68110", Offset = "0x6D66910", VA = "0x186D68110", Slot = "4")]
	[AsyncStateMachine(typeof(IHLBJLJJFGJ))]
	public Task<AJNJHKDDHCJ> GPAHAKNMCMB(string BDGBAJGFOEP, string OIOHDIKIFLP, string MHFKHGLKMAE, string AMIMGFNMFAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PCJHNNFBCKC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> EPJGGMLLELN;

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D150", Offset = "0x6D6B950", VA = "0x186D6D150")]
	internal static bool BEJIMFIADEN(string KCGKBDGKIOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JPCCNIJJLHG
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AJNJHKDDHCJ> GPAHAKNMCMB(string BDGBAJGFOEP, string OIOHDIKIFLP, string MHFKHGLKMAE, string AMIMGFNMFAC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct AJNJHKDDHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly int DPCMDGLFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public readonly string JLEJHHCEKGH;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x11A2B30", Offset = "0x11A1330", VA = "0x1811A2B30")]
	public AJNJHKDDHCJ(int FOLJEJAHGHP, string GJMFGDIDLME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum ICILLAONFOJ
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
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JPADPJDEKIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private long NDMCMKNKKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PEBLDCBBNCF PIHEOEPKNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool PEIMHGCEKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float BABMEOKPLPN;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6D69DF0", Offset = "0x6D685F0", VA = "0x186D69DF0")]
	public JPADPJDEKIF(string PPKAABHDHGK, float BABMEOKPLPN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x30BCEB0", Offset = "0x30BB6B0", VA = "0x1830BCEB0")]
	public void CBCEOFNIIEL<T>(string MFCFAMOHGBK, T INDENPJBLHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6D69B70", Offset = "0x6D68370", VA = "0x186D69B70")]
	public void CBCEOFNIIEL(string MFCFAMOHGBK, string INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6D69CB0", Offset = "0x6D684B0", VA = "0x186D69CB0")]
	public void FIAKMCLJCGI(string NCJNMNPDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6D69BF0", Offset = "0x6D683F0", VA = "0x186D69BF0")]
	public void FAOADCFEFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6D69A60", Offset = "0x6D68260", VA = "0x186D69A60")]
	private void BLMPLCBPOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6D69DA0", Offset = "0x6D685A0", VA = "0x186D69DA0")]
	private bool LNMBLGHCELO()
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
		public enum NFNEFNAEEMK
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
		private NFNEFNAEEMK parameterType;

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
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NFNEFNAEEMK Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
			get
			{
				return default(NFNEFNAEEMK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8E3DA0", Offset = "0x8E25A0", VA = "0x1808E3DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D6DA30", Offset = "0x6D6C230", VA = "0x186D6DA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class ADHFAMFEHNM : JFLMKPADPMF, PBCBPMGNLGP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void NNEENHANKON(NMBDGOHOEKM PBOLCENBLOC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly HLJMNCOMCJA EFHDPAJLGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly NNEENHANKON DFFOPGEFMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly string LIIKMIELHPN;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BGNKMHBIFPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x160F220", Offset = "0x160DA20", VA = "0x18160F220", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool AHKBIIOACNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B590", Offset = "0x6D59D90", VA = "0x186D5B590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool GNECLMOMGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B5B0", Offset = "0x6D59DB0", VA = "0x186D5B5B0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<string> DEKEBDFIMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x160F310", Offset = "0x160DB10", VA = "0x18160F310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B5D0", Offset = "0x6D59DD0", VA = "0x186D5B5D0")]
	public ADHFAMFEHNM(HLJMNCOMCJA MEGJMJCJPOE, string EOHAHOLHAFK, [Optional] NNEENHANKON CAHPMBMNKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3739E00", Offset = "0x3738600", VA = "0x183739E00", Slot = "8")]
	public T EFGCOGNKKLM<T>(string KCGKBDGKIOP, T DFEJJOPGBKP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BIFLICIJFDM : KHOLIEJJFCA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AFMFEGJMOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public AHCEOCKOIIG userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public BIFLICIJFDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C020", Offset = "0x6D5A820", VA = "0x186D5C020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C970", Offset = "0x6D5B170", VA = "0x186D5C970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NPLLKALEKLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BAF0", Offset = "0x6D6A2F0", VA = "0x186D6BAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6D6BCB0", Offset = "0x6D6A4B0", VA = "0x186D6BCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LJCEEBPNKBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public AHCEOCKOIIG userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BIFLICIJFDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool <containsUserInfo>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private bool <fireInitEvent>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AB00", Offset = "0x6D69300", VA = "0x186D6AB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AF10", Offset = "0x6D69710", VA = "0x186D6AF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct LBBEBBGMLHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public BIFLICIJFDM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AHCEOCKOIIG userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Dictionary<string, string> customIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D69F80", Offset = "0x6D68780", VA = "0x186D69F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A330", Offset = "0x6D68B30", VA = "0x186D6A330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly IReadOnlyDictionary<string, ABHFOCAKDIO> BIGAAEBJDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool BNMAJJGNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool HNDHBKJJMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private TaskCompletionSource<bool> ABFAKBNOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private TaskCompletionSource<bool> NPBOMHOKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private readonly SemaphoreSlim NOLECGNKCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HFOHMDDDJDF DMAEOGNAGNP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Task GEEICIDKJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D64880", Offset = "0x6D63080", VA = "0x186D64880", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AAGNCMOIOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool GAGGDDKFDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xF57710", Offset = "0xF55F10", VA = "0x180F57710", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string JEKNDBLIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D64AA0", Offset = "0x6D632A0", VA = "0x186D64AA0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CIHAHAGDENN IKHHENHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D64850", Offset = "0x6D63050", VA = "0x186D64850", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action LIKJAHHDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D64A00", Offset = "0x6D63200", VA = "0x186D64A00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D64B50", Offset = "0x6D63350", VA = "0x186D64B50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LAKBOOHDCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D65E40", Offset = "0x6D64640", VA = "0x186D65E40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D65A30", Offset = "0x6D64230", VA = "0x186D65A30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MOIFHLMAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D64AB0", Offset = "0x6D632B0", VA = "0x186D64AB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D658A0", Offset = "0x6D640A0", VA = "0x186D658A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<NMBDGOHOEKM> MAABBDNPGNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D65980", Offset = "0x6D64180", VA = "0x186D65980", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D65AD0", Offset = "0x6D642D0", VA = "0x186D65AD0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D648C0", Offset = "0x6D630C0", VA = "0x186D648C0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D648E0", Offset = "0x6D630E0", VA = "0x186D648E0", Slot = "12")]
	[AsyncStateMachine(typeof(AFMFEGJMOOK))]
	public Task EHFCOOMFLME(string ILMGIEMLOCH, [Optional] AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D644B0", Offset = "0x6D62CB0", VA = "0x186D644B0", Slot = "23")]
	[AsyncStateMachine(typeof(NPLLKALEKLL))]
	public Task BCBJCDIBNBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D64750", Offset = "0x6D62F50", VA = "0x186D64750", Slot = "18")]
	[AsyncStateMachine(typeof(LJCEEBPNKBC))]
	public Task DBAEADCHDEI(AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D65640", Offset = "0x6D63E40", VA = "0x186D65640")]
	private void HELCGCLIOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D64BF0", Offset = "0x6D633F0", VA = "0x186D64BF0", Slot = "19")]
	[AsyncStateMachine(typeof(LBBEBBGMLHG))]
	public Task GDBPMFJAOPG(AHCEOCKOIIG HOHMNCPBCJA, Dictionary<string, string> FOGJDPIHAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D65EE0", Offset = "0x6D646E0", VA = "0x186D65EE0", Slot = "20")]
	public bool PNDCLLGJIMC(string KIOKOPNCEOO, bool FJHGOJLLMFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D656E0", Offset = "0x6D63EE0", VA = "0x186D656E0", Slot = "21")]
	public JFLMKPADPMF HJMECDFFPHO(string EOHAHOLHAFK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D64560", Offset = "0x6D62D60", VA = "0x186D64560")]
	private HLJMNCOMCJA BIDAHAIJBKK(string EOHAHOLHAFK, bool FJHGOJLLMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6D64230", Offset = "0x6D62A30", VA = "0x186D64230", Slot = "22")]
	public GGDHHCPDIBD AKLIDCGBBKP(string MOGICMFHHLK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D643E0", Offset = "0x6D62BE0", VA = "0x186D643E0")]
	private ELEHGCAKAND APBHJBNANEO(string MOGICMFHHLK, bool FJHGOJLLMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D64D00", Offset = "0x6D63500", VA = "0x186D64D00")]
	private JOBEHPCEDFJ HBIJEAGLGEM(AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6D65B80", Offset = "0x6D64380", VA = "0x186D65B80")]
	private PKAKINNCPOP OINPEHIOFHA(string ILMGIEMLOCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D65D30", Offset = "0x6D64530", VA = "0x186D65D30")]
	private void PECOIHKLHPF(string EOHAHOLHAFK, HLJMNCOMCJA MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D66110", Offset = "0x6D64910", VA = "0x186D66110")]
	public BIFLICIJFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6D65940", Offset = "0x6D64140", VA = "0x186D65940")]
	[CompilerGenerated]
	private void NOABNPDFOAA(NMBDGOHOEKM EBAPCDIJGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D65940", Offset = "0x6D64140", VA = "0x186D65940")]
	[CompilerGenerated]
	private void JLEIEFPKFLJ(NMBDGOHOEKM EBAPCDIJGCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OODKIDOLLNJ : KHOLIEJJFCA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct AFJENCKLNDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public OODKIDOLLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public AHCEOCKOIIG userData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string recNetEnv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B640", Offset = "0x6D59E40", VA = "0x186D5B640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D5BFC0", Offset = "0x6D5A7C0", VA = "0x186D5BFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct PCONDKEMINJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public TaskCompletionSource<bool> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D6D300", Offset = "0x6D6BB00", VA = "0x186D6D300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x908140", Offset = "0x906940", VA = "0x180908140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private BIFLICIJFDM KEEHDDPJDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private TaskCompletionSource<bool> ABFAKBNOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TaskCompletionSource<bool> NPBOMHOKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Task PEFIGBMEGFN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private KHOLIEJJFCA FNMDAPOIJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CDB0", Offset = "0x6D6B5B0", VA = "0x186D6CDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GAGGDDKFDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CB70", Offset = "0x6D6B370", VA = "0x186D6CB70", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool AAGNCMOIOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CB60", Offset = "0x6D6B360", VA = "0x186D6CB60", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Task GEEICIDKJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C180", Offset = "0x6D6A980", VA = "0x186D6C180", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string JEKNDBLIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C6E0", Offset = "0x6D6AEE0", VA = "0x186D6C6E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CIHAHAGDENN IKHHENHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C140", Offset = "0x6D6A940", VA = "0x186D6C140", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LAKBOOHDCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CED0", Offset = "0x6D6B6D0", VA = "0x186D6CED0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD10", Offset = "0x6D6B510", VA = "0x186D6CD10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action LIKJAHHDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C640", Offset = "0x6D6AE40", VA = "0x186D6C640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C7A0", Offset = "0x6D6AFA0", VA = "0x186D6C7A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MOIFHLMAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6D6C700", Offset = "0x6D6AF00", VA = "0x186D6C700", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CB80", Offset = "0x6D6B380", VA = "0x186D6CB80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<NMBDGOHOEKM> MAABBDNPGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CC20", Offset = "0x6D6B420", VA = "0x186D6CC20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CE20", Offset = "0x6D6B620", VA = "0x186D6CE20", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D6D090", Offset = "0x6D6B890", VA = "0x186D6D090")]
	[UnityEngine.Scripting.Preserve]
	public OODKIDOLLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BEC0", Offset = "0x6D6A6C0", VA = "0x186D6BEC0")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void ANCFBKBPAGI(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CA30", Offset = "0x6D6B230", VA = "0x186D6CA30")]
	internal static void HILFAFIEMCN(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C380", Offset = "0x6D6AB80", VA = "0x186D6C380", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C3B0", Offset = "0x6D6ABB0", VA = "0x186D6C3B0", Slot = "12")]
	[AsyncStateMachine(typeof(AFJENCKLNDD))]
	public Task EHFCOOMFLME(string ILMGIEMLOCH, [Optional] AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C040", Offset = "0x6D6A840", VA = "0x186D6C040", Slot = "18")]
	public Task DBAEADCHDEI(AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C840", Offset = "0x6D6B040", VA = "0x186D6C840", Slot = "19")]
	public Task GDBPMFJAOPG(AHCEOCKOIIG HOHMNCPBCJA, Dictionary<string, string> FOGJDPIHAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CF70", Offset = "0x6D6B770", VA = "0x186D6CF70", Slot = "20")]
	public bool PNDCLLGJIMC(string KIOKOPNCEOO, bool FJHGOJLLMFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CAA0", Offset = "0x6D6B2A0", VA = "0x186D6CAA0", Slot = "21")]
	public JFLMKPADPMF HJMECDFFPHO(string EOHAHOLHAFK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BE00", Offset = "0x6D6A600", VA = "0x186D6BE00", Slot = "22")]
	public GGDHHCPDIBD AKLIDCGBBKP(string MOGICMFHHLK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6BF30", Offset = "0x6D6A730", VA = "0x186D6BF30", Slot = "23")]
	public Task BCBJCDIBNBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C4C0", Offset = "0x6D6ACC0", VA = "0x186D6C4C0")]
	private static void EHKBKFJDPKA(TaskCompletionSource<bool> BOBBGFPNGHE, Task MOLIGCIAIPE, Task NLDGPGLFMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6D6C960", Offset = "0x6D6B160", VA = "0x186D6C960")]
	[AsyncStateMachine(typeof(PCONDKEMINJ))]
	private static void HCHBJCEICNA(Task DIGFCMIOIEB, TaskCompletionSource<bool> BOBBGFPNGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA8CD50", Offset = "0xA8B550", VA = "0x180A8CD50")]
	[CompilerGenerated]
	private void IMMGNGBPCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xAE85A0", Offset = "0xAE6DA0", VA = "0x180AE85A0")]
	[CompilerGenerated]
	private void HHICGDNAIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x9914B0", Offset = "0x98FCB0", VA = "0x1809914B0")]
	[CompilerGenerated]
	private void PCECJCJKGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CCD0", Offset = "0x6D6B4D0", VA = "0x186D6CCD0")]
	[CompilerGenerated]
	private void LCFCBBCPIFE(NMBDGOHOEKM EBAPCDIJGCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class DPFCAEBNCIE : GGDHHCPDIBD, PBCBPMGNLGP
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void PNOODABCPHI(NMBDGOHOEKM PBOLCENBLOC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly PNOODABCPHI DFFOPGEFMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ELEHGCAKAND NLNHOIJLFPO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string BGNKMHBIFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9FAE40", Offset = "0x9F9640", VA = "0x1809FAE40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x607C8B0", Offset = "0x607B0B0", VA = "0x18607C8B0")]
	public DPFCAEBNCIE(ELEHGCAKAND AKANAFFGCPI, [Optional] PNOODABCPHI CAHPMBMNKGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2EABAF0", Offset = "0x2EAA2F0", VA = "0x182EABAF0", Slot = "5")]
	public T EFGCOGNKKLM<T>(string KCGKBDGKIOP, T DFEJJOPGBKP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface OOGELGIKKFH
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[UsedImplicitly]
public class ABPAPCBMKGG : OOGELGIKKFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly DJJMJMGHGGE MPDHMHNLGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly List<DLANBAJNKJM> KFOAOGBDCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly string EHINGDCBBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly string FFCGMLCGBPF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AA90", Offset = "0x6D59290", VA = "0x186D5AA90")]
	[UsedImplicitly]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void EDDDBNCFOFG(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AB00", Offset = "0x6D59300", VA = "0x186D5AB00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ABPAPCBMKGG([NotNull][NDCFMLCHJCI(null)] DJJMJMGHGGE MPDHMHNLGJD, [NDCFMLCHJCI(null)][NotNull] LPKEPODCFME BPMCFJLLFCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class ABPCHEFDHCD : KHOLIEJJFCA
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Task GEEICIDKJDP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AE10", Offset = "0x6D59610", VA = "0x186D5AE10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GAGGDDKFDHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool AAGNCMOIOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string JEKNDBLIDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public CIHAHAGDENN IKHHENHDCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AB0", Offset = "0x8B52B0", VA = "0x1808B6AB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action LAKBOOHDCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B4F0", Offset = "0x6D59CF0", VA = "0x186D5B4F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B3A0", Offset = "0x6D59BA0", VA = "0x186D5B3A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action LIKJAHHDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AF30", Offset = "0x6D59730", VA = "0x186D5AF30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B070", Offset = "0x6D59870", VA = "0x186D5B070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action MOIFHLMAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AFD0", Offset = "0x6D597D0", VA = "0x186D5AFD0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B250", Offset = "0x6D59A50", VA = "0x186D5B250", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<NMBDGOHOEKM> MAABBDNPGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B2F0", Offset = "0x6D59AF0", VA = "0x186D5B2F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B440", Offset = "0x6D59C40", VA = "0x186D5B440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABPCHEFDHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AEA0", Offset = "0x6D596A0", VA = "0x186D5AEA0", Slot = "12")]
	public Task EHFCOOMFLME(string ILMGIEMLOCH, [Optional] AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AD80", Offset = "0x6D59580", VA = "0x186D5AD80", Slot = "18")]
	public Task DBAEADCHDEI(AHCEOCKOIIG HOHMNCPBCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B110", Offset = "0x6D59910", VA = "0x186D5B110", Slot = "19")]
	public Task GDBPMFJAOPG(AHCEOCKOIIG HOHMNCPBCJA, Dictionary<string, string> FOGJDPIHAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "20")]
	public bool PNDCLLGJIMC(string KIOKOPNCEOO, bool FJHGOJLLMFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B1A0", Offset = "0x6D599A0", VA = "0x186D5B1A0", Slot = "21")]
	public JFLMKPADPMF HJMECDFFPHO(string EOHAHOLHAFK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D5AC60", Offset = "0x6D59460", VA = "0x186D5AC60", Slot = "22")]
	public GGDHHCPDIBD AKLIDCGBBKP(string MOGICMFHHLK, bool FJHGOJLLMFM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D5ACF0", Offset = "0x6D594F0", VA = "0x186D5ACF0", Slot = "23")]
	public Task BCBJCDIBNBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal class HFOHMDDDJDF : CIHAHAGDENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly JOBEHPCEDFJ AIDGABNBHOJ;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IReadOnlyDictionary<string, object> CCDFLDMELBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F2990", Offset = "0x9F1190", VA = "0x1809F2990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8C0090", Offset = "0x8BE890", VA = "0x1808C0090")]
	public HFOHMDDDJDF(JOBEHPCEDFJ KOBABMFCPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JMHNOHPGGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JPADPJDEKIF AFPOHGKGEGC(string PPKAABHDHGK);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KEKAPCFDNME
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ONGDAGHGNMG
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	long PMLNFGOGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string IPCEOBFCOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string DHLENHFHMAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool IMHMKMJGNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long LOPHOACDIDE();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLANLBNONBC(long JJNICACABPB, bool PNFKKGMMLNP = true);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HJPKLCIGGPO(string IKGPEBFFMPK, string DJAHFJKCKHL, string LMDNGEIKACH);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MGEGFOOCHAB(string IKGPEBFFMPK);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ALBNNGGBAAP(string IKGPEBFFMPK, string MKADAEINKCB, string NCHACHPMIHH);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKCADLPLOKK(string NKMKHNNHPJD, object AEJCDFOCKFB, object JHEECFAMGAA);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MCACOHAALJO(ONGDAGHGNMG DHIJNOHMCPC, int CEHMFIFBHOE, [Optional] LCGDKKHFGMF MFCJINOOPFA, [Optional] string OJFLKNLHMHG, [Optional] string JBBHONJKFOI);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DFGNKAAJIDL(LCGDKKHFGMF MFCJINOOPFA, long BGIBJFAHLBK, long MDMPFKHDPEF, int FBOHAPBAOEH, string OJFLKNLHMHG, int CEHMFIFBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MPDEPMCMLNP(LCGDKKHFGMF MFCJINOOPFA, bool ANJHFABIGJN, [Optional] string JBBHONJKFOI);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CHNOCPPJGGP(LCGDKKHFGMF MFCJINOOPFA, bool ANJHFABIGJN, [Optional] string JBBHONJKFOI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KBLHIBNIJCA(LCGDKKHFGMF MFCJINOOPFA, bool ANJHFABIGJN, [Optional] string JBBHONJKFOI);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void APAMHLNJMPD(long NKDNOGOOODN, string MFNHDJHNEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NMNGILNFNPL
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string NBCBEOMGKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
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
