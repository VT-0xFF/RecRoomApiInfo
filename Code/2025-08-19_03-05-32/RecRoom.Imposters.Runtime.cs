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
		public readonly RQQQIGIPNON ImposterRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FriendlyName;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC88220", Offset = "0xC87020", VA = "0x180C88220")]
		public QueuedLoad(RQQQIGIPNON imposterRequest, string friendlyName)
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
		[Cpp2IlInjected.Address(RVA = "0x85D87E0", Offset = "0x85D75E0", VA = "0x1885D87E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85D8BA0", Offset = "0x85D79A0", VA = "0x1885D8BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider YHMZLKZGYPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IKFXAMNBEVI<QueuedLoad, GameObject> QAKDPISFIVP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HCESWOVJNEK NBXATOSNEUA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IKFXAMNBEVI<QueuedLoad, GameObject> YBOAXJLWETE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85D3150", Offset = "0x85D1F50", VA = "0x1885D3150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CYJYBYIVNVM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85D3100", Offset = "0x85D1F00", VA = "0x1885D3100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85D2CC0", Offset = "0x85D1AC0", VA = "0x1885D2CC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x85D3090", Offset = "0x85D1E90", VA = "0x1885D3090", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85D2DA0", Offset = "0x85D1BA0", VA = "0x1885D2DA0")]
	[AsyncStateMachine(typeof(<GenerateImposter>d__12))]
	private Task<GameObject> JUKGXEBCQQT(QueuedLoad a, CancellationToken b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85D2EC0", Offset = "0x85D1CC0", VA = "0x1885D2EC0")]
	public Task<GameObject> LoadItemAsync(RQQQIGIPNON imposterRequest, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85D32A0", Offset = "0x85D20A0", VA = "0x1885D32A0")]
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
		public RQQQIGIPNON PKPSWRZOKVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture IUKMQYNKCQO;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xABFA30", Offset = "0xABE830", VA = "0x180ABFA30")]
		public Value(RQQQIGIPNON imposterRequestObject, Texture texture)
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
	private class PDWVNFRMGGM : BLIGOBMKYBR<Texture2D>
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
			public PDWVNFRMGGM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85D8C10", Offset = "0x85D7A10", VA = "0x1885D8C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85D9400", Offset = "0x85D8200", VA = "0x1885D9400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly RQQQIGIPNON OXGVZLQDBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture NJNIOADFMTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig VKXQUEBERFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken QSOIRXWDLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D URQULZVXJRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject FEVVWBVQQGA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override YLZUVDOLRNC<Texture2D> WNZKCPHFDRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85D84D0", Offset = "0x85D72D0", VA = "0x1885D84D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> BXEMHWGQXGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85D8520", Offset = "0x85D7320", VA = "0x1885D8520")]
		public PDWVNFRMGGM(RQQQIGIPNON a, RenderTexture b, ImposterRenderConfig c, CancellationToken d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85D83E0", Offset = "0x85D71E0", VA = "0x1885D83E0")]
		[AsyncStateMachine(typeof(<Load>d__12))]
		private Task<Texture2D> Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85D8330", Offset = "0x85D7130", VA = "0x1885D8330", Slot = "10")]
		protected override void BNXMXBZBTNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85D8360", Offset = "0x85D7160", VA = "0x1885D8360")]
		private static void EGKVXRYTFBE(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x85D9630", Offset = "0x85D8430", VA = "0x1885D9630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB1D920", Offset = "0xB1C720", VA = "0x180B1D920", Slot = "5")]
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
	private static int TIXVDWNVGEU;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture VFHYDFWJIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private XMDLDBBQBIK<GameObject> BVESJBBUQDX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private SGMUANPBQKN WMYKVQZQTVK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource RALLNVAJZKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NMFGCGLVGPZ<Texture2D> FKZNMYOIMHS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private RQQQIGIPNON PPITHDGDEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture JWGVCLITJLM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int VRRRLMOTIWZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85D4200", Offset = "0x85D3000", VA = "0x1885D4200")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85D4250", Offset = "0x85D3050", VA = "0x1885D4250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PUYVMYESEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85D3950", Offset = "0x85D2750", VA = "0x1885D3950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private RQQQIGIPNON PKPSWRZOKVA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85D3800", Offset = "0x85D2600", VA = "0x1885D3800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool SMGUZSGLRKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x250DBB0", Offset = "0x250C9B0", VA = "0x18250DBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MFFQDJVXXHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85D3BB0", Offset = "0x85D29B0", VA = "0x1885D3BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85D37E0", Offset = "0x85D25E0", VA = "0x1885D37E0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85D3C40", Offset = "0x85D2A40", VA = "0x1885D3C40")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85D3B30", Offset = "0x85D2930", VA = "0x1885D3B30")]
	private void KLETYPRPOYI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85D3FF0", Offset = "0x85D2DF0", VA = "0x1885D3FF0")]
	public void Set(RQQQIGIPNON newImposterRequestObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85D4000", Offset = "0x85D2E00", VA = "0x1885D4000")]
	public void Set(Texture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85D4010", Offset = "0x85D2E10", VA = "0x1885D4010")]
	public void Set(Value value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85D37F0", Offset = "0x85D25F0", VA = "0x1885D37F0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85D3DF0", Offset = "0x85D2BF0", VA = "0x1885D3DF0")]
	public void SetInternal(RQQQIGIPNON newImposterRequestObject, [Optional] Texture newOverrideTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85D3DE0", Offset = "0x85D2BE0", VA = "0x1885D3DE0")]
	public void SetCustomSize(int customSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xE1B620", Offset = "0xE1A420", VA = "0x180E1B620")]
	public void SetAntiAliasing(int antiAliasing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x85D3D30", Offset = "0x85D2B30", VA = "0x1885D3D30")]
	[AsyncStateMachine(typeof(<UpdateImposterImage>d__40))]
	private void QZKTMZVUFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85D4050", Offset = "0x85D2E50", VA = "0x1885D4050")]
	private void XZXMFRJSDBT(Texture a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85D4180", Offset = "0x85D2F80", VA = "0x1885D4180")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, VSANGKUKHUI
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float LWNHZRGCRQQ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85D37A0", Offset = "0x85D25A0", VA = "0x1885D37A0")]
	public void SetReferencePoint(Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85D35B0", Offset = "0x85D23B0", VA = "0x1885D35B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85D3780", Offset = "0x85D2580", VA = "0x1885D3780")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22CA300", Offset = "0x22C9100", VA = "0x1822CA300")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D9F50", Offset = "0x85D8D50", VA = "0x1885D9F50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
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
		private const int DOFFWSPACVE = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int TOMJJLUFAJO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> YWRGNRVAEYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool HFRSKXSQBFU;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85D44A0", Offset = "0x85D32A0", VA = "0x1885D44A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85D43A0", Offset = "0x85D31A0", VA = "0x1885D43A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85D46E0", Offset = "0x85D34E0", VA = "0x1885D46E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Systems.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface RQQQIGIPNON
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string GKYNQALFUTK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ImposterRenderSettings ZOOREEKTRHP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action BYNCKXNBOBN;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GameObject> EGAYSJMUISJ(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AAEKKNGNHOE(RQQQIGIPNON a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DNLRGRXUOOE();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QNADTZQXNFN();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OWDTSSJHPRD(uint? a, [Out] NMFGCGLVGPZ<Texture2D> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YWZJZRZPPUM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85D9E60", Offset = "0x85D8C60", VA = "0x1885D9E60")]
		public static bool Match(RQQQIGIPNON requestA, RQQQIGIPNON requestB)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, VSANGKUKHUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85D21D0", Offset = "0x85D0FD0", VA = "0x1885D21D0", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public HideInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface VSANGKUKHUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PrepareImposter(ImposterParameters parameters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SVPGLJSWMDY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<Type> YNIKDETJVLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IEnumerable<Type> FSXPUJXXZJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HCESWOVJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BILXSIYADCR(params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a FGNSFTRPOKV<a>(a a, Transform b, bool c = false) where a : Component;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b FGNSFTRPOKV<b>(GameObject a, Transform b, bool c = false) where b : Component;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject FGNSFTRPOKV(GameObject a, Transform b, ImposterParameters c, bool d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class NCQXAGRLNHX : IDisposable, HCESWOVJNEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly HashSet<Type> YSVBUSGRDGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<Type> NZHBFISDRXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform OBMSBCJDYLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Component> LFTODIEMJTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<IncreaseTransparentRenderQueueWhenInUI> AJOTLMAMHDN;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85D72C0", Offset = "0x85D60C0", VA = "0x1885D72C0")]
		[FDNTPBIGLET.Root]
		public static void FDNTPBIGLET(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85D7F10", Offset = "0x85D6D10", VA = "0x1885D7F10")]
		[UnityEngine.Scripting.Preserve]
		public NCQXAGRLNHX([Inject(null)] SVPGLJSWMDY componentTypeResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85D71C0", Offset = "0x85D5FC0", VA = "0x1885D71C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85D6EF0", Offset = "0x85D5CF0", VA = "0x1885D6EF0", Slot = "5")]
		public void BILXSIYADCR(params Type[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE810", Offset = "0x3ACD610", VA = "0x183ACE810", Slot = "6")]
		public a FGNSFTRPOKV<a>(a a, Transform b, bool c = false) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE8A0", Offset = "0x3ACD6A0", VA = "0x183ACE8A0", Slot = "7")]
		public b FGNSFTRPOKV<b>(GameObject a, Transform b, bool c = false) where b : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85D73B0", Offset = "0x85D61B0", VA = "0x1885D73B0", Slot = "8")]
		public GameObject FGNSFTRPOKV(GameObject a, Transform b, ImposterParameters c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3ACEEF0", Offset = "0x3ACDCF0", VA = "0x183ACEEF0", Slot = "9")]
		public c FGNSFTRPOKV<c>(GameObject a, Transform b, ImposterParameters c, bool d) where c : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3ACE920", Offset = "0x3ACD720", VA = "0x183ACE920")]
		private e FGNSFTRPOKV<e>(GameObject a, Transform b, ImposterParameters c, bool d, [Out] GameObject e) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3ACEF80", Offset = "0x3ACDD80", VA = "0x183ACEF80")]
		private f VNPNAUZVSJL<f>(GameObject a, ImposterParameters b, bool c) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85D7860", Offset = "0x85D6660", VA = "0x1885D7860")]
		private void JXGGOTPZTVX(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85D7CF0", Offset = "0x85D6AF0", VA = "0x1885D7CF0")]
		private void ZYNVLUEJSRL(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85D70B0", Offset = "0x85D5EB0", VA = "0x1885D70B0")]
		private void CTZVLUIKVIY(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85D7A80", Offset = "0x85D6880", VA = "0x1885D7A80")]
		private void ZYNVLUEJSRL(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x85D7440", Offset = "0x85D6240", VA = "0x1885D7440")]
		private void JKXCFAKRUHO(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85D6F40", Offset = "0x85D5D40", VA = "0x1885D6F40")]
		private void BWLCOWLQLJV(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x3998C70", Offset = "0x3997A70", VA = "0x183998C70")]
		public ImposterParameters Set<T>(T param)
		{
			return default(ImposterParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3998A10", Offset = "0x3997810", VA = "0x183998A10")]
		public T Get<T>(T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3999340", Offset = "0x3998140", VA = "0x183999340")]
		public bool UYCPXVCHFQY<a>([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85D3560", Offset = "0x85D2360", VA = "0x1885D3560")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D38590", Offset = "0x2D37390", VA = "0x182D38590")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D87D0", Offset = "0x85D75D0", VA = "0x1885D87D0")]
		public ShouldIgnoreImposterCustomTransforms(bool shouldIgnore)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, VSANGKUKHUI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85D8750", Offset = "0x85D7550", VA = "0x1885D8750", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
		public Bounds ISXMBMUUVVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85D3430", Offset = "0x85D2230", VA = "0x1885D3430")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85D33F0", Offset = "0x85D21F0", VA = "0x1885D33F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85D33B0", Offset = "0x85D21B0", VA = "0x1885D33B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85D32E0", Offset = "0x85D20E0", VA = "0x1885D32E0")]
		private void HCLHSGHNOLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x85D6ED0", Offset = "0x85D5CD0", VA = "0x1885D6ED0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85D6EC0", Offset = "0x85D5CC0", VA = "0x1885D6EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D42C0", Offset = "0x85D30C0", VA = "0x1885D42C0")]
		public void SetExplicitCameraComposition(Vector3 positionOffset, Quaternion rotationOffset, float orthographicSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x85D42F0", Offset = "0x85D30F0", VA = "0x1885D42F0")]
		public ImposterRenderConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class KNXHEXPLEWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly Vector3 XNXWXICTDWT;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly List<URPLight> OAZSWPWRUQB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly List<Light> IHTHVHIXYYQ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static Camera UJSVANYQDSL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<Renderer> PDHKBRLHZMX;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly List<ImposterBoundsOverride> HJZHYORWTAA;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static AmbientMode PUNCJGMACJM;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static Color CEXKCKMHHAX;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Color WBXRPYNHALJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static Color GLMPBTETYRZ;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Cubemap CQZZKVRTWAS;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static bool ECBVXZFCYEB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static List<URPLight> UUUZYJWNRIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x85D4760", Offset = "0x85D3560", VA = "0x1885D4760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static List<Light> MFJQKBRKOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x85D5940", Offset = "0x85D4740", VA = "0x1885D5940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Camera TATAJARYORI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85D6280", Offset = "0x85D5080", VA = "0x1885D6280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85D5300", Offset = "0x85D4100", VA = "0x1885D5300")]
		public static void JRWOZKQVJFM(Vector3 a, Quaternion b, ImposterRenderConfig c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85D4F00", Offset = "0x85D3D00", VA = "0x1885D4F00")]
		private static void FUSVQXYHXXM(Vector3 a, Quaternion b, URPLight c, ImposterRenderConfig.LightConfig d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85D5220", Offset = "0x85D4020", VA = "0x1885D5220")]
		public static void IVWBAWTHDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85D4960", Offset = "0x85D3760", VA = "0x1885D4960")]
		private static void BFHJDCMAVRL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85D47B0", Offset = "0x85D35B0", VA = "0x1885D47B0")]
		public static void ASUSIYDIJWV(ImposterRenderConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85D4E20", Offset = "0x85D3C20", VA = "0x1885D4E20")]
		public static void FMFPHIADNYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85D69A0", Offset = "0x85D57A0", VA = "0x1885D69A0")]
		public static void ZUFCROLNZHI(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, [Optional] Vector3? e, [Optional] Vector3? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85D5C50", Offset = "0x85D4A50", VA = "0x1885D5C50")]
		private static void NRFRGUYFHPZ(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, Vector3 e, Vector3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85D5990", Offset = "0x85D4790", VA = "0x1885D5990")]
		private static void NPSVGFUEOZW(GameObject a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x85D5660", Offset = "0x85D4460", VA = "0x1885D5660")]
		public static void MZGPFQZLEGP(Bounds a, ImposterRenderConfig b, [Out] Vector3 c, [Out] Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85D64B0", Offset = "0x85D52B0", VA = "0x1885D64B0")]
		private static void YGHBUXLOBBG(GameObject a, ImposterRenderConfig b, ImposterRenderSettings c, [Out] Vector3 d, [Out] Quaternion e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85D5590", Offset = "0x85D4390", VA = "0x1885D5590")]
		public static RenderTexture LOYGWOSFAHC(int a, int b, RenderTextureFormat c = RenderTextureFormat.ARGB32, string d = "[ImposterRendering]Preview")
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
			public YPTUROBCDWM Promise;

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
			[Cpp2IlInjected.Address(RVA = "0x85D86E0", Offset = "0x85D74E0", VA = "0x1885D86E0")]
			public QueuedImposterRender(YPTUROBCDWM promise, GameObject targetGameObject, RenderTexture renderTexture, ImposterRenderConfig imposterRenderConfig, ImposterRenderSettings imposterRenderSettings)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static IKFXAMNBEVI<QueuedImposterRender, RenderTexture> AUPJHZDCWKX;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<QueuedImposterRender> YHMENAOOVJV;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int ZCJNCTBIQQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x85D2A70", Offset = "0x85D1870", VA = "0x1885D2A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85D2810", Offset = "0x85D1610", VA = "0x1885D2810")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject targetGameobject, RenderTexture renderTexture, ImposterRenderConfig imposterConfig, ImposterRenderSettings imposterRenderSettings, CancellationToken cancellationToken, bool disableWhileQueued = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85D22E0", Offset = "0x85D10E0", VA = "0x1885D22E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85D2780", Offset = "0x85D1580", VA = "0x1885D2780", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85D24E0", Offset = "0x85D12E0", VA = "0x1885D24E0")]
		private static Task<RenderTexture> HHZIKPYSPUF(QueuedImposterRender a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85D2C80", Offset = "0x85D1A80", VA = "0x1885D2C80")]
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
