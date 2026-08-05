using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.JetBrains.Annotations;
using RecRoom.Notifications;
using RecRoom.RoomLoading;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B83D20", Offset = "0x9B83120", VA = "0x189B83D20")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GJBBNODVZUB : UPCQRDCONQC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class EERQBUIKVSE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int FOIFJKRVJDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int GMMTYXYPSTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public bool SAPXUBRINMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DateTime? NWGEVUGZXZU;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9B81DA0", Offset = "0x9B811A0", VA = "0x189B81DA0")]
			public EERQBUIKVSE()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <RefreshDailyXP>d__73 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GJBBNODVZUB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9B83DA0", Offset = "0x9B831A0", VA = "0x189B83DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9B84180", Offset = "0x9B83580", VA = "0x189B84180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private struct <RewardImageForLevel>d__70 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public AsyncTaskMethodBuilder<string> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int level;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public GJBBNODVZUB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<PurchasableGiftDrop> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9B841E0", Offset = "0x9B835E0", VA = "0x189B841E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9B84590", Offset = "0x9B83990", VA = "0x189B84590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly WNSQWVKTIWE JJVTBLGYZSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly ULAEJZXLBAU QYECOEKQBOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly VRZTAZVISBD FKPLHKIKXFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly GXWSXQHGBQT FCMMQEBLNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LWMYGHQSDIB SQDQYZLSOPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UQTOQTEIEZW TTSPYWPUEVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly FVOWJYYJCCF GEUJFEKRTOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly GMRMSQJRUDP HTGVQEORFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly NSJZDFUANRD PZZHCQMVHWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ProgressionDisplaySource, Progression> LUYZRZIBTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly EERQBUIKVSE XCXITMARJMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Dictionary<int, string> LQJCOAOLDUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int MOEYGKXGJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float CGDQPDSZYMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float ZOCRDJFHNYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int? VBMEKPGGTRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int FZZTCYYCTDM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ZMGLXJDMXMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9B82B70", Offset = "0x9B81F70", VA = "0x189B82B70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int YPTRGFJMSWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD2B1C0", Offset = "0xD2A5C0", VA = "0x180D2B1C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD762F0", Offset = "0xD756F0", VA = "0x180D762F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TimeSpan UWBRTICVLKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9B82CB0", Offset = "0x9B820B0", VA = "0x189B82CB0", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DateTime JVZBXDZUZUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9B83460", Offset = "0x9B82860", VA = "0x189B83460")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool RGDVHXVCQUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B83820", Offset = "0x9B82C20", VA = "0x189B83820", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DateTime IUDDZHPLRKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9B821D0", Offset = "0x9B815D0", VA = "0x189B821D0")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string FTUIIWEAFTO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF8190", Offset = "0xCF7590", VA = "0x180CF8190", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7A50", Offset = "0xCF6E50", VA = "0x180CF7A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string ANZXSUZBYBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B70", Offset = "0xCF6F70", VA = "0x180CF7B70", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6F60", VA = "0x180CF7B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool EXPXEQSCZUA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xFACC40", Offset = "0xFAC040", VA = "0x180FACC40", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFA8160", Offset = "0xFA7560", VA = "0x180FA8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float RMFEEGSVERM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF2EE70", Offset = "0xF2E270", VA = "0x180F2EE70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF2EE80", Offset = "0xF2E280", VA = "0x180F2EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float YYCFMPXSVAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1688610", Offset = "0x1687A10", VA = "0x181688610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1687640", Offset = "0x1686A40", VA = "0x181687640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string ZCIXONZMETD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDCCCD0", Offset = "0xDCC0D0", VA = "0x180DCCCD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE82D80", Offset = "0xE82180", VA = "0x180E82D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string GMDUUBASGSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCFF1A0", Offset = "0xCFE5A0", VA = "0x180CFF1A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCFF160", Offset = "0xCFE560", VA = "0x180CFF160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int OCPGTFGJXKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9B82BE0", Offset = "0x9B81FE0", VA = "0x189B82BE0", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B83920", Offset = "0x9B82D20", VA = "0x189B83920")]
		[Preserve]
		internal GJBBNODVZUB([Inject(null)][NotNull] WNSQWVKTIWE recNetProgressions, [Inject(null)][NotNull] ULAEJZXLBAU recNetMatchmaking, [Inject("ServerTime")][NotNull] VRZTAZVISBD serverTimeProvider, [Inject(null)][NotNull] GXWSXQHGBQT gameConfigsProvider, [Inject(null)][NotNull] LWMYGHQSDIB notificationManager, [Inject(null)][NotNull] UQTOQTEIEZW statsig, [Inject(null)][NotNull] FVOWJYYJCCF roomManager, [Inject(null)][NotNull] GMRMSQJRUDP localPlayer, [Inject(null)][NotNull] NSJZDFUANRD recNetStorefronts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B81F20", Offset = "0x9B81320", VA = "0x189B81F20", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B83440", Offset = "0x9B82840", VA = "0x189B83440")]
		private void RKTMCALSBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B835E0", Offset = "0x9B829E0", VA = "0x189B835E0")]
		private void VPZTYJAKRCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B82260", Offset = "0x9B81660", VA = "0x189B82260")]
		private void HRBUWHKQDUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B82D40", Offset = "0x9B82140", VA = "0x189B82D40")]
		private void OXXNEKZRSIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B823F0", Offset = "0x9B817F0", VA = "0x189B823F0")]
		private void HTITNWQTCRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B831A0", Offset = "0x9B825A0", VA = "0x189B831A0", Slot = "16")]
		public int PRGDTDYKOYA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B83250", Offset = "0x9B82650", VA = "0x189B83250", Slot = "17")]
		[AsyncStateMachine(typeof(<RewardImageForLevel>d__70))]
		public Task<string> QGDSDLRTMTH(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B82130", Offset = "0x9B81530", VA = "0x189B82130", Slot = "18")]
		public Progression FETBQBAOJZJ(ProgressionDisplaySource a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B83380", Offset = "0x9B82780", VA = "0x189B83380", Slot = "19")]
		public void QGTWKACPTZC(ProgressionDisplaySource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B83510", Offset = "0x9B82910", VA = "0x189B83510", Slot = "20")]
		[AsyncStateMachine(typeof(<RefreshDailyXP>d__73))]
		public Task UMSGFKVXETI([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B82B00", Offset = "0x9B81F00", VA = "0x189B82B00", Slot = "21")]
		public (int, int) JHPOTYTMOHS()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B83410", Offset = "0x9B82810", VA = "0x189B83410", Slot = "22")]
		public void QOICQWGTKSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B81DC0", Offset = "0x9B811C0", VA = "0x189B81DC0")]
		private int DCWJNZXZVGO(Progression a, Progression b)
		{
			return default(int);
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
