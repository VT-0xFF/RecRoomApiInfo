using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Initialization;
using RecRoom.Systems.Imposters;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct QueuedLoad
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LPSHHQPSWJE ImposterRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FriendlyName;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEB4670", Offset = "0xEB3470", VA = "0x180EB4670")]
		public QueuedLoad(LPSHHQPSWJE imposterRequest, string friendlyName)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct <GenerateImposter>d__12 : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public QueuedLoad queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x856EA40", Offset = "0x856D840", VA = "0x18856EA40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x856EE00", Offset = "0x856DC00", VA = "0x18856EE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DONCGBIEJPQ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NGYWNHTYQAB<QueuedLoad, GameObject> RINRIVXJBMM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public QTBGXFPKUHX CDYLTXPJWMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NGYWNHTYQAB<QueuedLoad, GameObject> BSFMEJDPGXT
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x856A5A0", Offset = "0x85693A0", VA = "0x18856A5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int VDSVFVQKCUN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x856A550", Offset = "0x8569350", VA = "0x18856A550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x856A120", Offset = "0x8568F20", VA = "0x18856A120", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x856A4E0", Offset = "0x85692E0", VA = "0x18856A4E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x856A200", Offset = "0x8569000", VA = "0x18856A200")]
	[AsyncStateMachine(typeof(<GenerateImposter>d__12))]
	private Task<GameObject> JZRZJQTTUCA(QueuedLoad a, CancellationToken b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x856A320", Offset = "0x8569120", VA = "0x18856A320")]
	public Task<GameObject> LoadItemAsync(LPSHHQPSWJE imposterRequest, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x856A6F0", Offset = "0x85694F0", VA = "0x18856A6F0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class Value
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LPSHHQPSWJE TOZBTMWHYNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture SOONMUUVFMP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAD31B0", Offset = "0xAD1FB0", VA = "0x180AD31B0")]
		public Value(LPSHHQPSWJE imposterRequestObject, Texture texture)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum Size
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class IJUVHSVDZVP : OBGMYYIFYGQ<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <Load>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IJUVHSVDZVP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x856EE70", Offset = "0x856DC70", VA = "0x18856EE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x856F650", Offset = "0x856E450", VA = "0x18856F650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LPSHHQPSWJE ORKSEUEDLHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture CHACTZDOVXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GPJWQXFMXGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken TNLIWMRTKWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D XZDKSQGDVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject YIRQDMQTDZN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override YHTYBMEYRGD<Texture2D> HXDZUNEVDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x856D110", Offset = "0x856BF10", VA = "0x18856D110", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> ZHNJRPNPCWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x856D1E0", Offset = "0x856BFE0", VA = "0x18856D1E0")]
		public IJUVHSVDZVP(LPSHHQPSWJE a, RenderTexture b, ImposterRenderConfig c, CancellationToken d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x856D020", Offset = "0x856BE20", VA = "0x18856D020")]
		[AsyncStateMachine(typeof(<Load>d__12))]
		private Task<Texture2D> Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x856CFF0", Offset = "0x856BDF0", VA = "0x18856CFF0", Slot = "10")]
		protected override void FYGFKXMSGZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x856D160", Offset = "0x856BF60", VA = "0x18856D160")]
		private static void WFXTDHQRIXJ(GameObject a)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct <UpdateImposterImage>d__40 : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x856F880", Offset = "0x856E680", VA = "0x18856F880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB2AF10", Offset = "0xB29D10", VA = "0x180B2AF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Header("General")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[Autofill(AutofillType.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Header("Imposter Rendering")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	private Size size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[ConditionalField("size", Size.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int HSQWMLEWHSD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture EIWTFXRCHUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private TYCZLKLRXIR<GameObject> OEKZTIDDIWE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JWWHWLOHQXU DZKLUUVVJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource EGMGOMZOSMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private XNDFGATNVRQ<Texture2D> ZLRDEFTFZHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LPSHHQPSWJE BMVQXGRWMQY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture BNHZUZRHLMH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AMLKEEICQEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x856E2C0", Offset = "0x856D0C0", VA = "0x18856E2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x856E310", Offset = "0x856D110", VA = "0x18856E310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture UVDLHTVRVHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x856DD00", Offset = "0x856CB00", VA = "0x18856DD00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xACC830", Offset = "0xACB630", VA = "0x180ACC830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LPSHHQPSWJE TOZBTMWHYNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x856D940", Offset = "0x856C740", VA = "0x18856D940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OBSRLWGSTVI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x218BFE0", Offset = "0x218ADE0", VA = "0x18218BFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int BBADYQRLEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x856DA90", Offset = "0x856C890", VA = "0x18856DA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x856D8A0", Offset = "0x856C6A0", VA = "0x18856D8A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x856DC10", Offset = "0x856CA10", VA = "0x18856DC10")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x856D8B0", Offset = "0x856C6B0", VA = "0x18856D8B0")]
	private void CRIBLVSOXJZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x856E130", Offset = "0x856CF30", VA = "0x18856E130")]
	public void Set(LPSHHQPSWJE newImposterRequestObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x856E0E0", Offset = "0x856CEE0", VA = "0x18856E0E0")]
	public void Set(Texture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x856E0F0", Offset = "0x856CEF0", VA = "0x18856E0F0")]
	public void Set(Value value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x856D930", Offset = "0x856C730", VA = "0x18856D930")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x856DEF0", Offset = "0x856CCF0", VA = "0x18856DEF0")]
	public void SetInternal(LPSHHQPSWJE newImposterRequestObject, [Optional] Texture newOverrideTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x856DEE0", Offset = "0x856CCE0", VA = "0x18856DEE0")]
	public void SetCustomSize(int customSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xBC2620", Offset = "0xBC1420", VA = "0x180BC2620")]
	public void SetAntiAliasing(int antiAliasing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x856E140", Offset = "0x856CF40", VA = "0x18856E140")]
	[AsyncStateMachine(typeof(<UpdateImposterImage>d__40))]
	private void XMGPQXJXMRF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x856DB30", Offset = "0x856C930", VA = "0x18856DB30")]
	private void IAESZOEQEFA(Texture a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x856E240", Offset = "0x856D040", VA = "0x18856E240")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, VTYEKSTWJLD
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float QVVEARWEKWV = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x856D860", Offset = "0x856C660", VA = "0x18856D860")]
	public void SetReferencePoint(Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x856D670", Offset = "0x856C470", VA = "0x18856D670")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x856D840", Offset = "0x856C640", VA = "0x18856D840")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21303C0", Offset = "0x212F1C0", VA = "0x1821303C0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ImposterRenderSettings
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static ImposterRenderSettings DefaultSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float CustomUIScale;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
	public ImposterRenderSettings(float customUIScale)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8571530", Offset = "0x8570330", VA = "0x188571530", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NQFEGNCGPKT = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int ZYKJHIAVTRL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> EJMURXQFZVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool QAJIGHRVKSB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x856E570", Offset = "0x856D370", VA = "0x18856E570")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x856E470", Offset = "0x856D270", VA = "0x18856E470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x856E7B0", Offset = "0x856D5B0", VA = "0x18856E7B0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Systems.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LPSHHQPSWJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string VEQNREMIVXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ImposterRenderSettings MFQYOUQQCMC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action MSOGKUTCCAC;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GameObject> BZONDPMGDIG(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZDTNNGWRSGZ(LPSHHQPSWJE a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XCEVBKIFNTB();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void TIMFFGMTIOI();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool PLZHZFDIGPU(uint? a, [Out] XNDFGATNVRQ<Texture2D> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class QGGYPONEUID
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x856E860", Offset = "0x856D660", VA = "0x18856E860")]
		public static bool Match(LPSHHQPSWJE requestA, LPSHHQPSWJE requestB)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, VTYEKSTWJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8569610", Offset = "0x8568410", VA = "0x188569610", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class EquipmentImposterUIRotation : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Vector3 UIRotation;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x856A730", Offset = "0x8569530", VA = "0x18856A730")]
		public EquipmentImposterUIRotation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public HideInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface VTYEKSTWJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PrepareImposter(ImposterParameters parameters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface QYUMUIFIAZX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<Type> RNQEVJINFTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IEnumerable<Type> RHHWXQHZFNC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface QTBGXFPKUHX
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DMATFMGDTIM(params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a WSHHJRFUAKY<a>(a a, Transform b, bool c = false) where a : Component;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b WSHHJRFUAKY<b>(GameObject a, Transform b, bool c = false) where b : Component;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject WSHHJRFUAKY(GameObject a, Transform b, ImposterParameters c, bool d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class VRVEPYEWDHC : IDisposable, QTBGXFPKUHX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<Type> OMNWEFBXMXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<Type> HWEQONTEQSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Transform BXEGLGHEISE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<Component> JBBUMCRCPEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly List<IncreaseTransparentRenderQueueWhenInUI> DOJXFFVSJBO;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8570220", Offset = "0x856F020", VA = "0x188570220")]
		[AUEAKLYJEMA.Root]
		public static void AUEAKLYJEMA(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85710E0", Offset = "0x856FEE0", VA = "0x1885710E0")]
		[UnityEngine.Scripting.Preserve]
		public VRVEPYEWDHC([Inject(null)] QYUMUIFIAZX componentTypeResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8570360", Offset = "0x856F160", VA = "0x188570360", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8570310", Offset = "0x856F110", VA = "0x188570310", Slot = "5")]
		public void DMATFMGDTIM(params Type[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CFE0", Offset = "0x3C7BDE0", VA = "0x183C7CFE0", Slot = "6")]
		public a WSHHJRFUAKY<a>(a a, Transform b, bool c = false) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CED0", Offset = "0x3C7BCD0", VA = "0x183C7CED0", Slot = "7")]
		public b WSHHJRFUAKY<b>(GameObject a, Transform b, bool c = false) where b : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8570F40", Offset = "0x856FD40", VA = "0x188570F40", Slot = "8")]
		public GameObject WSHHJRFUAKY(GameObject a, Transform b, ImposterParameters c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CF50", Offset = "0x3C7BD50", VA = "0x183C7CF50", Slot = "9")]
		public c WSHHJRFUAKY<c>(GameObject a, Transform b, ImposterParameters c, bool d) where c : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C8F0", Offset = "0x3C7B6F0", VA = "0x183C7C8F0")]
		private e WSHHJRFUAKY<e>(GameObject a, Transform b, ImposterParameters c, bool d, [Out] GameObject e) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C600", Offset = "0x3C7B400", VA = "0x183C7C600")]
		private f UJKWCHXMBXK<f>(GameObject a, ImposterParameters b, bool c) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8570D20", Offset = "0x856FB20", VA = "0x188570D20")]
		private void UUJEGQQGUPW(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8570460", Offset = "0x856F260", VA = "0x188570460")]
		private void FQKAFRSOLUG(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8570FD0", Offset = "0x856FDD0", VA = "0x188570FD0")]
		private void XLTACHOTBZF(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8570680", Offset = "0x856F480", VA = "0x188570680")]
		private void FQKAFRSOLUG(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85708F0", Offset = "0x856F6F0", VA = "0x1885708F0")]
		private void JTIKXPOKCJF(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85700B0", Offset = "0x856EEB0", VA = "0x1885700B0")]
		private void ABBIPWJOTUI(GameObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct ImposterParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<Type, object> customParams;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x37E8980", Offset = "0x37E7780", VA = "0x1837E8980")]
		public ImposterParameters Set<T>(T param)
		{
			return default(ImposterParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x37E7ED0", Offset = "0x37E6CD0", VA = "0x1837E7ED0")]
		public T Get<T>(T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x37E8130", Offset = "0x37E6F30", VA = "0x1837E8130")]
		public bool LRBGKMPHKRZ<a>([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x856D620", Offset = "0x856C420", VA = "0x18856D620")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct ImposterIsUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public bool isUI;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x24DF8C0", Offset = "0x24DE6C0", VA = "0x1824DF8C0")]
		public ImposterIsUI(bool _isUI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct ShouldIgnoreImposterCustomTransforms
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly bool applyTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x856EA30", Offset = "0x856D830", VA = "0x18856EA30")]
		public ShouldIgnoreImposterCustomTransforms(bool shouldIgnore)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ScaleInImposter : MonoBehaviour, VTYEKSTWJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x856E9B0", Offset = "0x856D7B0", VA = "0x18856E9B0", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds GWRIRMKUSGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x856D4F0", Offset = "0x856C2F0", VA = "0x18856D4F0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x856D4B0", Offset = "0x856C2B0", VA = "0x18856D4B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x856D470", Offset = "0x856C270", VA = "0x18856D470")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x856D3A0", Offset = "0x856C1A0", VA = "0x18856D3A0")]
		private void IPITAJDDWFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x856E840", Offset = "0x856D640", VA = "0x18856E840")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x856E830", Offset = "0x856D630", VA = "0x18856E830")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ConditionalField("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[ConditionalField("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x856E390", Offset = "0x856D190", VA = "0x18856E390")]
		public void SetExplicitCameraComposition(Vector3 positionOffset, Quaternion rotationOffset, float orthographicSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x856E3C0", Offset = "0x856D1C0", VA = "0x18856E3C0")]
		public ImposterRenderConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class IJBAYZBAFDX
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public static readonly Vector3 PVIUJQZLLPK;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly List<URPLight> HSYKJMLWNLQ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly List<Light> BOCHZHEJEEN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static Camera NKOLLYUXOMA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly List<Renderer> QRSYXKTCBVM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly List<ImposterBoundsOverride> ZEKWKEZFXHZ;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static AmbientMode JYPWCTWUVQB;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Color HMNWYPFXGDE;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static Color XYNKVZEVDJC;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Color SFJNMACWPPQ;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Cubemap XGNDLDZDZDJ;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static bool WOJSEMBYFVE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static List<URPLight> SIQSOIGMWRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x856B0D0", Offset = "0x8569ED0", VA = "0x18856B0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static List<Light> MMHUNVWFWKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x856C8A0", Offset = "0x856B6A0", VA = "0x18856C8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Camera RYAKJEOBYZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x856CB90", Offset = "0x856B990", VA = "0x18856CB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x856C8F0", Offset = "0x856B6F0", VA = "0x18856C8F0")]
		public static void VPIJKCIMKQB(Vector3 a, Quaternion b, ImposterRenderConfig c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x856C580", Offset = "0x856B380", VA = "0x18856C580")]
		private static void VELBMHXYFKB(Vector3 a, Quaternion b, URPLight c, ImposterRenderConfig.LightConfig d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x856AD10", Offset = "0x8569B10", VA = "0x18856AD10")]
		public static void FZZQAFZFVJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x856BA60", Offset = "0x856A860", VA = "0x18856BA60")]
		private static void QCEVAOCMGJK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x856A860", Offset = "0x8569660", VA = "0x18856A860")]
		public static void CHPQNVOKLKC(ImposterRenderConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x856B630", Offset = "0x856A430", VA = "0x18856B630")]
		public static void OHNIJEGTAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x856B720", Offset = "0x856A520", VA = "0x18856B720")]
		public static void QCDONCCRDOL(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, [Optional] Vector3? e, [Optional] Vector3? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x856BF20", Offset = "0x856AD20", VA = "0x18856BF20")]
		private static void SBVGDBJWFBS(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, Vector3 e, Vector3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x856AA30", Offset = "0x8569830", VA = "0x18856AA30")]
		private static void EBOYXHHASLD(GameObject a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x856ADF0", Offset = "0x8569BF0", VA = "0x18856ADF0")]
		public static void IZUBAEHUFCK(Bounds a, ImposterRenderConfig b, [Out] Vector3 c, [Out] Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x856B120", Offset = "0x8569F20", VA = "0x18856B120")]
		private static void OBPVNCCNRRD(GameObject a, ImposterRenderConfig b, ImposterRenderSettings c, [Out] Vector3 d, [Out] Quaternion e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x856A790", Offset = "0x8569590", VA = "0x18856A790")]
		public static RenderTexture AJIGFCHQVHJ(int a, int b, RenderTextureFormat c = RenderTextureFormat.ARGB32, string d = "[ImposterRendering]Preview")
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct QueuedImposterRender
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public OHONQDGFHPH Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public GameObject TargetGameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public RenderTexture RenderTexture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public ImposterRenderConfig ImposterRenderConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public ImposterRenderSettings ImposterRenderSettings;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x856E940", Offset = "0x856D740", VA = "0x18856E940")]
			public QueuedImposterRender(OHONQDGFHPH promise, GameObject targetGameObject, RenderTexture renderTexture, ImposterRenderConfig imposterRenderConfig, ImposterRenderSettings imposterRenderSettings)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static NGYWNHTYQAB<QueuedImposterRender, RenderTexture> IJHSJNXCENE;

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static readonly List<QueuedImposterRender> BDYNDZXXWDI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int ULJGZIIDYWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8569920", Offset = "0x8568720", VA = "0x188569920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8569A50", Offset = "0x8568850", VA = "0x188569A50")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject targetGameobject, RenderTexture renderTexture, ImposterRenderConfig imposterConfig, ImposterRenderSettings imposterRenderSettings, CancellationToken cancellationToken, bool disableWhileQueued = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8569720", Offset = "0x8568520", VA = "0x188569720", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85699B0", Offset = "0x85687B0", VA = "0x1885699B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8569CB0", Offset = "0x8568AB0", VA = "0x188569CB0")]
		private static Task<RenderTexture> VDZETZLWFOQ(QueuedImposterRender a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x856A0E0", Offset = "0x8568EE0", VA = "0x18856A0E0")]
		public DeferredImposterRenderer()
		{
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
