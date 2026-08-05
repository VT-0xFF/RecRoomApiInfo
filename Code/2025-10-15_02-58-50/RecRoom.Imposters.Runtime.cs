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
		public readonly WQRICBYGOZL ImposterRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FriendlyName;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
		public QueuedLoad(WQRICBYGOZL imposterRequest, string friendlyName)
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
		[Cpp2IlInjected.Address(RVA = "0x84CC670", Offset = "0x84CB470", VA = "0x1884CC670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84CCA30", Offset = "0x84CB830", VA = "0x1884CCA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider YRENZKPTMXB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private JRDFLZEHNJE<QueuedLoad, GameObject> ZAFXADMTICF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public WTVYJAOOJPM PFXIUHPABDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JRDFLZEHNJE<QueuedLoad, GameObject> GSELHTWAKRY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84C8300", Offset = "0x84C7100", VA = "0x1884C8300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int JGDFNTSICSW
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C8070", Offset = "0x84C6E70", VA = "0x1884C8070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84C7E70", Offset = "0x84C6C70", VA = "0x1884C7E70", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84C8290", Offset = "0x84C7090", VA = "0x1884C8290", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84C7F50", Offset = "0x84C6D50", VA = "0x1884C7F50")]
	[AsyncStateMachine(typeof(<GenerateImposter>d__12))]
	private Task<GameObject> DGGLWRUXXKT(QueuedLoad a, CancellationToken b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84C80C0", Offset = "0x84C6EC0", VA = "0x1884C80C0")]
	public Task<GameObject> LoadItemAsync(WQRICBYGOZL imposterRequest, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84C8450", Offset = "0x84C7250", VA = "0x1884C8450")]
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
		public WQRICBYGOZL FXRDYEZUWBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture ZWJWQVARUQW;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public Value(WQRICBYGOZL imposterRequestObject, Texture texture)
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
	private class QFLGHXUKHMU : CRGCCOOWEBZ<Texture2D>
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
			public QFLGHXUKHMU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x84CCAA0", Offset = "0x84CB8A0", VA = "0x1884CCAA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x84CD290", Offset = "0x84CC090", VA = "0x1884CD290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly WQRICBYGOZL CMOHYRLPAKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture MYSCHDFLYKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MVNXZOTJSKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken HFIKUHJADDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D TKZSIIWVWBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject WNKYWXZQZYQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override WCGMKCSPRXW<Texture2D> PQFAKRQEOUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84CC360", Offset = "0x84CB160", VA = "0x1884CC360", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> PRSDEJIPCXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84CC3B0", Offset = "0x84CB1B0", VA = "0x1884CC3B0")]
		public QFLGHXUKHMU(WQRICBYGOZL a, RenderTexture b, ImposterRenderConfig c, CancellationToken d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84CC1F0", Offset = "0x84CAFF0", VA = "0x1884CC1F0")]
		[AsyncStateMachine(typeof(<Load>d__12))]
		private Task<Texture2D> Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84CC1C0", Offset = "0x84CAFC0", VA = "0x1884CC1C0", Slot = "10")]
		protected override void KCBMTJTGMRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84CC2E0", Offset = "0x84CB0E0", VA = "0x1884CC2E0")]
		private static void TZCDJTAHLIO(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x84CD4C0", Offset = "0x84CC2C0", VA = "0x1884CD4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAFC280", Offset = "0xAFB080", VA = "0x180AFC280", Slot = "5")]
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
	private static int FSFRBHHFNVG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture BMNHMNQZLVF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PRZZFGROFQC<GameObject> KATWFZBIWPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private JFEJQPLKJHX OWYBHEWYKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource TDRVAICITUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private SQZZORITPNB<Texture2D> SDPWSQDJCLS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private WQRICBYGOZL BEXXQNMCOUL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture NHKBQHCUTOG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int GULYUVEWWAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84CBC20", Offset = "0x84CAA20", VA = "0x1884CBC20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84CBC70", Offset = "0x84CAA70", VA = "0x1884CBC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture SBOZPAIUBTA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84CB440", Offset = "0x84CA240", VA = "0x1884CB440")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private WQRICBYGOZL FXRDYEZUWBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84CB620", Offset = "0x84CA420", VA = "0x1884CB620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool PZEQNBMLAZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25AEB10", Offset = "0x25AD910", VA = "0x1825AEB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int DDNFYIZOHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84CB1F0", Offset = "0x84C9FF0", VA = "0x1884CB1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84CB290", Offset = "0x84CA090", VA = "0x1884CB290")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84CB770", Offset = "0x84CA570", VA = "0x1884CB770")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84CBAD0", Offset = "0x84CA8D0", VA = "0x1884CBAD0")]
	private void VOGABAFSXYE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84CBA70", Offset = "0x84CA870", VA = "0x1884CBA70")]
	public void Set(WQRICBYGOZL newImposterRequestObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84CBA80", Offset = "0x84CA880", VA = "0x1884CBA80")]
	public void Set(Texture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84CBA90", Offset = "0x84CA890", VA = "0x1884CBA90")]
	public void Set(Value value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84CB380", Offset = "0x84CA180", VA = "0x1884CB380")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84CB870", Offset = "0x84CA670", VA = "0x1884CB870")]
	public void SetInternal(WQRICBYGOZL newImposterRequestObject, [Optional] Texture newOverrideTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84CB860", Offset = "0x84CA660", VA = "0x1884CB860")]
	public void SetCustomSize(int customSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xE7AD40", Offset = "0xE79B40", VA = "0x180E7AD40")]
	public void SetAntiAliasing(int antiAliasing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84CB390", Offset = "0x84CA190", VA = "0x1884CB390")]
	[AsyncStateMachine(typeof(<UpdateImposterImage>d__40))]
	private void GPNLFUULEWG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84CB2A0", Offset = "0x84CA0A0", VA = "0x1884CB2A0")]
	private void CNBGLTQHION(Texture a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84CBBA0", Offset = "0x84CA9A0", VA = "0x1884CBBA0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, EZNEIROVHMY
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float CIZXQQJFUTW = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84CB1B0", Offset = "0x84C9FB0", VA = "0x1884CB1B0")]
	public void SetReferencePoint(Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84CAFC0", Offset = "0x84C9DC0", VA = "0x1884CAFC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84CB190", Offset = "0x84C9F90", VA = "0x1884CB190")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2308930", Offset = "0x2307730", VA = "0x182308930")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x84CDCF0", Offset = "0x84CCAF0", VA = "0x1884CDCF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
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
		private const int IUNWHYHFDEK = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int STXLUXZTZNK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> IKULOZXPFUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CWZCKFGGMLU;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84CBED0", Offset = "0x84CACD0", VA = "0x1884CBED0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84CBDD0", Offset = "0x84CABD0", VA = "0x1884CBDD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84CC110", Offset = "0x84CAF10", VA = "0x1884CC110")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Systems.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface WQRICBYGOZL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string PQOXMWZCGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ImposterRenderSettings XRVULLAIIFX
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action EAPZWPYCYPZ;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GameObject> MEFPUYLLHIB(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool WJGIXKOZXAY(WQRICBYGOZL a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WMYJYQOGULC();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PNTQJXEYLRN();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool RNOMUPWEKKN(uint? a, [Out] SQZZORITPNB<Texture2D> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CEGVNBRTJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84C5E20", Offset = "0x84C4C20", VA = "0x1884C5E20")]
		public static bool Match(WQRICBYGOZL requestA, WQRICBYGOZL requestB)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, EZNEIROVHMY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84C5F10", Offset = "0x84C4D10", VA = "0x1884C5F10", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public HideInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface EZNEIROVHMY
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PrepareImposter(ImposterParameters parameters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NSZWOSROFQK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<Type> HNYJSKUDCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IEnumerable<Type> BARATURYTXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface WTVYJAOOJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HQFETEYTERH(params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a DFKBMUQMYRH<a>(a a, Transform b, bool c = false) where a : Component;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b DFKBMUQMYRH<b>(GameObject a, Transform b, bool c = false) where b : Component;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject DFKBMUQMYRH(GameObject a, Transform b, ImposterParameters c, bool d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DAABHKGDHPX : IDisposable, WTVYJAOOJPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly HashSet<Type> LOQRISFUTZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<Type> GNHOGMCNSDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform MKKIZYFNZKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Component> IXFBGJMBBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<IncreaseTransparentRenderQueueWhenInUI> PAFQKHPKXQT;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84C6F60", Offset = "0x84C5D60", VA = "0x1884C6F60")]
		[XNELNNYDNRZ.Root]
		public static void XNELNNYDNRZ(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84C7050", Offset = "0x84C5E50", VA = "0x1884C7050")]
		[UnityEngine.Scripting.Preserve]
		public DAABHKGDHPX([Inject(null)] NSZWOSROFQK componentTypeResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84C60B0", Offset = "0x84C4EB0", VA = "0x1884C60B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84C6320", Offset = "0x84C5120", VA = "0x1884C6320", Slot = "5")]
		public void HQFETEYTERH(params Type[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x37BB0B0", Offset = "0x37B9EB0", VA = "0x1837BB0B0", Slot = "6")]
		public a DFKBMUQMYRH<a>(a a, Transform b, bool c = false) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37BB140", Offset = "0x37B9F40", VA = "0x1837BB140", Slot = "7")]
		public b DFKBMUQMYRH<b>(GameObject a, Transform b, bool c = false) where b : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84C6020", Offset = "0x84C4E20", VA = "0x1884C6020", Slot = "8")]
		public GameObject DFKBMUQMYRH(GameObject a, Transform b, ImposterParameters c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37BB1C0", Offset = "0x37B9FC0", VA = "0x1837BB1C0", Slot = "9")]
		public c DFKBMUQMYRH<c>(GameObject a, Transform b, ImposterParameters c, bool d) where c : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37BB250", Offset = "0x37BA050", VA = "0x1837BB250")]
		private e DFKBMUQMYRH<e>(GameObject a, Transform b, ImposterParameters c, bool d, [Out] GameObject e) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37BB830", Offset = "0x37BA630", VA = "0x1837BB830")]
		private f WZGZLLOMEAN<f>(GameObject a, ImposterParameters b, bool c) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84C6480", Offset = "0x84C5280", VA = "0x1884C6480")]
		private void QHRBMCTONMJ(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84C6AD0", Offset = "0x84C58D0", VA = "0x1884C6AD0")]
		private void WCHAJCIILJX(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84C6370", Offset = "0x84C5170", VA = "0x1884C6370")]
		private void NXWOVSJOMWI(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84C6CF0", Offset = "0x84C5AF0", VA = "0x1884C6CF0")]
		private void WCHAJCIILJX(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84C66A0", Offset = "0x84C54A0", VA = "0x1884C66A0")]
		private void SASXEOTDAUU(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84C61B0", Offset = "0x84C4FB0", VA = "0x1884C61B0")]
		private void EVSMJDBAVKL(GameObject a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct ImposterParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Dictionary<Type, object> customParams;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x396A8C0", Offset = "0x39696C0", VA = "0x18396A8C0")]
		public ImposterParameters Set<T>(T param)
		{
			return default(ImposterParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3969E10", Offset = "0x3968C10", VA = "0x183969E10")]
		public T Get<T>(T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x396A070", Offset = "0x3968E70", VA = "0x18396A070")]
		public bool QIVTMCSUQLO<a>([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84CAF70", Offset = "0x84C9D70", VA = "0x1884CAF70")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct ImposterIsUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool isUI;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D702A0", Offset = "0x2D6F0A0", VA = "0x182D702A0")]
		public ImposterIsUI(bool _isUI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct ShouldIgnoreImposterCustomTransforms
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly bool applyTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84CC660", Offset = "0x84CB460", VA = "0x1884CC660")]
		public ShouldIgnoreImposterCustomTransforms(bool shouldIgnore)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, EZNEIROVHMY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84CC5E0", Offset = "0x84CB3E0", VA = "0x1884CC5E0", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds ZWGOIVFBLXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x84CAE40", Offset = "0x84C9C40", VA = "0x1884CAE40")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84CAD30", Offset = "0x84C9B30", VA = "0x1884CAD30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84CACF0", Offset = "0x84C9AF0", VA = "0x1884CACF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84CAD70", Offset = "0x84C9B70", VA = "0x1884CAD70")]
		private void PPAZNSRHRET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006E")]
				[Cpp2IlInjected.Address(RVA = "0x84CC1A0", Offset = "0x84CAFA0", VA = "0x1884CC1A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84CC190", Offset = "0x84CAF90", VA = "0x1884CC190")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ConditionalField("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[ConditionalField("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84CBCF0", Offset = "0x84CAAF0", VA = "0x1884CBCF0")]
		public void SetExplicitCameraComposition(Vector3 positionOffset, Quaternion rotationOffset, float orthographicSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84CBD20", Offset = "0x84CAB20", VA = "0x1884CBD20")]
		public ImposterRenderConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class EADCRWWIDUQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly Vector3 VWXGHVTTVSL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly List<URPLight> WXGVHBBXDNL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly List<Light> VGDPHPEVALK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static Camera OFFRIGGHHXJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<Renderer> PRRRBFAHBOL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly List<ImposterBoundsOverride> KDJAXRDAVMI;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static AmbientMode IBTOYXBZRLM;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static Color LMERIYOSVZF;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Color AJIYIERSSTB;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static Color BPFUNATUJJF;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Cubemap DWJCXHQVHUO;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static bool FYFPKERYPXP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static List<URPLight> UGTNPBMXCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84C8B00", Offset = "0x84C7900", VA = "0x1884C8B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static List<Light> IZSHVSGUSSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84C8490", Offset = "0x84C7290", VA = "0x1884C8490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Camera NTCCVYTEOMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84CA000", Offset = "0x84C8E00", VA = "0x1884CA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84C8B50", Offset = "0x84C7950", VA = "0x1884C8B50")]
		public static void IRXPWWJQRMG(Vector3 a, Quaternion b, ImposterRenderConfig c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84C97D0", Offset = "0x84C85D0", VA = "0x1884C97D0")]
		private static void QKDHBJBBOGS(Vector3 a, Quaternion b, URPLight c, ImposterRenderConfig.LightConfig d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84C9450", Offset = "0x84C8250", VA = "0x1884C9450")]
		public static void MMKKRUWJGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84CA250", Offset = "0x84C9050", VA = "0x1884CA250")]
		private static void YCEKPEOHRWZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84C9530", Offset = "0x84C8330", VA = "0x1884C9530")]
		public static void NBXHZAQBZYR(ImposterRenderConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84CA9F0", Offset = "0x84C97F0", VA = "0x1884CA9F0")]
		public static void ZQBGFBAYTSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84C87C0", Offset = "0x84C75C0", VA = "0x1884C87C0")]
		public static void FTILBGBCJEW(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, [Optional] Vector3? e, [Optional] Vector3? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84C8DF0", Offset = "0x84C7BF0", VA = "0x1884C8DF0")]
		private static void LSZJSRVXZAP(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, Vector3 e, Vector3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84C84E0", Offset = "0x84C72E0", VA = "0x1884C84E0")]
		private static void DOMOFIVRPGA(GameObject a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84CA710", Offset = "0x84C9510", VA = "0x1884CA710")]
		public static void YSDVUAPIBNF(Bounds a, ImposterRenderConfig b, [Out] Vector3 c, [Out] Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84C9AF0", Offset = "0x84C88F0", VA = "0x1884C9AF0")]
		private static void TTXQVYTMFNG(GameObject a, ImposterRenderConfig b, ImposterRenderSettings c, [Out] Vector3 d, [Out] Quaternion e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84C9700", Offset = "0x84C8500", VA = "0x1884C9700")]
		public static RenderTexture NSGWBSYFNHW(int a, int b, RenderTextureFormat c = RenderTextureFormat.ARGB32, string d = "[ImposterRendering]Preview")
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct QueuedImposterRender
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public RNTACPTQADO Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject TargetGameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture RenderTexture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig ImposterRenderConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public ImposterRenderSettings ImposterRenderSettings;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x84CC570", Offset = "0x84CB370", VA = "0x1884CC570")]
			public QueuedImposterRender(RNTACPTQADO promise, GameObject targetGameObject, RenderTexture renderTexture, ImposterRenderConfig imposterRenderConfig, ImposterRenderSettings imposterRenderSettings)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static JRDFLZEHNJE<QueuedImposterRender, RenderTexture> FSEONBCQBFV;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<QueuedImposterRender> AENJOUDKNTZ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int WWDRCNYHSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x84C7910", Offset = "0x84C6710", VA = "0x1884C7910")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84C7A40", Offset = "0x84C6840", VA = "0x1884C7A40")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject targetGameobject, RenderTexture renderTexture, ImposterRenderConfig imposterConfig, ImposterRenderSettings imposterRenderSettings, CancellationToken cancellationToken, bool disableWhileQueued = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84C7710", Offset = "0x84C6510", VA = "0x1884C7710", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84C79A0", Offset = "0x84C67A0", VA = "0x1884C79A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84C7470", Offset = "0x84C6270", VA = "0x1884C7470")]
		private static Task<RenderTexture> ASGNEVMGAXL(QueuedImposterRender a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84C7E30", Offset = "0x84C6C30", VA = "0x1884C7E30")]
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
