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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F05980", Offset = "0x7F04580", VA = "0x187F05980")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F04830", Offset = "0x7F03430", VA = "0x187F04830", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0BA50", Offset = "0x7F0A650", VA = "0x187F0BA50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
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
		public AmplitudeAnalyticsClient.Settings EBKZPUJIDTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BOEXRARFPRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC6B1E0", Offset = "0xC69DE0", VA = "0x180C6B1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, ZBFTVEGBKPN
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
				public int QUZKDPPBJPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> KEHXNRUHCHP;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public Item()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class KZRZTSLLDPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public int? CMOXIKZVMHZ;

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public KZRZTSLLDPA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x7F04690", Offset = "0x7F03290", VA = "0x187F04690")]
				internal bool BPSCMZTGQGJ(Item a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string IIXKSEUXUGC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string YDLODEQGXMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<Item> NEDBTQCWYXE;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? CDWAVUEEUNT
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7F02620", Offset = "0x7F01220", VA = "0x187F02620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F026C0", Offset = "0x7F012C0", VA = "0x187F026C0")]
			internal AnalyticsCache(string cacheName, string recNetEnv)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F01360", Offset = "0x7EFFF60", VA = "0x187F01360")]
			public int CEURUXVQYNI([Optional] int? a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F02290", Offset = "0x7F00E90", VA = "0x187F02290")]
			public List<Dictionary<string, object>> TSIWPIMGATZ(int a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7F01510", Offset = "0x7F00110", VA = "0x187F01510")]
			public void KNVDFACLAIB(AmplitudeAnalyticsIdentifyMessage a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F015B0", Offset = "0x7F001B0", VA = "0x187F015B0")]
			public void KNVDFACLAIB(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7F01820", Offset = "0x7F00420", VA = "0x187F01820")]
			public void LVPQHLQGITP(params Dictionary<string, object>[] objs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7F01E40", Offset = "0x7F00A40", VA = "0x187F01E40")]
			public void SHEHSGZVGFB(List<Dictionary<string, object>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7F01710", Offset = "0x7F00310", VA = "0x187F01710")]
			private void LOTGFUOWCHS(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F02090", Offset = "0x7F00C90", VA = "0x187F02090")]
			public void SaveToDisk()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F019A0", Offset = "0x7F005A0", VA = "0x187F019A0")]
			private void LoadFromDisk([Optional] string filePath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F01DF0", Offset = "0x7F009F0", VA = "0x187F01DF0")]
			private void MYDZOKUKONX(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F02500", Offset = "0x7F01100", VA = "0x187F02500")]
			private static string UVHZLPSBWFA(string a, string b)
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

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7F06480", Offset = "0x7F05080", VA = "0x187F06480")]
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
		private sealed class XCUTXKBOZSF : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float NQWYEJZENHA;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public XCUTXKBOZSF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B680", Offset = "0x7F0A280", VA = "0x187F0B680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B8D0", Offset = "0x7F0A4D0", VA = "0x187F0B8D0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class TZKQHXGBLEB : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float NQWYEJZENHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AnalyticsCache UIJVCMPQJAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? CMOXIKZVMHZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string VHBXGNBFWNS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action<int> CSFVYXTQFLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float BQZKDGEFYQJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<Dictionary<string, object>> IWFMXIJOROJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private bool LTIJFDIEBPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool ZVSZTBYRZKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int RUCMSFENBHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private Task<EventResponse<List<Dictionary<string, object>>>> QEIWONDMUVS;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public TZKQHXGBLEB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F06940", Offset = "0x7F05540", VA = "0x187F06940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7F075A0", Offset = "0x7F061A0", VA = "0x187F075A0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CVYYMYBYNBF : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float NQWYEJZENHA;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public CVYYMYBYNBF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7F02A50", Offset = "0x7F01650", VA = "0x187F02A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7F02CB0", Offset = "0x7F018B0", VA = "0x187F02CB0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HGZMTTKDEMS : IEnumerator<YRPRUNTVYNF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private YRPRUNTVYNF VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsEvent PLXGPMDQGJN;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private YRPRUNTVYNF AYWYUYDOKDY
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public HGZMTTKDEMS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7F03710", Offset = "0x7F02310", VA = "0x187F03710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7F03EA0", Offset = "0x7F02AA0", VA = "0x187F03EA0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
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

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7F09A40", Offset = "0x7F08640", VA = "0x187F09A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7F09CD0", Offset = "0x7F088D0", VA = "0x187F09CD0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7F09D40", Offset = "0x7F08940", VA = "0x187F09D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7F0A270", Offset = "0x7F08E70", VA = "0x187F0A270", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4F7D6F0", Offset = "0x4F7C2F0", VA = "0x184F7D6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x4F7B790", Offset = "0x4F7A390", VA = "0x184F7B790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class WFITXSHRRVL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float NQWYEJZENHA;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object IWBNOFQUZOU
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public WFITXSHRRVL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B4D0", Offset = "0x7F0A0D0", VA = "0x187F0B4D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B640", Offset = "0x7F0A240", VA = "0x187F0B640", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class YOJVLUNIQQO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public NJJRGFITQLO AEAZKKNLYMU;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object IWBNOFQUZOU
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public YOJVLUNIQQO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B910", Offset = "0x7F0A510", VA = "0x187F0B910", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7F0BA10", Offset = "0x7F0A610", VA = "0x187F0BA10", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private VNCXHMYABJK YZFYWPWOEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<CYQWOSXZXCR> MCXHPWHOBZQ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string VOFWWSMOZIO = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ZXFHMZHBACP = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string NYESVBLJDWN = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int XCNCWMVBNID = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int TOYFLGQKJFE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int ZPYPBPTODSA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float PKGMFPIPALX = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long VNLERRRRJRK = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string CGIELHWIRFJ = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string EFFMTQCYNKS = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string UGBPRZNKSAP = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string AVZLBYVFAQR = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool DJGIZEMOXUM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool CTUWDHLCXPT;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int XZKKWOPKCJS;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int UCMGNQYYYEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DHDLHNHTCAE KMCRMLUQQLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private MEPVTRUEPMQ DTLTOMEHLIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HXFXHNYTPOW ECOIXTNYGAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool NCJEAUTWIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float FNTFLTRPDTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float UOQCZRTESVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int MTFHVIHLHVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int MMFJFONWURS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? CWOQFDWKDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? CNXULCPKDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long NICYQHBYLQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string NKZJVHJGVMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string HKYGNTHOFVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long ICILULOPZDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string FXATQNDQKUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string QQNEPVVXEMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> MXLZIUTPZQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private QuitState LMUGXGOSHSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int GHLGMCODYPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int HZEJSKHBHQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float TBYKITJVSZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool IYZJGSHQUXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool PHHJRVTXPET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AnalyticsCache NZVXQZSBSJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AnalyticsCache CCUDZGCRNRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AnalyticsCache RLYDUARRGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string QZRPKOVFFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> LLVFJCERFYR;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo REUFMIXVJWX;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string UBUYECRNXKE;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string WYDNEUZFVZV = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string UYFEFXXSXKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string NNBMUXMHNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string WKGPNWPXQYK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private VNCXHMYABJK XINWZLHVKRB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7EFC2B0", Offset = "0x7EFAEB0", VA = "0x187EFC2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CYQWOSXZXCR HNPFNWFCVCU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7EFD8C0", Offset = "0x7EFC4C0", VA = "0x187EFD8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int DIXHSKFTGED
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7EFEED0", Offset = "0x7EFDAD0", VA = "0x187EFEED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long FNKKCOWYFTC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFCA0", Offset = "0x7EFE8A0", VA = "0x187EFFCA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFDB0", Offset = "0x7EFE9B0", VA = "0x187EFFDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string VXEIGDFHNHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFC70", Offset = "0x7EFE870", VA = "0x187EFFC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD95580", Offset = "0xD94180", VA = "0x180D95580", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1463AC0", Offset = "0x14626C0", VA = "0x181463AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBF4E60", Offset = "0xBF3A60", VA = "0x180BF4E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBF5030", Offset = "0xBF3C30", VA = "0x180BF5030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? AMNDVGHWCYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xC66620", Offset = "0xC65220", VA = "0x180C66620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2426AF0", Offset = "0x24256F0", VA = "0x182426AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool YYDISZZWJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xC7D200", Offset = "0xC7BE00", VA = "0x180C7D200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x21360F0", Offset = "0x2134CF0", VA = "0x1821360F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool APOFNJJWKLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFB70", Offset = "0x7EFE770", VA = "0x187EFFB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> WITTNHCOUWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFAB0", Offset = "0x7EFE6B0", VA = "0x187EFFAB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFCF0", Offset = "0x7EFE8F0", VA = "0x187EFFCF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA0C0", Offset = "0x7EF8CC0", VA = "0x187EFA0C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE560", Offset = "0x7EFD160", VA = "0x187EFE560")]
		private void UOPJBIDHCBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE540", Offset = "0x7EFD140", VA = "0x187EFE540")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCC20", Offset = "0x7EFB820", VA = "0x187EFCC20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EFEC40", Offset = "0x7EFD840", VA = "0x187EFEC40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF70", Offset = "0x7EFBB70", VA = "0x187EFCF70")]
		public MRIYACRIYFZ PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC220", Offset = "0x7EFAE20", VA = "0x187EFC220")]
		[IteratorStateMachine(typeof(HGZMTTKDEMS))]
		public IEnumerator<YRPRUNTVYNF> InitializeForLocalAccount(AmplitudeAnalyticsEvent initialEvent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EFDBE0", Offset = "0x7EFC7E0", VA = "0x187EFDBE0")]
		public void SendAppEnterEvent(bool delaySend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7EFEBC0", Offset = "0x7EFD7C0", VA = "0x187EFEBC0")]
		public void UpdateLastKnownInteractionCategory(string interactionCategory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EFEB10", Offset = "0x7EFD710", VA = "0x187EFEB10")]
		public void UpdateLastAliveTime(float deltaTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCCE0", Offset = "0x7EFB8E0", VA = "0x187EFCCE0")]
		private MRIYACRIYFZ POJUVZMQWFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD910", Offset = "0x7EFC510", VA = "0x187EFD910")]
		private MRIYACRIYFZ QRQHYANUWVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EFDF20", Offset = "0x7EFCB20", VA = "0x187EFDF20")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA6E0", Offset = "0x7EF92E0", VA = "0x187EFA6E0")]
		[IteratorStateMachine(typeof(YOJVLUNIQQO))]
		private IEnumerator CGJVERRABRX(NJJRGFITQLO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF150", Offset = "0x7EFDD50", VA = "0x187EFF150")]
		[IteratorStateMachine(typeof(WFITXSHRRVL))]
		public IEnumerator WaitForFlush(float timeout = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE9F0", Offset = "0x7EFD5F0", VA = "0x187EFE9F0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE930", Offset = "0x7EFD530", VA = "0x187EFE930")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime time)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBD20", Offset = "0x7EFA920", VA = "0x187EFBD20")]
		public static KOFGWWZDMUL Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9F10", Offset = "0x7EF8B10", VA = "0x187EF9F10")]
		public static JXHUWLMTKVF AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string event_type, string userId, CrmType assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB890", Offset = "0x7EFA490", VA = "0x187EFB890")]
		public static JXHUWLMTKVF Event([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EFD0F0", Offset = "0x7EFBCF0", VA = "0x187EFD0F0")]
		public static JXHUWLMTKVF PreviousSessionEvent([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBEC0", Offset = "0x7EFAAC0", VA = "0x187EFBEC0")]
		public static JXHUWLMTKVF InitializeEvent(string userId, int allocatedMemMBOnBoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EFE120", Offset = "0x7EFCD20", VA = "0x187EFE120")]
		public static JXHUWLMTKVF StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA770", Offset = "0x7EF9370", VA = "0x187EFA770")]
		public static JXHUWLMTKVF CreateOutOfSessionEvent(string event_type, bool anonymous = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC820", Offset = "0x7EFB420", VA = "0x187EFC820")]
		public static MRIYACRIYFZ LogOutOfSessionEvent(JXHUWLMTKVF eventToLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC5A0", Offset = "0x7EFB1A0", VA = "0x187EFC5A0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCA10", Offset = "0x7EFB610", VA = "0x187EFCA10")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCB40", Offset = "0x7EFB740", VA = "0x187EFCB40")]
		public void LogSerializedEventAsync(Dictionary<string, object> serializedAnalyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC6E0", Offset = "0x7EFB2E0", VA = "0x187EFC6E0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage identifyMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC4B0", Offset = "0x7EFB0B0", VA = "0x187EFC4B0")]
		private void LTHHTKCZDXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF1D0", Offset = "0x7EFDDD0", VA = "0x187EFF1D0")]
		private void YMQPKIQNKQV(Dictionary<string, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFDAF0", Offset = "0x7EFC6F0", VA = "0x187EFDAF0")]
		private void SJIEVJMARZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCDA0", Offset = "0x7EFB9A0", VA = "0x187EFCDA0")]
		private void PQRAAGBUKNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBC80", Offset = "0x7EFA880", VA = "0x187EFBC80")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF0D0", Offset = "0x7EFDCD0", VA = "0x187EFF0D0")]
		[IteratorStateMachine(typeof(XCUTXKBOZSF))]
		private IEnumerator<YRPRUNTVYNF> WVRIHJXJPEC(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7EFDA70", Offset = "0x7EFC670", VA = "0x187EFDA70")]
		[IteratorStateMachine(typeof(CVYYMYBYNBF))]
		private IEnumerator<YRPRUNTVYNF> RDBXYBFVWDC(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBBA0", Offset = "0x7EFA7A0", VA = "0x187EFBBA0")]
		[IteratorStateMachine(typeof(TZKQHXGBLEB))]
		private IEnumerator<YRPRUNTVYNF> FlushFromCache(AnalyticsCache cache, int? earlierThanFrame, string dataIdentifier, float timeout, Action<int> onBatchSent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9E00", Offset = "0x7EF8A00", VA = "0x187EF9E00")]
		private static void ACVKVUPPGFG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF5F0", Offset = "0x7EFE1F0", VA = "0x187EFF5F0")]
		[AsyncStateMachine(typeof(<PostJson>d__123))]
		private Task<EventResponse<Dictionary<string, object>>> ZGJFLATBFFJ(string a, string b, Dictionary<string, object> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF490", Offset = "0x7EFE090", VA = "0x187EFF490")]
		[AsyncStateMachine(typeof(<PostJson>d__124))]
		private Task<EventResponse<List<Dictionary<string, object>>>> ZGJFLATBFFJ(string a, string b, List<Dictionary<string, object>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3071BC0", Offset = "0x30707C0", VA = "0x183071BC0")]
		[AsyncStateMachine(typeof(<PostRudderStackJson>d__125<>))]
		private Task<EventResponse<T>> PostRudderStackJson<T>(string url, string dataIdentifier, string rudderStackKey, T eventParams, Dictionary<string, object> rudderStackEventParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA690", Offset = "0x7EF9290", VA = "0x187EFA690")]
		private bool CEBTAIEKLPU(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAA50", Offset = "0x7EF9650", VA = "0x187EFAA50")]
		private Dictionary<string, object> DEKTWWKZYWS(string a, Dictionary<string, object> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF7B0", Offset = "0x7EFE3B0", VA = "0x187EFF7B0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAC28F0", Offset = "0xAC14F0", VA = "0x180AC28F0", Slot = "6")]
		private bool NUYYTWIRXSE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC340", Offset = "0x7EFAF40", VA = "0x187EFC340")]
		[CompilerGenerated]
		private long LHZSVKMHCRA()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBD10", Offset = "0x7EFA910", VA = "0x187EFBD10")]
		[CompilerGenerated]
		private void IFPQVVYFNWQ(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string VVJOZWBBBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string XICSYMPKYXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly long JQDKWVQGOVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string RGVILANTJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal Dictionary<string, object> HRWRGFUACLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private string UWHFSWNKGWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long DDKCRVCMDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long PBQSOLCKDIY;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F00A90", Offset = "0x7EFF690", VA = "0x187F00A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F00B70", Offset = "0x7EFF770", VA = "0x187F00B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7F00AD0", Offset = "0x7EFF6D0", VA = "0x187F00AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7F00BD0", Offset = "0x7EFF7D0", VA = "0x187F00BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7F00A50", Offset = "0x7EFF650", VA = "0x187F00A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7F00B10", Offset = "0x7EFF710", VA = "0x187F00B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA20", Offset = "0xA9D620", VA = "0x180A9EA20")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7EFFF20", Offset = "0x7EFEB20", VA = "0x187EFFF20")]
		public static JXHUWLMTKVF Create(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F00190", Offset = "0x7EFED90", VA = "0x187F00190")]
		public static JXHUWLMTKVF OJWLRJUKHJM(string a, [JetBrains.Annotations.NotNull] string eventType, long b, long c, string d, long e, string f, string g, string h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F008B0", Offset = "0x7EFF4B0", VA = "0x187F008B0")]
		private AmplitudeAnalyticsEvent(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCE3E40", Offset = "0xCE2A40", VA = "0x180CE3E40")]
		public void RGNDPEOYKLO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7F002F0", Offset = "0x7EFEEF0", VA = "0x187F002F0", Slot = "5")]
		public override void QCGJEHOAJEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F00010", Offset = "0x7EFEC10", VA = "0x187F00010", Slot = "6")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F00400", Offset = "0x7EFF000", VA = "0x187F00400", Slot = "4")]
		protected override Dictionary<string, object> REKCDQLQBHF(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFFE10", Offset = "0x7EFEA10", VA = "0x187EFFE10")]
		private void AJSTYMRJNKW(string a, string b, bool c = false)
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

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x7F02CF0", Offset = "0x7F018F0", VA = "0x187F02CF0")]
			public void TKYZAJDQUKB(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F05D10", Offset = "0x7F04910", VA = "0x187F05D10")]
			public void TKYZAJDQUKB(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x12CE400", Offset = "0x12CD000", VA = "0x1812CE400")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal DeviceInfo BQUSUQDTZYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal RevenueData ACQWJWZBUHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly string YOVMRHHCMMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string UWHFSWNKGWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		internal Dictionary<string, object> YGNWMNWERKR;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F00C30", Offset = "0x7EFF830", VA = "0x187F00C30")]
		public static KOFGWWZDMUL Create(string version, string userId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F012A0", Offset = "0x7EFFEA0", VA = "0x187F012A0")]
		protected AmplitudeAnalyticsIdentifyMessage(string version, string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F00D80", Offset = "0x7EFF980", VA = "0x187F00D80")]
		public Dictionary<string, object> JNXIGPHEVPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F00F80", Offset = "0x7EFFB80", VA = "0x187F00F80", Slot = "4")]
		protected virtual Dictionary<string, object> REKCDQLQBHF(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CE0", Offset = "0x7EFF8E0", VA = "0x187F00CE0")]
		protected void DHKOIHZDGUD(string a, Dictionary<string, object> b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F00E80", Offset = "0x7EFFA80", VA = "0x187F00E80")]
		protected void NRVOOBXDKQL(string a, string b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F00EF0", Offset = "0x7EFFAF0", VA = "0x187F00EF0", Slot = "5")]
		public virtual void QCGJEHOAJEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F00E00", Offset = "0x7EFFA00", VA = "0x187F00E00", Slot = "6")]
		public virtual void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class KOFGWWZDMUL : MXTYUPYRKTZ<AmplitudeAnalyticsIdentifyMessage, KOFGWWZDMUL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override KOFGWWZDMUL YICQJTYBJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "5")]
		public override AmplitudeAnalyticsIdentifyMessage Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F04640", Offset = "0x7F03240", VA = "0x187F04640")]
		public KOFGWWZDMUL(AmplitudeAnalyticsIdentifyMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F04590", Offset = "0x7F03190", VA = "0x187F04590", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class JXHUWLMTKVF : MXTYUPYRKTZ<AmplitudeAnalyticsEvent, JXHUWLMTKVF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool LKGGSSHTMUB;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override JXHUWLMTKVF YICQJTYBJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long KQDJTNBPSJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F044F0", Offset = "0x7F030F0", VA = "0x187F044F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F04540", Offset = "0x7F03140", VA = "0x187F04540")]
		public JXHUWLMTKVF(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "5")]
		public override AmplitudeAnalyticsEvent Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F042B0", Offset = "0x7F02EB0", VA = "0x187F042B0", Slot = "4")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F04120", Offset = "0x7F02D20", VA = "0x187F04120")]
		public JXHUWLMTKVF BQOZGJXYHDE(string a, long[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3726930", Offset = "0x3725530", VA = "0x183726930")]
		public JXHUWLMTKVF BQOZGJXYHDE<a>(string a, a[] b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3726930", Offset = "0x3725530", VA = "0x183726930")]
		public JXHUWLMTKVF BQOZGJXYHDE(string a, string[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x37266F0", Offset = "0x37252F0", VA = "0x1837266F0")]
		public JXHUWLMTKVF BQOZGJXYHDE<b>(string a, b b) where b : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F04230", Offset = "0x7F02E30", VA = "0x187F04230")]
		public JXHUWLMTKVF BQOZGJXYHDE(string a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F040B0", Offset = "0x7F02CB0", VA = "0x187F040B0")]
		public JXHUWLMTKVF BQOZGJXYHDE(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F04510", Offset = "0x7F03110", VA = "0x187F04510")]
		public JXHUWLMTKVF YSCJBUGIDKP(string a, object? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F04350", Offset = "0x7F02F50", VA = "0x187F04350")]
		public JXHUWLMTKVF OLYCAOXIJNN(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F043F0", Offset = "0x7F02FF0", VA = "0x187F043F0")]
		private JXHUWLMTKVF QWEUNRMYRMN(string a, object b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class OOTYKTPBYVO : JXHUWLMTKVF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F04540", Offset = "0x7F03140", VA = "0x187F04540")]
		public OOTYKTPBYVO(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F05B60", Offset = "0x7F04760", VA = "0x187F05B60", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class MXTYUPYRKTZ<b, c> where b : AmplitudeAnalyticsIdentifyMessage where c : MXTYUPYRKTZ<b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected b HJECQFCDJVI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract c YICQJTYBJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public MXTYUPYRKTZ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5714100", Offset = "0x5712D00", VA = "0x185714100")]
		public c RSWDZWILLCN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5713F80", Offset = "0x5712B80", VA = "0x185713F80")]
		public c EQXDQFHUKRD(AmplitudeAnalyticsIdentifyMessage.RevenueData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5713E60", Offset = "0x5712A60", VA = "0x185713E60")]
		public c BILKAULVCCZ(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x37DACB0", Offset = "0x37D98B0", VA = "0x1837DACB0")]
		public c BILKAULVCCZ<a>(string a, a b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LogAsync();

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x57140D0", Offset = "0x5712CD0", VA = "0x1857140D0")]
		internal static string PNIRYVZNVZK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5713FD0", Offset = "0x5712BD0", VA = "0x185713FD0")]
		private c EZZPSPYKGGG(string a, object b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract b Build();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class WCLAUKOTRQD : DHDLHNHTCAE
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
			public WCLAUKOTRQD <>4__this;

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

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7F08FC0", Offset = "0x7F07BC0", VA = "0x187F08FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F099D0", Offset = "0x7F085D0", VA = "0x187F099D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private HttpClient QGVEOOYRLBJ;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B280", Offset = "0x7F09E80", VA = "0x187F0B280")]
		[YLZSHGPPZTN.Root]
		internal static void SMIKROMYQNV(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B460", Offset = "0x7F0A060", VA = "0x187F0B460")]
		[RecRoom.NoEngine.Common.Preserve]
		public WCLAUKOTRQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B2F0", Offset = "0x7F09EF0", VA = "0x187F0B2F0", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__4))]
		public Task<PostResponse> ZAGZXAWUSOV(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class OHWCQFCNHIG : DHDLHNHTCAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class VVHTIKYAJVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public UnityWebRequest ELIJPWFRWFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TaskCompletionSource<PostResponse> UPSUWKZBRXF;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public VVHTIKYAJVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B1A0", Offset = "0x7F09DA0", VA = "0x187F0B1A0")]
			internal void RFCLRTMGYWD(AsyncOperation a)
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

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7F08A40", Offset = "0x7F07640", VA = "0x187F08A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F08F50", Offset = "0x7F07B50", VA = "0x187F08F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		[YLZSHGPPZTN.Root]
		internal static void PJMOUCYWCBS(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public OHWCQFCNHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F05A00", Offset = "0x7F04600", VA = "0x187F05A00", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__3))]
		public Task<PostResponse> ZAGZXAWUSOV(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class CQCMZNXUIWE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> NIFPTYVLWLJ;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F028B0", Offset = "0x7F014B0", VA = "0x187F028B0")]
		internal static bool PYCLNFSJPUE(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DHDLHNHTCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PostResponse> ZAGZXAWUSOV(string a, string b, string c, string d);
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1688A10", Offset = "0x1687610", VA = "0x181688A10")]
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
	public class SDKPDWPMXPQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private long UDLLATSKLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private JXHUWLMTKVF IDQJKFYFBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool AIJSEHJHRQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private float ZZHGFGISEYH;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F06200", Offset = "0x7F04E00", VA = "0x187F06200")]
		public SDKPDWPMXPQ(string a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3A39CD0", Offset = "0x3A388D0", VA = "0x183A39CD0")]
		public void BQOZGJXYHDE<a>(string a, a b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F05E70", Offset = "0x7F04A70", VA = "0x187F05E70")]
		public void BQOZGJXYHDE(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F05EF0", Offset = "0x7F04AF0", VA = "0x187F05EF0")]
		public void Fail(string failureMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F060F0", Offset = "0x7F04CF0", VA = "0x187F060F0")]
		public void IZYJGPMUZPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F05FE0", Offset = "0x7F04BE0", VA = "0x187F05FE0")]
		private void ISLVGQTUCQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F061B0", Offset = "0x7F04DB0", VA = "0x187F061B0")]
		private bool MRVSLCABKBM()
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
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ParameterType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			get
			{
				return default(ParameterType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAF8F90", Offset = "0xAF7B90", VA = "0x180AF8F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F06390", Offset = "0x7F04F90", VA = "0x187F06390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class RMYRPEWHPRE<a> : QTKEVELKZDB<a>, NEYKVFRTPKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly UWTFUWBHDBX JLEQEFITJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly string WPMXOOZJOKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly string HWGGBWQETMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private a ZZILBUZQHDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly a HCVQUWIIBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool GHROWSJMCUJ;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string QYBLEIQGJYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1550", Offset = "0x5AC0150", VA = "0x185AC1550")]
		public RMYRPEWHPRE(UWTFUWBHDBX a, string b, string c, a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AC1050", Offset = "0x5ABFC50", VA = "0x185AC1050", Slot = "4")]
		public a LVCSCSACIOC()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x13DC680", Offset = "0x13DB280", VA = "0x1813DC680", Slot = "6")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.NoEngine.Common.Preserve]
	public class StatsigCachedValueFactory : RSQORZJJEOK, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			public LayerParamCacheKey(string layerName, string paramName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1133700", Offset = "0x1132300", VA = "0x181133700", Slot = "4")]
			public bool Equals(LayerParamCacheKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F04700", Offset = "0x7F03300", VA = "0x187F04700", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F047C0", Offset = "0x7F033C0", VA = "0x187F047C0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private UWTFUWBHDBX JLEQEFITJOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Dictionary<LayerParamCacheKey, NEYKVFRTPKI> NFSINDXRRSD;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F06740", Offset = "0x7F05340", VA = "0x187F06740")]
		[YLZSHGPPZTN.Root.GameOnly]
		internal static void UYMINUXTTWE(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F067B0", Offset = "0x7F053B0", VA = "0x187F067B0")]
		[RecRoom.NoEngine.Common.Preserve]
		public StatsigCachedValueFactory([Inject(null)][System.Diagnostics.CodeAnalysis.NotNull] UWTFUWBHDBX statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F06490", Offset = "0x7F05090", VA = "0x187F06490", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F06730", Offset = "0x7F05330", VA = "0x187F06730")]
		private void IUDBAYIVXEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F06580", Offset = "0x7F05180", VA = "0x187F06580")]
		private void GDHXRVOENLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A5AEA0", Offset = "0x3A59AA0", VA = "0x183A5AEA0", Slot = "4")]
		public QTKEVELKZDB<a> DCDJUIXZFNZ<a>(string a, string b, a c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class FCDQIESBMGL : QGLWFZXCUQC, KDSKGZCQIMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly HQXLFQSCMUS RCNNIUYVMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly GetCallback LWCVKRLHSFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string HXDSUPETKYY;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1033180", Offset = "0x1031D80", VA = "0x181033180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string MSCQHHMYIHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1C06A60", Offset = "0x1C05660", VA = "0x181C06A60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool LHCAJBUPSDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7F02E90", Offset = "0x7F01A90", VA = "0x187F02E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KOLLZOLEUSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F02E70", Offset = "0x7F01A70", VA = "0x187F02E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyList<string> NOPRJMEOKPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1C06B00", Offset = "0x1C05700", VA = "0x181C06B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x11A7FF0", Offset = "0x11A6BF0", VA = "0x1811A7FF0")]
		public FCDQIESBMGL(HQXLFQSCMUS a, string b, [Optional] GetCallback c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x367C290", Offset = "0x367AE90", VA = "0x18367C290", Slot = "9")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class AZJJSQONSNG : UWTFUWBHDBX, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private struct <Initialize>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public MEPVTRUEPMQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public AZJJSQONSNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public VFLWQMTBIMW buildSettings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private bool <containsUserInfo>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7F08200", Offset = "0x7F06E00", VA = "0x187F08200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7F089E0", Offset = "0x7F075E0", VA = "0x187F089E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct <Shutdown>d__61 : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7F0A2E0", Offset = "0x7F08EE0", VA = "0x187F0A2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F0A4C0", Offset = "0x7F090C0", VA = "0x187F0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <UpdateUser>d__62 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public MEPVTRUEPMQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public AZJJSQONSNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private bool <containsUserInfo>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private bool <fireInitEvent>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7F0AD10", Offset = "0x7F09910", VA = "0x187F0AD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B140", Offset = "0x7F09D40", VA = "0x187F0B140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <UpdateUserAddCustomIds>d__64 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public AZJJSQONSNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public MEPVTRUEPMQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Dictionary<string, string> customIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7F0A8F0", Offset = "0x7F094F0", VA = "0x187F0A8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F0ACB0", Offset = "0x7F098B0", VA = "0x187F0ACB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly IReadOnlyDictionary<string, EnvironmentTier> KNXJXZBGCUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool SOHZZXVPZIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool MYKOGVNUITF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskCompletionSource<bool> PWNYLHQLPQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskCompletionSource<bool> NZITCPUUDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly SemaphoreSlim HRGJSECTURO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private MQRWHCNHASD XYKCLYZJHDT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Task FEIIJLTXXOP
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7C70", Offset = "0x7EF6870", VA = "0x187EF7C70", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Task KCCLOGQBBGC
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7EF89B0", Offset = "0x7EF75B0", VA = "0x187EF89B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DNKUELDARSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAE9750", Offset = "0xAE8350", VA = "0x180AE9750", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool WNQJLPCICGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xAFC0F0", Offset = "0xAFACF0", VA = "0x180AFC0F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7EF80A0", Offset = "0x7EF6CA0", VA = "0x187EF80A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public GBCUKIFVCUK ESFTLSIOWCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7EF80B0", Offset = "0x7EF6CB0", VA = "0x187EF80B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action APCCBITFZCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7EF86C0", Offset = "0x7EF72C0", VA = "0x187EF86C0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8000", Offset = "0x7EF6C00", VA = "0x187EF8000", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action PYHZELDXIXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8910", Offset = "0x7EF7510", VA = "0x187EF8910", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8870", Offset = "0x7EF7470", VA = "0x187EF8870", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OJVAJNLQQRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8390", Offset = "0x7EF6F90", VA = "0x187EF8390", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8E20", Offset = "0x7EF7A20", VA = "0x187EF8E20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ParameterAccessRecord> DSZITJCNQMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7BC0", Offset = "0x7EF67C0", VA = "0x187EF7BC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7DC0", Offset = "0x7EF69C0", VA = "0x187EF7DC0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7CB0", Offset = "0x7EF68B0", VA = "0x187EF7CB0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF80E0", Offset = "0x7EF6CE0", VA = "0x187EF80E0", Slot = "10")]
		public Task Initialize([Optional] MEPVTRUEPMQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8270", Offset = "0x7EF6E70", VA = "0x187EF8270")]
		[AsyncStateMachine(typeof(<Initialize>d__47))]
		private Task Initialize(VFLWQMTBIMW buildSettings, MEPVTRUEPMQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8D70", Offset = "0x7EF7970", VA = "0x187EF8D70", Slot = "22")]
		[AsyncStateMachine(typeof(<Shutdown>d__61))]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7E70", Offset = "0x7EF6A70", VA = "0x187EF7E70", Slot = "17")]
		[AsyncStateMachine(typeof(<UpdateUser>d__62))]
		public Task GRTRSJCIZDX(MEPVTRUEPMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7F70", Offset = "0x7EF6B70", VA = "0x187EF7F70")]
		private void HFZTZOIBJXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8760", Offset = "0x7EF7360", VA = "0x187EF8760", Slot = "18")]
		[AsyncStateMachine(typeof(<UpdateUserAddCustomIds>d__64))]
		public Task OUKTCXIETOX(MEPVTRUEPMQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7CD0", Offset = "0x7EF68D0", VA = "0x187EF7CD0", Slot = "19")]
		public bool EPPVVNWQRKO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8550", Offset = "0x7EF7150", VA = "0x187EF8550", Slot = "20")]
		public QGLWFZXCUQC MVLVYVNYRQK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8430", Offset = "0x7EF7030", VA = "0x187EF8430")]
		private HQXLFQSCMUS LUEFUVMEZTB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7A60", Offset = "0x7EF6660", VA = "0x187EF7A60", Slot = "21")]
		public ZCAAWVSNQRU AOOCNUWWULM(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9A70", Offset = "0x7EF8670", VA = "0x187EF9A70")]
		private QYBLEIQGJYE YCKKQCXRUOD(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8EC0", Offset = "0x7EF7AC0", VA = "0x187EF8EC0")]
		private CJIWCOHPDYZ XBFUCYFZPPZ(MEPVTRUEPMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8B80", Offset = "0x7EF7780", VA = "0x187EF8B80")]
		private static MUMWYRVWHHC SLUJWFOFGZE(VFLWQMTBIMW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF89F0", Offset = "0x7EF75F0", VA = "0x187EF89F0")]
		private static MUMWYRVWHHC SLUJWFOFGZE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7EF97E0", Offset = "0x7EF83E0", VA = "0x187EF97E0")]
		private void XENVMZFPERX(string a, HQXLFQSCMUS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9D20", Offset = "0x7EF8920", VA = "0x187EF9D20")]
		public AZJJSQONSNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7A20", Offset = "0x7EF6620", VA = "0x187EF7A20")]
		[CompilerGenerated]
		private void AADXRNOOERD(ParameterAccessRecord a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7A20", Offset = "0x7EF6620", VA = "0x187EF7A20")]
		[CompilerGenerated]
		private void ZRSLKMJPKAL(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class NELFAYQAKKH : UWTFUWBHDBX, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x7F075E0", Offset = "0x7F061E0", VA = "0x187F075E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
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
			public NELFAYQAKKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public MEPVTRUEPMQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x7F07820", Offset = "0x7F06420", VA = "0x187F07820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7F081A0", Offset = "0x7F06DA0", VA = "0x187F081A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private AZJJSQONSNG TQTSVMPUVDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[CompilerGenerated]
		private Action PYHZELDXIXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskCompletionSource<bool> PWNYLHQLPQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskCompletionSource<bool> NZITCPUUDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Task RQFGTUZKESX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Task MIGIVSALNDM;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private UWTFUWBHDBX BAVCUJFKEMR
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7F05380", Offset = "0x7F03F80", VA = "0x187F05380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool WNQJLPCICGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7F04AB0", Offset = "0x7F036B0", VA = "0x187F04AB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool DNKUELDARSE
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7F05500", Offset = "0x7F04100", VA = "0x187F05500", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Task FEIIJLTXXOP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7F04A10", Offset = "0x7F03610", VA = "0x187F04A10", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Task KCCLOGQBBGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7F05510", Offset = "0x7F04110", VA = "0x187F05510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7F04FD0", Offset = "0x7F03BD0", VA = "0x187F04FD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GBCUKIFVCUK ESFTLSIOWCY
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7F04FF0", Offset = "0x7F03BF0", VA = "0x187F04FF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action APCCBITFZCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F052E0", Offset = "0x7F03EE0", VA = "0x187F052E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7F04F30", Offset = "0x7F03B30", VA = "0x187F04F30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OJVAJNLQQRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F05120", Offset = "0x7F03D20", VA = "0x187F05120", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7F057C0", Offset = "0x7F043C0", VA = "0x187F057C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ParameterAccessRecord> DSZITJCNQMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7F04960", Offset = "0x7F03560", VA = "0x187F04960", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7F04D70", Offset = "0x7F03970", VA = "0x187F04D70", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7F058D0", Offset = "0x7F044D0", VA = "0x187F058D0")]
		[UnityEngine.Scripting.Preserve]
		public NELFAYQAKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7F05860", Offset = "0x7F04460", VA = "0x187F05860")]
		[YLZSHGPPZTN.Root.GameOnly]
		internal static void UYMINUXTTWE(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F051C0", Offset = "0x7F03DC0", VA = "0x187F051C0")]
		internal static void LIMSETBRPHC(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F04C30", Offset = "0x7F03830", VA = "0x187F04C30", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F05030", Offset = "0x7F03C30", VA = "0x187F05030", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__23))]
		public Task Initialize([Optional] MEPVTRUEPMQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7F04E20", Offset = "0x7F03A20", VA = "0x187F04E20", Slot = "17")]
		public Task GRTRSJCIZDX(MEPVTRUEPMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F053F0", Offset = "0x7F03FF0", VA = "0x187F053F0", Slot = "18")]
		public Task OUKTCXIETOX(MEPVTRUEPMQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7F04C60", Offset = "0x7F03860", VA = "0x187F04C60", Slot = "19")]
		public bool EPPVVNWQRKO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7F05230", Offset = "0x7F03E30", VA = "0x187F05230", Slot = "20")]
		public QGLWFZXCUQC MVLVYVNYRQK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7F048B0", Offset = "0x7F034B0", VA = "0x187F048B0", Slot = "21")]
		public ZCAAWVSNQRU AOOCNUWWULM(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F055B0", Offset = "0x7F041B0", VA = "0x187F055B0", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F04AC0", Offset = "0x7F036C0", VA = "0x187F04AC0")]
		private static void DLQDBXZWNMM(TaskCompletionSource<bool> a, Task b, Task c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F056B0", Offset = "0x7F042B0", VA = "0x187F056B0")]
		[AsyncStateMachine(typeof(<ForwardTaskToTCS>d__43))]
		private static void TOLDNHXXCPU(Task a, TaskCompletionSource<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xCEC8D0", Offset = "0xCEB4D0", VA = "0x180CEC8D0")]
		[CompilerGenerated]
		private void UISIZMGFPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xDAD930", Offset = "0xDAC530", VA = "0x180DAD930")]
		[CompilerGenerated]
		private void UINCCFMIFPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xBFF490", Offset = "0xBFE090", VA = "0x180BFF490")]
		[CompilerGenerated]
		private void UIHVEYSKWEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F05780", Offset = "0x7F04380", VA = "0x187F05780")]
		[CompilerGenerated]
		private void UICOHRYNMTC(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class HDFSHAHIIQZ : ZCAAWVSNQRU, KDSKGZCQIMP
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly GetCallback LWCVKRLHSFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly QYBLEIQGJYE GGIRGYYZSXX;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string XPPEXRAPNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x27DA980", Offset = "0x27D9580", VA = "0x1827DA980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string MSCQHHMYIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7AD10", VA = "0x180C7C110", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2078410", Offset = "0x2077010", VA = "0x182078410")]
		public HDFSHAHIIQZ(QYBLEIQGJYE a, [Optional] GetCallback b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x36AC890", Offset = "0x36AB490", VA = "0x1836AC890", Slot = "6")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface BVQEJIUMOTF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[UsedImplicitly]
	public class JKEVEBDXNSE : BVQEJIUMOTF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly WOLHWEPXSUA PTFSTILWOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly List<StatsigMemoryOverrideParameterDTO> BUUZFCUXCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly string WOLVZQRLYLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly string LOCGPCJYEFC;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F03EE0", Offset = "0x7F02AE0", VA = "0x187F03EE0")]
		[YLZSHGPPZTN.Root.GameOnly]
		[UsedImplicitly]
		internal static void IGQDZAZABEW(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F03F50", Offset = "0x7F02B50", VA = "0x187F03F50")]
		[RecRoom.NoEngine.Common.Preserve]
		internal JKEVEBDXNSE([Inject(null)][JetBrains.Annotations.NotNull] WOLHWEPXSUA recNetMemoryExperiments, [Inject(null)][JetBrains.Annotations.NotNull] VFLWQMTBIMW buildSettingsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class FEXVJUPANAA : UWTFUWBHDBX
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Task FEIIJLTXXOP
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7F02FE0", Offset = "0x7F01BE0", VA = "0x187F02FE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Task KCCLOGQBBGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7F03550", Offset = "0x7F02150", VA = "0x187F03550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool WNQJLPCICGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool DNKUELDARSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string TMQOZVXYALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public GBCUKIFVCUK ESFTLSIOWCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action APCCBITFZCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7F03420", Offset = "0x7F02020", VA = "0x187F03420", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7F031B0", Offset = "0x7F01DB0", VA = "0x187F031B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action OJVAJNLQQRG
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7F032E0", Offset = "0x7F01EE0", VA = "0x187F032E0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7F03670", Offset = "0x7F02270", VA = "0x187F03670", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ParameterAccessRecord> DSZITJCNQMT
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7F02F30", Offset = "0x7F01B30", VA = "0x187F02F30", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7F03070", Offset = "0x7F01C70", VA = "0x187F03070", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public FEXVJUPANAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7F03250", Offset = "0x7F01E50", VA = "0x187F03250", Slot = "10")]
		public Task Initialize([Optional] MEPVTRUEPMQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F03120", Offset = "0x7F01D20", VA = "0x187F03120", Slot = "17")]
		public Task GRTRSJCIZDX(MEPVTRUEPMQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7F034C0", Offset = "0x7F020C0", VA = "0x187F034C0", Slot = "18")]
		public Task OUKTCXIETOX(MEPVTRUEPMQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "19")]
		public bool EPPVVNWQRKO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F03380", Offset = "0x7F01F80", VA = "0x187F03380", Slot = "20")]
		public QGLWFZXCUQC MVLVYVNYRQK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F02EB0", Offset = "0x7F01AB0", VA = "0x187F02EB0", Slot = "21")]
		public ZCAAWVSNQRU AOOCNUWWULM(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7F035E0", Offset = "0x7F021E0", VA = "0x187F035E0", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class MQRWHCNHASD : GBCUKIFVCUK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly CJIWCOHPDYZ AZKCSYZROYL;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyDictionary<string, object> UNZHJXSLLSB
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xC87950", Offset = "0xC86550", VA = "0x180C87950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public MQRWHCNHASD(CJIWCOHPDYZ a)
		{
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface ZVJCSUGAPJO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SDKPDWPMXPQ WERCLRHQCWM(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface HXFXHNYTPOW
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum RoomOfferPurchaseFunnelStep
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			ViewedStore,
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			ViewedCheckoutDialog,
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			ConfirmButton,
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			PurchaseSuccessful,
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			PurchaseFailed,
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			NotEnoughTokens
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public enum ShoppingBagAction
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Add,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			Purchase,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			RemoveFromUpdate
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		long SELQWZJWDDY
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		string QOWINKSYPXL
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string ESVHZEDMRRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool UJWGHYULSHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "4")]
		long FMJHMHOLIAG();

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TXTOXSRHUQK(long a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ANBTFMWPVTY(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void QMUGSFZPIAX(Guid a, Guid b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CDHVZFODRLE(string a);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void VQIVHYJCECQ(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void LOVMFMKBYIQ(string a, object b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void CKJZQZJTBXS(RoomOfferPurchaseFunnelStep a, int b, [Optional] RoomOffer c, [Optional] string d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void HJEILMPIZDJ(RoomOffer a, long b, long c, int d, string e, int f);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void LILHIOJWZOO(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void TGPDLMFPDOV(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void OHLBZSRWCTV(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void IJYOIKRSTLD(long a, string b);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void CNRBOWMKSRC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task AVJZGSRXQCR(ShoppingBagAction a, Guid? b, List<UnifiedItemId> c, List<UnifiedItemId> d, Func<UGUUNTAQHIA, long> e, string f, bool? g, [Optional] long? h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface MQSFRIRBMKC
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string VHGCHTNVSJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
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
