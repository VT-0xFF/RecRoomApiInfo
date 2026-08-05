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
		public readonly GKOMGOBKOKC ImposterRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FriendlyName;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
		public QueuedLoad(GKOMGOBKOKC imposterRequest, string friendlyName)
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
		[Cpp2IlInjected.Address(RVA = "0x98A5D00", Offset = "0x98A4900", VA = "0x1898A5D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98A60C0", Offset = "0x98A4CC0", VA = "0x1898A60C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CSNNXWEHHHY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private UOYACGEXCPT<QueuedLoad, GameObject> RRTDBFNERYU;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HUGRMVAOERL JQBAJDFXUMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0370", VA = "0x180CF1770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private UOYACGEXCPT<QueuedLoad, GameObject> XZTIQIJMKYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98A3E00", Offset = "0x98A2A00", VA = "0x1898A3E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AVVEKIGBHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98A42A0", Offset = "0x98A2EA0", VA = "0x1898A42A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x98A3D20", Offset = "0x98A2920", VA = "0x1898A3D20", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x98A4230", Offset = "0x98A2E30", VA = "0x1898A4230", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x98A4110", Offset = "0x98A2D10", VA = "0x1898A4110")]
	[AsyncStateMachine(typeof(<GenerateImposter>d__12))]
	private Task<GameObject> ONAACUBJIUE(QueuedLoad a, CancellationToken b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x98A3F50", Offset = "0x98A2B50", VA = "0x1898A3F50")]
	public Task<GameObject> LoadItemAsync(GKOMGOBKOKC imposterRequest, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x98A42F0", Offset = "0x98A2EF0", VA = "0x1898A42F0")]
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
		public GKOMGOBKOKC LYNSWLDJQOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DPNAWKZJIJZ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1560", VA = "0x180CF2960")]
		public Value(GKOMGOBKOKC imposterRequestObject, Texture texture)
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
	private class LHNVAZBADQJ : VCFQZWYQCQE<Texture2D>
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
			public LHNVAZBADQJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x98A6130", Offset = "0x98A4D30", VA = "0x1898A6130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x98A6910", Offset = "0x98A5510", VA = "0x1898A6910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GKOMGOBKOKC JEJPALQENEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LGVQZEEFGMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig QEICOYXRSDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken XKCAMCSUPQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D KWEZACJBSMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject YLAPAUMTQGP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override IMNXFPWKHPJ<Texture2D> SVJAFKKNIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x98A59C0", Offset = "0x98A45C0", VA = "0x1898A59C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> YSZJRGVILQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98A5A10", Offset = "0x98A4610", VA = "0x1898A5A10")]
		public LHNVAZBADQJ(GKOMGOBKOKC a, RenderTexture b, ImposterRenderConfig c, CancellationToken d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98A58D0", Offset = "0x98A44D0", VA = "0x1898A58D0")]
		[AsyncStateMachine(typeof(<Load>d__12))]
		private Task<Texture2D> Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98A5820", Offset = "0x98A4420", VA = "0x1898A5820", Slot = "10")]
		protected override void DDSBUNYLOXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98A5850", Offset = "0x98A4450", VA = "0x1898A5850")]
		private static void HBOACXSAZZR(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x98A6B40", Offset = "0x98A5740", VA = "0x1898A6B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
	private static int HIZNSXIQPGT;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MABSQVXMPXS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LBYDYJHNDER<GameObject> MFEPYGCUXYE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private ZSWOFHRQHTQ ICJWYSJUQYZ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource YOMUJIVFYSJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DVNZWAEHOWC<Texture2D> OLTRRZHNMTD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GKOMGOBKOKC XPIBBQJNYBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture XYIIECFUVLJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EPULNPWLRMQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98A52B0", Offset = "0x98A3EB0", VA = "0x1898A52B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98A5300", Offset = "0x98A3F00", VA = "0x1898A5300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture RCDXHKDKJKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98A4BA0", Offset = "0x98A37A0", VA = "0x1898A4BA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GKOMGOBKOKC LYNSWLDJQOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCEE720", Offset = "0xCED320", VA = "0x180CEE720")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98A4FE0", Offset = "0x98A3BE0", VA = "0x1898A4FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool RNROMGOEWSC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x23C3FC0", Offset = "0x23C2BC0", VA = "0x1823C3FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int XROWWISOZLY
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98A48B0", Offset = "0x98A34B0", VA = "0x1898A48B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x98A4890", Offset = "0x98A3490", VA = "0x1898A4890")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x98A4AB0", Offset = "0x98A36B0", VA = "0x1898A4AB0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x98A4A30", Offset = "0x98A3630", VA = "0x1898A4A30")]
	private void ODBUAJOLBUD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x98A4F80", Offset = "0x98A3B80", VA = "0x1898A4F80")]
	public void Set(GKOMGOBKOKC newImposterRequestObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x98A4F90", Offset = "0x98A3B90", VA = "0x1898A4F90")]
	public void Set(Texture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x98A4FA0", Offset = "0x98A3BA0", VA = "0x1898A4FA0")]
	public void Set(Value value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x98A48A0", Offset = "0x98A34A0", VA = "0x1898A48A0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x98A4D90", Offset = "0x98A3990", VA = "0x1898A4D90")]
	public void SetInternal(GKOMGOBKOKC newImposterRequestObject, [Optional] Texture newOverrideTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x98A4D80", Offset = "0x98A3980", VA = "0x1898A4D80")]
	public void SetCustomSize(int customSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xDE9880", Offset = "0xDE8480", VA = "0x180DE9880")]
	public void SetAntiAliasing(int antiAliasing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x98A5130", Offset = "0x98A3D30", VA = "0x1898A5130")]
	[AsyncStateMachine(typeof(<UpdateImposterImage>d__40))]
	private void YAVVJUTJZQT()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x98A4950", Offset = "0x98A3550", VA = "0x1898A4950")]
	private void KRMWAECNZTQ(Texture a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x98A5230", Offset = "0x98A3E30", VA = "0x1898A5230")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LVXWIUDAJEB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float IHZMVMIWIBX = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x98A4850", Offset = "0x98A3450", VA = "0x1898A4850")]
	public void SetReferencePoint(Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x98A4660", Offset = "0x98A3260", VA = "0x1898A4660")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x98A4830", Offset = "0x98A3430", VA = "0x1898A4830")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x235F980", Offset = "0x235E580", VA = "0x18235F980")]
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
	[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A88C0", Offset = "0x98A74C0", VA = "0x1898A88C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
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
		private const int GXJQABFASML = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int VJHVAMTCGCV = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> EFRJFIGKRHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool AWSEWGIFXCV;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98A5560", Offset = "0x98A4160", VA = "0x1898A5560")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98A5460", Offset = "0x98A4060", VA = "0x1898A5460")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98A57A0", Offset = "0x98A43A0", VA = "0x1898A57A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Systems.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GKOMGOBKOKC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string WZHJKSIKGLV
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ImposterRenderSettings EEGAQGZAZHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action EALMXYVGJGC;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GameObject> SOOZSWMOHLA(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool BVIACZNRYPP(GKOMGOBKOKC a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IFJYLDRWRLR();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BKVDCCYEGBS();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IERKIFCWGZI(uint? a, [Out] DVNZWAEHOWC<Texture2D> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class VDSFCBDZMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98A7370", Offset = "0x98A5F70", VA = "0x1898A7370")]
		public static bool Match(GKOMGOBKOKC requestA, GKOMGOBKOKC requestB)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, LVXWIUDAJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x98A3210", Offset = "0x98A1E10", VA = "0x1898A3210", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A4330", Offset = "0x98A2F30", VA = "0x1898A4330")]
		public EquipmentImposterUIRotation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public HideInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface LVXWIUDAJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PrepareImposter(ImposterParameters parameters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface DEJKQYIRELT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<Type> XTQJQUMPVZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IEnumerable<Type> GGCNEJCLDNS
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HUGRMVAOERL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PDLOZCIVPJK(params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a RRZLOEQMVBG<a>(a a, Transform b, bool c = false) where a : Component;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b RRZLOEQMVBG<b>(GameObject a, Transform b, bool c = false) where b : Component;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject RRZLOEQMVBG(GameObject a, Transform b, ImposterParameters c, bool d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class XWYOHXHCWOY : IDisposable, HUGRMVAOERL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<Type> FZWNJMIQMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly HashSet<Type> GAEIWZDFNUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Transform ZRFPHZCMVFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<Component> VVIMZOJDZVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly List<IncreaseTransparentRenderQueueWhenInUI> HWKDCYKCZKM;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x98A7B50", Offset = "0x98A6750", VA = "0x1898A7B50")]
		[GEPWJNEAFDW.Root]
		public static void GEPWJNEAFDW(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98A8470", Offset = "0x98A7070", VA = "0x1898A8470")]
		[UnityEngine.Scripting.Preserve]
		public XWYOHXHCWOY([Inject(null)] DEJKQYIRELT componentTypeResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98A7A50", Offset = "0x98A6650", VA = "0x1898A7A50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98A8060", Offset = "0x98A6C60", VA = "0x1898A8060", Slot = "5")]
		public void PDLOZCIVPJK(params Type[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4129DC0", Offset = "0x41289C0", VA = "0x184129DC0", Slot = "6")]
		public a RRZLOEQMVBG<a>(a a, Transform b, bool c = false) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4129CB0", Offset = "0x41288B0", VA = "0x184129CB0", Slot = "7")]
		public b RRZLOEQMVBG<b>(GameObject a, Transform b, bool c = false) where b : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98A80B0", Offset = "0x98A6CB0", VA = "0x1898A80B0", Slot = "8")]
		public GameObject RRZLOEQMVBG(GameObject a, Transform b, ImposterParameters c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4129D30", Offset = "0x4128930", VA = "0x184129D30", Slot = "9")]
		public c RRZLOEQMVBG<c>(GameObject a, Transform b, ImposterParameters c, bool d) where c : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x41296D0", Offset = "0x41282D0", VA = "0x1841296D0")]
		private e RRZLOEQMVBG<e>(GameObject a, Transform b, ImposterParameters c, bool d, [Out] GameObject e) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x41293E0", Offset = "0x4127FE0", VA = "0x1841293E0")]
		private f HUPGHEJKHUY<f>(GameObject a, ImposterParameters b, bool c) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98A8250", Offset = "0x98A6E50", VA = "0x1898A8250")]
		private void UBZSQYWZUPW(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98A7830", Offset = "0x98A6430", VA = "0x1898A7830")]
		private void BHCBBRAWGZQ(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x98A8140", Offset = "0x98A6D40", VA = "0x1898A8140")]
		private void SHOGKVUDRLZ(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98A75C0", Offset = "0x98A61C0", VA = "0x1898A75C0")]
		private void BHCBBRAWGZQ(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98A7C40", Offset = "0x98A6840", VA = "0x1898A7C40")]
		private void HIDMLSAQOKT(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98A7450", Offset = "0x98A6050", VA = "0x1898A7450")]
		private void AAFDRLZGUAE(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x3B99980", Offset = "0x3B98580", VA = "0x183B99980")]
		public ImposterParameters Set<T>(T param)
		{
			return default(ImposterParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3B98EA0", Offset = "0x3B97AA0", VA = "0x183B98EA0")]
		public T Get<T>(T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3B99100", Offset = "0x3B97D00", VA = "0x183B99100")]
		public bool PXXJOAVVPYH<a>([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x98A4610", Offset = "0x98A3210", VA = "0x1898A4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x2720D50", Offset = "0x271F950", VA = "0x182720D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x98A5CF0", Offset = "0x98A48F0", VA = "0x1898A5CF0")]
		public ShouldIgnoreImposterCustomTransforms(bool shouldIgnore)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ScaleInImposter : MonoBehaviour, LVXWIUDAJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x98A5C70", Offset = "0x98A4870", VA = "0x1898A5C70", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
		public Bounds KZRHQMWENAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x98A44E0", Offset = "0x98A30E0", VA = "0x1898A44E0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x98A43D0", Offset = "0x98A2FD0", VA = "0x1898A43D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x98A4390", Offset = "0x98A2F90", VA = "0x1898A4390")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x98A4410", Offset = "0x98A3010", VA = "0x1898A4410")]
		private void UKKWSUDEKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
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
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006F")]
				[Cpp2IlInjected.Address(RVA = "0x98A5BE0", Offset = "0x98A47E0", VA = "0x1898A5BE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x98A5BD0", Offset = "0x98A47D0", VA = "0x1898A5BD0")]
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
		public bool useAvatarExportFraming;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ConditionalField("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[ConditionalField("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x98A5380", Offset = "0x98A3F80", VA = "0x1898A5380")]
		public void SetExplicitCameraComposition(Vector3 positionOffset, Quaternion rotationOffset, float orthographicSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x98A53B0", Offset = "0x98A3FB0", VA = "0x1898A53B0")]
		public ImposterRenderConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class AYIDXDSHAZP
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly Vector3 WSZLOYPDJCM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly List<URPLight> YQXDTFZZWCW;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<Light> WRUNYCOWEKB;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static Camera TJKSXAISBHG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly List<Renderer> SSUFVXZQLDA;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly List<ImposterBoundsOverride> VMHLQZIMMVJ;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static AmbientMode ZAJZQQEFTWN;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static Color TKCESRRTERI;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Color ZEYCYXTZYZG;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static Color XQQWQNZCCNA;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private static Cubemap HXUZMHYGMBR;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private static bool JPYGXAMVCBI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static List<URPLight> XYZOGUFQTKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x98A2500", Offset = "0x98A1100", VA = "0x1898A2500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static List<Light> DKLAIYLIMIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98A0990", Offset = "0x989F590", VA = "0x1898A0990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Camera STJOYQLNAXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98A1C40", Offset = "0x98A0840", VA = "0x1898A1C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x98A2260", Offset = "0x98A0E60", VA = "0x1898A2260")]
		public static void SAQBSCBZJAF(Vector3 a, Quaternion b, ImposterRenderConfig c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x98A1460", Offset = "0x98A0060", VA = "0x1898A1460")]
		private static void IEUWCXCDXRD(Vector3 a, Quaternion b, URPLight c, ImposterRenderConfig.LightConfig d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x98A1380", Offset = "0x989FF80", VA = "0x1898A1380")]
		public static void HDLXZGKJOZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x98A1780", Offset = "0x98A0380", VA = "0x1898A1780")]
		private static void KISVMMKBQWA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98A07C0", Offset = "0x989F3C0", VA = "0x1898A07C0")]
		public static void AQVBIAMDSGO(ImposterRenderConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98A1E90", Offset = "0x98A0A90", VA = "0x1898A1E90")]
		public static void KVQHVCBTUDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98A1040", Offset = "0x989FC40", VA = "0x1898A1040")]
		public static void DHRAYBMZBXR(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, [Optional] Vector3? e, [Optional] Vector3? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98A09E0", Offset = "0x989F5E0", VA = "0x1898A09E0")]
		private static void CAHHGNEODTO(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, Vector3 e, Vector3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x98A1F80", Offset = "0x98A0B80", VA = "0x1898A1F80")]
		private static void RPDAAZRTSUZ(GameObject a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x98A2D20", Offset = "0x98A1920", VA = "0x1898A2D20")]
		public static void ZIUFBBVVOOO(Bounds a, ImposterRenderConfig b, [Out] Vector3 c, [Out] Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x98A2550", Offset = "0x98A1150", VA = "0x1898A2550")]
		private static void TBMLGDDDHKZ(GameObject a, ImposterRenderConfig b, ImposterRenderSettings c, [Out] Vector3 d, [Out] Quaternion e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98A2C50", Offset = "0x98A1850", VA = "0x1898A2C50")]
		public static RenderTexture UZMPGTJNMAD(int a, int b, RenderTextureFormat c = RenderTextureFormat.ARGB32, string d = "[ImposterRendering]Preview")
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
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public YNVUIOBZBUF Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public GameObject TargetGameObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public RenderTexture RenderTexture;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public ImposterRenderConfig ImposterRenderConfig;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public ImposterRenderSettings ImposterRenderSettings;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x98A5C00", Offset = "0x98A4800", VA = "0x1898A5C00")]
			public QueuedImposterRender(YNVUIOBZBUF promise, GameObject targetGameObject, RenderTexture renderTexture, ImposterRenderConfig imposterRenderConfig, ImposterRenderSettings imposterRenderSettings)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private static UOYACGEXCPT<QueuedImposterRender, RenderTexture> MZCVPLICNCW;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly List<QueuedImposterRender> WBBBJFIWAUW;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int NVIZXMDYDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x98A3AC0", Offset = "0x98A26C0", VA = "0x1898A3AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x98A35C0", Offset = "0x98A21C0", VA = "0x1898A35C0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject targetGameobject, RenderTexture renderTexture, ImposterRenderConfig imposterConfig, ImposterRenderSettings imposterRenderSettings, CancellationToken cancellationToken, bool disableWhileQueued = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98A3320", Offset = "0x98A1F20", VA = "0x1898A3320", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x98A3520", Offset = "0x98A2120", VA = "0x1898A3520", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x98A3820", Offset = "0x98A2420", VA = "0x1898A3820")]
		private static Task<RenderTexture> RZJJZOZUMGM(QueuedImposterRender a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x98A3CE0", Offset = "0x98A28E0", VA = "0x1898A3CE0")]
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
