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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F721C0", Offset = "0x7F709C0", VA = "0x187F721C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F72140", Offset = "0x7F70940", VA = "0x187F72140", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F76F60", Offset = "0x7F75760", VA = "0x187F76F60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2735A30", Offset = "0x2734230", VA = "0x182735A30")]
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
		public AmplitudeAnalyticsClient.Settings NIMGMRBCQJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool TYQLPVPBHBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBE0", Offset = "0xC9A3E0", VA = "0x180C9BBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public AGAmplitudeAnalyticsSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AmplitudeAnalyticsClient : SingletonMonoBehaviour<AmplitudeAnalyticsClient>, POKLIYYXBNR
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
				public int ESCXMYJDZSY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				public Dictionary<string, object> AFJYTYZRNGZ;

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
				public Item()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class LWREDTRENBY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				public int? PIMXNKMBWHN;

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
				public LWREDTRENBY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x7F71D10", Offset = "0x7F70510", VA = "0x187F71D10")]
				internal bool ZEIEMIEBISF(Item a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private const string BZMYHBTGAHU = "AnalyticsCacheKey";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private readonly string YODSDRFNMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private List<Item> PCBJJBVEEZU;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public int? EYTYVDMMGSN
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x7F6BE90", Offset = "0x7F6A690", VA = "0x187F6BE90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C960", Offset = "0x7F6B160", VA = "0x187F6C960")]
			internal AnalyticsCache(string cacheName, string recNetEnv)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C5C0", Offset = "0x7F6ADC0", VA = "0x187F6C5C0")]
			public int RRFZQRDLISS([Optional] int? a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B640", Offset = "0x7F69E40", VA = "0x187F6B640")]
			public List<Dictionary<string, object>> BVLPZBQYUHN(int a, int? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BB80", Offset = "0x7F6A380", VA = "0x187F6BB80")]
			public void FBDYLTGBBCN(AmplitudeAnalyticsIdentifyMessage a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BA20", Offset = "0x7F6A220", VA = "0x187F6BA20")]
			public void FBDYLTGBBCN(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BD20", Offset = "0x7F6A520", VA = "0x187F6BD20")]
			public void FXSCWEUOAJP(params Dictionary<string, object>[] objs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C380", Offset = "0x7F6AB80", VA = "0x187F6C380")]
			public void RQASFFZZLDV(List<Dictionary<string, object>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BC20", Offset = "0x7F6A420", VA = "0x187F6BC20")]
			private void FNSTIWBVKRC(Dictionary<string, object> a, bool b = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C770", Offset = "0x7F6AF70", VA = "0x187F6C770")]
			public void SaveToDisk()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F6BF30", Offset = "0x7F6A730", VA = "0x187F6BF30")]
			private void LoadFromDisk([Optional] string filePath)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B9D0", Offset = "0x7F6A1D0", VA = "0x187F6B9D0")]
			private void EIXQBSABHCN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F6B8B0", Offset = "0x7F6A0B0", VA = "0x187F6B8B0")]
			private static string DGMBTBZAGKC(string a, string b)
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
			[Cpp2IlInjected.Address(RVA = "0x7F72490", Offset = "0x7F70C90", VA = "0x187F72490")]
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
		private sealed class LYAEECGIXZT : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float PBWDKVBBYGK;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public LYAEECGIXZT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7F71D80", Offset = "0x7F70580", VA = "0x187F71D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7F71FD0", Offset = "0x7F707D0", VA = "0x187F71FD0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DKEPKFCKUFH : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float PBWDKVBBYGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public AnalyticsCache VFPYZGXPKLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int? PIMXNKMBWHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public string XUJJCTDKZCY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action<int> CANKQRGKEIY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float TUKCDIAWWRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private List<Dictionary<string, object>> RDSQYRCKZUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private bool VYKFGTNSQMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private bool NYIKAUYTBCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private int NXKTCMRFAUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			private Task<EventResponse<List<Dictionary<string, object>>>> ZJMIJFMEKVO;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public DKEPKFCKUFH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CF20", Offset = "0x7F6B720", VA = "0x187F6CF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7F6DB60", Offset = "0x7F6C360", VA = "0x187F6DB60", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CGBEBWWJKPB : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float PBWDKVBBYGK;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000075")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public CGBEBWWJKPB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CB50", Offset = "0x7F6B350", VA = "0x187F6CB50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CDA0", Offset = "0x7F6B5A0", VA = "0x187F6CDA0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class IANUOGTFUXI : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AmplitudeAnalyticsEvent AYSXOBHWMVJ;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public IANUOGTFUXI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7F70730", Offset = "0x7F6EF30", VA = "0x187F70730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7F70EB0", Offset = "0x7F6F6B0", VA = "0x187F70EB0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
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
			[Cpp2IlInjected.Address(RVA = "0x7F74F40", Offset = "0x7F73740", VA = "0x187F74F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7F751D0", Offset = "0x7F739D0", VA = "0x187F751D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F75240", Offset = "0x7F73A40", VA = "0x187F75240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7F75770", Offset = "0x7F73F70", VA = "0x187F75770", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x506D120", Offset = "0x506B920", VA = "0x18506D120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x506B1C0", Offset = "0x50699C0", VA = "0x18506B1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class HDTAKVYGBFP : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public float PBWDKVBBYGK;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public HDTAKVYGBFP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7F703B0", Offset = "0x7F6EBB0", VA = "0x187F703B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7F70520", Offset = "0x7F6ED20", VA = "0x187F70520", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DFFRTWRYNEG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private object YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AmplitudeAnalyticsClient VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public BCGUMWNTOSM RHOOBBSLLPW;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private object FHSTBNTIQTK
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public DFFRTWRYNEG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CDE0", Offset = "0x7F6B5E0", VA = "0x187F6CDE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CEE0", Offset = "0x7F6B6E0", VA = "0x187F6CEE0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private ILBIZEMNXBW NFSDJYHTNWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Lazy<ABRHTLCJVTL> NUOYRDSNRUG;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public const string EVENT_DATA_IDENTIFIER = "event";

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const string IDENTITY_DATA_IDENTIFIER = "identification";

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const string FDBKOUVUGSC = "queued_events";

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string PJTFQPUKAWL = "queued_identify";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string DAUCPNYSQKV = "prev_user_props";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const int RCJQNAFEECX = 15;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const int IYKYCTQPOZE = 10;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const int KXZWWHNTWZS = 5;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const float FJBMCBKAURP = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const long OPOYGWSGZBO = -1L;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string PCBDQHKKELN = "23NiJHIgu3koaGNCZIiuYvIQNCu";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string DADSROCPHYC = "2c6k98v3C52XkXvdkRFaGoi3qRf";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string WHETUQBJLWT = "23NiNLXh0CbGePSMIqFniJSAXkv";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string VGKFOROESIN = "23NjjFeEZwGXdg7C55qZsRGo2D8";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static bool ULBHZMCNORC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static bool WOFKJBEESON;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static int TLZTZHFDOAY;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static int ILQTIABMZVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Settings settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CXYCVUYWJUE CMNYNGCYUQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private WIOYKNCFBMU BLQNPUZPIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LQJJUOWYIRI BYMDEFTNGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ZOLTIOOSRPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float DUKPFUKLPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float GWRUGRVYEVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int DUKEWJHIDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int RBUVRSXDBSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int? YGEECTAGQJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int? JADBKETEFAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private long WZPSYZBYJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string MIXWXTSOXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private string XPSWGGUQZWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long GJVMSBCNQIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private string HLVMRJANYDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private string WIKTNGYXIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Dictionary<string, object> MOAQADPJDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private QuitState LCCSTYKHKUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int IFYPYSDAASG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int JUGWXKVLFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private float EJENVFJUTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool WPJGOTBNOZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool DWZZLSXPULV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AnalyticsCache VXMYHBKORBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private AnalyticsCache GJKUCCJGBNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private AnalyticsCache YGHGOHHMKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private string KDINXVZBPQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly List<AmplitudeAnalyticsIdentifyMessage> AUVCUGRPTOJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static AmplitudeAnalyticsIdentifyMessage.DeviceInfo MLEICWXDFZN;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static string RYABGMCSDAE;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const string CTEXJQNMDZZ = "https://recroom-dataplane.rudderstack.com";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly string TAUYDDKWELG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly string FFQHTCYIBQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly string GLIGNOWGPBQ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public const string EVENT_API_URL = "https://api2.amplitude.com/httpapi";

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public const string IDENTIFY_API_URL = "https://api2.amplitude.com/identify";

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ILBIZEMNXBW PXAJVRTQIQP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F693C0", Offset = "0x7F67BC0", VA = "0x187F693C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private ABRHTLCJVTL BUMFGWMJXOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7F683D0", Offset = "0x7F66BD0", VA = "0x187F683D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ZCQMLVMWLYD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F64940", Offset = "0x7F63140", VA = "0x187F64940")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static long LLZZIWIMNZK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F69FC0", Offset = "0x7F687C0", VA = "0x187F69FC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F6A0D0", Offset = "0x7F688D0", VA = "0x187F6A0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static string PIZHGSMGBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7F69F90", Offset = "0x7F68790", VA = "0x187F69F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xDD24D0", Offset = "0xDD0CD0", VA = "0x180DD24D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x148C390", Offset = "0x148AB90", VA = "0x18148C390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ZDHOMCXUJER
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC235C0", Offset = "0xC21DC0", VA = "0x180C235C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC23D70", Offset = "0xC22570", VA = "0x180C23D70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int? QIMDPKOHETV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xC982E0", Offset = "0xC96AE0", VA = "0x180C982E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x248AA10", Offset = "0x2489210", VA = "0x18248AA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UXDFYDEEYYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xCAB410", Offset = "0xCA9C10", VA = "0x180CAB410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2171D60", Offset = "0x2170560", VA = "0x182171D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool GDXNNTOHTQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7F69E60", Offset = "0x7F68660", VA = "0x187F69E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> GAWYFUPPUDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7F69DA0", Offset = "0x7F685A0", VA = "0x187F69DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F6A010", Offset = "0x7F68810", VA = "0x187F6A010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F64370", Offset = "0x7F62B70", VA = "0x187F64370", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F66F50", Offset = "0x7F65750", VA = "0x187F66F50")]
		private void NIUVFVZQOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F68E00", Offset = "0x7F67600", VA = "0x187F68E00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F67740", Offset = "0x7F65F40", VA = "0x187F67740", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F69130", Offset = "0x7F67930", VA = "0x187F69130")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F67960", Offset = "0x7F66160", VA = "0x187F67960")]
		public DNXWICJZUNF PrepareToQuit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F659E0", Offset = "0x7F641E0", VA = "0x187F659E0")]
		[IteratorStateMachine(typeof(IANUOGTFUXI))]
		public IEnumerator<YTAMKWOJLST> InitializeForLocalAccount(AmplitudeAnalyticsEvent initialEvent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F684B0", Offset = "0x7F66CB0", VA = "0x187F684B0")]
		public void SendAppEnterEvent(bool delaySend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7F690B0", Offset = "0x7F678B0", VA = "0x187F690B0")]
		public void UpdateLastKnownInteractionCategory(string interactionCategory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F69000", Offset = "0x7F67800", VA = "0x187F69000")]
		public void UpdateLastAliveTime(float deltaTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7F65270", Offset = "0x7F63A70", VA = "0x187F65270")]
		private DNXWICJZUNF GEPUQGPOCIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7F675E0", Offset = "0x7F65DE0", VA = "0x187F675E0")]
		private DNXWICJZUNF ORTXCAJDVAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F687F0", Offset = "0x7F66FF0", VA = "0x187F687F0")]
		public void SendEndSessionEvent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F68340", Offset = "0x7F66B40", VA = "0x187F68340")]
		[IteratorStateMachine(typeof(DFFRTWRYNEG))]
		private IEnumerator QEVMJEGRGNP(BCGUMWNTOSM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F69610", Offset = "0x7F67E10", VA = "0x187F69610")]
		[IteratorStateMachine(typeof(HDTAKVYGBFP))]
		public IEnumerator WaitForFlush(float timeout = 30f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F68EE0", Offset = "0x7F676E0", VA = "0x187F68EE0")]
		public static long UTCMillisSinceEpoch()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F68E20", Offset = "0x7F67620", VA = "0x187F68E20")]
		public static long UTCDateTimeToMillisSinceEpoch(DateTime time)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F65500", Offset = "0x7F63D00", VA = "0x187F65500")]
		public static GZXSYCWNELZ Identify()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F641C0", Offset = "0x7F629C0", VA = "0x187F641C0")]
		public static LMGHEDDKZEH AccountSelectionPostLoginEvent([JetBrains.Annotations.NotNull] string event_type, string userId, CrmType assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F64E00", Offset = "0x7F63600", VA = "0x187F64E00")]
		public static LMGHEDDKZEH Event([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F67AE0", Offset = "0x7F662E0", VA = "0x187F67AE0")]
		public static LMGHEDDKZEH PreviousSessionEvent([JetBrains.Annotations.NotNull] string event_type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F65690", Offset = "0x7F63E90", VA = "0x187F65690")]
		public static LMGHEDDKZEH InitializeEvent(string userId, int allocatedMemMBOnBoot)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F689F0", Offset = "0x7F671F0", VA = "0x187F689F0")]
		public static LMGHEDDKZEH StartSessionEvent()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F64B40", Offset = "0x7F63340", VA = "0x187F64B40")]
		public static LMGHEDDKZEH CreateOutOfSessionEvent(string event_type, bool anonymous = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B60", Offset = "0x7F65360", VA = "0x187F66B60")]
		public static DNXWICJZUNF LogOutOfSessionEvent(LMGHEDDKZEH eventToLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F66900", Offset = "0x7F65100", VA = "0x187F66900")]
		public void LogEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F66D40", Offset = "0x7F65540", VA = "0x187F66D40")]
		public void LogPrevSessionEventAsync(AmplitudeAnalyticsEvent analyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E70", Offset = "0x7F65670", VA = "0x187F66E70")]
		public void LogSerializedEventAsync(Dictionary<string, object> serializedAnalyticsEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F66A30", Offset = "0x7F65230", VA = "0x187F66A30")]
		public void LogIdentifyAsync(AmplitudeAnalyticsIdentifyMessage identifyMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F65410", Offset = "0x7F63C10", VA = "0x187F65410")]
		private void HHCZLFVXDQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F67320", Offset = "0x7F65B20", VA = "0x187F67320")]
		private void OKCQYJBUUHL(Dictionary<string, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F65320", Offset = "0x7F63B20", VA = "0x187F65320")]
		private void GRTRWTUKLDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F69450", Offset = "0x7F67C50", VA = "0x187F69450")]
		private void WNPJCOIQVZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F651E0", Offset = "0x7F639E0", VA = "0x187F651E0")]
		public void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F68420", Offset = "0x7F66C20", VA = "0x187F68420")]
		[IteratorStateMachine(typeof(LYAEECGIXZT))]
		private IEnumerator<YTAMKWOJLST> QYNRDSBFOFQ(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F682C0", Offset = "0x7F66AC0", VA = "0x187F682C0")]
		[IteratorStateMachine(typeof(CGBEBWWJKPB))]
		private IEnumerator<YTAMKWOJLST> QETQYGOANAI(float a = -1f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F65100", Offset = "0x7F63900", VA = "0x187F65100")]
		[IteratorStateMachine(typeof(DKEPKFCKUFH))]
		private IEnumerator<YTAMKWOJLST> FlushFromCache(AnalyticsCache cache, int? earlierThanFrame, string dataIdentifier, float timeout, Action<int> onBatchSent)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F69690", Offset = "0x7F67E90", VA = "0x187F69690")]
		private static void XCEZVDQASGY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F69790", Offset = "0x7F67F90", VA = "0x187F69790")]
		[AsyncStateMachine(typeof(<PostJson>d__123))]
		private Task<EventResponse<Dictionary<string, object>>> ZDVJGGLZVMP(string a, string b, Dictionary<string, object> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F698F0", Offset = "0x7F680F0", VA = "0x187F698F0")]
		[AsyncStateMachine(typeof(<PostJson>d__124))]
		private Task<EventResponse<List<Dictionary<string, object>>>> ZDVJGGLZVMP(string a, string b, List<Dictionary<string, object>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x30539F0", Offset = "0x30521F0", VA = "0x1830539F0")]
		[AsyncStateMachine(typeof(<PostRudderStackJson>d__125<>))]
		private Task<EventResponse<T>> PostRudderStackJson<T>(string url, string dataIdentifier, string rudderStackKey, T eventParams, Dictionary<string, object> rudderStackEventParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F65A70", Offset = "0x7F64270", VA = "0x187F65A70")]
		private bool LQMRDOZSGQC(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F65AC0", Offset = "0x7F642C0", VA = "0x187F65AC0")]
		private Dictionary<string, object> LTJONPDXRAG(string a, Dictionary<string, object> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F69AB0", Offset = "0x7F682B0", VA = "0x187F69AB0")]
		public AmplitudeAnalyticsClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xACB290", Offset = "0xAC9A90", VA = "0x180ACB290", Slot = "6")]
		private bool DRKPYICDKEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F677F0", Offset = "0x7F65FF0", VA = "0x187F677F0")]
		[CompilerGenerated]
		private long PAWPINOLWDI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F684A0", Offset = "0x7F66CA0", VA = "0x187F684A0")]
		[CompilerGenerated]
		private void SGWDTGFWADG(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AmplitudeAnalyticsEvent : AmplitudeAnalyticsIdentifyMessage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string FMTLDMDCEAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly string GGJOXDVKQSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly long VORFCQJPOHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string GGKQOVIPKUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		internal Dictionary<string, object> NEQTPZAZNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private string JUKJWNITXFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private long SAFVJFPAHJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private long MZVFCRMDGYI;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static string SessionTrackingData
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F6ADA0", Offset = "0x7F695A0", VA = "0x187F6ADA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AE70", Offset = "0x7F69670", VA = "0x187F6AE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static string StableId
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7F6ADE0", Offset = "0x7F695E0", VA = "0x187F6ADE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AEC0", Offset = "0x7F696C0", VA = "0x187F6AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static string ClientLauncher
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AD60", Offset = "0x7F69560", VA = "0x187F6AD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7F6AE20", Offset = "0x7F69620", VA = "0x187F6AE20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public long EventTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A130", Offset = "0x7F68930", VA = "0x187F6A130")]
		public static LMGHEDDKZEH Create(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A850", Offset = "0x7F69050", VA = "0x187F6A850")]
		public static LMGHEDDKZEH QXJADJYMPDM(string a, [JetBrains.Annotations.NotNull] string eventType, long b, long c, string d, long e, string f, string g, string h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F6ABC0", Offset = "0x7F693C0", VA = "0x187F6ABC0")]
		private AmplitudeAnalyticsEvent(string version, [JetBrains.Annotations.NotNull] string eventType, long sessionId, long sequenceNumber, string userId, string assignedUserCrm)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xD25AA0", Offset = "0xD242A0", VA = "0x180D25AA0")]
		public void XJLGZLFJNQU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AAC0", Offset = "0x7F692C0", VA = "0x187F6AAC0", Slot = "5")]
		public override void TVSCKZVQWBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A6D0", Offset = "0x7F68ED0", VA = "0x187F6A6D0", Slot = "6")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A220", Offset = "0x7F68A20", VA = "0x187F6A220", Slot = "4")]
		protected override Dictionary<string, object> HWSKVSTLYJR(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A9B0", Offset = "0x7F691B0", VA = "0x187F6A9B0")]
		private void TTLFARFYTHA(string a, string b, bool c = false)
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
			[Cpp2IlInjected.Address(RVA = "0x7F6DBA0", Offset = "0x7F6C3A0", VA = "0x187F6DBA0")]
			public void CXLORIXPMMJ(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F72240", Offset = "0x7F70A40", VA = "0x187F72240")]
			public void CXLORIXPMMJ(Dictionary<string, object> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x12F5A10", Offset = "0x12F4210", VA = "0x1812F5A10")]
			public RevenueData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		internal DeviceInfo LTUEQHNXQHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		internal RevenueData NCGPAYQYQHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly string BWEEKJDINNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly string JUKJWNITXFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		internal Dictionary<string, object> BDRPRXBCDIZ;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected string ZDHOMCXUJER
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AF10", Offset = "0x7F69710", VA = "0x187F6AF10")]
		public static GZXSYCWNELZ Create(string version, string userId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B580", Offset = "0x7F69D80", VA = "0x187F6B580")]
		protected AmplitudeAnalyticsIdentifyMessage(string version, string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B3D0", Offset = "0x7F69BD0", VA = "0x187F6B3D0")]
		public Dictionary<string, object> NDMEWFJFHAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F6AFC0", Offset = "0x7F697C0", VA = "0x187F6AFC0", Slot = "4")]
		protected virtual Dictionary<string, object> HWSKVSTLYJR(Dictionary<string, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B4E0", Offset = "0x7F69CE0", VA = "0x187F6B4E0")]
		protected void XBJJWJOJMSL(string a, Dictionary<string, object> b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B2E0", Offset = "0x7F69AE0", VA = "0x187F6B2E0")]
		protected void LOPUEFFHPFB(string a, string b, Dictionary<string, object> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B450", Offset = "0x7F69C50", VA = "0x187F6B450", Slot = "5")]
		public virtual void TVSCKZVQWBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F6B350", Offset = "0x7F69B50", VA = "0x187F6B350", Slot = "6")]
		public virtual void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class GZXSYCWNELZ : YSAGVOBEMQD<AmplitudeAnalyticsIdentifyMessage, GZXSYCWNELZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override GZXSYCWNELZ EMSFLQVLFQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "5")]
		public override AmplitudeAnalyticsIdentifyMessage Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DF50", Offset = "0x7F6C750", VA = "0x187F6DF50")]
		public GZXSYCWNELZ(AmplitudeAnalyticsIdentifyMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DEB0", Offset = "0x7F6C6B0", VA = "0x187F6DEB0", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class LMGHEDDKZEH : YSAGVOBEMQD<AmplitudeAnalyticsEvent, LMGHEDDKZEH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool FJNNBHDOVDT;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override LMGHEDDKZEH EMSFLQVLFQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB431D0", Offset = "0xB419D0", VA = "0x180B431D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public long HENRMAZVTGY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F71BD0", Offset = "0x7F703D0", VA = "0x187F71BD0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F71CC0", Offset = "0x7F704C0", VA = "0x187F71CC0")]
		public LMGHEDDKZEH(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "5")]
		public override AmplitudeAnalyticsEvent Build()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F71B30", Offset = "0x7F70330", VA = "0x187F71B30", Slot = "4")]
		public override void LogAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F71920", Offset = "0x7F70120", VA = "0x187F71920")]
		public LMGHEDDKZEH FQAFOMBBPQO(string a, long[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x374A400", Offset = "0x3748C00", VA = "0x18374A400")]
		public LMGHEDDKZEH FQAFOMBBPQO<a>(string a, a[] b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x374A400", Offset = "0x3748C00", VA = "0x18374A400")]
		public LMGHEDDKZEH FQAFOMBBPQO(string a, string[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x374A1C0", Offset = "0x37489C0", VA = "0x18374A1C0")]
		public LMGHEDDKZEH FQAFOMBBPQO<b>(string a, b b) where b : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F71830", Offset = "0x7F70030", VA = "0x187F71830")]
		public LMGHEDDKZEH FQAFOMBBPQO(string a, long b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F718B0", Offset = "0x7F700B0", VA = "0x187F718B0")]
		public LMGHEDDKZEH FQAFOMBBPQO(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F71C90", Offset = "0x7F70490", VA = "0x187F71C90")]
		public LMGHEDDKZEH USHLRXEFAHN(string a, object? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F71BF0", Offset = "0x7F703F0", VA = "0x187F71BF0")]
		public LMGHEDDKZEH URQOANWVELR(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F71A30", Offset = "0x7F70230", VA = "0x187F71A30")]
		private LMGHEDDKZEH JTQENGWKONT(string a, object b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class TTIWLVVSTHS : LMGHEDDKZEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F71CC0", Offset = "0x7F704C0", VA = "0x187F71CC0")]
		public TTIWLVVSTHS(AmplitudeAnalyticsEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F72950", Offset = "0x7F71150", VA = "0x187F72950", Slot = "4")]
		public override void LogAsync()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class YSAGVOBEMQD<b, c> where b : AmplitudeAnalyticsIdentifyMessage where c : YSAGVOBEMQD<b, c>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected b DDJYNHSBGTM;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract c EMSFLQVLFQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public YSAGVOBEMQD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7C30", Offset = "0x3DF6430", VA = "0x183DF7C30")]
		public c ZHWYPEQTFOR(AmplitudeAnalyticsIdentifyMessage.DeviceInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7990", Offset = "0x3DF6190", VA = "0x183DF7990")]
		public c OZUJDJDTMGV(AmplitudeAnalyticsIdentifyMessage.RevenueData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7B10", Offset = "0x3DF6310", VA = "0x183DF7B10")]
		public c RFSKNGUQDAV(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x304B560", Offset = "0x3049D60", VA = "0x18304B560")]
		public c RFSKNGUQDAV<a>(string a, a b) where a : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void LogAsync();

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3DF7AE0", Offset = "0x3DF62E0", VA = "0x183DF7AE0")]
		internal static string QQEOOLVKYKY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3DF79E0", Offset = "0x3DF61E0", VA = "0x183DF79E0")]
		private c QLJVFHNFJYC(string a, object b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract b Build();
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal class ZPFGBNKBRCD : CXYCVUYWJUE
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
			public ZPFGBNKBRCD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F744D0", Offset = "0x7F72CD0", VA = "0x187F744D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F74ED0", Offset = "0x7F736D0", VA = "0x187F74ED0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private HttpClient UVOLFWSTNTJ;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F76E80", Offset = "0x7F75680", VA = "0x187F76E80")]
		[UKOBXVXKPZF.Root]
		internal static void FCQIYOCOFGD(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F76EF0", Offset = "0x7F756F0", VA = "0x187F76EF0")]
		[RecRoom.NoEngine.Common.Preserve]
		public ZPFGBNKBRCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F76D10", Offset = "0x7F75510", VA = "0x187F76D10", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__4))]
		public Task<PostResponse> DNKKFQQHUVT(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal class WUCJXKJRMIO : CXYCVUYWJUE
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class KSOSAENBDBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public UnityWebRequest VKZRYAFRQQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TaskCompletionSource<PostResponse> UVOQYGXJHEX;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KSOSAENBDBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F70EF0", Offset = "0x7F6F6F0", VA = "0x187F70EF0")]
			internal void ZGTKGIBBRGL(AsyncOperation a)
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
			[Cpp2IlInjected.Address(RVA = "0x7F73F50", Offset = "0x7F72750", VA = "0x187F73F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F74460", Offset = "0x7F72C60", VA = "0x187F74460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		[UKOBXVXKPZF.Root]
		internal static void OPHYMRNCQVO(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[RecRoom.NoEngine.Common.Preserve]
		public WUCJXKJRMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F76BB0", Offset = "0x7F753B0", VA = "0x187F76BB0", Slot = "4")]
		[AsyncStateMachine(typeof(<PostJsonBasicAuth>d__3))]
		public Task<PostResponse> DNKKFQQHUVT(string a, string b, string c, string d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EBCTTILAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly Func<AmplitudeAnalyticsIdentifyMessage.DeviceInfo> WGMLYHZBIUD;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DD20", Offset = "0x7F6C520", VA = "0x187F6DD20")]
		internal static bool JNUCKDJYWJS(string a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface CXYCVUYWJUE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PostResponse> DNKKFQQHUVT(string a, string b, string c, string d);
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
		[Cpp2IlInjected.Address(RVA = "0x16B0DC0", Offset = "0x16AF5C0", VA = "0x1816B0DC0")]
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
	public class WPDBKHYVUQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private long PCGROBWBZRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private LMGHEDDKZEH QTZPWKSUMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool ZOLKCNSSLXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private float ROYIPGYDPIX;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F76A20", Offset = "0x7F75220", VA = "0x187F76A20")]
		public WPDBKHYVUQO(string a, float b = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3BCC350", Offset = "0x3BCAB50", VA = "0x183BCC350")]
		public void FQAFOMBBPQO<a>(string a, a b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F767F0", Offset = "0x7F74FF0", VA = "0x187F767F0")]
		public void FQAFOMBBPQO(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F76870", Offset = "0x7F75070", VA = "0x187F76870")]
		public void Fail(string failureMessage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F76960", Offset = "0x7F75160", VA = "0x187F76960")]
		public void XYQJHTASTOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F76690", Offset = "0x7F74E90", VA = "0x187F76690")]
		private void ECUJPYVCPER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F767A0", Offset = "0x7F74FA0", VA = "0x187F767A0")]
		private bool FKRWWLMUZIO()
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string ParameterName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ParameterType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
			get
			{
				return default(ParameterType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string ParameterValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool BoolValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F723A0", Offset = "0x7F70BA0", VA = "0x187F723A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SerializedStatsigExperimentSegment()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class QZYJDWCHAIO<a> : NOLNNMHXXIL<a>, OMNFRUYFXQY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly string XZJBAQBQMOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly string TVFGUAVYAOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private a WHXERYUCZBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly a PAXXNMAMTTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private bool DCLRAGLVOEF;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string IBLPVXFARYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B905B0", Offset = "0x5B8EDB0", VA = "0x185B905B0")]
		public QZYJDWCHAIO(XXWNNZHXIHL a, string b, string c, a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5B903B0", Offset = "0x5B8EBB0", VA = "0x185B903B0", Slot = "4")]
		public a EZPQDIKHPRU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1402800", Offset = "0x1401000", VA = "0x181402800", Slot = "6")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.NoEngine.Common.Preserve]
	public class StatsigCachedValueFactory : VCIZCIQFHGK, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
			public LayerParamCacheKey(string layerName, string paramName)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x115DC70", Offset = "0x115C470", VA = "0x18115DC70", Slot = "4")]
			public bool Equals(LayerParamCacheKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F72010", Offset = "0x7F70810", VA = "0x187F72010", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F720D0", Offset = "0x7F708D0", VA = "0x187F720D0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private XXWNNZHXIHL WYETQWNOSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Dictionary<LayerParamCacheKey, OMNFRUYFXQY> AXFZJFZPLET;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F72740", Offset = "0x7F70F40", VA = "0x187F72740")]
		[UKOBXVXKPZF.Root.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F727C0", Offset = "0x7F70FC0", VA = "0x187F727C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public StatsigCachedValueFactory([Inject(null)][System.Diagnostics.CodeAnalysis.NotNull] XXWNNZHXIHL statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F724A0", Offset = "0x7F70CA0", VA = "0x187F724A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F727B0", Offset = "0x7F70FB0", VA = "0x187F727B0")]
		private void VODGLIZOMLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F72590", Offset = "0x7F70D90", VA = "0x187F72590")]
		private void HODVJNTCOAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A40B80", Offset = "0x3A3F380", VA = "0x183A40B80", Slot = "4")]
		public NOLNNMHXXIL<a> PAUSTUYNEID<a>(string a, string b, a c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class AWIXMNCICML : RIFQRNMIFDU, AJRPFUWHSXF
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly CHWYQPQVGUO RYSPGPOVWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly GetCallback LUBVBIJWUHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly string LJRJQAEYSFS;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x105B090", Offset = "0x1059890", VA = "0x18105B090", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string OWWFYLAONDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1C28760", Offset = "0x1C26F60", VA = "0x181C28760", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool OYHWSCQESXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7F641A0", Offset = "0x7F629A0", VA = "0x187F641A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LXYXSTCQIIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F64180", Offset = "0x7F62980", VA = "0x187F64180", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IReadOnlyList<string> SCLLUGZLPDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1C28590", Offset = "0x1C26D90", VA = "0x181C28590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x11CE890", Offset = "0x11CD090", VA = "0x1811CE890")]
		public AWIXMNCICML(CHWYQPQVGUO a, string b, [Optional] GetCallback c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x30438E0", Offset = "0x30420E0", VA = "0x1830438E0", Slot = "9")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class HDGBWEEXKYU : XXWNNZHXIHL, IDisposable
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
			public WIOYKNCFBMU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public HDGBWEEXKYU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public BHPADFNGIKO buildSettings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private bool <containsUserInfo>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7F73710", Offset = "0x7F71F10", VA = "0x187F73710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7F73EF0", Offset = "0x7F726F0", VA = "0x187F73EF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F757E0", Offset = "0x7F73FE0", VA = "0x187F757E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F759C0", Offset = "0x7F741C0", VA = "0x187F759C0", Slot = "5")]
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
			public WIOYKNCFBMU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public HDGBWEEXKYU <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F76210", Offset = "0x7F74A10", VA = "0x187F76210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7F76630", Offset = "0x7F74E30", VA = "0x187F76630", Slot = "5")]
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
			public HDGBWEEXKYU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public WIOYKNCFBMU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Dictionary<string, string> customIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x7F75DF0", Offset = "0x7F745F0", VA = "0x187F75DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F761B0", Offset = "0x7F749B0", VA = "0x187F761B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly IReadOnlyDictionary<string, EnvironmentTier> VPPZJGHIZZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private bool FRTMLQVCQGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool FBFQELAZUDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private TaskCompletionSource<bool> XLGVBMGNNWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TaskCompletionSource<bool> ARXATUHJOCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly SemaphoreSlim UOWIZSUOHUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private OEHWWSSSSXN JFXDONAPVGZ;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Task BPBQURBKXBV
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E840", Offset = "0x7F6D040", VA = "0x187F6E840", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Task QZGBFKFGIUO
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7F700E0", Offset = "0x7F6E8E0", VA = "0x187F700E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LBXMQDHTNFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAF3180", Offset = "0xAF1980", VA = "0x180AF3180", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MFNNPQZEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xB391B0", Offset = "0xB379B0", VA = "0x180B391B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string ZDHOMCXUJER
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E830", Offset = "0x7F6D030", VA = "0x187F6E830", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public QVFKQMEFOXA UKCGLSAPKGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7F6DFA0", Offset = "0x7F6C7A0", VA = "0x187F6DFA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MRGYQJWYQME
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E640", Offset = "0x7F6CE40", VA = "0x187F6E640", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E790", Offset = "0x7F6CF90", VA = "0x187F6E790", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action VQEPBCHGTIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E450", Offset = "0x7F6CC50", VA = "0x187F6E450", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7F6F8B0", Offset = "0x7F6E0B0", VA = "0x187F6F8B0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action EOVBHQZNRGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7F6FDC0", Offset = "0x7F6E5C0", VA = "0x187F6FDC0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E4F0", Offset = "0x7F6CCF0", VA = "0x187F6E4F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ParameterAccessRecord> MGXYTEKXMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7F6F5B0", Offset = "0x7F6DDB0", VA = "0x187F6F5B0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7F6E6E0", Offset = "0x7F6CEE0", VA = "0x187F6E6E0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E620", Offset = "0x7F6CE20", VA = "0x187F6E620", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F320", Offset = "0x7F6DB20", VA = "0x187F6F320", Slot = "10")]
		public Task Initialize([Optional] WIOYKNCFBMU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F200", Offset = "0x7F6DA00", VA = "0x187F6F200")]
		[AsyncStateMachine(typeof(<Initialize>d__47))]
		private Task Initialize(BHPADFNGIKO buildSettings, WIOYKNCFBMU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FBA0", Offset = "0x7F6E3A0", VA = "0x187F6FBA0", Slot = "22")]
		[AsyncStateMachine(typeof(<Shutdown>d__61))]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F660", Offset = "0x7F6DE60", VA = "0x187F6F660", Slot = "17")]
		[AsyncStateMachine(typeof(<UpdateUser>d__62))]
		public Task KWTAQCFOLXT(WIOYKNCFBMU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E590", Offset = "0x7F6CD90", VA = "0x187F6E590")]
		private void DONLEVCOPBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F6DFD0", Offset = "0x7F6C7D0", VA = "0x187F6DFD0", Slot = "18")]
		[AsyncStateMachine(typeof(<UpdateUserAddCustomIds>d__64))]
		public Task AVKVWCRQMFR(WIOYKNCFBMU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F950", Offset = "0x7F6E150", VA = "0x187F6F950", Slot = "19")]
		public bool PJHWDUFDOPU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FC50", Offset = "0x7F6E450", VA = "0x187F6FC50", Slot = "20")]
		public RIFQRNMIFDU TFIBJNVVMJY(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F7A0", Offset = "0x7F6DFA0", VA = "0x187F6F7A0")]
		private CHWYQPQVGUO MTRCKAAXXQD(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FA40", Offset = "0x7F6E240", VA = "0x187F6FA40", Slot = "21")]
		public VHBFKNMYECO SFTVZAFGSOK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F4B0", Offset = "0x7F6DCB0", VA = "0x187F6F4B0")]
		private IBLPVXFARYY JZQXNZGOCJR(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E880", Offset = "0x7F6D080", VA = "0x187F6E880")]
		private JYEWWZDSYON ILEQRGGBNKP(WIOYKNCFBMU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E0E0", Offset = "0x7F6C8E0", VA = "0x187F6E0E0")]
		private static JPESVIPRHAU AZYQRFDDPBU(BHPADFNGIKO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6E2C0", Offset = "0x7F6CAC0", VA = "0x187F6E2C0")]
		private static JPESVIPRHAU AZYQRFDDPBU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FE60", Offset = "0x7F6E660", VA = "0x187F6FE60")]
		private void XLQSAEYTFKV(string a, CHWYQPQVGUO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F702D0", Offset = "0x7F6EAD0", VA = "0x187F702D0")]
		public HDGBWEEXKYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F760", Offset = "0x7F6DF60", VA = "0x187F6F760")]
		[CompilerGenerated]
		private void USLLBMMSSDD(ParameterAccessRecord a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F760", Offset = "0x7F6DF60", VA = "0x187F6F760")]
		[CompilerGenerated]
		private void LTNXOHYOWZF(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class ATOTSTKRPGX : XXWNNZHXIHL, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7F72AF0", Offset = "0x7F712F0", VA = "0x187F72AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAFF690", Offset = "0xAFDE90", VA = "0x180AFF690", Slot = "5")]
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
			public ATOTSTKRPGX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public WIOYKNCFBMU userData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x7F72D30", Offset = "0x7F71530", VA = "0x187F72D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7F736B0", Offset = "0x7F71EB0", VA = "0x187F736B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private HDGBWEEXKYU EEFKXHPWURM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[CompilerGenerated]
		private Action VQEPBCHGTIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskCompletionSource<bool> XLGVBMGNNWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private TaskCompletionSource<bool> ARXATUHJOCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Task XLNSCESXFIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Task WDMQZGMECEK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private XXWNNZHXIHL RYIUERPQILX
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7F636A0", Offset = "0x7F61EA0", VA = "0x187F636A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MFNNPQZEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7F63970", Offset = "0x7F62170", VA = "0x187F63970", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool LBXMQDHTNFS
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7F63B30", Offset = "0x7F62330", VA = "0x187F63B30", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Task BPBQURBKXBV
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7F63600", Offset = "0x7F61E00", VA = "0x187F63600", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Task QZGBFKFGIUO
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7F64030", Offset = "0x7F62830", VA = "0x187F64030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string ZDHOMCXUJER
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7F635E0", Offset = "0x7F61DE0", VA = "0x187F635E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public QVFKQMEFOXA UKCGLSAPKGU
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7F630C0", Offset = "0x7F618C0", VA = "0x187F630C0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action MRGYQJWYQME
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x7F633F0", Offset = "0x7F61BF0", VA = "0x187F633F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7F63540", Offset = "0x7F61D40", VA = "0x187F63540", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action EOVBHQZNRGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7F63F20", Offset = "0x7F62720", VA = "0x187F63F20", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7F632E0", Offset = "0x7F61AE0", VA = "0x187F632E0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ParameterAccessRecord> MGXYTEKXMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7F63980", Offset = "0x7F62180", VA = "0x187F63980", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7F63490", Offset = "0x7F61C90", VA = "0x187F63490", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7F640D0", Offset = "0x7F628D0", VA = "0x187F640D0")]
		[UnityEngine.Scripting.Preserve]
		public ATOTSTKRPGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7F63D00", Offset = "0x7F62500", VA = "0x187F63D00")]
		[UKOBXVXKPZF.Root.GameOnly]
		internal static void SWMNZJEUWLS(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F63FC0", Offset = "0x7F627C0", VA = "0x187F63FC0")]
		internal static void UMJRNTFPEVO(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F633C0", Offset = "0x7F61BC0", VA = "0x187F633C0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F63880", Offset = "0x7F62080", VA = "0x187F63880", Slot = "10")]
		[AsyncStateMachine(typeof(<Initialize>d__23))]
		public Task Initialize([Optional] WIOYKNCFBMU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7F63A30", Offset = "0x7F62230", VA = "0x187F63A30", Slot = "17")]
		public Task KWTAQCFOLXT(WIOYKNCFBMU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F63100", Offset = "0x7F61900", VA = "0x187F63100", Slot = "18")]
		public Task AVKVWCRQMFR(WIOYKNCFBMU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B40", Offset = "0x7F62340", VA = "0x187F63B40", Slot = "19")]
		public bool PJHWDUFDOPU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7F63E70", Offset = "0x7F62670", VA = "0x187F63E70", Slot = "20")]
		public RIFQRNMIFDU TFIBJNVVMJY(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7F63C50", Offset = "0x7F62450", VA = "0x187F63C50", Slot = "21")]
		public VHBFKNMYECO SFTVZAFGSOK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F63D70", Offset = "0x7F62570", VA = "0x187F63D70", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F63710", Offset = "0x7F61F10", VA = "0x187F63710")]
		private static void IXGAGZGMMMM(TaskCompletionSource<bool> a, Task b, Task c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F63210", Offset = "0x7F61A10", VA = "0x187F63210")]
		[AsyncStateMachine(typeof(<ForwardTaskToTCS>d__43))]
		private static void BDOVSOVGFIC(Task a, TaskCompletionSource<bool> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xD192D0", Offset = "0xD17AD0", VA = "0x180D192D0")]
		[CompilerGenerated]
		private void DBOTZQYMEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xDDE2E0", Offset = "0xDDCAE0", VA = "0x180DDE2E0")]
		[CompilerGenerated]
		private void DBJNCKEOUUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xC54860", Offset = "0xC53060", VA = "0x180C54860")]
		[CompilerGenerated]
		private void DBEGFDKRLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F63380", Offset = "0x7F61B80", VA = "0x187F63380")]
		[CompilerGenerated]
		private void DAYZHWQUBYA(ParameterAccessRecord a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal class DCHMJOAYKRL : VHBFKNMYECO, AJRPFUWHSXF
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public delegate void GetCallback(ParameterAccessRecord record);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly GetCallback LUBVBIJWUHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private readonly IBLPVXFARYY WJJOUHTOQGV;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string NRBYPZADYJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x27EC730", Offset = "0x27EAF30", VA = "0x1827EC730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string OWWFYLAONDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF70", Offset = "0xCC9770", VA = "0x180CCAF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x20B0900", Offset = "0x20AF100", VA = "0x1820B0900")]
		public DCHMJOAYKRL(IBLPVXFARYY a, [Optional] GetCallback b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x35275F0", Offset = "0x3525DF0", VA = "0x1835275F0", Slot = "6")]
		public T Get<T>(string key, T defaultValue)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public interface WJJGPFOLWIX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[UsedImplicitly]
	public class HDZVDJXFFGQ : WJJGPFOLWIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly PKNJDIJXDOE IHMWFUNKYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly List<StatsigMemoryOverrideParameterDTO> PHORZFUEWCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly string WNTVWEZXEAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly string DXVWBTHUWVG;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F70560", Offset = "0x7F6ED60", VA = "0x187F70560")]
		[UKOBXVXKPZF.Root.GameOnly]
		[UsedImplicitly]
		internal static void SKEBEIJGPGG(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F705D0", Offset = "0x7F6EDD0", VA = "0x187F705D0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal HDZVDJXFFGQ([Inject(null)][JetBrains.Annotations.NotNull] PKNJDIJXDOE recNetMemoryExperiments, [Inject(null)][JetBrains.Annotations.NotNull] BHPADFNGIKO buildSettingsProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class LGTQUAJRKUA : XXWNNZHXIHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Task BPBQURBKXBV
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7F712F0", Offset = "0x7F6FAF0", VA = "0x187F712F0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Task QZGBFKFGIUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7F717A0", Offset = "0x7F6FFA0", VA = "0x187F717A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool MFNNPQZEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool LBXMQDHTNFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string ZDHOMCXUJER
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public QVFKQMEFOXA UKCGLSAPKGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action MRGYQJWYQME
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7F71100", Offset = "0x7F6F900", VA = "0x187F71100", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7F71250", Offset = "0x7F6FA50", VA = "0x187F71250", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action EOVBHQZNRGU
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x7F71700", Offset = "0x7F6FF00", VA = "0x187F71700", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7F71060", Offset = "0x7F6F860", VA = "0x187F71060", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ParameterAccessRecord> MGXYTEKXMAH
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7F71410", Offset = "0x7F6FC10", VA = "0x187F71410", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7F711A0", Offset = "0x7F6F9A0", VA = "0x187F711A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		[RecRoom.NoEngine.Common.Preserve]
		public LGTQUAJRKUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7F71380", Offset = "0x7F6FB80", VA = "0x187F71380", Slot = "10")]
		public Task Initialize([Optional] WIOYKNCFBMU userData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F714C0", Offset = "0x7F6FCC0", VA = "0x187F714C0", Slot = "17")]
		public Task KWTAQCFOLXT(WIOYKNCFBMU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7F70FD0", Offset = "0x7F6F7D0", VA = "0x187F70FD0", Slot = "18")]
		public Task AVKVWCRQMFR(WIOYKNCFBMU a, Dictionary<string, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "19")]
		public bool PJHWDUFDOPU(string a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F71660", Offset = "0x7F6FE60", VA = "0x187F71660", Slot = "20")]
		public RIFQRNMIFDU TFIBJNVVMJY(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F71550", Offset = "0x7F6FD50", VA = "0x187F71550", Slot = "21")]
		public VHBFKNMYECO SFTVZAFGSOK(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7F715D0", Offset = "0x7F6FDD0", VA = "0x187F715D0", Slot = "22")]
		public Task Shutdown()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class OEHWWSSSSXN : QVFKQMEFOXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly JYEWWZDSYON QCECOOWAMVV;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyDictionary<string, object> XMIGPVAGIDH
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCA9D00", Offset = "0xCA8500", VA = "0x180CA9D00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public OEHWWSSSSXN(JYEWWZDSYON a)
		{
		}
	}
}
namespace RecRoom.Analytics.AccessInterfaces
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface KZQFETANNSI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		WPDBKHYVUQO PLQUFLLIRYI(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface LQJJUOWYIRI
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
		long PGXLCJXXFTE
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		string CEGRSVQJJPX
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		string OVFNYLLPKSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool AWFVJJEKBIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "4")]
		long YNUZBKGRMYS();

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NNABMEZUQVM(long a, bool b = true);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NEZUOKPPCJM(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void JAKMNTLKPAX(Guid a, Guid b, bool c);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void QVYHOMWZNYW(string a);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void BCRGUZAWHBK(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DWPJHXRHLMQ(string a, object b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void CCCALDAHNWI(RoomOfferPurchaseFunnelStep a, int b, [Optional] RoomOffer c, [Optional] string d, [Optional] string e);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void JDMTVYREBWH(RoomOffer a, long b, long c, int d, string e, int f);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XLYSWUPKNMG(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void CVWSYYMTQUR(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GPKQFZOUVQT(RoomOffer a, bool b, [Optional] string c);

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OFYOVDGZCBH(long a, string b);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void YQFCAXIPNNC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "18")]
		Task XVVNKBBMUFX(ShoppingBagAction a, Guid? b, List<UnifiedItemId> c, List<UnifiedItemId> d, Func<PVBFKGLGSKM, long> e, string f, bool? g, [Optional] long? h);
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface AYMZLXNQJXA
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		string NJHWLAOAOGS
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
