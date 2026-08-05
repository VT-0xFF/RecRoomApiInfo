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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84634C0", Offset = "0x84624C0", VA = "0x1884634C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8463440", Offset = "0x8462440", VA = "0x188463440", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x846B890", Offset = "0x846A890", VA = "0x18846B890", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
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
		public AmplitudeAnalyticsClient.Settings LWAROPTYEXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ZGYMLBAVHRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCF83E0", Offset = "0xCF73E0", VA = "0x180CF83E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, BEQJGZNJVRX
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
				public int CMWKHNPAVXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> SGATYWLCVNB;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public Item()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class SCYSNCSTSXC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public int? JBGPQIZGVYB;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public SCYSNCSTSXC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x84640A0", Offset = "0x84630A0", VA = "0x1884640A0")]
				internal bool TXBNZSJGVPR(Item a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string JNGRFNAQGIU = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string GCWKIIAADGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<Item> ZJIDMCMQZIA;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? KNSRNXZXMOP
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x8460480", Offset = "0x845F480", VA = "0x188460480")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8460520", Offset = "0x845F520", VA = "0x188460520")]
			internal AnalyticsCache(string cacheName, string recNetEnv)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x845F920", Offset = "0x845E920", VA = "0x18845F920")]
			public int LDJOARBMXJG([Optional] int? a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x845F6B0", Offset = "0x845E6B0", VA = "0x18845F6B0")]
			public List<Dictionary<string, object>> LDBVSKAOYDH(int a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x845F500", Offset = "0x845E500", VA = "0x18845F500")]
			public void ILSUJDIISET(AmplitudeAnalyticsIdentifyMessage a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x845F5A0", Offset = "0x845E5A0", VA = "0x18845F5A0")]
			public void ILSUJDIISET(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x845F260", Offset = "0x845E260", VA = "0x18845F260")]
			public void DFSIBAFQUYX(params Dictionary<string, object>[] objs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x845FF20", Offset = "0x845EF20", VA = "0x18845FF20")]
			public void NISRXMRDOIN(List<Dictionary<string, object>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8460170", Offset = "0x845F170", VA = "0x188460170")]
			private void PDWGTHCGOQG(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8460280", Offset = "0x845F280", VA = "0x188460280")]
			public void SaveToDisk()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x845FAD0", Offset = "0x845EAD0", VA = "0x18845FAD0")]
			private void LoadFromDisk([Optional] string filePath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x845F3E0", Offset = "0x845E3E0", VA = "0x18845F3E0")]
			private static string GHGDCYRVJGM(string a, string b)
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
			[Cpp2IlInjected.Address(RVA = "0x8464200", Offset = "0x8463200", VA = "0x188464200")]
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
		private sealed class GOULVEVQQZJ : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float DLEHJPOMNSU;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public GOULVEVQQZJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8460FA0", Offset = "0x845FFA0", VA = "0x188460FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8460F60", Offset = "0x845FF60", VA = "0x188460F60", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class HWJLHIGNNJV : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float DLEHJPOMNSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AnalyticsCache CEKFMDAEOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? JBGPQIZGVYB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string FEKYUFIUZZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action<int> DAUBKEAZYKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float RMOLNFYQGQH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<Dictionary<string, object>> LIUEXXURIYX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private bool WWVDGHAPDBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool MTCEUGCGQDW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int YGAYVNOARNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private Task<EventResponse<List<Dictionary<string, object>>>> PGJGHXZQLLE;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public HWJLHIGNNJV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8462020", Offset = "0x8461020", VA = "0x188462020", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8461FE0", Offset = "0x8460FE0", VA = "0x188461FE0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class EXBIIZXDIIR : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float DLEHJPOMNSU;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public EXBIIZXDIIR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8460D00", Offset = "0x845FD00", VA = "0x188460D00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8460CC0", Offset = "0x845FCC0", VA = "0x188460CC0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class HUAOVDPHPWA : IEnumerator<UNBASXFCXPD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private UNBASXFCXPD IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsEvent ZFCKPUHNLXT;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private UNBASXFCXPD UORWHXRETNW
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public HUAOVDPHPWA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8461850", Offset = "0x8460850", VA = "0x188461850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8461810", Offset = "0x8460810", VA = "0x188461810", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
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
			[Cpp2IlInjected.Address(RVA = "0x8466C40", Offset = "0x8465C40", VA = "0x188466C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8466ED0", Offset = "0x8465ED0", VA = "0x188466ED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8466F40", Offset = "0x8465F40", VA = "0x188466F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8467470", Offset = "0x8466470", VA = "0x188467470", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x53C88B0", Offset = "0x53C78B0", VA = "0x1853C88B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x53C5310", Offset = "0x53C4310", VA = "0x1853C5310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class AXHDNQMJRST : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float DLEHJPOMNSU;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object YFFTPSTGFHY
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public AXHDNQMJRST(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8457AE0", Offset = "0x8456AE0", VA = "0x188457AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8457AA0", Offset = "0x8456AA0", VA = "0x188457AA0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DXUQAJLPTFC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AUSTWJIEORM XNBFCGOCERM;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object YFFTPSTGFHY
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public DXUQAJLPTFC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8460A00", Offset = "0x845FA00", VA = "0x188460A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x84609C0", Offset = "0x845F9C0", VA = "0x1884609C0", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private VUZKNGQNDWC PCRBIUUBVRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<ECBJGLLFWNR> UQUOXPUIOZO;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string KWDBIQAKNBK = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string ZDAZXUWSNXD = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string XJVFJBRVHZR = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int CMWYBCSCNTD = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int LGTZKAHLOCQ = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int QXJZSEVIEMK = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float UPWZJPVGHAX = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long FCAOVRTFUZY = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string AIZCVIJPFAN = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string HCAWIUBGIJS = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LYISVLOFJOJ = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string YPAGMEVOOVB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool PXEOUZUFHVU;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool RGCFJXEPCWD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int BBGZFWWEMSW;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int FXWTIZVWQEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CYEVZAMLBKO QDKFBAHRWNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private KULZSMGSHHQ LAMGTMDETHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private MUPSOWNDBOY SPQMTEXESKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool RAVSXNYYRKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float TDRBFHZMJVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float GIZZUUOJZHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int WZKTMZXRCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int EZJRJUROBXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? PKGXEJBGDAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? ELRJBLOXQTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long YDUTVEHHTCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string PTRRWZIBFGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string CVSVLBXVSDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long VZMRDIDVJWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string YMHHIKFFQWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string VHQUYPFVDSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> JXBDNTLJZZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private QuitState RZOPTTBHLRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int GHMLEYLWDOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int LHDXXENYDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float ARUNOYFWXFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool MDIVYACFXJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool ISRMLMAKENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AnalyticsCache MLZMSJXOFZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AnalyticsCache DKFWKMDVQPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AnalyticsCache HISREOFXDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CMFXRRDOQSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> GWNNEWOFYOD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo BYYUKDHFTBH;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string THQWFXVWMIO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string VEXCEDYSNSV = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string TPLZNTSLOXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string JJMEIZGKNOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string TJNWORRZIYA;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private VUZKNGQNDWC ATDZTSAKTWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x845A950", Offset = "0x8459950", VA = "0x18845A950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ECBJGLLFWNR BOCCVODFXUW
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x845B570", Offset = "0x845A570", VA = "0x18845B570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int YUTPGJJKSKR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x845B370", Offset = "0x845A370", VA = "0x18845B370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long EBXJODMHRAS
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x845DB90", Offset = "0x845CB90", VA = "0x18845DB90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x845DCA0", Offset = "0x845CCA0", VA = "0x18845DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string GPVKEHCNPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x845DB60", Offset = "0x845CB60", VA = "0x18845DB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD0A060", Offset = "0xD09060", VA = "0x180D0A060", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD0AD40", Offset = "0xD09D40", VA = "0x180D0AD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ATTLPYUINOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB64BB0", Offset = "0xB63BB0", VA = "0x180B64BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xBF5E90", Offset = "0xBF4E90", VA = "0x180BF5E90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? DMXEZVXUGIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB40420", Offset = "0xB3F420", VA = "0x180B40420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB40F30", Offset = "0xB3FF30", VA = "0x180B40F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ROSLGXNMTMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xBE8A00", Offset = "0xBE7A00", VA = "0x180BE8A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xC0FFB0", Offset = "0xC0EFB0", VA = "0x180C0FFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool QCHARVFWGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x845DA60", Offset = "0x845CA60", VA = "0x18845DA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> RVRYFXHYQMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x845D9A0", Offset = "0x845C9A0", VA = "0x18845D9A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x845DBE0", Offset = "0x845CBE0", VA = "0x18845DBE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8457E80", Offset = "0x8456E80", VA = "0x188457E80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8459A30", Offset = "0x8458A30", VA = "0x188459A30")]
		private void MKHASELFKQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x845B350", Offset = "0x845A350", VA = "0x18845B350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8459E10", Offset = "0x8458E10", VA = "0x188459E10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x845B8D0", Offset = "0x845A8D0", VA = "0x18845B8D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8459ED0", Offset = "0x8458ED0", VA = "0x188459ED0")]
		public EMLXNRBUHND PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8459230", Offset = "0x8458230", VA = "0x188459230")]
		[IteratorStateMachine(typeof(HUAOVDPHPWA))]
		public IEnumerator<UNBASXFCXPD> InitializeForLocalAccount(AmplitudeAnalyticsEvent initialEvent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x845A9E0", Offset = "0x84599E0", VA = "0x18845A9E0")]
		public void SendAppEnterEvent(bool delaySend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x845B850", Offset = "0x845A850", VA = "0x18845B850")]
		public void UpdateLastKnownInteractionCategory(string interactionCategory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x845B7A0", Offset = "0x845A7A0", VA = "0x18845B7A0")]
		public void UpdateLastAliveTime(float deltaTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x845CFB0", Offset = "0x845BFB0", VA = "0x18845CFB0")]
		private EMLXNRBUHND XHUZUREIPSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x845CB10", Offset = "0x845BB10", VA = "0x18845CB10")]
		private EMLXNRBUHND VUFMAGSEODT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x845AD20", Offset = "0x8459D20", VA = "0x18845AD20")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8458C90", Offset = "0x8457C90", VA = "0x188458C90")]
		[IteratorStateMachine(typeof(DXUQAJLPTFC))]
		private IEnumerator HJFFRFNGPQD(AUSTWJIEORM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x845CF30", Offset = "0x845BF30", VA = "0x18845CF30")]
		[IteratorStateMachine(typeof(AXHDNQMJRST))]
		public IEnumerator WaitForFlush(float timeout = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x845B680", Offset = "0x845A680", VA = "0x18845B680")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x845B5C0", Offset = "0x845A5C0", VA = "0x18845B5C0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime time)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8458D20", Offset = "0x8457D20", VA = "0x188458D20")]
		public static GTYKNCMGBCN Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8457CD0", Offset = "0x8456CD0", VA = "0x188457CD0")]
		public static IHBQHRTKCMV AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string event_type, string userId, CrmType assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8458800", Offset = "0x8457800", VA = "0x188458800")]
		public static IHBQHRTKCMV Event([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x845A050", Offset = "0x8459050", VA = "0x18845A050")]
		public static IHBQHRTKCMV PreviousSessionEvent([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8458EC0", Offset = "0x8457EC0", VA = "0x188458EC0")]
		public static IHBQHRTKCMV InitializeEvent(string userId, int allocatedMemMBOnBoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x845AF20", Offset = "0x8459F20", VA = "0x18845AF20")]
		public static IHBQHRTKCMV StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84584A0", Offset = "0x84574A0", VA = "0x1884584A0")]
		public static IHBQHRTKCMV CreateOutOfSessionEvent(string event_type, bool anonymous = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8459630", Offset = "0x8458630", VA = "0x188459630")]
		public static EMLXNRBUHND LogOutOfSessionEvent(IHBQHRTKCMV eventToLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84593B0", Offset = "0x84583B0", VA = "0x1884593B0")]
		public void LogEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8459820", Offset = "0x8458820", VA = "0x188459820")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8459950", Offset = "0x8458950", VA = "0x188459950")]
		public void LogSerializedEventAsync(Dictionary<string, object> serializedAnalyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84594F0", Offset = "0x84584F0", VA = "0x1884594F0")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage identifyMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x845D070", Offset = "0x845C070", VA = "0x18845D070")]
		private void XLIZBSDUZCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x845D160", Offset = "0x845C160", VA = "0x18845D160")]
		private void XRDARVLUJRZ(Dictionary<string, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84592C0", Offset = "0x84582C0", VA = "0x1884592C0")]
		private void KSBPBPONTJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x845D470", Offset = "0x845C470", VA = "0x18845D470")]
		private void ZZQYDNBDKFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8458C00", Offset = "0x8457C00", VA = "0x188458C00")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8458780", Offset = "0x8457780", VA = "0x188458780")]
		[IteratorStateMachine(typeof(GOULVEVQQZJ))]
		private IEnumerator<UNBASXFCXPD> DPQPYDOIVRS(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8457C50", Offset = "0x8456C50", VA = "0x188457C50")]
		[IteratorStateMachine(typeof(EXBIIZXDIIR))]
		private IEnumerator<UNBASXFCXPD> AUDANYFTSDA(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8458B20", Offset = "0x8457B20", VA = "0x188458B20")]
		[IteratorStateMachine(typeof(HWJLHIGNNJV))]
		private IEnumerator<UNBASXFCXPD> FlushFromCache(AnalyticsCache cache, int? earlierThanFrame, string dataIdentifier, float timeout, Action<int> onBatchSent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x845A840", Offset = "0x8459840", VA = "0x18845A840")]
		private static void RCKDKGAFBWC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x845CC70", Offset = "0x845BC70", VA = "0x18845CC70")]
		[AsyncStateMachine(typeof(<PostJson>d__123))]
		private Task<EventResponse<Dictionary<string, object>>> WYQZQMXYUMJ(string a, string b, Dictionary<string, object> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x845CDD0", Offset = "0x845BDD0", VA = "0x18845CDD0")]
		[AsyncStateMachine(typeof(<PostJson>d__124))]
		private Task<EventResponse<List<Dictionary<string, object>>>> WYQZQMXYUMJ(string a, string b, List<Dictionary<string, object>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3337240", Offset = "0x3336240", VA = "0x183337240")]
		[AsyncStateMachine(typeof(<PostRudderStackJson>d__125<>))]
		private Task<EventResponse<T>> PostRudderStackJson<T>(string url, string dataIdentifier, string rudderStackKey, T eventParams, Dictionary<string, object> rudderStackEventParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x845D420", Offset = "0x845C420", VA = "0x18845D420")]
		private bool ZMJHXODVLHO(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x845BCD0", Offset = "0x845ACD0", VA = "0x18845BCD0")]
		private Dictionary<string, object> VJQUCHIRHAA(string a, Dictionary<string, object> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x845D6A0", Offset = "0x845C6A0", VA = "0x18845D6A0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAF9F50", Offset = "0xAF8F50", VA = "0x180AF9F50", Slot = "6")]
		private bool BNWFRWAFNPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x845BB60", Offset = "0x845AB60", VA = "0x18845BB60")]
		[CompilerGenerated]
		private long VIAYAQLVLMU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8459E00", Offset = "0x8458E00", VA = "0x188459E00")]
		[CompilerGenerated]
		private void NCCMLDOJYNE(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string VDTPEIDBVYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string SRQKKAGXFTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly long BICOTRSWSHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string FXYWISJSPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal Dictionary<string, object> WPBXUMWSXFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private string OMAPMBUCPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long ZPOJOWPCROI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long BVKGLOVRDQK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x845E980", Offset = "0x845D980", VA = "0x18845E980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x845EA60", Offset = "0x845DA60", VA = "0x18845EA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x845E9C0", Offset = "0x845D9C0", VA = "0x18845E9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x845EAC0", Offset = "0x845DAC0", VA = "0x18845EAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x845E940", Offset = "0x845D940", VA = "0x18845E940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x845EA00", Offset = "0x845DA00", VA = "0x18845EA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xACEBB0", Offset = "0xACDBB0", VA = "0x180ACEBB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x845DD00", Offset = "0x845CD00", VA = "0x18845DD00")]
		public static IHBQHRTKCMV Create(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x845E640", Offset = "0x845D640", VA = "0x18845E640")]
		public static IHBQHRTKCMV YXANSFVYPFK(string a, [JetBrains.Annotations.NotNull] string eventType, long b, long c, string d, long e, string f, string g, string h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x845E7A0", Offset = "0x845D7A0", VA = "0x18845E7A0")]
		private AmplitudeAnalyticsEvent(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10B88B0", Offset = "0x10B78B0", VA = "0x1810B88B0")]
		public void OWZFQJBGQSO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x845DF00", Offset = "0x845CF00", VA = "0x18845DF00", Slot = "5")]
		public override void KCWCBXSKCWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x845E010", Offset = "0x845D010", VA = "0x18845E010", Slot = "6")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x845E190", Offset = "0x845D190", VA = "0x18845E190", Slot = "4")]
		protected override Dictionary<string, object> XCMYNKXPSVH(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x845DDF0", Offset = "0x845CDF0", VA = "0x18845DDF0")]
		private void JZDXOEJOAZS(string a, string b, bool c = false)
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
			[Cpp2IlInjected.Address(RVA = "0x8460B00", Offset = "0x845FB00", VA = "0x188460B00")]
			public void RNLWBJLUYOP(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8463F40", Offset = "0x8462F40", VA = "0x188463F40")]
			public void RNLWBJLUYOP(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x169D850", Offset = "0x169C850", VA = "0x18169D850")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal DeviceInfo RICKHUFGPXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal RevenueData KYLAYBLMPQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly string ARJPRCLVFGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string OMAPMBUCPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		internal Dictionary<string, object> IPUADLADYRJ;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string ATTLPYUINOT
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x845EC40", Offset = "0x845DC40", VA = "0x18845EC40")]
		public static GTYKNCMGBCN Create(string version, string userId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x845F1A0", Offset = "0x845E1A0", VA = "0x18845F1A0")]
		protected AmplitudeAnalyticsIdentifyMessage(string version, string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x845EBC0", Offset = "0x845DBC0", VA = "0x18845EBC0")]
		public Dictionary<string, object> CTGCSSKKUXQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x845EE80", Offset = "0x845DE80", VA = "0x18845EE80", Slot = "4")]
		protected virtual Dictionary<string, object> XCMYNKXPSVH(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x845EB20", Offset = "0x845DB20", VA = "0x18845EB20")]
		protected void AYYSSSPVRVT(string a, Dictionary<string, object> b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x845EE10", Offset = "0x845DE10", VA = "0x18845EE10")]
		protected void QZFMOKKVVAB(string a, string b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x845ECF0", Offset = "0x845DCF0", VA = "0x18845ECF0", Slot = "5")]
		public virtual void KCWCBXSKCWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x845ED80", Offset = "0x845DD80", VA = "0x18845ED80", Slot = "6")]
		public virtual void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class GTYKNCMGBCN : CBTMRQMCMPD<AmplitudeAnalyticsIdentifyMessage, GTYKNCMGBCN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override GTYKNCMGBCN KNVKMKDJIHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "5")]
		public override AmplitudeAnalyticsIdentifyMessage Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84612A0", Offset = "0x84602A0", VA = "0x1884612A0")]
		public GTYKNCMGBCN(AmplitudeAnalyticsIdentifyMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84611F0", Offset = "0x84601F0", VA = "0x1884611F0", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class IHBQHRTKCMV : CBTMRQMCMPD<AmplitudeAnalyticsEvent, IHBQHRTKCMV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool UGOWBDOJEJB;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override IHBQHRTKCMV KNVKMKDJIHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long GNBYNCIIQAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8462CB0", Offset = "0x8461CB0", VA = "0x188462CB0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8463110", Offset = "0x8462110", VA = "0x188463110")]
		public IHBQHRTKCMV(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "5")]
		public override AmplitudeAnalyticsEvent Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8462D70", Offset = "0x8461D70", VA = "0x188462D70", Slot = "4")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8463000", Offset = "0x8462000", VA = "0x188463000")]
		public IHBQHRTKCMV TPHGULILVSY(string a, long[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x39C65C0", Offset = "0x39C55C0", VA = "0x1839C65C0")]
		public IHBQHRTKCMV TPHGULILVSY<a>(string a, a[] b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x39C65C0", Offset = "0x39C55C0", VA = "0x1839C65C0")]
		public IHBQHRTKCMV TPHGULILVSY(string a, string[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x39C62D0", Offset = "0x39C52D0", VA = "0x1839C62D0")]
		public IHBQHRTKCMV TPHGULILVSY<b>(string a, b b) where b : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8462F10", Offset = "0x8461F10", VA = "0x188462F10")]
		public IHBQHRTKCMV TPHGULILVSY(string a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8462F90", Offset = "0x8461F90", VA = "0x188462F90")]
		public IHBQHRTKCMV TPHGULILVSY(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8462C80", Offset = "0x8461C80", VA = "0x188462C80")]
		public IHBQHRTKCMV BYZMZMWEVNX(string a, object? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8462CD0", Offset = "0x8461CD0", VA = "0x188462CD0")]
		public IHBQHRTKCMV GRKKKPQYSTP(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8462E10", Offset = "0x8461E10", VA = "0x188462E10")]
		private IHBQHRTKCMV QOZUVXRABMH(string a, object b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class LBVDQBHWIHI : IHBQHRTKCMV
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8463110", Offset = "0x8462110", VA = "0x188463110")]
		public LBVDQBHWIHI(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8463160", Offset = "0x8462160", VA = "0x188463160", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class CBTMRQMCMPD<b, c> where b : AmplitudeAnalyticsIdentifyMessage where c : CBTMRQMCMPD<b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected b EUAXTPABLNS;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract c KNVKMKDJIHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public CBTMRQMCMPD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4206540", Offset = "0x4205540", VA = "0x184206540")]
		public c QAGQZGXIABN(AmplitudeAnalyticsIdentifyMessage.DeviceInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x42064F0", Offset = "0x42054F0", VA = "0x1842064F0")]
		public c FXEDDEEIJZF(AmplitudeAnalyticsIdentifyMessage.RevenueData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x42063D0", Offset = "0x42053D0", VA = "0x1842063D0")]
		public c CYJHCFOAXOP(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x38F9F60", Offset = "0x38F8F60", VA = "0x1838F9F60")]
		public c CYJHCFOAXOP<a>(string a, a b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LogAsync();

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42062A0", Offset = "0x42052A0", VA = "0x1842062A0")]
		internal static string AEDCCYAICPA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x42062D0", Offset = "0x42052D0", VA = "0x1842062D0")]
		private c BPGWPJQPAWA(string a, object b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract b Build();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class BEBGIHFILDD : CYEVZAMLBKO
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
			public BEBGIHFILDD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x84661C0", Offset = "0x84651C0", VA = "0x1884661C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x8466BD0", Offset = "0x8465BD0", VA = "0x188466BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private HttpClient PHFPIIJPHCJ;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8460800", Offset = "0x845F800", VA = "0x188460800")]
		[OKVIBKJHYHD.Root]
		internal static void GWKCBIRTCEB(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8460870", Offset = "0x845F870", VA = "0x188460870")]
		[RecRoom.NoEngine.Common.Preserve]
		public BEBGIHFILDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8460690", Offset = "0x845F690", VA = "0x188460690", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__4))]
		public Task<PostResponse> CGBLEAOBROT(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class UZTUEJRLPUY : CYEVZAMLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class CWRWNJLXLSS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public UnityWebRequest GCGFWWKATQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TaskCompletionSource<PostResponse> VMXMCYTGNIR;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public CWRWNJLXLSS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x84608E0", Offset = "0x845F8E0", VA = "0x1884608E0")]
			internal void UNFLSUZTPQV(AsyncOperation a)
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
			[Cpp2IlInjected.Address(RVA = "0x8465C40", Offset = "0x8464C40", VA = "0x188465C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8466150", Offset = "0x8465150", VA = "0x188466150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		[OKVIBKJHYHD.Root]
		internal static void AVTJDMLCOBU(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		[RecRoom.NoEngine.Common.Preserve]
		public UZTUEJRLPUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84683A0", Offset = "0x84673A0", VA = "0x1884683A0", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__3))]
		public Task<PostResponse> CGBLEAOBROT(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RNDXBWQYCQW
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> YDVXEGCPJZH;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8463DA0", Offset = "0x8462DA0", VA = "0x188463DA0")]
		internal static bool FVMBWNFGUIG(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface CYEVZAMLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PostResponse> CGBLEAOBROT(string a, string b, string c, string d);
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
		[Cpp2IlInjected.Address(RVA = "0x1A340D0", Offset = "0x1A330D0", VA = "0x181A340D0")]
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
	public class HPUQCNOTFMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private long ZRWEQNSDFXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private IHBQHRTKCMV XSHCABDGCOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool ZLWLTJBMRWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private float LCUHTXOWOSV;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8461680", Offset = "0x8460680", VA = "0x188461680")]
		public HPUQCNOTFMI(string a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x39A67A0", Offset = "0x39A57A0", VA = "0x1839A67A0")]
		public void TPHGULILVSY<a>(string a, a b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8461600", Offset = "0x8460600", VA = "0x188461600")]
		public void TPHGULILVSY(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84612F0", Offset = "0x84602F0", VA = "0x1884612F0")]
		public void Fail(string failureMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84613E0", Offset = "0x84603E0", VA = "0x1884613E0")]
		public void GALYLLECKTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84614F0", Offset = "0x84604F0", VA = "0x1884614F0")]
		private void OUUDUFPSLIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x84614A0", Offset = "0x84604A0", VA = "0x1884614A0")]
		private bool MRIYTTJLAMM()
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
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ParameterType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			get
			{
				return default(ParameterType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xACFF90", Offset = "0xACEF90", VA = "0x180ACFF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8464110", Offset = "0x8463110", VA = "0x188464110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class DTVFOIQQXEQ<a> : IMMGQELNPJL<a>, PKSWRSGKLRA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly NSVFBUEKZEH HLDOQRQFSYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly string KWMTUFDMFZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly string DADNBGOCIUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private a JOLWGJEGVLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly a LFMGOKLYGZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool BXHJKKTBOKL;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string MXMBEBAUDGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4445C10", Offset = "0x4444C10", VA = "0x184445C10")]
		public DTVFOIQQXEQ(NSVFBUEKZEH a, string b, string c, a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4445AB0", Offset = "0x4444AB0", VA = "0x184445AB0", Slot = "4")]
		public a ULHBYTJZYOM()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1782460", Offset = "0x1781460", VA = "0x181782460", Slot = "6")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.NoEngine.Common.Preserve]
	public class StatsigCachedValueFactory : SZNXRHYQSJW, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
			public LayerParamCacheKey(string layerName, string paramName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x14E4ED0", Offset = "0x14E3ED0", VA = "0x1814E4ED0", Slot = "4")]
			public bool Equals(LayerParamCacheKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8463310", Offset = "0x8462310", VA = "0x188463310", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x84633D0", Offset = "0x84623D0", VA = "0x1884633D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private NSVFBUEKZEH HLDOQRQFSYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Dictionary<LayerParamCacheKey, PKSWRSGKLRA> GIRHBJLMHLL;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8464210", Offset = "0x8463210", VA = "0x188464210")]
		[OKVIBKJHYHD.Root.GameOnly]
		internal static void CQLKHQZBQNQ(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8464530", Offset = "0x8463530", VA = "0x188464530")]
		[RecRoom.NoEngine.Common.Preserve]
		public StatsigCachedValueFactory([Inject(null)][System.Diagnostics.CodeAnalysis.NotNull] NSVFBUEKZEH statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8464280", Offset = "0x8463280", VA = "0x188464280", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8464370", Offset = "0x8463370", VA = "0x188464370")]
		private void KEYOXTVDEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8464380", Offset = "0x8463380", VA = "0x188464380")]
		private void MWIIJIJMFYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D96780", Offset = "0x3D95780", VA = "0x183D96780", Slot = "4")]
		public IMMGQELNPJL<a> IPSGQXVECIJ<a>(string a, string b, a c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class ERFDYLJPHWR : QQEEPTKDHAM, PPGEOGKMMGV
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly VRGYKYTWTPC UKKZIOLCWOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly GetCallback RKBTBMIOGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string CMGTZYUREAG;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x13F2120", Offset = "0x13F1120", VA = "0x1813F2120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string HECRYFPJJUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1F68A20", Offset = "0x1F67A20", VA = "0x181F68A20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool YOXMRVTRFBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x8460C80", Offset = "0x845FC80", VA = "0x188460C80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool NACAIBXNOOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8460CA0", Offset = "0x845FCA0", VA = "0x188460CA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyList<string> DXOYFGMNAFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1F68AE0", Offset = "0x1F67AE0", VA = "0x181F68AE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1572DE0", Offset = "0x1571DE0", VA = "0x181572DE0")]
		public ERFDYLJPHWR(VRGYKYTWTPC a, string b, [Optional] GetCallback c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3880660", Offset = "0x387F660", VA = "0x183880660", Slot = "9")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class YCUFDURXMXE : NSVFBUEKZEH, IDisposable
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
			public KULZSMGSHHQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public YCUFDURXMXE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8465280", Offset = "0x8464280", VA = "0x188465280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8465BE0", Offset = "0x8464BE0", VA = "0x188465BE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x84674E0", Offset = "0x84664E0", VA = "0x1884674E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x84676C0", Offset = "0x84666C0", VA = "0x1884676C0", Slot = "5")]
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
			public KULZSMGSHHQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public YCUFDURXMXE <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8467F10", Offset = "0x8466F10", VA = "0x188467F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8468340", Offset = "0x8467340", VA = "0x188468340", Slot = "5")]
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
			public YCUFDURXMXE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public KULZSMGSHHQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Dictionary<string, string> customIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8467AF0", Offset = "0x8466AF0", VA = "0x188467AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8467EB0", Offset = "0x8466EB0", VA = "0x188467EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly IReadOnlyDictionary<string, EnvironmentTier> TPZJJTICEZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool CHFXJBIOWTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool COGYKXGAVNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskCompletionSource<bool> AYTYAWUSWMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskCompletionSource<bool> XOSRAPFVIXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly SemaphoreSlim GXBZUROXNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private WZPEFKRCBCR MSMCZYHSFXN;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Task RZVEKDRDVCB
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x8468C70", Offset = "0x8467C70", VA = "0x188468C70", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Task VQDLGECVBDC
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8468500", Offset = "0x8467500", VA = "0x188468500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CHAEEWFAUIW
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xB21E00", Offset = "0xB20E00", VA = "0x180B21E00", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool KIPUYQFCGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xC3C9D0", Offset = "0xC3B9D0", VA = "0x180C3C9D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string ATTLPYUINOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8468870", Offset = "0x8467870", VA = "0x188468870", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IJSEHKIYCJO ZGAKTZIQYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x8468D60", Offset = "0x8467D60", VA = "0x188468D60", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action APLMFRVCHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8468D90", Offset = "0x8467D90", VA = "0x188468D90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8468540", Offset = "0x8467540", VA = "0x188468540", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action JXSJVSKZBXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8468BD0", Offset = "0x8467BD0", VA = "0x188468BD0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8469400", Offset = "0x8468400", VA = "0x188469400", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action HNXSNDNFFQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8468B30", Offset = "0x8467B30", VA = "0x188468B30", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8469F80", Offset = "0x8468F80", VA = "0x188469F80", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ParameterAccessRecord> RFUZILWCESJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8468CB0", Offset = "0x8467CB0", VA = "0x188468CB0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8469350", Offset = "0x8468350", VA = "0x188469350", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8468850", Offset = "0x8467850", VA = "0x188468850", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x84690C0", Offset = "0x84680C0", VA = "0x1884690C0", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__46))]
		public Task Initialize(string recNetEnv, [Optional] KULZSMGSHHQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x846A020", Offset = "0x8469020", VA = "0x18846A020", Slot = "22")]
		[AsyncStateMachine(typeof(<Shutdown>d__60))]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8468880", Offset = "0x8467880", VA = "0x188468880", Slot = "17")]
		[AsyncStateMachine(typeof(<UpdateUser>d__61))]
		public Task FFWWUUJLGVB(KULZSMGSHHQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x846A1D0", Offset = "0x84691D0", VA = "0x18846A1D0")]
		private void VQIFSNCXFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8468620", Offset = "0x8467620", VA = "0x188468620", Slot = "18")]
		[AsyncStateMachine(typeof(<UpdateUserAddCustomIds>d__63))]
		public Task CNYBDCNCTGZ(KULZSMGSHHQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x846A260", Offset = "0x8469260", VA = "0x18846A260", Slot = "19")]
		public bool WHWJCGPRTTO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x84691E0", Offset = "0x84681E0", VA = "0x1884691E0", Slot = "20")]
		public QQEEPTKDHAM JOYYEOZOPNC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8468730", Offset = "0x8467730", VA = "0x188468730")]
		private VRGYKYTWTPC DYALGSUGUIB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8469E20", Offset = "0x8468E20", VA = "0x188469E20", Slot = "21")]
		public HPAXISYABKE RIETDPSPMLW(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x846A0D0", Offset = "0x84690D0", VA = "0x18846A0D0")]
		private MXMBEBAUDGS TEWXCXGSBZH(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x84694A0", Offset = "0x84684A0", VA = "0x1884694A0")]
		private JCFGQEYROIH QAEMIMMGPYZ(KULZSMGSHHQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8468980", Offset = "0x8467980", VA = "0x188468980")]
		private RAQBZUEVJOS FQGUPQCDPEA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8468E30", Offset = "0x8467E30", VA = "0x188468E30")]
		private void IXTSHUQZQLN(string a, VRGYKYTWTPC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x846A500", Offset = "0x8469500", VA = "0x18846A500")]
		public YCUFDURXMXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x84685E0", Offset = "0x84675E0", VA = "0x1884685E0")]
		[CompilerGenerated]
		private void BOUXQUOARHE(ParameterAccessRecord a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x84685E0", Offset = "0x84675E0", VA = "0x1884685E0")]
		[CompilerGenerated]
		private void ZOCCXETSPSQ(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class YDOCBRGIVYB : NSVFBUEKZEH, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x84646C0", Offset = "0x84636C0", VA = "0x1884646C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
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
			public YDOCBRGIVYB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public KULZSMGSHHQ userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public string recNetEnv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8464900", Offset = "0x8463900", VA = "0x188464900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8465220", Offset = "0x8464220", VA = "0x188465220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private YCUFDURXMXE LDUABCDLACU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[CompilerGenerated]
		private Action JXSJVSKZBXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskCompletionSource<bool> AYTYAWUSWMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskCompletionSource<bool> XOSRAPFVIXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Task LBECUMDUODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Task LXBZKOQIDXW;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private NSVFBUEKZEH UBQXSNUIYVR
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x846B050", Offset = "0x846A050", VA = "0x18846B050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KIPUYQFCGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x846A9F0", Offset = "0x84699F0", VA = "0x18846A9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool CHAEEWFAUIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x846B380", Offset = "0x846A380", VA = "0x18846B380", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Task RZVEKDRDVCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x846AAA0", Offset = "0x8469AA0", VA = "0x18846AAA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Task VQDLGECVBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x846A5E0", Offset = "0x84695E0", VA = "0x18846A5E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string ATTLPYUINOT
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x846A8D0", Offset = "0x84698D0", VA = "0x18846A8D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public IJSEHKIYCJO ZGAKTZIQYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x846ABF0", Offset = "0x8469BF0", VA = "0x18846ABF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action APLMFRVCHNA
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x846AC30", Offset = "0x8469C30", VA = "0x18846AC30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x846A680", Offset = "0x8469680", VA = "0x18846A680", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action HNXSNDNFFQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x846AA00", Offset = "0x8469A00", VA = "0x18846AA00", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x846B170", Offset = "0x846A170", VA = "0x18846B170", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ParameterAccessRecord> RFUZILWCESJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x846AB40", Offset = "0x8469B40", VA = "0x18846AB40", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x846AE90", Offset = "0x8469E90", VA = "0x18846AE90", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x846B610", Offset = "0x846A610", VA = "0x18846B610")]
		[UnityEngine.Scripting.Preserve]
		public YDOCBRGIVYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x846A830", Offset = "0x8469830", VA = "0x18846A830")]
		[OKVIBKJHYHD.Root.GameOnly]
		internal static void CQLKHQZBQNQ(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x846B310", Offset = "0x846A310", VA = "0x18846B310")]
		internal static void URNWFUEVCZM(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x846A8A0", Offset = "0x84698A0", VA = "0x18846A8A0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x846ACD0", Offset = "0x8469CD0", VA = "0x18846ACD0", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__23))]
		public Task Initialize(string recNetEnv, [Optional] KULZSMGSHHQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x846A8F0", Offset = "0x84698F0", VA = "0x18846A8F0", Slot = "17")]
		public Task FFWWUUJLGVB(KULZSMGSHHQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x846A720", Offset = "0x8469720", VA = "0x18846A720", Slot = "18")]
		public Task CNYBDCNCTGZ(KULZSMGSHHQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x846B390", Offset = "0x846A390", VA = "0x18846B390", Slot = "19")]
		public bool WHWJCGPRTTO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x846ADE0", Offset = "0x8469DE0", VA = "0x18846ADE0", Slot = "20")]
		public QQEEPTKDHAM JOYYEOZOPNC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x846B0C0", Offset = "0x846A0C0", VA = "0x18846B0C0", Slot = "21")]
		public HPAXISYABKE RIETDPSPMLW(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x846B210", Offset = "0x846A210", VA = "0x18846B210", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x846B4A0", Offset = "0x846A4A0", VA = "0x18846B4A0")]
		private static void XWALKFREXZM(TaskCompletionSource<bool> a, Task b, Task c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x846AF40", Offset = "0x8469F40", VA = "0x18846AF40")]
		[AsyncStateMachine(typeof(<ForwardTaskToTCS>d__43))]
		private static void OMCEMIODKOQ(Task a, TaskCompletionSource<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x10C11E0", Offset = "0x10C01E0", VA = "0x1810C11E0")]
		[CompilerGenerated]
		private void OVZSKWTOVAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x11649D0", Offset = "0x11639D0", VA = "0x1811649D0")]
		[CompilerGenerated]
		private void OVULNPZRLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xFEA310", Offset = "0xFE9310", VA = "0x180FEA310")]
		[CompilerGenerated]
		private void OWKGFKHJNXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x846B010", Offset = "0x846A010", VA = "0x18846B010")]
		[CompilerGenerated]
		private void OWEZIDNMEMG(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class XGHQRSCXTPJ : HPAXISYABKE, PPGEOGKMMGV
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly GetCallback RKBTBMIOGCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly MXMBEBAUDGS GHBQSNTFAPZ;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string LQPFQGKUSJI
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAF160", Offset = "0x2AAE160", VA = "0x182AAF160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HECRYFPJJUW
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x104CE40", Offset = "0x104BE40", VA = "0x18104CE40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x260C200", Offset = "0x260B200", VA = "0x18260C200")]
		public XGHQRSCXTPJ(MXMBEBAUDGS a, [Optional] GetCallback b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3F51510", Offset = "0x3F50510", VA = "0x183F51510", Slot = "6")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface UDMASIAUAFP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[UsedImplicitly]
	public class ZVMZGCLRVKG : UDMASIAUAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly WQOIOKWSHQW LMUEPTAHGSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly List<StatsigMemoryOverrideParameterDTO> HHPLKJFHQRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly string AUZGLFOIDSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly string DCCLVCVNVOC;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x846B6C0", Offset = "0x846A6C0", VA = "0x18846B6C0")]
		[OKVIBKJHYHD.Root.GameOnly]
		[UsedImplicitly]
		internal static void AUVAYKNAWWE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x846B730", Offset = "0x846A730", VA = "0x18846B730")]
		[RecRoom.NoEngine.Common.Preserve]
		internal ZVMZGCLRVKG([Inject(null)][JetBrains.Annotations.NotNull] WQOIOKWSHQW recNetMemoryExperiments, [Inject(null)][JetBrains.Annotations.NotNull] WHHSAFBZJOE buildSettingsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class QDUIAQZXGXE : NSVFBUEKZEH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Task RZVEKDRDVCB
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8463830", Offset = "0x8462830", VA = "0x188463830", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Task VQDLGECVBDC
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8463540", Offset = "0x8462540", VA = "0x188463540", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool KIPUYQFCGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool CHAEEWFAUIW
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ATTLPYUINOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IJSEHKIYCJO ZGAKTZIQYLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action APLMFRVCHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8463970", Offset = "0x8462970", VA = "0x188463970", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x84635D0", Offset = "0x84625D0", VA = "0x1884635D0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action HNXSNDNFFQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8463790", Offset = "0x8462790", VA = "0x188463790", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x8463C70", Offset = "0x8462C70", VA = "0x188463C70", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ParameterAccessRecord> RFUZILWCESJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x84638C0", Offset = "0x84628C0", VA = "0x1884638C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8463B40", Offset = "0x8462B40", VA = "0x188463B40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		[RecRoom.NoEngine.Common.Preserve]
		public QDUIAQZXGXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8463A10", Offset = "0x8462A10", VA = "0x188463A10", Slot = "10")]
		public Task Initialize(string recNetEnv, [Optional] KULZSMGSHHQ userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8463700", Offset = "0x8462700", VA = "0x188463700", Slot = "17")]
		public Task FFWWUUJLGVB(KULZSMGSHHQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8463670", Offset = "0x8462670", VA = "0x188463670", Slot = "18")]
		public Task CNYBDCNCTGZ(KULZSMGSHHQ a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "19")]
		public bool WHWJCGPRTTO(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8463AA0", Offset = "0x8462AA0", VA = "0x188463AA0", Slot = "20")]
		public QQEEPTKDHAM JOYYEOZOPNC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8463BF0", Offset = "0x8462BF0", VA = "0x188463BF0", Slot = "21")]
		public HPAXISYABKE RIETDPSPMLW(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8463D10", Offset = "0x8462D10", VA = "0x188463D10", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class WZPEFKRCBCR : IJSEHKIYCJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly JCFGQEYROIH IIZFACELZJX;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyDictionary<string, object> NPODZDYFPAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1059440", Offset = "0x1058440", VA = "0x181059440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public WZPEFKRCBCR(JCFGQEYROIH a)
		{
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface TKGJWEMPWBE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HPUQCNOTFMI UYXMEANMNXM(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface MUPSOWNDBOY
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
		long NZHDAHYGFRS
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		string SXEZLKIATVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string CZVQZAAKWRU
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool OLSLYCUFEMH
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		long YGSRNDIUIDO();

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OTMFHSEBHBG(long a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LZXHJZUSYDG(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PIPDIKBZRUV(Guid a, Guid b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VSBGZMTNKCY(string a);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UYGNYMRDPIO(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void UPUQJHBOZVM(string a, object b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void DXZFTMXJKGC(RoomOfferPurchaseFunnelStep a, int b, [Optional] RoomOffer c, [Optional] string d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void UJRKALUJRBH(RoomOffer a, long b, long c, int d, string e, int f);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ZEYUONQDXCU(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void JSNKVJCZDXJ(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void LXQZQTSYOTL(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void PHKIDLHWXMX(long a, string b);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ULTGKNDHKYK(string a);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task FLLNWKRGIAT(ShoppingBagAction a, Guid? b, List<UnifiedItemId> c, List<UnifiedItemId> d, Func<KJHSHGFTILM, long> e, string f, bool? g, [Optional] long? h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface XTPZYKNKWDC
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string IBVFCMYJOLW
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
