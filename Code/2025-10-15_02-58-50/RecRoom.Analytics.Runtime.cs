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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81D0F50", Offset = "0x81CFD50", VA = "0x1881D0F50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x81D0DE0", Offset = "0x81CFBE0", VA = "0x1881D0DE0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81D6D70", Offset = "0x81D5B70", VA = "0x1881D6D70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
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
		public AmplitudeAnalyticsClient.Settings ZVWXPSEMRXN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool WRAOXXTJCYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCB7060", Offset = "0xCB5E60", VA = "0x180CB7060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, GDGVDDKKAVJ
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
				public int NHHPEFYIUGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> NYZNXVCZRRH;

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public Item()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class IEWMQXGPNAW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public int? CXDKGIKLPYL;

				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
				public IEWMQXGPNAW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x81CE5D0", Offset = "0x81CD3D0", VA = "0x1881CE5D0")]
				internal bool OLXNLQCVLXT(Item a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string PSMCABXGXYC = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string HMCJLWVXEBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<Item> RFVNCKLGWXU;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? LFTSIEIVCOB
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x81CA980", Offset = "0x81C9780", VA = "0x1881CA980")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x81CB8E0", Offset = "0x81CA6E0", VA = "0x1881CB8E0")]
			internal AnalyticsCache(string cacheName, string recNetEnv)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x81CA5D0", Offset = "0x81C93D0", VA = "0x1881CA5D0")]
			public int AGUHLHAHLOC([Optional] int? a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x81CB4F0", Offset = "0x81CA2F0", VA = "0x1881CB4F0")]
			public List<Dictionary<string, object>> WKBAOLFHOHZ(int a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x81CA8E0", Offset = "0x81C96E0", VA = "0x1881CA8E0")]
			public void DWEQLVJXHJD(AmplitudeAnalyticsIdentifyMessage a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x81CA780", Offset = "0x81C9580", VA = "0x1881CA780")]
			public void DWEQLVJXHJD(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x81CB760", Offset = "0x81CA560", VA = "0x1881CB760")]
			public void YRESZZKEMQF(params Dictionary<string, object>[] objs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x81CAA20", Offset = "0x81C9820", VA = "0x1881CAA20")]
			public void KUJTIGGTXFF(List<Dictionary<string, object>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x81CAC70", Offset = "0x81C9A70", VA = "0x1881CAC70")]
			private void LAKJCGMDJZC(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x81CB1D0", Offset = "0x81C9FD0", VA = "0x1881CB1D0")]
			public void SaveToDisk()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x81CAD80", Offset = "0x81C9B80", VA = "0x1881CAD80")]
			private void LoadFromDisk([Optional] string filePath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x81CB3D0", Offset = "0x81CA1D0", VA = "0x1881CB3D0")]
			private static string WJZTIAPBSKG(string a, string b)
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
			[Cpp2IlInjected.Address(RVA = "0x81D15E0", Offset = "0x81D03E0", VA = "0x1881D15E0")]
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
		private sealed class IMZBXVQCDIJ : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float JBVNWZUGFGC;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public IMZBXVQCDIJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x81CE680", Offset = "0x81CD480", VA = "0x1881CE680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x81CE640", Offset = "0x81CD440", VA = "0x1881CE640", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class UQLCUZRHOGZ : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float JBVNWZUGFGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AnalyticsCache NVECHISXHAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? CXDKGIKLPYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string PTESFOXVELW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action<int> YCYKGAGYXLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float DHTSUMBJVXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<Dictionary<string, object>> YVZJSPEPCJX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private bool LWQCITJAEDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool HAWCMAASQPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int YSGVOVPCJND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private Task<EventResponse<List<Dictionary<string, object>>>> DNDGDZVTFJG;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public UQLCUZRHOGZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x81D5970", Offset = "0x81D4770", VA = "0x1881D5970", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x81D5930", Offset = "0x81D4730", VA = "0x1881D5930", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class ETXCRMAZKVZ : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float JBVNWZUGFGC;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public ETXCRMAZKVZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x81CDE50", Offset = "0x81CCC50", VA = "0x1881CDE50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x81CDE10", Offset = "0x81CCC10", VA = "0x1881CDE10", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class ZUTFGABRZOS : IEnumerator<XTKXCVTPKYX>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private XTKXCVTPKYX KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsEvent QSOUYNJZYJF;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private XTKXCVTPKYX INPROFPLOIG
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public ZUTFGABRZOS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x81D65F0", Offset = "0x81D53F0", VA = "0x1881D65F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x81D65B0", Offset = "0x81D53B0", VA = "0x1881D65B0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
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
			[Cpp2IlInjected.Address(RVA = "0x81D41D0", Offset = "0x81D2FD0", VA = "0x1881D41D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x81D4460", Offset = "0x81D3260", VA = "0x1881D4460", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x81D44D0", Offset = "0x81D32D0", VA = "0x1881D44D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x81D4A00", Offset = "0x81D3800", VA = "0x1881D4A00", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5259E00", Offset = "0x5258C00", VA = "0x185259E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5255C90", Offset = "0x5254A90", VA = "0x185255C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class TMAAKCRYNUF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float JBVNWZUGFGC;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object COBQHRVGZMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000088")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public TMAAKCRYNUF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x81D1AE0", Offset = "0x81D08E0", VA = "0x1881D1AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x81D1AA0", Offset = "0x81D08A0", VA = "0x1881D1AA0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class SXZXQITUAFE : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public RNTACPTQADO KUFFSUKAZNG;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object COBQHRVGZMA
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public SXZXQITUAFE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x81D13F0", Offset = "0x81D01F0", VA = "0x1881D13F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x81D13B0", Offset = "0x81D01B0", VA = "0x1881D13B0", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private TFFUOHKAKFW HFIRYMQICVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<XRJTIFFFBVT> XVWEMULTPGG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string QEVHKKYNMWG = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string MEFVYWDRBLZ = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string CONOJHRXEMV = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int ONUMMCCQITZ = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int WWQCWUSVLDQ = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int ERSLTYBPCUA = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float DOFUSNXRSAF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long NITJYSEHNAM = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string HMIBNMWQGPZ = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string TJHVLBOZSJI = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string VUEFUZPYBNZ = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string SGFQMEHFWAB = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool RWOETHZMIHC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool PDQTJZRSDEJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int RSWCRTMSGTW;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int DYSKNCHMTHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private KZVHWHOGKRK LEKFCMZVLSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OLJXKAJDMQU GMMBYPFOHVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private NMVRUBNUUWS HUTMIAVXTSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool IFUUVKLYKWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float LQFEWYMZYQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float QLXBBEGFTCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int CYNSPIQJUFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int ASFWRMDSNGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? TYNGCIMVYVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? ILOOFJHEIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long LOFTBMNOIXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string RVJSLVSLREM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string LDPBYNPWELZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long XOVOMLJWVNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string TNMHHAOOBPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string QYVSTTDKYZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> NYYRAZCNTRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private QuitState QDHXEBGOVIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int WLISTQVOGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int QCDPVVDIKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float ELTFAWNCXKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool URAZCPIQSQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool XZBAHVBYSRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AnalyticsCache COHQJKMETRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AnalyticsCache FSHBJUWLHGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AnalyticsCache SFKHJLDBYLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string CRRUSYTYDIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> UQGHPYPVKWZ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo DBQSVWRFGFV;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string KUCIUJFDEPG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string EYIGCVDPMAL = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string EDNJLHJTIUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string RVHILRSFSTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string XTJHABKDGGO;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private TFFUOHKAKFW TFVZJHFKHIX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81C7F60", Offset = "0x81C6D60", VA = "0x1881C7F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private XRJTIFFFBVT IQFDPFOGQGI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x81C8680", Offset = "0x81C7480", VA = "0x1881C8680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LNWTTHPCCTN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x81C73E0", Offset = "0x81C61E0", VA = "0x1881C73E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long UQZTKBBMBWM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x81C8F20", Offset = "0x81C7D20", VA = "0x1881C8F20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x81C9030", Offset = "0x81C7E30", VA = "0x1881C9030")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string EZXMMQOFLGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x81C8EF0", Offset = "0x81C7CF0", VA = "0x1881C8EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xC9CFF0", Offset = "0xC9BDF0", VA = "0x180C9CFF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC9EBD0", Offset = "0xC9D9D0", VA = "0x180C9EBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB0C120", Offset = "0xB0AF20", VA = "0x180B0C120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB99150", Offset = "0xB97F50", VA = "0x180B99150")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? UBJXLBJTXBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB078F0", Offset = "0xB066F0", VA = "0x180B078F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB8E560", Offset = "0xB8D360", VA = "0x180B8E560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CMGVZJVQUPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB8E550", Offset = "0xB8D350", VA = "0x180B8E550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xBB66A0", Offset = "0xBB54A0", VA = "0x180BB66A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool IRUZYHUDBNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81C8DF0", Offset = "0x81C7BF0", VA = "0x1881C8DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> SBBAULFVSSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x81C8D30", Offset = "0x81C7B30", VA = "0x1881C8D30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x81C8F70", Offset = "0x81C7D70", VA = "0x1881C8F70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81C3200", Offset = "0x81C2000", VA = "0x1881C3200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81C7010", Offset = "0x81C5E10", VA = "0x1881C7010")]
		private void QOYWFFBURIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81C7F40", Offset = "0x81C6D40", VA = "0x1881C7F40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81C6610", Offset = "0x81C5410", VA = "0x1881C6610", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81C8300", Offset = "0x81C7100", VA = "0x1881C8300")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81C66D0", Offset = "0x81C54D0", VA = "0x1881C66D0")]
		public DQILUIFDCOX PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81C5C70", Offset = "0x81C4A70", VA = "0x1881C5C70")]
		[IteratorStateMachine(typeof(ZUTFGABRZOS))]
		public IEnumerator<XTKXCVTPKYX> InitializeForLocalAccount(AmplitudeAnalyticsEvent initialEvent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81C75E0", Offset = "0x81C63E0", VA = "0x1881C75E0")]
		public void SendAppEnterEvent(bool delaySend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81C8280", Offset = "0x81C7080", VA = "0x1881C8280")]
		public void UpdateLastKnownInteractionCategory(string interactionCategory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81C81D0", Offset = "0x81C6FD0", VA = "0x1881C81D0")]
		public void UpdateLastAliveTime(float deltaTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81C6550", Offset = "0x81C5350", VA = "0x1881C6550")]
		private DQILUIFDCOX OZWUUZADIVM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81C5610", Offset = "0x81C4410", VA = "0x1881C5610")]
		private DQILUIFDCOX IXISITGGUKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81C7920", Offset = "0x81C6720", VA = "0x1881C7920")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81C46F0", Offset = "0x81C34F0", VA = "0x1881C46F0")]
		[IteratorStateMachine(typeof(SXZXQITUAFE))]
		private IEnumerator CPCDSIYLBQB(RNTACPTQADO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81C8840", Offset = "0x81C7640", VA = "0x1881C8840")]
		[IteratorStateMachine(typeof(TMAAKCRYNUF))]
		public IEnumerator WaitForFlush(float timeout = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81C80B0", Offset = "0x81C6EB0", VA = "0x1881C80B0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81C7FF0", Offset = "0x81C6DF0", VA = "0x1881C7FF0")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime time)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81C5770", Offset = "0x81C4570", VA = "0x1881C5770")]
		public static NNHZDTSNWJJ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81C3050", Offset = "0x81C1E50", VA = "0x1881C3050")]
		public static LCBYVFKAXFR AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string event_type, string userId, CrmType assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81C4AB0", Offset = "0x81C38B0", VA = "0x1881C4AB0")]
		public static LCBYVFKAXFR Event([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81C6850", Offset = "0x81C5650", VA = "0x1881C6850")]
		public static LCBYVFKAXFR PreviousSessionEvent([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81C5910", Offset = "0x81C4710", VA = "0x1881C5910")]
		public static LCBYVFKAXFR InitializeEvent(string userId, int allocatedMemMBOnBoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81C7B20", Offset = "0x81C6920", VA = "0x1881C7B20")]
		public static LCBYVFKAXFR StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81C4780", Offset = "0x81C3580", VA = "0x1881C4780")]
		public static LCBYVFKAXFR CreateOutOfSessionEvent(string event_type, bool anonymous = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81C5F90", Offset = "0x81C4D90", VA = "0x1881C5F90")]
		public static DQILUIFDCOX LogOutOfSessionEvent(LCBYVFKAXFR eventToLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81C5D10", Offset = "0x81C4B10", VA = "0x1881C5D10")]
		public void LogEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81C6180", Offset = "0x81C4F80", VA = "0x1881C6180")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81C62B0", Offset = "0x81C50B0", VA = "0x1881C62B0")]
		public void LogSerializedEventAsync(Dictionary<string, object> serializedAnalyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81C5E50", Offset = "0x81C4C50", VA = "0x1881C5E50")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage identifyMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81C4DC0", Offset = "0x81C3BC0", VA = "0x1881C4DC0")]
		private void FGTIBBYJVWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81C5020", Offset = "0x81C3E20", VA = "0x1881C5020")]
		private void GDGGQURYCTH(Dictionary<string, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81C8590", Offset = "0x81C7390", VA = "0x1881C8590")]
		private void VBDXUJRIHRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81C6390", Offset = "0x81C5190", VA = "0x1881C6390")]
		private void OXKJUOBOJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81C4F90", Offset = "0x81C3D90", VA = "0x1881C4F90")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81C5590", Offset = "0x81C4390", VA = "0x1881C5590")]
		[IteratorStateMachine(typeof(IMZBXVQCDIJ))]
		private IEnumerator<XTKXCVTPKYX> HDKOMKBQCLQ(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81C4670", Offset = "0x81C3470", VA = "0x1881C4670")]
		[IteratorStateMachine(typeof(ETXCRMAZKVZ))]
		private IEnumerator<XTKXCVTPKYX> CMUZWUNOJQE(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81C4EB0", Offset = "0x81C3CB0", VA = "0x1881C4EB0")]
		[IteratorStateMachine(typeof(UQLCUZRHOGZ))]
		private IEnumerator<XTKXCVTPKYX> FlushFromCache(AnalyticsCache cache, int? earlierThanFrame, string dataIdentifier, float timeout, Action<int> onBatchSent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x81C88C0", Offset = "0x81C76C0", VA = "0x1881C88C0")]
		private static void XSYVURZUAZG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81C52D0", Offset = "0x81C40D0", VA = "0x1881C52D0")]
		[AsyncStateMachine(typeof(<PostJson>d__123))]
		private Task<EventResponse<Dictionary<string, object>>> GOLJDVMFGWD(string a, string b, Dictionary<string, object> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81C5430", Offset = "0x81C4230", VA = "0x1881C5430")]
		[AsyncStateMachine(typeof(<PostJson>d__124))]
		private Task<EventResponse<List<Dictionary<string, object>>>> GOLJDVMFGWD(string a, string b, List<Dictionary<string, object>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x32CF930", Offset = "0x32CE730", VA = "0x1832CF930")]
		[AsyncStateMachine(typeof(<PostRudderStackJson>d__125<>))]
		private Task<EventResponse<T>> PostRudderStackJson<T>(string url, string dataIdentifier, string rudderStackKey, T eventParams, Dictionary<string, object> rudderStackEventParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81C4A60", Offset = "0x81C3860", VA = "0x1881C4A60")]
		private bool DGINVIRYVNI(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81C3820", Offset = "0x81C2620", VA = "0x1881C3820")]
		private Dictionary<string, object> BGJHVTQJSHI(string a, Dictionary<string, object> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x81C8A30", Offset = "0x81C7830", VA = "0x1881C8A30")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xACA9B0", Offset = "0xAC97B0", VA = "0x180ACA9B0", Slot = "6")]
		private bool PMVBHJCOWSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81C86D0", Offset = "0x81C74D0", VA = "0x1881C86D0")]
		[CompilerGenerated]
		private long WUKKIIATEES()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81C5D00", Offset = "0x81C4B00", VA = "0x1881C5D00")]
		[CompilerGenerated]
		private void JKJHSUEGUYA(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string PNTRCWYHJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string YCGERJAOUNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly long PMOMPDCRJFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string WEAUMHCHVSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal Dictionary<string, object> YQNGKMPJHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private string RNAVQGKYSIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long SZVVMMEZSKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long VSGJQZCNBLS;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x81C9D00", Offset = "0x81C8B00", VA = "0x1881C9D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x81C9DE0", Offset = "0x81C8BE0", VA = "0x1881C9DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x81C9D40", Offset = "0x81C8B40", VA = "0x1881C9D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x81C9E40", Offset = "0x81C8C40", VA = "0x1881C9E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x81C9CC0", Offset = "0x81C8AC0", VA = "0x1881C9CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x81C9D80", Offset = "0x81C8B80", VA = "0x1881C9D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x81C9090", Offset = "0x81C7E90", VA = "0x1881C9090")]
		public static LCBYVFKAXFR Create(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81C9630", Offset = "0x81C8430", VA = "0x1881C9630")]
		public static LCBYVFKAXFR FDHQVVTHUAS(string a, [JetBrains.Annotations.NotNull] string eventType, long b, long c, string d, long e, string f, string g, string h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81C9B20", Offset = "0x81C8920", VA = "0x1881C9B20")]
		private AmplitudeAnalyticsEvent(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x106EDC0", Offset = "0x106DBC0", VA = "0x18106EDC0")]
		public void TMSUTVYLWZC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81C9A20", Offset = "0x81C8820", VA = "0x1881C9A20", Slot = "5")]
		public override void TMXGPSMFBTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x81C98A0", Offset = "0x81C86A0", VA = "0x1881C98A0", Slot = "6")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81C9180", Offset = "0x81C7F80", VA = "0x1881C9180", Slot = "4")]
		protected override Dictionary<string, object> DSSCWJJMTED(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x81C9790", Offset = "0x81C8590", VA = "0x1881C9790")]
		private void LXYGYVVACTI(string a, string b, bool c = false)
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
			[Cpp2IlInjected.Address(RVA = "0x81CDC90", Offset = "0x81CCA90", VA = "0x1881CDC90")]
			public void OLJXDNRDZJX(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
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
			[Cpp2IlInjected.Address(RVA = "0x81D10F0", Offset = "0x81CFEF0", VA = "0x1881D10F0")]
			public void OLJXDNRDZJX(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1634260", Offset = "0x1633060", VA = "0x181634260")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal DeviceInfo CDAXMDLCTDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal RevenueData WGNFZZLGYWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly string ORJPDCCQUNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string RNAVQGKYSIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		internal Dictionary<string, object> GSWMGJHOILD;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x81C9EA0", Offset = "0x81C8CA0", VA = "0x1881C9EA0")]
		public static NNHZDTSNWJJ Create(string version, string userId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x81CA510", Offset = "0x81C9310", VA = "0x1881CA510")]
		protected AmplitudeAnalyticsIdentifyMessage(string version, string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81CA360", Offset = "0x81C9160", VA = "0x1881CA360")]
		public Dictionary<string, object> QTBUFQCCWOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81C9F50", Offset = "0x81C8D50", VA = "0x1881C9F50", Slot = "4")]
		protected virtual Dictionary<string, object> DSSCWJJMTED(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81CA3E0", Offset = "0x81C91E0", VA = "0x1881CA3E0")]
		protected void THRMMDZMKXV(string a, Dictionary<string, object> b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81CA2F0", Offset = "0x81C90F0", VA = "0x1881CA2F0")]
		protected void PLARHVUOLAH(string a, string b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81CA480", Offset = "0x81C9280", VA = "0x1881CA480", Slot = "5")]
		public virtual void TMXGPSMFBTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81CA270", Offset = "0x81C9070", VA = "0x1881CA270", Slot = "6")]
		public virtual void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class NNHZDTSNWJJ : RNOQXHYWUJF<AmplitudeAnalyticsIdentifyMessage, NNHZDTSNWJJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override NNHZDTSNWJJ DPUODNDYWQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "5")]
		public override AmplitudeAnalyticsIdentifyMessage Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x81D0F00", Offset = "0x81CFD00", VA = "0x1881D0F00")]
		public NNHZDTSNWJJ(AmplitudeAnalyticsIdentifyMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x81D0E60", Offset = "0x81CFC60", VA = "0x1881D0E60", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class LCBYVFKAXFR : RNOQXHYWUJF<AmplitudeAnalyticsEvent, LCBYVFKAXFR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool NKUXVBKTOWN;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override LCBYVFKAXFR DPUODNDYWQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xE64C30", Offset = "0xE63A30", VA = "0x180E64C30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long LZFNOLDTPYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x81CFC60", Offset = "0x81CEA60", VA = "0x1881CFC60")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81D00C0", Offset = "0x81CEEC0", VA = "0x1881D00C0")]
		public LCBYVFKAXFR(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "5")]
		public override AmplitudeAnalyticsEvent Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81CFC80", Offset = "0x81CEA80", VA = "0x1881CFC80", Slot = "4")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81CFF10", Offset = "0x81CED10", VA = "0x1881CFF10")]
		public LCBYVFKAXFR PGOJPAZEDZA(string a, long[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x39B99E0", Offset = "0x39B87E0", VA = "0x1839B99E0")]
		public LCBYVFKAXFR PGOJPAZEDZA<a>(string a, a[] b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x39B99E0", Offset = "0x39B87E0", VA = "0x1839B99E0")]
		public LCBYVFKAXFR PGOJPAZEDZA(string a, string[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x39B97A0", Offset = "0x39B85A0", VA = "0x1839B97A0")]
		public LCBYVFKAXFR PGOJPAZEDZA<b>(string a, b b) where b : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81CFE90", Offset = "0x81CEC90", VA = "0x1881CFE90")]
		public LCBYVFKAXFR PGOJPAZEDZA(string a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x81CFE20", Offset = "0x81CEC20", VA = "0x1881CFE20")]
		public LCBYVFKAXFR PGOJPAZEDZA(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81CFC30", Offset = "0x81CEA30", VA = "0x1881CFC30")]
		public LCBYVFKAXFR ICQHIGSYBID(string a, object? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81D0020", Offset = "0x81CEE20", VA = "0x1881D0020")]
		public LCBYVFKAXFR RWTVFUURMOH(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x81CFD20", Offset = "0x81CEB20", VA = "0x1881CFD20")]
		private LCBYVFKAXFR OQBLEKMYPUN(string a, object b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class LISCFBPKUIQ : LCBYVFKAXFR
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81D00C0", Offset = "0x81CEEC0", VA = "0x1881D00C0")]
		public LISCFBPKUIQ(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x81D0110", Offset = "0x81CEF10", VA = "0x1881D0110", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class RNOQXHYWUJF<b, c> where b : AmplitudeAnalyticsIdentifyMessage where c : RNOQXHYWUJF<b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected b JAOULZQPCWS;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract c DPUODNDYWQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public RNOQXHYWUJF(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D48D60", Offset = "0x5D47B60", VA = "0x185D48D60")]
		public c CKRDEEHOOKR(AmplitudeAnalyticsIdentifyMessage.DeviceInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D48DB0", Offset = "0x5D47BB0", VA = "0x185D48DB0")]
		public c COGJMKYGUUV(AmplitudeAnalyticsIdentifyMessage.RevenueData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D48E00", Offset = "0x5D47C00", VA = "0x185D48E00")]
		public c JNHQFBYMBJH(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C14850", Offset = "0x3C13650", VA = "0x183C14850")]
		public c JNHQFBYMBJH<a>(string a, a b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LogAsync();

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D48D30", Offset = "0x5D47B30", VA = "0x185D48D30")]
		internal static string BQQLBMBWPME(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5D48F20", Offset = "0x5D47D20", VA = "0x185D48F20")]
		private c ZXWNJSTJOVA(string a, object b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract b Build();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class KILAXQRKCSL : KZVHWHOGKRK
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
			public KILAXQRKCSL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x81D3750", Offset = "0x81D2550", VA = "0x1881D3750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x81D4160", Offset = "0x81D2F60", VA = "0x1881D4160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private HttpClient OTJEKWWBKBV;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x81CFB50", Offset = "0x81CE950", VA = "0x1881CFB50")]
		[XNELNNYDNRZ.Root]
		internal static void HREQUMUDOAP(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x81CFBC0", Offset = "0x81CE9C0", VA = "0x1881CFBC0")]
		[RecRoom.NoEngine.Common.Preserve]
		public KILAXQRKCSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x81CF9E0", Offset = "0x81CE7E0", VA = "0x1881CF9E0", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__4))]
		public Task<PostResponse> BSUBRLFURFL(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class SCQJDZCGAGW : KZVHWHOGKRK
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class RYMNRJREOIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public UnityWebRequest DBBMXUTRZAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TaskCompletionSource<PostResponse> DVWAGPVZTCX;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public RYMNRJREOIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x81D1010", Offset = "0x81CFE10", VA = "0x1881D1010")]
			internal void HOWIOYZIYPR(AsyncOperation a)
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
			[Cpp2IlInjected.Address(RVA = "0x81D31D0", Offset = "0x81D1FD0", VA = "0x1881D31D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x81D36E0", Offset = "0x81D24E0", VA = "0x1881D36E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		[XNELNNYDNRZ.Root]
		internal static void FRXNRQUDLHS(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[RecRoom.NoEngine.Common.Preserve]
		public SCQJDZCGAGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x81D1250", Offset = "0x81D0050", VA = "0x1881D1250", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__3))]
		public Task<PostResponse> BSUBRLFURFL(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class LPZLCEFEYLK
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> PKJUDHFLJJZ;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x81D02C0", Offset = "0x81CF0C0", VA = "0x1881D02C0")]
		internal static bool DZIPSUFZFVK(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface KZVHWHOGKRK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PostResponse> BSUBRLFURFL(string a, string b, string c, string d);
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
		[Cpp2IlInjected.Address(RVA = "0x19C77A0", Offset = "0x19C65A0", VA = "0x1819C77A0")]
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
	public class HXXSJMJTYFQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private long WBLLNFHXYLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private LCBYVFKAXFR DENNFGZVAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool AJFLWURHIFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private float HWBILPUJTZB;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x81CE440", Offset = "0x81CD240", VA = "0x1881CE440")]
		public HXXSJMJTYFQ(string a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3907E10", Offset = "0x3906C10", VA = "0x183907E10")]
		public void PGOJPAZEDZA<a>(string a, a b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x81CE1F0", Offset = "0x81CCFF0", VA = "0x1881CE1F0")]
		public void PGOJPAZEDZA(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81CE0B0", Offset = "0x81CCEB0", VA = "0x1881CE0B0")]
		public void Fail(string failureMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x81CE270", Offset = "0x81CD070", VA = "0x1881CE270")]
		public void QALJVCRSMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x81CE330", Offset = "0x81CD130", VA = "0x1881CE330")]
		private void YOLXLNPOLVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x81CE1A0", Offset = "0x81CCFA0", VA = "0x1881CE1A0")]
		private bool KHNAKTXKGQG()
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
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ParameterType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			get
			{
				return default(ParameterType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x81D14F0", Offset = "0x81D02F0", VA = "0x1881D14F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class GDOHSPRCGDE<a> : LGOSPXJWDCL<a>, QNNKKWWNICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly BDREYHRFHMB BCSFOWQURHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly string BVMYKRQUUPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly string VTYJIWHIGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private a ZENXFYCEGAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly a YGLWYKRZLIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool NCEFTLUBCGF;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string WHDOJSONNTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x50A1500", Offset = "0x50A0300", VA = "0x1850A1500")]
		public GDOHSPRCGDE(BDREYHRFHMB a, string b, string c, a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x50A1140", Offset = "0x509FF40", VA = "0x1850A1140", Slot = "4")]
		public a ZLWBNEVTNHE()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1717AC0", Offset = "0x17168C0", VA = "0x181717AC0", Slot = "6")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.NoEngine.Common.Preserve]
	public class StatsigCachedValueFactory : ULIPTRKYVPM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			public LayerParamCacheKey(string layerName, string paramName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x146D8C0", Offset = "0x146C6C0", VA = "0x18146D8C0", Slot = "4")]
			public bool Equals(LayerParamCacheKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x81D0CC0", Offset = "0x81CFAC0", VA = "0x1881D0CC0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x81D0D70", Offset = "0x81CFB70", VA = "0x1881D0D70", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private BDREYHRFHMB BCSFOWQURHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Dictionary<LayerParamCacheKey, QNNKKWWNICM> MLINMVSLIDV;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x81D18A0", Offset = "0x81D06A0", VA = "0x1881D18A0")]
		[XNELNNYDNRZ.Root.GameOnly]
		internal static void RZIXSWHMNAI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x81D1910", Offset = "0x81D0710", VA = "0x1881D1910")]
		[RecRoom.NoEngine.Common.Preserve]
		public StatsigCachedValueFactory([Inject(null)][System.Diagnostics.CodeAnalysis.NotNull] BDREYHRFHMB statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x81D1600", Offset = "0x81D0400", VA = "0x1881D1600", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x81D15F0", Offset = "0x81D03F0", VA = "0x1881D15F0")]
		private void AQHWGHQVFQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x81D16F0", Offset = "0x81D04F0", VA = "0x1881D16F0")]
		private void PKEUNONVZQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D09450", Offset = "0x3D08250", VA = "0x183D09450", Slot = "4")]
		public LGOSPXJWDCL<a> AGLSFITEIHJ<a>(string a, string b, a c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class QBRIAIPVPSP : YOONEIORVIO, LQMYRQJQQVN
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly IESFQQMONRE YEHOXYMAGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly GetCallback BOHICAMUWTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string CAPQWQOPKMY;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x132E200", Offset = "0x132D000", VA = "0x18132E200", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string IQMARLNWMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD050", Offset = "0x1EFBE50", VA = "0x181EFD050", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool RXAULQAIMCB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x81D0FF0", Offset = "0x81CFDF0", VA = "0x1881D0FF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VFIGTCPSSEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x81D0FD0", Offset = "0x81CFDD0", VA = "0x1881D0FD0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyList<string> DSZMNJTDOVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1EFD330", Offset = "0x1EFC130", VA = "0x181EFD330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1511780", Offset = "0x1510580", VA = "0x181511780")]
		public QBRIAIPVPSP(IESFQQMONRE a, string b, [Optional] GetCallback c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3C27FA0", Offset = "0x3C26DA0", VA = "0x183C27FA0", Slot = "9")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class DWVIIYVHDKI : BDREYHRFHMB, IDisposable
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
			public OLJXKAJDMQU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public DWVIIYVHDKI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x81D2810", Offset = "0x81D1610", VA = "0x1881D2810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x81D3170", Offset = "0x81D1F70", VA = "0x1881D3170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x81D4A70", Offset = "0x81D3870", VA = "0x1881D4A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x81D4C50", Offset = "0x81D3A50", VA = "0x1881D4C50", Slot = "5")]
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
			public OLJXKAJDMQU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public DWVIIYVHDKI <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x81D54A0", Offset = "0x81D42A0", VA = "0x1881D54A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x81D58D0", Offset = "0x81D46D0", VA = "0x1881D58D0", Slot = "5")]
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
			public DWVIIYVHDKI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public OLJXKAJDMQU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Dictionary<string, string> customIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x81D5080", Offset = "0x81D3E80", VA = "0x1881D5080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x81D5440", Offset = "0x81D4240", VA = "0x1881D5440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly IReadOnlyDictionary<string, EnvironmentTier> KDYQITLLIGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool LBBZPHTETTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool VQJEBPFAMUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskCompletionSource<bool> AHWZLPKJQUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskCompletionSource<bool> UCDVVSDFDWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly SemaphoreSlim TQUAYAPBONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private LAYLBJKJIQP NJBCTJERANT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Task ZYEZMTSYFML
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x81CD0E0", Offset = "0x81CBEE0", VA = "0x1881CD0E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Task HSKZFZXAIFA
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x81CCDB0", Offset = "0x81CBBB0", VA = "0x1881CCDB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool JVCPHQDTTYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DIFJOKXSZTD
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBF7480", Offset = "0xBF6280", VA = "0x180BF7480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x81CCDF0", Offset = "0x81CBBF0", VA = "0x1881CCDF0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public WFXCOPBMVIG WFAEANMDKSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x81CD2E0", Offset = "0x81CC0E0", VA = "0x1881CD2E0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action GUFIWKMWUVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x81CBC60", Offset = "0x81CAA60", VA = "0x1881CBC60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x81CCFA0", Offset = "0x81CBDA0", VA = "0x1881CCFA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action ZUVFKSIYFWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x81CBEB0", Offset = "0x81CACB0", VA = "0x1881CBEB0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x81CCF00", Offset = "0x81CBD00", VA = "0x1881CCF00", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action QWAZAOJIBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x81CD040", Offset = "0x81CBE40", VA = "0x1881CD040", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x81CD960", Offset = "0x81CC760", VA = "0x1881CD960", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ParameterAccessRecord> JVDLCJXMLXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x81CC890", Offset = "0x81CB690", VA = "0x1881CC890", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x81CC940", Offset = "0x81CB740", VA = "0x1881CC940", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x81CBF50", Offset = "0x81CAD50", VA = "0x1881CBF50", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x81CCC90", Offset = "0x81CBA90", VA = "0x1881CCC90", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__46))]
		public Task Initialize(string recNetEnv, [Optional] OLJXKAJDMQU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x81CD120", Offset = "0x81CBF20", VA = "0x1881CD120", Slot = "22")]
		[AsyncStateMachine(typeof(<Shutdown>d__60))]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x81CCE00", Offset = "0x81CBC00", VA = "0x1881CCE00", Slot = "17")]
		[AsyncStateMachine(typeof(<UpdateUser>d__61))]
		public Task KQBHRUOWZIN(OLJXKAJDMQU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x81CBD00", Offset = "0x81CAB00", VA = "0x1881CBD00")]
		private void BYHPSUVWUNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x81CD1D0", Offset = "0x81CBFD0", VA = "0x1881CD1D0", Slot = "18")]
		[AsyncStateMachine(typeof(<UpdateUserAddCustomIds>d__63))]
		public Task TRYLHLXEBID(OLJXKAJDMQU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x81CC9F0", Offset = "0x81CB7F0", VA = "0x1881CC9F0", Slot = "19")]
		public bool ICSFYPCCHQS(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x81CD6F0", Offset = "0x81CC4F0", VA = "0x1881CD6F0", Slot = "20")]
		public YOONEIORVIO VEPBRHEURUK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x81CBD90", Offset = "0x81CAB90", VA = "0x1881CBD90")]
		private IESFQQMONRE CAJTPYHGOKP(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x81CD590", Offset = "0x81CC390", VA = "0x1881CD590", Slot = "21")]
		public DAFESCTXOWS UYLHAOHGHSC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x81CD860", Offset = "0x81CC660", VA = "0x1881CD860")]
		private WHDOJSONNTW YXWVXCCUCUP(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x81CBF70", Offset = "0x81CAD70", VA = "0x1881CBF70")]
		private BQTZATEQLDL EJGDKICUXHZ(OLJXKAJDMQU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x81CCAE0", Offset = "0x81CB8E0", VA = "0x1881CCAE0")]
		private BCYNBPOFOEE IRMXKJJEGKK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x81CD310", Offset = "0x81CC110", VA = "0x1881CD310")]
		private void UJQIRSYUNQN(string a, IESFQQMONRE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x81CDBB0", Offset = "0x81CC9B0", VA = "0x1881CDBB0")]
		public DWVIIYVHDKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x81CBC20", Offset = "0x81CAA20", VA = "0x1881CBC20")]
		[CompilerGenerated]
		private void FOUEJMIDROY(ParameterAccessRecord a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x81CBC20", Offset = "0x81CAA20", VA = "0x1881CBC20")]
		[CompilerGenerated]
		private void AGSAJAIHLZI(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class ITYWUDXGBNF : BDREYHRFHMB, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x81D1C50", Offset = "0x81D0A50", VA = "0x1881D1C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
			public ITYWUDXGBNF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public OLJXKAJDMQU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public string recNetEnv;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x81D1E90", Offset = "0x81D0C90", VA = "0x1881D1E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x81D27B0", Offset = "0x81D15B0", VA = "0x1881D27B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private DWVIIYVHDKI RYBMRLXNGVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[CompilerGenerated]
		private Action ZUVFKSIYFWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskCompletionSource<bool> AHWZLPKJQUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskCompletionSource<bool> UCDVVSDFDWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Task CCJLDMGOBJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Task NENLWKMXYEO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private BDREYHRFHMB JJTHRRBTRRL
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x81CF750", Offset = "0x81CE550", VA = "0x1881CF750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DIFJOKXSZTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x81CEE80", Offset = "0x81CDC80", VA = "0x1881CEE80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool JVCPHQDTTYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x81CF740", Offset = "0x81CE540", VA = "0x1881CF740", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Task ZYEZMTSYFML
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x81CF100", Offset = "0x81CDF00", VA = "0x1881CF100", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Task HSKZFZXAIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x81CEDE0", Offset = "0x81CDBE0", VA = "0x1881CEDE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x81CEE90", Offset = "0x81CDC90", VA = "0x1881CEE90", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public WFXCOPBMVIG WFAEANMDKSI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x81CF430", Offset = "0x81CE230", VA = "0x1881CF430", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action GUFIWKMWUVO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x81CE8D0", Offset = "0x81CD6D0", VA = "0x1881CE8D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x81CEFC0", Offset = "0x81CDDC0", VA = "0x1881CEFC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action QWAZAOJIBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x81CF060", Offset = "0x81CDE60", VA = "0x1881CF060", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x81CF890", Offset = "0x81CE690", VA = "0x1881CF890", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ParameterAccessRecord> JVDLCJXMLXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x81CEA50", Offset = "0x81CD850", VA = "0x1881CEA50", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x81CEB00", Offset = "0x81CD900", VA = "0x1881CEB00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x81CF930", Offset = "0x81CE730", VA = "0x1881CF930")]
		[UnityEngine.Scripting.Preserve]
		public ITYWUDXGBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x81CF1A0", Offset = "0x81CDFA0", VA = "0x1881CF1A0")]
		[XNELNNYDNRZ.Root.GameOnly]
		internal static void RZIXSWHMNAI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x81CE9E0", Offset = "0x81CD7E0", VA = "0x1881CE9E0")]
		internal static void FCXAZQMAJPK(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x81CE9B0", Offset = "0x81CD7B0", VA = "0x1881CE9B0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x81CECD0", Offset = "0x81CDAD0", VA = "0x1881CECD0", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__23))]
		public Task Initialize(string recNetEnv, [Optional] OLJXKAJDMQU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x81CEEB0", Offset = "0x81CDCB0", VA = "0x1881CEEB0", Slot = "17")]
		public Task KQBHRUOWZIN(OLJXKAJDMQU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x81CF320", Offset = "0x81CE120", VA = "0x1881CF320", Slot = "18")]
		public Task TRYLHLXEBID(OLJXKAJDMQU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x81CEBB0", Offset = "0x81CD9B0", VA = "0x1881CEBB0", Slot = "19")]
		public bool ICSFYPCCHQS(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x81CF520", Offset = "0x81CE320", VA = "0x1881CF520", Slot = "20")]
		public YOONEIORVIO VEPBRHEURUK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x81CF470", Offset = "0x81CE270", VA = "0x1881CF470", Slot = "21")]
		public DAFESCTXOWS UYLHAOHGHSC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81CF210", Offset = "0x81CE010", VA = "0x1881CF210", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x81CF5D0", Offset = "0x81CE3D0", VA = "0x1881CF5D0")]
		private static void VMLJRTVAFSY(TaskCompletionSource<bool> a, Task b, Task c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x81CF7C0", Offset = "0x81CE5C0", VA = "0x1881CF7C0")]
		[AsyncStateMachine(typeof(<ForwardTaskToTCS>d__43))]
		private static void YOGLGZMLNIG(Task a, TaskCompletionSource<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1061A40", Offset = "0x1060840", VA = "0x181061A40")]
		[CompilerGenerated]
		private void DTOZXRGYZSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x10F24D0", Offset = "0x10F12D0", VA = "0x1810F24D0")]
		[CompilerGenerated]
		private void DTJTAKNBQGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xF7F1F0", Offset = "0xF7DFF0", VA = "0x180F7F1F0")]
		[CompilerGenerated]
		private void DTEMDDTEGVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x81CE970", Offset = "0x81CD770", VA = "0x1881CE970")]
		[CompilerGenerated]
		private void DSZFFWZGXKA(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class OFHXGKFIEUJ : DAFESCTXOWS, LQMYRQJQQVN
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly GetCallback BOHICAMUWTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly WHDOJSONNTW YMUUCBEBWKR;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4B210", Offset = "0x2A4A010", VA = "0x182A4B210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string IQMARLNWMEM
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xFDE650", Offset = "0xFDD450", VA = "0x180FDE650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x259CE20", Offset = "0x259BC20", VA = "0x18259CE20")]
		public OFHXGKFIEUJ(WHDOJSONNTW a, [Optional] GetCallback b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC100", Offset = "0x3AEAF00", VA = "0x183AEC100", Slot = "6")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface PZCDXFAYNDR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[UsedImplicitly]
	public class DVIBWZVPJQQ : PZCDXFAYNDR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly HZMAYPZLELK TVBJCAQKFFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly List<StatsigMemoryOverrideParameterDTO> VZOXDRWYMST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly string THYOWTPRFKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly string SYAWVVIQHSM;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x81CBA50", Offset = "0x81CA850", VA = "0x1881CBA50")]
		[XNELNNYDNRZ.Root.GameOnly]
		[UsedImplicitly]
		internal static void AMOQIHAHUJI(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x81CBAC0", Offset = "0x81CA8C0", VA = "0x1881CBAC0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal DVIBWZVPJQQ([Inject(null)][JetBrains.Annotations.NotNull] HZMAYPZLELK recNetMemoryExperiments, [Inject(null)][JetBrains.Annotations.NotNull] PMMGVHFCAYO buildSettingsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class LWFLCURBOIM : BDREYHRFHMB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Task ZYEZMTSYFML
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x81D0950", Offset = "0x81CF750", VA = "0x1881D0950", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Task HSKZFZXAIFA
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x81D06F0", Offset = "0x81CF4F0", VA = "0x1881D06F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool DIFJOKXSZTD
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool JVCPHQDTTYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public WFXCOPBMVIG WFAEANMDKSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action GUFIWKMWUVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x81D0460", Offset = "0x81CF260", VA = "0x1881D0460", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x81D0810", Offset = "0x81CF610", VA = "0x1881D0810", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action QWAZAOJIBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x81D08B0", Offset = "0x81CF6B0", VA = "0x1881D08B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x81D0C20", Offset = "0x81CFA20", VA = "0x1881D0C20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ParameterAccessRecord> JVDLCJXMLXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x81D0500", Offset = "0x81CF300", VA = "0x1881D0500", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x81D05B0", Offset = "0x81CF3B0", VA = "0x1881D05B0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		[RecRoom.NoEngine.Common.Preserve]
		public LWFLCURBOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x81D0660", Offset = "0x81CF460", VA = "0x1881D0660", Slot = "10")]
		public Task Initialize(string recNetEnv, [Optional] OLJXKAJDMQU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x81D0780", Offset = "0x81CF580", VA = "0x1881D0780", Slot = "17")]
		public Task KQBHRUOWZIN(OLJXKAJDMQU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x81D0A70", Offset = "0x81CF870", VA = "0x1881D0A70", Slot = "18")]
		public Task TRYLHLXEBID(OLJXKAJDMQU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "19")]
		public bool ICSFYPCCHQS(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x81D0B80", Offset = "0x81CF980", VA = "0x1881D0B80", Slot = "20")]
		public YOONEIORVIO VEPBRHEURUK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x81D0B00", Offset = "0x81CF900", VA = "0x1881D0B00", Slot = "21")]
		public DAFESCTXOWS UYLHAOHGHSC(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x81D09E0", Offset = "0x81CF7E0", VA = "0x1881D09E0", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class LAYLBJKJIQP : WFXCOPBMVIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly BQTZATEQLDL LZCIVPANNHB;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyDictionary<string, object> EOYPZSHVNGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xFE9590", Offset = "0xFE8390", VA = "0x180FE9590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public LAYLBJKJIQP(BQTZATEQLDL a)
		{
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface XZUAHCGECYE
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HXXSJMJTYFQ VPWDRNNZNPW(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface NMVRUBNUUWS
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
		long ZVPGRNHXITE
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		string UWBLGNMRRBP
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string HUBDAOVHALG
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool PJLWBGZZGSN
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		long ENVHWAXUBAC();

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XICPDEMNCDM(long a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NGAWWFRWLBE(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SBIRYNXINQD(Guid a, Guid b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void FOOSFXVHQLQ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void THQKNAVVWPW(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void YIDMZVYSEQQ(string a, object b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void IRRVGJNTOQM(RoomOfferPurchaseFunnelStep a, int b, [Optional] RoomOffer c, [Optional] string d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ZXIRPWMWRQP(RoomOffer a, long b, long c, int d, string e, int f);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OWVMUOBKNLU(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GJONPLUOABT(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void FNBOYKREUSP(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void TQZDKJMUIXP(long a, string b);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void OHLCRPLDTHS(string a);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task NEKKPWVHBYZ(ShoppingBagAction a, Guid? b, List<UnifiedItemId> c, List<UnifiedItemId> d, Func<ARAIZKZLBQI, long> e, string f, bool? g, [Optional] long? h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface FTCOFSHWSZE
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string GPCFERLWGHE
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
