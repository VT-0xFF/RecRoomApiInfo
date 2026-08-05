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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DEB6F0", Offset = "0x9DEA6F0", VA = "0x189DEB6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class XNLTNFLAFVB : ZSQWQIRTMEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CJTWETWVKOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int AEMXCSGTQJW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public int HPSZKRCPKGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public bool YNPBKVFFJRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DateTime? XVAJCENXYAY;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9DEB6D0", Offset = "0x9DEA6D0", VA = "0x189DEB6D0")]
			public CJTWETWVKOO()
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
			public XNLTNFLAFVB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<int> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9DEB770", Offset = "0x9DEA770", VA = "0x189DEB770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9DEBB50", Offset = "0x9DEAB50", VA = "0x189DEBB50", Slot = "5")]
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
			public XNLTNFLAFVB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<PurchasableGiftDrop> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9DEBBB0", Offset = "0x9DEABB0", VA = "0x189DEBBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9DEBF60", Offset = "0x9DEAF60", VA = "0x189DEBF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly COVLKDGINYC OWGYVWIQGTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MACYYLIGCSS SISFTJXHXYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly PBWCOHCUVUP LGBHQAJEHZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly CQTKPAWHYMF CHGIDVBNCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly HZMQRERDGQL QHOSESITETA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KBMIQUZVWZE ADTRHTTEIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly MBLRPYWQFOT EBLANSETYVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ZORYLYZVEXV PCZKXFVCKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly VFDTTZVTCLB QNHRBUFKAJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ProgressionDisplaySource, Progression> BNPVUAMTFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly CJTWETWVKOO JJAVELZFJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly Dictionary<int, string> BFJFYTQLLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int HMKGSDGUKKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float SXLYOHYQEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float VPXMATHUZOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int? MXXAANSCXRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int STPNWEUYPPC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int CEAVPBWGDKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9DECDD0", Offset = "0x9DEBDD0", VA = "0x189DECDD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int UUIYHUTUFYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD41470", Offset = "0xD40470", VA = "0x180D41470", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD8B620", Offset = "0xD8A620", VA = "0x180D8B620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TimeSpan OLDNGKHJZII
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9DECD40", Offset = "0x9DEBD40", VA = "0x189DECD40", Slot = "6")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private DateTime DXXBBSJVUXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC90", Offset = "0x9DEBC90", VA = "0x189DECC90")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JDRRCQJRFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9DED820", Offset = "0x9DEC820", VA = "0x189DED820", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private DateTime WLMJLYDRMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9DED920", Offset = "0x9DEC920", VA = "0x189DED920")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string XYMOSWRKXNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD12820", Offset = "0xD11820", VA = "0x180D12820", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD127E0", Offset = "0xD117E0", VA = "0x180D127E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string SFCAWHYIGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD12E90", Offset = "0xD11E90", VA = "0x180D12E90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD12850", Offset = "0xD11850", VA = "0x180D12850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ICEIBBLQQUG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xFB1600", Offset = "0xFB0600", VA = "0x180FB1600", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFB1180", Offset = "0xFB0180", VA = "0x180FB1180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float GOGYTQCSAFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF35C50", Offset = "0xF34C50", VA = "0x180F35C50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xF35C60", Offset = "0xF34C60", VA = "0x180F35C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float JMTIDKHIHRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1689100", Offset = "0x1688100", VA = "0x181689100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x168A0C0", Offset = "0x16890C0", VA = "0x18168A0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string JWFACVADIYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xDEFAF0", Offset = "0xDEEAF0", VA = "0x180DEFAF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEA7E00", Offset = "0xEA6E00", VA = "0x180EA7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string XMAHBWFSHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD0DC20", Offset = "0xD0CC20", VA = "0x180D0DC20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD0DB90", Offset = "0xD0CB90", VA = "0x180D0DB90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int UINDTFUQQMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9DECBC0", Offset = "0x9DEBBC0", VA = "0x189DECBC0", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DEDB10", Offset = "0x9DECB10", VA = "0x189DEDB10")]
		[Preserve]
		internal XNLTNFLAFVB([Inject(null)][NotNull] COVLKDGINYC recNetProgressions, [Inject(null)][NotNull] MACYYLIGCSS recNetMatchmaking, [Inject("ServerTime")][NotNull] PBWCOHCUVUP serverTimeProvider, [Inject(null)][NotNull] CQTKPAWHYMF gameConfigsProvider, [Inject(null)][NotNull] HZMQRERDGQL notificationManager, [Inject(null)][NotNull] KBMIQUZVWZE statsig, [Inject(null)][NotNull] MBLRPYWQFOT roomManager, [Inject(null)][NotNull] ZORYLYZVEXV localPlayer, [Inject(null)][NotNull] VFDTTZVTCLB recNetStorefronts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC270", Offset = "0x9DEB270", VA = "0x189DEC270", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECFD0", Offset = "0x9DEBFD0", VA = "0x189DECFD0")]
		private void OPZXFEYXIXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC990", Offset = "0x9DEB990", VA = "0x189DEC990")]
		private void HINYPYDXHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECE40", Offset = "0x9DEBE40", VA = "0x189DECE40")]
		private void OMARSUEODSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC480", Offset = "0x9DEB480", VA = "0x189DEC480")]
		private void EIPSKHRJGSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DED0F0", Offset = "0x9DEC0F0", VA = "0x189DED0F0")]
		private void QOYICXWMOFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC8E0", Offset = "0x9DEB8E0", VA = "0x189DEC8E0", Slot = "16")]
		public int GXTMYFDKXEO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC140", Offset = "0x9DEB140", VA = "0x189DEC140", Slot = "17")]
		[AsyncStateMachine(typeof(<RewardImageForLevel>d__70))]
		public Task<string> CQRNDTOJBAH(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DEBFD0", Offset = "0x9DEAFD0", VA = "0x189DEBFD0", Slot = "18")]
		public Progression BFBYXOAHBGJ(ProgressionDisplaySource a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DECFF0", Offset = "0x9DEBFF0", VA = "0x189DECFF0", Slot = "19")]
		public void PMPKIGTKWAK(ProgressionDisplaySource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DEC070", Offset = "0x9DEB070", VA = "0x189DEC070", Slot = "20")]
		[AsyncStateMachine(typeof(<RefreshDailyXP>d__73))]
		public Task BPXCCYJPYLK([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DED080", Offset = "0x9DEC080", VA = "0x189DED080", Slot = "21")]
		public (int, int) QOWMNLWTWPE()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DED7F0", Offset = "0x9DEC7F0", VA = "0x189DED7F0", Slot = "22")]
		public void QYGKJOWKLTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DED9B0", Offset = "0x9DEC9B0", VA = "0x189DED9B0")]
		private int ZXSMLOPAGHO(Progression a, Progression b)
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
