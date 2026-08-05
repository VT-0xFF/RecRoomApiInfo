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
using RecNet;
using RecRoom.Analytics.AccessInterfaces;
using RecRoom.Async;
using RecRoom.Core;
using RecRoom.Crm;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Preferences;
using StatsigUnity;
using UJect;
using UJect.Injection;
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8257A50", Offset = "0x8256050", VA = "0x188257A50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8257890", Offset = "0x8255E90", VA = "0x188257890", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Analytics_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8261400", Offset = "0x825FA00", VA = "0x188261400", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
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
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AmplitudeAnalyticsClient.Settings editorSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private bool forceEditorSettingsForDevelopers;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AmplitudeAnalyticsClient.Settings YMHXXUKQPUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MOBGDOHNXOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, UVPGGFUQPUW
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private enum QuitState
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			Running,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			WaitingForFlush,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Flushed
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		internal class AnalyticsCache
		{
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class Item
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				public int CYUNDOVTPZH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> TPUXDYOCFJA;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public Item()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class PMCLZVAKTMZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public int? GDNDVYLLGJS;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public PMCLZVAKTMZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x8257D60", Offset = "0x8256360", VA = "0x188257D60")]
				internal bool KULYARQHDPA(Item a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string EORGOHLEBDB = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string JCDBSKRWXIT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<Item> QMXFLAHQKBN;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? DUDJXHQLZNG
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x82553A0", Offset = "0x82539A0", VA = "0x1882553A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82562A0", Offset = "0x82548A0", VA = "0x1882562A0")]
			internal AnalyticsCache(string cacheName, string recNetEnv)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82550F0", Offset = "0x82536F0", VA = "0x1882550F0")]
			public int FNULUGFRZVL([Optional] int? a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8256030", Offset = "0x8254630", VA = "0x188256030")]
			public List<Dictionary<string, object>> VYQHGJHNJMI(int a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8255440", Offset = "0x8253A40", VA = "0x188255440")]
			public void IKWHKLNOBEO(AmplitudeAnalyticsIdentifyMessage a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82554E0", Offset = "0x8253AE0", VA = "0x1882554E0")]
			public void IKWHKLNOBEO(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8255A90", Offset = "0x8254090", VA = "0x188255A90")]
			public void QJBSSCUWQXC(params Dictionary<string, object>[] objs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8255DF0", Offset = "0x82543F0", VA = "0x188255DF0")]
			public void TABIEFFSMYY(List<Dictionary<string, object>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x82552A0", Offset = "0x82538A0", VA = "0x1882552A0")]
			private void FSSDKUSWHBB(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8255C00", Offset = "0x8254200", VA = "0x188255C00")]
			public void SaveToDisk()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8255640", Offset = "0x8253C40", VA = "0x188255640")]
			private void LoadFromDisk([Optional] string filePath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8254FD0", Offset = "0x82535D0", VA = "0x188254FD0")]
			private static string CRZOMAJWTMZ(string a, string b)
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
			[Cpp2IlInjected.Address(RVA = "0x82589A0", Offset = "0x8256FA0", VA = "0x1882589A0")]
			public Settings()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct EventResponse<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int statusCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public string responseText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T eventParams;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class OKCKHPVXELG : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float UYBCAYAIRSD;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public OKCKHPVXELG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8257AD0", Offset = "0x82560D0", VA = "0x188257AD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8257D20", Offset = "0x8256320", VA = "0x188257D20", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class TJRECNZANHY : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float UYBCAYAIRSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AnalyticsCache EGMRVGKGYOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? GDNDVYLLGJS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string ZNZYXLOJIVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action<int> XBUNLDPMJCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float FKZSYVHVDNW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<Dictionary<string, object>> FXTHRSEIWGQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private bool XJYLJMVUWBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool FBSSEOQZCYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int JTUEQSGYQCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private Task<EventResponse<List<Dictionary<string, object>>>> JCNDLTCEGGL;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public TJRECNZANHY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8258E60", Offset = "0x8257460", VA = "0x188258E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8259AA0", Offset = "0x82580A0", VA = "0x188259AA0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class QCADMOTDIUU : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float UYBCAYAIRSD;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public QCADMOTDIUU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8257DD0", Offset = "0x82563D0", VA = "0x188257DD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8258020", Offset = "0x8256620", VA = "0x188258020", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZPEIJSBXKTL : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsEvent WMCJSTXUYIU;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public ZPEIJSBXKTL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8260C40", Offset = "0x825F240", VA = "0x188260C40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x82613C0", Offset = "0x825F9C0", VA = "0x1882613C0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <PostJson>d__123 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public AsyncTaskMethodBuilder<EventResponse<Dictionary<string, object>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public Dictionary<string, object> eventParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public string rudderStackKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<EventResponse<Dictionary<string, object>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x825C080", Offset = "0x825A680", VA = "0x18825C080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x825C310", Offset = "0x825A910", VA = "0x18825C310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private struct <PostJson>d__124 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<EventResponse<List<Dictionary<string, object>>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public List<Dictionary<string, object>> eventParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public string dataIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public string rudderStackKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private TaskAwaiter<EventResponse<List<Dictionary<string, object>>>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x825C380", Offset = "0x825A980", VA = "0x18825C380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x825C8B0", Offset = "0x825AEB0", VA = "0x18825C8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private struct <PostRudderStackJson>d__125<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AsyncTaskMethodBuilder<EventResponse<T>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public string rudderStackKey;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public Dictionary<string, object> rudderStackEventParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public AmplitudeAnalyticsClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public T eventParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<PostResponse> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x520BF40", Offset = "0x520A540", VA = "0x18520BF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5207C10", Offset = "0x5206210", VA = "0x185207C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class YZCMNXEQABC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float UYBCAYAIRSD;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public YZCMNXEQABC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x82601C0", Offset = "0x825E7C0", VA = "0x1882601C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8260330", Offset = "0x825E930", VA = "0x188260330", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class NOZLRSKZDLL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public FOBJSUETHEV DHMJKDYRERL;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object ENGTUJRFGYV
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public NOZLRSKZDLL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8257910", Offset = "0x8255F10", VA = "0x188257910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8257A10", Offset = "0x8256010", VA = "0x188257A10", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private WQEISMLFQPB SKCFQLHZXMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<GCXMAKCZGQA> ZAZXROKTHNT;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string QAUFAGWVPEL = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string PAUCUQVNUVI = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string SITRZVVIROE = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CKZRTHQETRK = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int AXOHIFXBRVB = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int ZIHMVDCZCVR = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float CHJGRLOAQPW = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long CUSOWNWJIBZ = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PQPCLOKBOUU = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string STOHBVUUPQH = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string WPVMHKTUBWO = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string DWVVZXUBUAC = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool WNIPLJIDLGB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool JNIYICFONUS;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int KQPBSSKSXPB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int HWELHBISZWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private MIXPMIBRMMD EJDDJBJPFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EANKQRVHIPH WPCLKQRVZFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private XUVMDMZQVTP ISSBWSUMWLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool UZUVEVHSHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float KLKUDKUZFGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float IUSILJDOHVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int SVTUCWPQVDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int JGPUGMHRLJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? KODZPEZFPRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? RGXKZPYXIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long ENFWQHRTUKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string VNKEYYWNSDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string DJNVMCAAIZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long JQEFSSLKXFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string JUERXCDMKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string INIQVEKZHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> FLZQPJLQSMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private QuitState IZUEBMRAYVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LMFRLFVHSWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int LENFQGXQTNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float KNIBJSVZRJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool QCBWGWAXAWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool LCXTBIFJXVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AnalyticsCache DMLBOUUUFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AnalyticsCache AFULBAYSFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AnalyticsCache DILPSRKULJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string WLFJXTMVWVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> OPXTOFPMXHW;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo VJILKNFXFOA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string YHKSJPTZMTN;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string ALXVTAOEMNG = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string LIHYHSGQVOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string GHGTOLXVJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string LVKDBTXEAGV;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private WQEISMLFQPB JZFKDAUMBDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x824FA00", Offset = "0x824E000", VA = "0x18824FA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GCXMAKCZGQA SSATYJCMLTJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82531E0", Offset = "0x82517E0", VA = "0x1882531E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ITKNCXGLOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x824F800", Offset = "0x824DE00", VA = "0x18824F800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long BOMLGTGRWTL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8253950", Offset = "0x8251F50", VA = "0x188253950")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8253A60", Offset = "0x8252060", VA = "0x188253A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string TVIDJUNWRXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8253920", Offset = "0x8251F20", VA = "0x188253920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCB6C50", Offset = "0xCB5250", VA = "0x180CB6C50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCBBF50", Offset = "0xCBA550", VA = "0x180CBBF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB14AC0", Offset = "0xB130C0", VA = "0x180B14AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB9D6C0", Offset = "0xB9BCC0", VA = "0x180B9D6C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? ZKASHNAXQWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB102F0", Offset = "0xB0E8F0", VA = "0x180B102F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB96140", Offset = "0xB94740", VA = "0x180B96140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YORNAVSQXRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB96130", Offset = "0xB94730", VA = "0x180B96130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xBBD640", Offset = "0xBBBC40", VA = "0x180BBD640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool XKJPVKNVIOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82537F0", Offset = "0x8251DF0", VA = "0x1882537F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> XUXTRMBRPEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8253730", Offset = "0x8251D30", VA = "0x188253730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x82539A0", Offset = "0x8251FA0", VA = "0x1882539A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x824DD90", Offset = "0x824C390", VA = "0x18824DD90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x824E670", Offset = "0x824CC70", VA = "0x18824E670")]
		private void DCKPYUSWKYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8251D50", Offset = "0x8250350", VA = "0x188251D50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8250420", Offset = "0x824EA20", VA = "0x188250420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8252ED0", Offset = "0x82514D0", VA = "0x188252ED0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82504D0", Offset = "0x824EAD0", VA = "0x1882504D0")]
		public VCIEUBMMHTW PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x824F670", Offset = "0x824DC70", VA = "0x18824F670")]
		[IteratorStateMachine(typeof(ZPEIJSBXKTL))]
		public IEnumerator<SGCTHXNJFVM> InitializeForLocalAccount(AmplitudeAnalyticsEvent initialEvent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8251400", Offset = "0x824FA00", VA = "0x188251400")]
		public void SendAppEnterEvent(bool delaySend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8252E50", Offset = "0x8251450", VA = "0x188252E50")]
		public void UpdateLastKnownInteractionCategory(string interactionCategory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8252DA0", Offset = "0x82513A0", VA = "0x188252DA0")]
		public void UpdateLastAliveTime(float deltaTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8251080", Offset = "0x824F680", VA = "0x188251080")]
		private VCIEUBMMHTW QWRGQBCDLSR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8253280", Offset = "0x8251880", VA = "0x188253280")]
		private VCIEUBMMHTW YXNIRGNPHAY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8251740", Offset = "0x824FD40", VA = "0x188251740")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8250E30", Offset = "0x824F430", VA = "0x188250E30")]
		[IteratorStateMachine(typeof(NOZLRSKZDLL))]
		private IEnumerator QKLERKABYQU(FOBJSUETHEV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8253160", Offset = "0x8251760", VA = "0x188253160")]
		[IteratorStateMachine(typeof(YZCMNXEQABC))]
		public IEnumerator WaitForFlush(float timeout = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8251E30", Offset = "0x8250430", VA = "0x188251E30")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8251D70", Offset = "0x8250370", VA = "0x188251D70")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime time)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x824F190", Offset = "0x824D790", VA = "0x18824F190")]
		public static LUEWRAYDYHE Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x824DBE0", Offset = "0x824C1E0", VA = "0x18824DBE0")]
		public static ZEYZKKYTMYE AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string event_type, string userId, CrmType assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x824EC30", Offset = "0x824D230", VA = "0x18824EC30")]
		public static ZEYZKKYTMYE Event([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8250650", Offset = "0x824EC50", VA = "0x188250650")]
		public static ZEYZKKYTMYE PreviousSessionEvent([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x824F320", Offset = "0x824D920", VA = "0x18824F320")]
		public static ZEYZKKYTMYE InitializeEvent(string userId, int allocatedMemMBOnBoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8251940", Offset = "0x824FF40", VA = "0x188251940")]
		public static ZEYZKKYTMYE StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x824E3B0", Offset = "0x824C9B0", VA = "0x18824E3B0")]
		public static ZEYZKKYTMYE CreateOutOfSessionEvent(string event_type, bool anonymous = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x824FCF0", Offset = "0x824E2F0", VA = "0x18824FCF0")]
		public static VCIEUBMMHTW LogOutOfSessionEvent(ZEYZKKYTMYE eventToLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x824FA90", Offset = "0x824E090", VA = "0x18824FA90")]
		public void LogEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x824FED0", Offset = "0x824E4D0", VA = "0x18824FED0")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8250000", Offset = "0x824E600", VA = "0x188250000")]
		public void LogSerializedEventAsync(Dictionary<string, object> serializedAnalyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x824FBC0", Offset = "0x824E1C0", VA = "0x18824FBC0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage identifyMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x824EF30", Offset = "0x824D530", VA = "0x18824EF30")]
		private void FYIZZBCLKSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82500E0", Offset = "0x824E6E0", VA = "0x1882500E0")]
		private void MQLJYMAGKUM(Dictionary<string, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x824DAF0", Offset = "0x824C0F0", VA = "0x18824DAF0")]
		private void AAQQZSHFVTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8250EC0", Offset = "0x824F4C0", VA = "0x188250EC0")]
		private void QNCLCCZCGVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x824F100", Offset = "0x824D700", VA = "0x18824F100")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x824EBB0", Offset = "0x824D1B0", VA = "0x18824EBB0")]
		[IteratorStateMachine(typeof(OKCKHPVXELG))]
		private IEnumerator<SGCTHXNJFVM> DYTOGILCRFV(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82503A0", Offset = "0x824E9A0", VA = "0x1882503A0")]
		[IteratorStateMachine(typeof(QCADMOTDIUU))]
		private IEnumerator<SGCTHXNJFVM> MRDMJNIEWBJ(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x824F020", Offset = "0x824D620", VA = "0x18824F020")]
		[IteratorStateMachine(typeof(TJRECNZANHY))]
		private IEnumerator<SGCTHXNJFVM> FlushFromCache(AnalyticsCache cache, int? earlierThanFrame, string dataIdentifier, float timeout, Action<int> onBatchSent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x824F700", Offset = "0x824DD00", VA = "0x18824F700")]
		private static void KIEOXOILLRD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8251130", Offset = "0x824F730", VA = "0x188251130")]
		[AsyncStateMachine(typeof(<PostJson>d__123))]
		private Task<EventResponse<Dictionary<string, object>>> RILUUQDYIHW(string a, string b, Dictionary<string, object> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8251290", Offset = "0x824F890", VA = "0x188251290")]
		[AsyncStateMachine(typeof(<PostJson>d__124))]
		private Task<EventResponse<List<Dictionary<string, object>>>> RILUUQDYIHW(string a, string b, List<Dictionary<string, object>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x32B56C0", Offset = "0x32B3CC0", VA = "0x1832B56C0")]
		[AsyncStateMachine(typeof(<PostRudderStackJson>d__125<>))]
		private Task<EventResponse<T>> PostRudderStackJson<T>(string url, string dataIdentifier, string rudderStackKey, T eventParams, Dictionary<string, object> rudderStackEventParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8253230", Offset = "0x8251830", VA = "0x188253230")]
		private bool YGEBNUSPDND(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8251F50", Offset = "0x8250550", VA = "0x188251F50")]
		private Dictionary<string, object> UUIIJTFLXBV(string a, Dictionary<string, object> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8253440", Offset = "0x8251A40", VA = "0x188253440")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAD30B0", Offset = "0xAD16B0", VA = "0x180AD30B0", Slot = "6")]
		private bool FBHCIIFSLTL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x824EA40", Offset = "0x824D040", VA = "0x18824EA40")]
		[CompilerGenerated]
		private long DODFVVRTCHB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82513F0", Offset = "0x824F9F0", VA = "0x1882513F0")]
		[CompilerGenerated]
		private void RVNQDGRXTNL(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string XWYVHAXMWCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string LIGHVJEXCSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly long YFBDPGMMRRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string RQBOTKGKJRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal Dictionary<string, object> TWAMTSYSSIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private string KPPBBIUFZWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long RKBUCJXUHFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long IKVFOPLEEXD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8254730", Offset = "0x8252D30", VA = "0x188254730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8254800", Offset = "0x8252E00", VA = "0x188254800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8254770", Offset = "0x8252D70", VA = "0x188254770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8254850", Offset = "0x8252E50", VA = "0x188254850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x82546F0", Offset = "0x8252CF0", VA = "0x1882546F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x82547B0", Offset = "0x8252DB0", VA = "0x1882547B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8253C20", Offset = "0x8252220", VA = "0x188253C20")]
		public static ZEYZKKYTMYE Create(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8253AC0", Offset = "0x82520C0", VA = "0x188253AC0")]
		public static ZEYZKKYTMYE AFEROVWEADD(string a, [JetBrains.Annotations.NotNull] string eventType, long b, long c, string d, long e, string f, string g, string h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8254550", Offset = "0x8252B50", VA = "0x188254550")]
		private AmplitudeAnalyticsEvent(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1071260", Offset = "0x106F860", VA = "0x181071260")]
		public void OZBZNKFRPIV(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8254450", Offset = "0x8252A50", VA = "0x188254450", Slot = "5")]
		public override void UITADCHSXYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x82541C0", Offset = "0x82527C0", VA = "0x1882541C0", Slot = "6")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8253D10", Offset = "0x8252310", VA = "0x188253D10", Slot = "4")]
		protected override Dictionary<string, object> JABMYYPPZVU(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8254340", Offset = "0x8252940", VA = "0x188254340")]
		private void UDUYLHNQYNH(string a, string b, bool c = false)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AmplitudeAnalyticsIdentifyMessage
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class DeviceInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public string platform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public string osName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public string osVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string deviceBrand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public string deviceManufacturer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public string deviceModel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public string deviceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public string carrier;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8256410", Offset = "0x8254A10", VA = "0x188256410")]
			public void XIEDYYGFVWK(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DeviceInfo()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class RevenueData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public float price;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int quantity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public float revenue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public string productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public string revenueType;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8258750", Offset = "0x8256D50", VA = "0x188258750")]
			public void XIEDYYGFVWK(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1632040", Offset = "0x1630640", VA = "0x181632040")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal DeviceInfo HLUYIEYETEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal RevenueData UTFQRTAJULK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly string ECKDOMTAJQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string KPPBBIUFZWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		internal Dictionary<string, object> GGTMAWFNTDQ;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8254940", Offset = "0x8252F40", VA = "0x188254940")]
		public static LUEWRAYDYHE Create(string version, string userId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8254F10", Offset = "0x8253510", VA = "0x188254F10")]
		protected AmplitudeAnalyticsIdentifyMessage(string version, string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82549F0", Offset = "0x8252FF0", VA = "0x1882549F0")]
		public Dictionary<string, object> FOCTKTZDTPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8254A70", Offset = "0x8253070", VA = "0x188254A70", Slot = "4")]
		protected virtual Dictionary<string, object> JABMYYPPZVU(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82548A0", Offset = "0x8252EA0", VA = "0x1882548A0")]
		protected void CITZVBPGLMW(string a, Dictionary<string, object> b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8254E10", Offset = "0x8253410", VA = "0x188254E10")]
		protected void SYXSSAZPWYA(string a, string b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8254E80", Offset = "0x8253480", VA = "0x188254E80", Slot = "5")]
		public virtual void UITADCHSXYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8254D90", Offset = "0x8253390", VA = "0x188254D90", Slot = "6")]
		public virtual void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class LUEWRAYDYHE : NBMOTZDBWUW<AmplitudeAnalyticsIdentifyMessage, LUEWRAYDYHE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override LUEWRAYDYHE OREWMQEESQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "5")]
		public override AmplitudeAnalyticsIdentifyMessage Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8257710", Offset = "0x8255D10", VA = "0x188257710")]
		public LUEWRAYDYHE(AmplitudeAnalyticsIdentifyMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8257670", Offset = "0x8255C70", VA = "0x188257670", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ZEYZKKYTMYE : NBMOTZDBWUW<AmplitudeAnalyticsEvent, ZEYZKKYTMYE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool SFMQZXMIFOW;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override ZEYZKKYTMYE OREWMQEESQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long OFCHOSKLVTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x82605C0", Offset = "0x825EBC0", VA = "0x1882605C0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8260A50", Offset = "0x825F050", VA = "0x188260A50")]
		public ZEYZKKYTMYE(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "5")]
		public override AmplitudeAnalyticsEvent Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8260980", Offset = "0x825EF80", VA = "0x188260980", Slot = "4")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8260700", Offset = "0x825ED00", VA = "0x188260700")]
		public ZEYZKKYTMYE ITXCMLULPYF(string a, long[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9F80", Offset = "0x3EE8580", VA = "0x183EE9F80")]
		public ZEYZKKYTMYE ITXCMLULPYF<a>(string a, a[] b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9F80", Offset = "0x3EE8580", VA = "0x183EE9F80")]
		public ZEYZKKYTMYE ITXCMLULPYF(string a, string[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9C90", Offset = "0x3EE8290", VA = "0x183EE9C90")]
		public ZEYZKKYTMYE ITXCMLULPYF<b>(string a, b b) where b : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8260680", Offset = "0x825EC80", VA = "0x188260680")]
		public ZEYZKKYTMYE ITXCMLULPYF(string a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8260810", Offset = "0x825EE10", VA = "0x188260810")]
		public ZEYZKKYTMYE ITXCMLULPYF(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8260A20", Offset = "0x825F020", VA = "0x188260A20")]
		public ZEYZKKYTMYE YXRSHQUZUZA(string a, object? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82605E0", Offset = "0x825EBE0", VA = "0x1882605E0")]
		public ZEYZKKYTMYE CNRFUJLNEII(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8260880", Offset = "0x825EE80", VA = "0x188260880")]
		private ZEYZKKYTMYE JDXWLBUGUQU(string a, object b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ZJWEQNAUYQR : ZEYZKKYTMYE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8260A50", Offset = "0x825F050", VA = "0x188260A50")]
		public ZJWEQNAUYQR(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8260AA0", Offset = "0x825F0A0", VA = "0x188260AA0", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class NBMOTZDBWUW<b, c> where b : AmplitudeAnalyticsIdentifyMessage where c : NBMOTZDBWUW<b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected b MPZKLQFYNSH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract c OREWMQEESQU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public NBMOTZDBWUW(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B7C0", Offset = "0x5A69DC0", VA = "0x185A6B7C0")]
		public c IBGCHSHBHBE(AmplitudeAnalyticsIdentifyMessage.DeviceInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B810", Offset = "0x5A69E10", VA = "0x185A6B810")]
		public c LYYGKISIRTG(AmplitudeAnalyticsIdentifyMessage.RevenueData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B670", Offset = "0x5A69C70", VA = "0x185A6B670")]
		public c EFTJVDFBWDM(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A4DB60", Offset = "0x3A4C160", VA = "0x183A4DB60")]
		public c EFTJVDFBWDM<a>(string a, a b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LogAsync();

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B790", Offset = "0x5A69D90", VA = "0x185A6B790")]
		internal static string GYGZWXSTXQH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B860", Offset = "0x5A69E60", VA = "0x185A6B860")]
		private c SDHADHBFIJR(string a, object b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract b Build();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class YZFJGFJNFAS : MIXPMIBRMMD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private struct <PostJsonBasicAuth>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder<PostResponse> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public string bodyJson;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public string username;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public string password;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public YZFJGFJNFAS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private StringContent <requestBody>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private HttpRequestMessage <request>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private HttpResponseMessage <httpResponse>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<HttpResponseMessage> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<string> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x825B610", Offset = "0x8259C10", VA = "0x18825B610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x825C010", Offset = "0x825A610", VA = "0x18825C010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private HttpClient UIDQHZIWBZQ;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8260370", Offset = "0x825E970", VA = "0x188260370")]
		[ZOKCDQOPSGU.Root]
		internal static void JIQRYJWGXWO(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8260550", Offset = "0x825EB50", VA = "0x188260550")]
		[RecRoom.NoEngine.Common.Preserve]
		public YZFJGFJNFAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x82603E0", Offset = "0x825E9E0", VA = "0x1882603E0", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__4))]
		public Task<PostResponse> XKEOEJPDRLW(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class AFZGWXQLTNF : MIXPMIBRMMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class XIPYLIIUTHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public UnityWebRequest IPZSVHKCSSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TaskCompletionSource<PostResponse> DJPZNQAOSXE;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XIPYLIIUTHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x825F880", Offset = "0x825DE80", VA = "0x18825F880")]
			internal void EYYJFKMCXYK(AsyncOperation a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <PostJsonBasicAuth>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<PostResponse> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string bodyJson;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string url;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public string username;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string password;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<PostResponse> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x825B090", Offset = "0x8259690", VA = "0x18825B090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x825B5A0", Offset = "0x8259BA0", VA = "0x18825B5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		[ZOKCDQOPSGU.Root]
		internal static void YTCOWYROFPD(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public AFZGWXQLTNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x824D800", Offset = "0x824BE00", VA = "0x18824D800", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__3))]
		public Task<PostResponse> XKEOEJPDRLW(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AJPIBUTPGCZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> LLOENHSHQII;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x824D960", Offset = "0x824BF60", VA = "0x18824D960")]
		internal static bool AQPODWSKDFR(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface MIXPMIBRMMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PostResponse> XKEOEJPDRLW(string a, string b, string c, string d);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct PostResponse
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly int StatusCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly string DataAsText;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x19C4AC0", Offset = "0x19C30C0", VA = "0x1819C4AC0")]
		public PostResponse(int statusCode, string responseText)
		{
		}
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum ChatTelemetrySource
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		ChatPage,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		PlayerDetailsScreen,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		ActionCode,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		FriendImport,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		PlatformFriendInvite,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		PlatformNotification,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		WatchNotification,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		LegacyHomeScreen,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		NavigationBar,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		LegacyChatPage,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		MobileHomeChat,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		PlayerProfile,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		ShareContent,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		HUDHotbarShortcut,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		GameInvite,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		RoomChat,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		DebugCommand,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		WidgetWatch
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RAHLCSUYNGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private long GWJZNOCADOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private ZEYZKKYTMYE MCIPRLQNAUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool TOCXGPKYLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private float TSCXKEVATKY;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x82585C0", Offset = "0x8256BC0", VA = "0x1882585C0")]
		public RAHLCSUYNGL(string a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B440", Offset = "0x3C39A40", VA = "0x183C3B440")]
		public void ITXCMLULPYF<a>(string a, a b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8258320", Offset = "0x8256920", VA = "0x188258320")]
		public void ITXCMLULPYF(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8258230", Offset = "0x8256830", VA = "0x188258230")]
		public void Fail(string failureMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x82584B0", Offset = "0x8256AB0", VA = "0x1882584B0")]
		public void OFYRQGYYPWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82583A0", Offset = "0x82569A0", VA = "0x1882583A0")]
		private void OBMUZVWJJBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8258570", Offset = "0x8256B70", VA = "0x188258570")]
		private bool SQHAVCPJDCL()
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Analytics.Statsig
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SerializedStatsigExperimentSegment
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum ParameterType
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			String,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Bool
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private string experimentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private string parameterName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		private ParameterType parameterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private string parameterValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private bool boolValue;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ExperimentName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ParameterType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
			get
			{
				return default(ParameterType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x82588B0", Offset = "0x8256EB0", VA = "0x1882588B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class DLRHKCOILHX<a> : RZEJFZHJNSW<a>, LQCTLDAVHQN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly YAEPLJOWYUO IRYXGQYJBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly string PPPZOZSOUTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly string ZRYZNOQNEXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private a VYANXXDWHSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly a SHIETRXPSKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool CFHEZPGXZVC;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string COTBMNXENNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4319710", Offset = "0x4317D10", VA = "0x184319710")]
		public DLRHKCOILHX(YAEPLJOWYUO a, string b, string c, a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4319570", Offset = "0x4317B70", VA = "0x184319570", Slot = "4")]
		public a MSUQGLLKEHH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x17157E0", Offset = "0x1713DE0", VA = "0x1817157E0", Slot = "6")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.NoEngine.Common.Preserve]
	public class StatsigCachedValueFactory : RSHWUQSFCAZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct LayerParamCacheKey : IEquatable<LayerParamCacheKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly string LayerName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly string ParamName;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			public LayerParamCacheKey(string layerName, string paramName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x146D850", Offset = "0x146BE50", VA = "0x18146D850", Slot = "4")]
			public bool Equals(LayerParamCacheKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8257760", Offset = "0x8255D60", VA = "0x188257760", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8257820", Offset = "0x8255E20", VA = "0x188257820", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private YAEPLJOWYUO IRYXGQYJBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Dictionary<LayerParamCacheKey, LQCTLDAVHQN> OVXNWTAELQM;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8258C50", Offset = "0x8257250", VA = "0x188258C50")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void GVEUOOVHRBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8258CD0", Offset = "0x82572D0", VA = "0x188258CD0")]
		[RecRoom.NoEngine.Common.Preserve]
		public StatsigCachedValueFactory([Inject(null)][System.Diagnostics.CodeAnalysis.NotNull] YAEPLJOWYUO statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x82589B0", Offset = "0x8256FB0", VA = "0x1882589B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8258CC0", Offset = "0x82572C0", VA = "0x188258CC0")]
		private void SUZLZWUDSGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8258AA0", Offset = "0x82570A0", VA = "0x188258AA0")]
		private void EVXCOCVKFTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D38CF0", Offset = "0x3D372F0", VA = "0x183D38CF0", Slot = "4")]
		public RZEJFZHJNSW<a> CIBHGOSNGSY<a>(string a, string b, a c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class TJVLQKTXRFA : VMNMQIOPYIB, XLIQMFXRMOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly JKWMOUVYVGL QIGQVWAVODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly GetCallback MQILLRSWCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string NUNPUASRQDT;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x134A510", Offset = "0x1348B10", VA = "0x18134A510", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string SOTSKTZNZKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1EF0200", Offset = "0x1EEE800", VA = "0x181EF0200", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OXGYWAESBME
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8259B00", Offset = "0x8258100", VA = "0x188259B00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool JTLJXXJMTHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8259AE0", Offset = "0x82580E0", VA = "0x188259AE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyList<string> JJYBMGUXEAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1EF01B0", Offset = "0x1EEE7B0", VA = "0x181EF01B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1513C20", Offset = "0x1512220", VA = "0x181513C20")]
		public TJVLQKTXRFA(JKWMOUVYVGL a, string b, [Optional] GetCallback c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F530", Offset = "0x3D5DB30", VA = "0x183D5F530", Slot = "9")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class VZNRTCNRBLL : YAEPLJOWYUO, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <Initialize>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public EANKQRVHIPH userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public VZNRTCNRBLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public string recNetEnv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private bool <containsUserInfo>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x825A6E0", Offset = "0x8258CE0", VA = "0x18825A6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x825B030", Offset = "0x8259630", VA = "0x18825B030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <Shutdown>d__60 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x825C920", Offset = "0x825AF20", VA = "0x18825C920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x825CB00", Offset = "0x825B100", VA = "0x18825CB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <UpdateUser>d__61 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public EANKQRVHIPH userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public VZNRTCNRBLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private bool <containsUserInfo>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private bool <fireInitEvent>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x825D350", Offset = "0x825B950", VA = "0x18825D350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x825D770", Offset = "0x825BD70", VA = "0x18825D770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <UpdateUserAddCustomIds>d__63 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public VZNRTCNRBLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public EANKQRVHIPH userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Dictionary<string, string> customIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x825CF30", Offset = "0x825B530", VA = "0x18825CF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x825D2F0", Offset = "0x825B8F0", VA = "0x18825D2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly IReadOnlyDictionary<string, EnvironmentTier> ZSLBEDVPQFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool QWSVTLRIJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool RGKLHGSTING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskCompletionSource<bool> DUQSRAHETCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskCompletionSource<bool> WSONKCYRFVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly SemaphoreSlim WGNWKKXGXBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private WWTFFXAOVZA UEBTMENDSEI;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Task GGCAKJPGFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x825F500", Offset = "0x825DB00", VA = "0x18825F500", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Task LROGKBAVEHB
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x825D9C0", Offset = "0x825BFC0", VA = "0x18825D9C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool WURVIRGAPUX
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GMEQOXNUKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBE49E0", Offset = "0xBE2FE0", VA = "0x180BE49E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x825F410", Offset = "0x825DA10", VA = "0x18825F410", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public DAMPXYLQMYJ CWMAYMDGNLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x825F420", Offset = "0x825DA20", VA = "0x18825F420", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action CHXVYXUMIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x825DBC0", Offset = "0x825C1C0", VA = "0x18825DBC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x825DA00", Offset = "0x825C000", VA = "0x18825DA00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action LHUPNPQLXLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x825E7C0", Offset = "0x825CDC0", VA = "0x18825E7C0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x825D870", Offset = "0x825BE70", VA = "0x18825D870", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MINWORPGXYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x825EDE0", Offset = "0x825D3E0", VA = "0x18825EDE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x825D7D0", Offset = "0x825BDD0", VA = "0x18825D7D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ParameterAccessRecord> NKOQBFQPRJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x825F450", Offset = "0x825DA50", VA = "0x18825F450", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x825F540", Offset = "0x825DB40", VA = "0x18825F540", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x825D9A0", Offset = "0x825BFA0", VA = "0x18825D9A0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x825DAA0", Offset = "0x825C0A0", VA = "0x18825DAA0", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__46))]
		public Task Initialize(string recNetEnv, [Optional] EANKQRVHIPH userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x825F1F0", Offset = "0x825D7F0", VA = "0x18825F1F0", Slot = "22")]
		[AsyncStateMachine(typeof(<Shutdown>d__60))]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x825F0F0", Offset = "0x825D6F0", VA = "0x18825F0F0", Slot = "17")]
		[AsyncStateMachine(typeof(<UpdateUser>d__61))]
		public Task SLOPHSNMLOO(EANKQRVHIPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x825D910", Offset = "0x825BF10", VA = "0x18825D910")]
		private void BOEOASLTQQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x825EFE0", Offset = "0x825D5E0", VA = "0x18825EFE0", Slot = "18")]
		[AsyncStateMachine(typeof(<UpdateUserAddCustomIds>d__63))]
		public Task RTJBNIVFRLG(EANKQRVHIPH a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x825E860", Offset = "0x825CE60", VA = "0x18825E860", Slot = "19")]
		public bool NRRPZRQXRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x825F2A0", Offset = "0x825D8A0", VA = "0x18825F2A0", Slot = "20")]
		public VMNMQIOPYIB TPETXWUAKKD(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x825ECD0", Offset = "0x825D2D0", VA = "0x18825ECD0")]
		private JKWMOUVYVGL RCNCCRDLOIW(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x825EE80", Offset = "0x825D480", VA = "0x18825EE80", Slot = "21")]
		public TBHWXJAMPWT RTFYQQVUXND(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x825EBD0", Offset = "0x825D1D0", VA = "0x18825EBD0")]
		private COTBMNXENNH QYDAOZUXLTS(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x825DE00", Offset = "0x825C400", VA = "0x18825DE00")]
		private UAQBPCEJCIQ LPIXQWIOWUQ(EANKQRVHIPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x825DC60", Offset = "0x825C260", VA = "0x18825DC60")]
		private MURIKHXWSGD LDQHSBHRRJR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x825E950", Offset = "0x825CF50", VA = "0x18825E950")]
		private void PYEFLALUGDC(string a, JKWMOUVYVGL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x825F7A0", Offset = "0x825DDA0", VA = "0x18825F7A0")]
		public VZNRTCNRBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x825E780", Offset = "0x825CD80", VA = "0x18825E780")]
		[CompilerGenerated]
		private void MCXXXYPHNAP(ParameterAccessRecord a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x825E780", Offset = "0x825CD80", VA = "0x18825E780")]
		[CompilerGenerated]
		private void TVODUKKXVYX(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class IOTWOVYVNKE : YAEPLJOWYUO, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private struct <ForwardTaskToTCS>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public Task task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public TaskCompletionSource<bool> tcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8259B20", Offset = "0x8258120", VA = "0x188259B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <Initialize>d__23 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public IOTWOVYVNKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public EANKQRVHIPH userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public string recNetEnv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8259D60", Offset = "0x8258360", VA = "0x188259D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x825A680", Offset = "0x8258C80", VA = "0x18825A680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private VZNRTCNRBLL YFQIFKVUPHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[CompilerGenerated]
		private Action LHUPNPQLXLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskCompletionSource<bool> DUQSRAHETCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskCompletionSource<bool> WSONKCYRFVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Task TVLVRCGWUCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Task NXXRQUNHLGL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private YAEPLJOWYUO QLSILRZRARE
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8257550", Offset = "0x8255B50", VA = "0x188257550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GMEQOXNUKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8256C40", Offset = "0x8255240", VA = "0x188256C40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WURVIRGAPUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8256DD0", Offset = "0x82553D0", VA = "0x188256DD0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Task GGCAKJPGFEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8257400", Offset = "0x8255A00", VA = "0x188257400", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Task LROGKBAVEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8256730", Offset = "0x8254D30", VA = "0x188256730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x82572F0", Offset = "0x82558F0", VA = "0x1882572F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public DAMPXYLQMYJ CWMAYMDGNLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8257310", Offset = "0x8255910", VA = "0x188257310", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action CHXVYXUMIAP
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8256BA0", Offset = "0x82551A0", VA = "0x188256BA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8256880", Offset = "0x8254E80", VA = "0x188256880", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action MINWORPGXYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8256DE0", Offset = "0x82553E0", VA = "0x188256DE0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8256590", Offset = "0x8254B90", VA = "0x188256590", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ParameterAccessRecord> NKOQBFQPRJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8257350", Offset = "0x8255950", VA = "0x188257350", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x82574A0", Offset = "0x8255AA0", VA = "0x1882574A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82575C0", Offset = "0x8255BC0", VA = "0x1882575C0")]
		[UnityEngine.Scripting.Preserve]
		public IOTWOVYVNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x82567D0", Offset = "0x8254DD0", VA = "0x1882567D0")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void GVEUOOVHRBJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8256D60", Offset = "0x8255360", VA = "0x188256D60")]
		internal static void PIALAHBQCJZ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8256630", Offset = "0x8254C30", VA = "0x188256630", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8256920", Offset = "0x8254F20", VA = "0x188256920", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__23))]
		public Task Initialize(string recNetEnv, [Optional] EANKQRVHIPH userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8257040", Offset = "0x8255640", VA = "0x188257040", Slot = "17")]
		public Task SLOPHSNMLOO(EANKQRVHIPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8256F30", Offset = "0x8255530", VA = "0x188256F30", Slot = "18")]
		public Task RTJBNIVFRLG(EANKQRVHIPH a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8256C50", Offset = "0x8255250", VA = "0x188256C50", Slot = "19")]
		public bool NRRPZRQXRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8257240", Offset = "0x8255840", VA = "0x188257240", Slot = "20")]
		public VMNMQIOPYIB TPETXWUAKKD(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8256E80", Offset = "0x8255480", VA = "0x188256E80", Slot = "21")]
		public TBHWXJAMPWT RTFYQQVUXND(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8257140", Offset = "0x8255740", VA = "0x188257140", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8256A30", Offset = "0x8255030", VA = "0x188256A30")]
		private static void KKUUBMANBVF(TaskCompletionSource<bool> a, Task b, Task c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8256660", Offset = "0x8254C60", VA = "0x188256660")]
		[AsyncStateMachine(typeof(<ForwardTaskToTCS>d__43))]
		private static void FGCXUQUNUHL(Task a, TaskCompletionSource<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x10645C0", Offset = "0x1062BC0", VA = "0x1810645C0")]
		[CompilerGenerated]
		private void GYLEKLVQALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x10F93C0", Offset = "0x10F79C0", VA = "0x1810F93C0")]
		[CompilerGenerated]
		private void GYQLHSPNJWT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xF840D0", Offset = "0xF826D0", VA = "0x180F840D0")]
		[CompilerGenerated]
		private void GYVSEZJKTIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8256840", Offset = "0x8254E40", VA = "0x188256840")]
		[CompilerGenerated]
		private void GZAZCGDICTL(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class BLMDYNFAYXE : TBHWXJAMPWT, XLIQMFXRMOM
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly GetCallback MQILLRSWCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly COTBMNXENNH MOMKADTEUBM;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x2A387D0", Offset = "0x2A36DD0", VA = "0x182A387D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string SOTSKTZNZKL
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x25838B0", Offset = "0x2581EB0", VA = "0x1825838B0")]
		public BLMDYNFAYXE(COTBMNXENNH a, [Optional] GetCallback b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x360F750", Offset = "0x360DD50", VA = "0x18360F750", Slot = "6")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface JBDDQDQHKQY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[UsedImplicitly]
	public class QCFPFBGUXXP : JBDDQDQHKQY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly OLNCKJOVBUD IZMGYGIDUCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly List<StatsigMemoryOverrideParameterDTO> DNPHIKTDHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly string WWVEHXAKXXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly string UQOXNNWPSOV;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8258060", Offset = "0x8256660", VA = "0x188258060")]
		[ZOKCDQOPSGU.Root.GameOnly]
		[UsedImplicitly]
		internal static void LSGYJXLQNAB(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x82580D0", Offset = "0x82566D0", VA = "0x1882580D0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal QCFPFBGUXXP([Inject(null)][JetBrains.Annotations.NotNull] OLNCKJOVBUD recNetMemoryExperiments, [Inject(null)][JetBrains.Annotations.NotNull] BUYGYURSYIB buildSettingsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class XYJSDQCARHH : YAEPLJOWYUO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Task GGCAKJPGFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8260080", Offset = "0x825E680", VA = "0x188260080", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Task LROGKBAVEHB
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x825FA00", Offset = "0x825E000", VA = "0x18825FA00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool GMEQOXNUKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool WURVIRGAPUX
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public DAMPXYLQMYJ CWMAYMDGNLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action CHXVYXUMIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x825FBC0", Offset = "0x825E1C0", VA = "0x18825FBC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x825FA90", Offset = "0x825E090", VA = "0x18825FA90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action MINWORPGXYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x825FC60", Offset = "0x825E260", VA = "0x18825FC60", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x825F960", Offset = "0x825DF60", VA = "0x18825F960", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ParameterAccessRecord> NKOQBFQPRJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x825FFD0", Offset = "0x825E5D0", VA = "0x18825FFD0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8260110", Offset = "0x825E710", VA = "0x188260110", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public XYJSDQCARHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x825FB30", Offset = "0x825E130", VA = "0x18825FB30", Slot = "10")]
		public Task Initialize(string recNetEnv, [Optional] EANKQRVHIPH userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x825FE10", Offset = "0x825E410", VA = "0x18825FE10", Slot = "17")]
		public Task SLOPHSNMLOO(EANKQRVHIPH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x825FD80", Offset = "0x825E380", VA = "0x18825FD80", Slot = "18")]
		public Task RTJBNIVFRLG(EANKQRVHIPH a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "19")]
		public bool NRRPZRQXRJL(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x825FF30", Offset = "0x825E530", VA = "0x18825FF30", Slot = "20")]
		public VMNMQIOPYIB TPETXWUAKKD(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x825FD00", Offset = "0x825E300", VA = "0x18825FD00", Slot = "21")]
		public TBHWXJAMPWT RTFYQQVUXND(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x825FEA0", Offset = "0x825E4A0", VA = "0x18825FEA0", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class WWTFFXAOVZA : DAMPXYLQMYJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly UAQBPCEJCIQ PTVUAZDHQDM;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyDictionary<string, object> CXHGTZWHXBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xFEA5D0", Offset = "0xFE8BD0", VA = "0x180FEA5D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public WWTFFXAOVZA(UAQBPCEJCIQ a)
		{
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface SKYRYZKZAWF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		RAHLCSUYNGL DRIULEDSUHZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface XUVMDMZQVTP
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum RoomOfferPurchaseFunnelStep
		{
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			ViewedStore,
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			ViewedCheckoutDialog,
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			ConfirmButton,
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			PurchaseSuccessful,
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			PurchaseFailed,
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			NotEnoughTokens
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public enum ShoppingBagAction
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			Purchase,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			RemoveFromUpdate
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		long BAQAWWLQPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		string ACGXYQOBZUU
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string POFKGNMGYUR
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool QPBSOGPCEIO
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		long IBBPOMQQMMZ();

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SLWQMEANJZD(long a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DNEVWKLERAP(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LDGQMNMSKMA(Guid a, Guid b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void NYHIRQFGACH(string a);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OAEAAMTXJYN(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RFAGENFOEXZ(string a, object b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void MYAHCULXWNB(RoomOfferPurchaseFunnelStep a, int b, [Optional] RoomOffer c, [Optional] string d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IDQXGEBXKHW(RoomOffer a, long b, long c, int d, string e, int f);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void WVBBERCMJTL(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void YRINUPNASHU(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void EKUCGPXGUIM(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void BQRGSWLZUFO(long a, string b);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ARECSILKFXJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task FINPCPZVWCS(ShoppingBagAction a, Guid? b, List<UnifiedItemId> c, List<UnifiedItemId> d, Func<DDINNFXFWWX, long> e, string f, bool? g, [Optional] long? h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface JSCPLJWYWLT
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string OAOQSJCWLNT
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
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
