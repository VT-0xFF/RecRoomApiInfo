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
		public readonly RHWTXRHBZXU ImposterRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FriendlyName;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
		public QueuedLoad(RHWTXRHBZXU imposterRequest, string friendlyName)
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
		[Cpp2IlInjected.Address(RVA = "0x8552420", Offset = "0x8550A20", VA = "0x188552420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85527E0", Offset = "0x8550DE0", VA = "0x1885527E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider AHRQODZOSRY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IYWOPWKMZEF<QueuedLoad, GameObject> KYXQHDYWOYI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GINMIBLDBTD QINGMCKYJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IYWOPWKMZEF<QueuedLoad, GameObject> AINJTVIGRZL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8550940", Offset = "0x854EF40", VA = "0x188550940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FOUOVWSKNIZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85508F0", Offset = "0x854EEF0", VA = "0x1885508F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85504C0", Offset = "0x854EAC0", VA = "0x1885504C0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8550880", Offset = "0x854EE80", VA = "0x188550880", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85505A0", Offset = "0x854EBA0", VA = "0x1885505A0")]
	[AsyncStateMachine(typeof(<GenerateImposter>d__12))]
	private Task<GameObject> IBWLUAEAVAY(QueuedLoad a, CancellationToken b)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85506C0", Offset = "0x854ECC0", VA = "0x1885506C0")]
	public Task<GameObject> LoadItemAsync(RHWTXRHBZXU imposterRequest, CancellationToken cancellationToken)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8550A90", Offset = "0x854F090", VA = "0x188550A90")]
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
		public RHWTXRHBZXU NNQHNPNDEPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GSRNUFNSHIX;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public Value(RHWTXRHBZXU imposterRequestObject, Texture texture)
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
	private class RMXIERJRHUB : CDPKZCVFWHO<Texture2D>
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
			public RMXIERJRHUB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8552850", Offset = "0x8550E50", VA = "0x188552850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8553030", Offset = "0x8551630", VA = "0x188553030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly RHWTXRHBZXU SLERCIFHRVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture HSOTZRWQSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IORXAWEKLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken YBWQEIOLJEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D LXCFMLQAZYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject PGIFSWMGRWL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NDLOPTUCVYP<Texture2D> DIYAHISPKKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8552010", Offset = "0x8550610", VA = "0x188552010", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> ICUGQWPTWJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85521D0", Offset = "0x85507D0", VA = "0x1885521D0")]
		public RMXIERJRHUB(RHWTXRHBZXU a, RenderTexture b, ImposterRenderConfig c, CancellationToken d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8552060", Offset = "0x8550660", VA = "0x188552060")]
		[AsyncStateMachine(typeof(<Load>d__12))]
		private Task<Texture2D> Load()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8551FE0", Offset = "0x85505E0", VA = "0x188551FE0", Slot = "10")]
		protected override void AJNZZLQWPYW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8552150", Offset = "0x8550750", VA = "0x188552150")]
		private static void PMGPLSBEQJN(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x8553260", Offset = "0x8551860", VA = "0x188553260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
	private static int ESGFZHXPXPZ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture TQOHQTJZTIY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PFWELOUCXRP<GameObject> KKPFWPVRNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FOIFKSVRRKC LKVABDMYDWJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource ERMOUZTPHRP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private XJCVXUISJRI<Texture2D> EKDPZIGTLPX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private RHWTXRHBZXU SELCXTPSOQQ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EMTFQSEMUYT;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AZJLIIPXLMQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85519E0", Offset = "0x854FFE0", VA = "0x1885519E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8551A30", Offset = "0x8550030", VA = "0x188551A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PELLLXENTPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8551150", Offset = "0x854F750", VA = "0x188551150")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private RHWTXRHBZXU NNQHNPNDEPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8551730", Offset = "0x854FD30", VA = "0x188551730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CWLDUGZTFBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x25A0170", Offset = "0x259E770", VA = "0x1825A0170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int IWJSHYUEJPY
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8551880", Offset = "0x854FE80", VA = "0x188551880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8550FD0", Offset = "0x854F5D0", VA = "0x188550FD0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x85513E0", Offset = "0x854F9E0", VA = "0x1885513E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85510D0", Offset = "0x854F6D0", VA = "0x1885510D0")]
	private void IVXYYGPTXED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85516D0", Offset = "0x854FCD0", VA = "0x1885516D0")]
	public void Set(RHWTXRHBZXU newImposterRequestObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x85516E0", Offset = "0x854FCE0", VA = "0x1885516E0")]
	public void Set(Texture texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x85516F0", Offset = "0x854FCF0", VA = "0x1885516F0")]
	public void Set(Value value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8550FE0", Offset = "0x854F5E0", VA = "0x188550FE0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85514E0", Offset = "0x854FAE0", VA = "0x1885514E0")]
	public void SetInternal(RHWTXRHBZXU newImposterRequestObject, [Optional] Texture newOverrideTexture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85514D0", Offset = "0x854FAD0", VA = "0x1885514D0")]
	public void SetCustomSize(int customSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xE799B0", Offset = "0xE77FB0", VA = "0x180E799B0")]
	public void SetAntiAliasing(int antiAliasing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8551330", Offset = "0x854F930", VA = "0x188551330")]
	[AsyncStateMachine(typeof(<UpdateImposterImage>d__40))]
	private void MVZVTKHKXNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8550FF0", Offset = "0x854F5F0", VA = "0x188550FF0")]
	private void ILIPRVIQDDY(Texture a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8551960", Offset = "0x854FF60", VA = "0x188551960")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HLRZFVSUYQF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float QPKYRVYFEMJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8550F90", Offset = "0x854F590", VA = "0x188550F90")]
	public void SetReferencePoint(Vector3 localPosition, Quaternion localRotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8550DA0", Offset = "0x854F3A0", VA = "0x188550DA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8550F70", Offset = "0x854F570", VA = "0x188550F70")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22FC6B0", Offset = "0x22FACB0", VA = "0x1822FC6B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8553B70", Offset = "0x8552170", VA = "0x188553B70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
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
		private const int XTZVSOSTSLF = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int CSGEHKZYDDP = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> BKYJDCDBOIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool TMYOVQUUPIJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8551C80", Offset = "0x8550280", VA = "0x188551C80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8551B80", Offset = "0x8550180", VA = "0x188551B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8551EC0", Offset = "0x85504C0", VA = "0x188551EC0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Systems.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface RHWTXRHBZXU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		string WVPPNVZRWJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		ImposterRenderSettings ORMGMYQNGRI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action CGQXMBCIQXU;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<GameObject> IVBAKXRQKPU(CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool EOPZZQTLZVX(RHWTXRHBZXU a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GCUVKUGGZFV();

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LRVTBGSTUCQ();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JLAYIMETGWW(uint? a, [Out] XJCVXUISJRI<Texture2D> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class URVYGAVSDDZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8553A90", Offset = "0x8552090", VA = "0x188553A90")]
		public static bool Match(RHWTXRHBZXU requestA, RHWTXRHBZXU requestB)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, HLRZFVSUYQF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x854F9D0", Offset = "0x854DFD0", VA = "0x18854F9D0", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public HideInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface HLRZFVSUYQF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PrepareImposter(ImposterParameters parameters);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface RQNFXXKFCJX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		IEnumerable<Type> PGLKYJBQDVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		IEnumerable<Type> DYCOIUXCGLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GINMIBLDBTD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TPSTGZTONLO(params Type[] types);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a PPMSNZLEMEE<a>(a a, Transform b, bool c = false) where a : Component;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b PPMSNZLEMEE<b>(GameObject a, Transform b, bool c = false) where b : Component;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GameObject PPMSNZLEMEE(GameObject a, Transform b, ImposterParameters c, bool d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class CDYHARRYPGM : IDisposable, GINMIBLDBTD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly HashSet<Type> LPDCXLMHQEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly HashSet<Type> AUHWEQVAASJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform DUXBBLBTLYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Component> VONGEQTZDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<IncreaseTransparentRenderQueueWhenInUI> LTHXFXOWYWA;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x854F4C0", Offset = "0x854DAC0", VA = "0x18854F4C0")]
		[ZOKCDQOPSGU.Root]
		public static void ZOKCDQOPSGU(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x854F5B0", Offset = "0x854DBB0", VA = "0x18854F5B0")]
		[UnityEngine.Scripting.Preserve]
		public CDYHARRYPGM([Inject(null)] RQNFXXKFCJX componentTypeResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x854E9B0", Offset = "0x854CFB0", VA = "0x18854E9B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x854F140", Offset = "0x854D740", VA = "0x18854F140", Slot = "5")]
		public void TPSTGZTONLO(params Type[] types)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36BF730", Offset = "0x36BDD30", VA = "0x1836BF730", Slot = "6")]
		public a PPMSNZLEMEE<a>(a a, Transform b, bool c = false) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x36BF7C0", Offset = "0x36BDDC0", VA = "0x1836BF7C0", Slot = "7")]
		public b PPMSNZLEMEE<b>(GameObject a, Transform b, bool c = false) where b : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x854EC20", Offset = "0x854D220", VA = "0x18854EC20", Slot = "8")]
		public GameObject PPMSNZLEMEE(GameObject a, Transform b, ImposterParameters c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x36BFE10", Offset = "0x36BE410", VA = "0x1836BFE10", Slot = "9")]
		public c PPMSNZLEMEE<c>(GameObject a, Transform b, ImposterParameters c, bool d) where c : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36BF840", Offset = "0x36BDE40", VA = "0x1836BF840")]
		private e PPMSNZLEMEE<e>(GameObject a, Transform b, ImposterParameters c, bool d, [Out] GameObject e) where e : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x36BF440", Offset = "0x36BDA40", VA = "0x1836BF440")]
		private f IRKHGRHUEZK<f>(GameObject a, ImposterParameters b, bool c) where f : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x854F2A0", Offset = "0x854D8A0", VA = "0x18854F2A0")]
		private void ZEXACBGCZSU(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x854EF20", Offset = "0x854D520", VA = "0x18854EF20")]
		private void RHSXKALZVPY(ImposterParameters a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x854F190", Offset = "0x854D790", VA = "0x18854F190")]
		private void VFUAHXEULJV(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x854ECB0", Offset = "0x854D2B0", VA = "0x18854ECB0")]
		private void RHSXKALZVPY(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x854E580", Offset = "0x854CB80", VA = "0x18854E580")]
		private void CRODQKESJFR(Component a, ImposterParameters b, bool c, bool d, [Optional] Type e, [Optional] Type f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x854EAB0", Offset = "0x854D0B0", VA = "0x18854EAB0")]
		private void IOHYHOZRFGU(GameObject a)
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
		[Cpp2IlInjected.Address(RVA = "0x395AC40", Offset = "0x3959240", VA = "0x18395AC40")]
		public ImposterParameters Set<T>(T param)
		{
			return default(ImposterParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x395A9E0", Offset = "0x3958FE0", VA = "0x18395A9E0")]
		public T Get<T>(T defaultValue)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x395B310", Offset = "0x3959910", VA = "0x18395B310")]
		public bool XTYYQLAKLBN<a>([Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8550D50", Offset = "0x854F350", VA = "0x188550D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D56040", Offset = "0x2D54640", VA = "0x182D56040")]
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
		[Cpp2IlInjected.Address(RVA = "0x8552410", Offset = "0x8550A10", VA = "0x188552410")]
		public ShouldIgnoreImposterCustomTransforms(bool shouldIgnore)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, HLRZFVSUYQF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8552390", Offset = "0x8550990", VA = "0x188552390", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		public Bounds HUBZSSPFXSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8550C20", Offset = "0x854F220", VA = "0x188550C20")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8550BE0", Offset = "0x854F1E0", VA = "0x188550BE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8550BA0", Offset = "0x854F1A0", VA = "0x188550BA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8550AD0", Offset = "0x854F0D0", VA = "0x188550AD0")]
		private void JWUJKNYDZSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
				[Cpp2IlInjected.Address(RVA = "0x8551F50", Offset = "0x8550550", VA = "0x188551F50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8551F40", Offset = "0x8550540", VA = "0x188551F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8551AA0", Offset = "0x85500A0", VA = "0x188551AA0")]
		public void SetExplicitCameraComposition(Vector3 positionOffset, Quaternion rotationOffset, float orthographicSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8551AD0", Offset = "0x85500D0", VA = "0x188551AD0")]
		public ImposterRenderConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class AXPLPBLIONP
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public static readonly Vector3 MJXKTGMVUBS;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly List<URPLight> GQJSTBTMYVQ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly List<Light> OHUMJXIQVZP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static Camera NWQSNMKWSWU;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<Renderer> JCDRTOKUSBQ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly List<ImposterBoundsOverride> NEIEWJDCDVV;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static AmbientMode ALNRKWMVCYV;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static Color HXDAXDVRZTI;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static Color WPQWZYUQHDW;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static Color DWIQPOXZWOG;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static Cubemap LJPXWGNDBQX;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private static bool LGDXWHMOLGS;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static List<URPLight> QGNEWDSVRFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x854BE20", Offset = "0x854A420", VA = "0x18854BE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static List<Light> GGPMXPRZRDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x854CA60", Offset = "0x854B060", VA = "0x18854CA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static Camera MHKXLJRACSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x854D7A0", Offset = "0x854BDA0", VA = "0x18854D7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x854BE70", Offset = "0x854A470", VA = "0x18854BE70")]
		public static void CRFWGNZBSSV(Vector3 a, Quaternion b, ImposterRenderConfig c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x854E070", Offset = "0x854C670", VA = "0x18854E070")]
		private static void YDCIQJRYZOJ(Vector3 a, Quaternion b, URPLight c, ImposterRenderConfig.LightConfig d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x854DF90", Offset = "0x854C590", VA = "0x18854DF90")]
		public static void XIQJMFJPTHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x854CB90", Offset = "0x854B190", VA = "0x18854CB90")]
		private static void JMPPAGUJRLC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x854D050", Offset = "0x854B650", VA = "0x18854D050")]
		public static void JMXDKWUGEFA(ImposterRenderConfig a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x854CAB0", Offset = "0x854B0B0", VA = "0x18854CAB0")]
		public static void IDSHLQZCQLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x854C100", Offset = "0x854A700", VA = "0x18854C100")]
		public static void DPANCVJHQML(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, [Optional] Vector3? e, [Optional] Vector3? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x854C430", Offset = "0x854AA30", VA = "0x18854C430")]
		private static void EOIWZGSIBZS(GameObject a, RenderTexture b, ImposterRenderConfig c, ImposterRenderSettings d, Vector3 e, Vector3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x854D4E0", Offset = "0x854BAE0", VA = "0x18854D4E0")]
		private static void MBOVYQZILHH(GameObject a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854D200", Offset = "0x854B800", VA = "0x18854D200")]
		public static void LZMQLRVJZRM(Bounds a, ImposterRenderConfig b, [Out] Vector3 c, [Out] Quaternion d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x854D9D0", Offset = "0x854BFD0", VA = "0x18854D9D0")]
		private static void UEENQSNHEBX(GameObject a, ImposterRenderConfig b, ImposterRenderSettings c, [Out] Vector3 d, [Out] Quaternion e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x854DEC0", Offset = "0x854C4C0", VA = "0x18854DEC0")]
		public static RenderTexture WOTHQUZQIRZ(int a, int b, RenderTextureFormat c = RenderTextureFormat.ARGB32, string d = "[ImposterRendering]Preview")
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
			public FOBJSUETHEV Promise;

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
			[Cpp2IlInjected.Address(RVA = "0x8551F70", Offset = "0x8550570", VA = "0x188551F70")]
			public QueuedImposterRender(FOBJSUETHEV promise, GameObject targetGameObject, RenderTexture renderTexture, ImposterRenderConfig imposterRenderConfig, ImposterRenderSettings imposterRenderSettings)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static IYWOPWKMZEF<QueuedImposterRender, RenderTexture> ZSAAOZKUAPA;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<QueuedImposterRender> FUZJUKEZURE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int LOSOEHRQPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x854FCE0", Offset = "0x854E2E0", VA = "0x18854FCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85500A0", Offset = "0x854E6A0", VA = "0x1885500A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject targetGameobject, RenderTexture renderTexture, ImposterRenderConfig imposterConfig, ImposterRenderSettings imposterRenderSettings, CancellationToken cancellationToken, bool disableWhileQueued = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x854FAE0", Offset = "0x854E0E0", VA = "0x18854FAE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8550010", Offset = "0x854E610", VA = "0x188550010", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x854FD70", Offset = "0x854E370", VA = "0x18854FD70")]
		private static Task<RenderTexture> LQRNGXAGFCY(QueuedImposterRender a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8550480", Offset = "0x854EA80", VA = "0x188550480")]
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
