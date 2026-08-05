using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
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
	private readonly struct HJFKNMPKKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OLEBGHFEPOP BPNNGEKCDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string LIBEHGHEMHN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
		public HJFKNMPKKBG(OLEBGHFEPOP CPPFGJCHHAO, string DEJHKKHOJGG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct NLBODNKJDJK : IAsyncStateMachine
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
		public HJFKNMPKKBG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C98F10", Offset = "0x6C98110", VA = "0x186C98F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C992D0", Offset = "0x6C984D0", VA = "0x186C992D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider JLLFGKCJNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EOINJFJBFND<HJFKNMPKKBG, GameObject> INPFKNHNOJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NODDKCADJKD JIBEDHPOJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8944A0", Offset = "0x8936A0", VA = "0x1808944A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EOINJFJBFND<HJFKNMPKKBG, GameObject> FKHDGFNMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C937A0", Offset = "0x6C929A0", VA = "0x186C937A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HGBLJEAIAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C93750", Offset = "0x6C92950", VA = "0x186C93750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C93670", Offset = "0x6C92870", VA = "0x186C93670", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C93BF0", Offset = "0x6C92DF0", VA = "0x186C93BF0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C93900", Offset = "0x6C92B00", VA = "0x186C93900")]
	[AsyncStateMachine(typeof(NLBODNKJDJK))]
	private Task<GameObject> FODLFFDLFJD(HJFKNMPKKBG PGPPIIFJAIK, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C93A20", Offset = "0x6C92C20", VA = "0x186C93A20")]
	public Task<GameObject> LoadItemAsync(OLEBGHFEPOP CPPFGJCHHAO, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C93C60", Offset = "0x6C92E60", VA = "0x186C93C60")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BIMCPPPOKCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OLEBGHFEPOP CJDENMCPAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture ACKHAOBGDGG;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
		public BIMCPPPOKCL(OLEBGHFEPOP KIHGCPGBAEK, Texture AIEGELCMLNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum AFEAICFKPPL
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
	private class BBEGDBEKAJG : PHGFAFOKJOP<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct ICFFHMHKKEL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public BBEGDBEKAJG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C970C0", Offset = "0x6C962C0", VA = "0x186C970C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C978B0", Offset = "0x6C96AB0", VA = "0x186C978B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly OLEBGHFEPOP KIHGCPGBAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FMCMPFBDEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IAKHDHKGLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken DDNLBFLLCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D BBCDILILHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject GNEDIKNHIJK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override PIHPPMDHIHB<Texture2D> JLCNKMOLJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C91ED0", Offset = "0x6C910D0", VA = "0x186C91ED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> NCKOPAEIIKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C920D0", Offset = "0x6C912D0", VA = "0x186C920D0")]
		public BBEGDBEKAJG(OLEBGHFEPOP KIHGCPGBAEK, RenderTexture FMCMPFBDEIN, ImposterRenderConfig IAKHDHKGLIL, CancellationToken DDNLBFLLCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C91FE0", Offset = "0x6C911E0", VA = "0x186C91FE0")]
		[AsyncStateMachine(typeof(ICFFHMHKKEL))]
		private Task<Texture2D> PJFLLLDJFDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C91F30", Offset = "0x6C91130", VA = "0x186C91F30", Slot = "10")]
		protected override void JNNBJPBADHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C91F60", Offset = "0x6C91160", VA = "0x186C91F60")]
		private static void OOFEMGGEFEL(GameObject GNEDIKNHIJK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct BLLAJONAMFN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C92290", Offset = "0x6C91490", VA = "0x186C92290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private AFEAICFKPPL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[BDABGKFLIPP("size", AFEAICFKPPL.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int BNIOFNIINEG;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MOJMHEFCINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KACCGKNHPBC<GameObject> OBCHPOGEHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FKNJNNPDPCK BNONAEKGIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MOPJKINAACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NMANDIAIDGE<Texture2D> IFKDIJKAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private OLEBGHFEPOP KCADJBNBKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MADJFNDIINH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AFAKOIKKMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C988E0", Offset = "0x6C97AE0", VA = "0x186C988E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C98930", Offset = "0x6C97B30", VA = "0x186C98930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture NABAIALKMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C97F60", Offset = "0x6C97160", VA = "0x186C97F60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private OLEBGHFEPOP CJDENMCPAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8942B0", Offset = "0x8934B0", VA = "0x1808942B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C98140", Offset = "0x6C97340", VA = "0x186C98140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool IMLGJCCBOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1A3AA10", Offset = "0x1A39C10", VA = "0x181A3AA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GBCCILPJLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C98380", Offset = "0x6C97580", VA = "0x186C98380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C97EC0", Offset = "0x6C970C0", VA = "0x186C97EC0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C984C0", Offset = "0x6C976C0", VA = "0x186C984C0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C97EE0", Offset = "0x6C970E0", VA = "0x186C97EE0")]
	private void GBKBNBMBJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C987C0", Offset = "0x6C979C0", VA = "0x186C987C0")]
	public void Set(OLEBGHFEPOP DAMIKCPAJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C987B0", Offset = "0x6C979B0", VA = "0x186C987B0")]
	public void Set(Texture AIEGELCMLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C987D0", Offset = "0x6C979D0", VA = "0x186C987D0")]
	public void Set(BIMCPPPOKCL JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C97ED0", Offset = "0x6C970D0", VA = "0x186C97ED0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C985C0", Offset = "0x6C977C0", VA = "0x186C985C0")]
	public void SetInternal(OLEBGHFEPOP DAMIKCPAJFH, [Optional] Texture LKLBOFCMGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C985B0", Offset = "0x6C977B0", VA = "0x186C985B0")]
	public void SetCustomSize(int CGJMMJFCNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x89FAC0", Offset = "0x89ECC0", VA = "0x18089FAC0")]
	public void SetAntiAliasing(int ICJELPEGDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C98410", Offset = "0x6C97610", VA = "0x186C98410")]
	[AsyncStateMachine(typeof(BLLAJONAMFN))]
	private void OGIDJDINBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C982A0", Offset = "0x6C974A0", VA = "0x186C982A0")]
	private void NFOCOKMNPDE(Texture AIEGELCMLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C98860", Offset = "0x6C97A60", VA = "0x186C98860")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NHCKHOOKHDB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float ACGLEIIJEDP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "4")]
	public void PrepareImposter(NGFCHFBLJAC JGJLGBDNBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C97E80", Offset = "0x6C97080", VA = "0x186C97E80")]
	public void SetReferencePoint(Vector3 KMEEFLDIFOK, Quaternion GGGHJBFEJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C97C90", Offset = "0x6C96E90", VA = "0x186C97C90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C97E60", Offset = "0x6C97060", VA = "0x186C97E60")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18B2F40", Offset = "0x18B2140", VA = "0x1818B2F40")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CGNOCMAMBLC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static CGNOCMAMBLC ECJOPKPLBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float PJCNAEOGNIF;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x23B16F0", Offset = "0x23B08F0", VA = "0x1823B16F0")]
	public CGNOCMAMBLC(float IBNJNNCCKLO)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C995F0", Offset = "0x6C987F0", VA = "0x186C995F0", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
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
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[FICFPGOHBIA(IKBOIBNEMID.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int GKDPAJHOMII = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int CJOJJKLKNKN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> BOGIADIJMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FFOEMMMILJM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C98B30", Offset = "0x6C97D30", VA = "0x186C98B30")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C98A30", Offset = "0x6C97C30", VA = "0x186C98A30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C98D70", Offset = "0x6C97F70", VA = "0x186C98D70")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OLEBGHFEPOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MGOCGBENCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CGNOCMAMBLC CGNOCMAMBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action COKIPCLGLAM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> HMKHFAPAFND(CancellationToken DDNLBFLLCLM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDFMNNNLDOH(OLEBGHFEPOP KDHPJMADEAD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHEFEKFHIIH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKDHGDKAAGF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GJKDNOIHKMM(uint? NOBDBIEALKI, [Out] NMANDIAIDGE<Texture2D> JJMCMBDGKPK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MMGIFLLEABI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C98E30", Offset = "0x6C98030", VA = "0x186C98E30")]
	public static bool MKPIEPLFLCB(OLEBGHFEPOP AIKPEJGMMAH, OLEBGHFEPOP MDHCCKJMIGM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, NHCKHOOKHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C92B10", Offset = "0x6C91D10", VA = "0x186C92B10", Slot = "4")]
		public void PrepareImposter(NGFCHFBLJAC JGJLGBDNBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHCKHOOKHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NGFCHFBLJAC JGJLGBDNBOB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EBPAGOBIMFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> JIALFLDFDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HJEBMFEBEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NODDKCADJKD
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECBODLCOIDA(params Type[] KIIFEOFPDGC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FEKAJLBOPFA(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T FEKAJLBOPFA<T>(T ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FEKAJLBOPFA<T>(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject FEKAJLBOPFA(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GIMADABMIGB : IDisposable, NODDKCADJKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> JILEDCBDFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> PKAOFPGINIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform IANOMJAPPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> GOCNMBBBFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ECDELBIODGC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C966C0", Offset = "0x6C958C0", VA = "0x186C966C0")]
	[NPIOOMADHDK.JLDADBHPDAA]
	public static void BMGOJHCGLFB(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C96C80", Offset = "0x6C95E80", VA = "0x186C96C80")]
	[UnityEngine.Scripting.Preserve]
	public GIMADABMIGB([GEFLINBOFNF(null)] EBPAGOBIMFM MFAKKPGJMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C967B0", Offset = "0x6C959B0", VA = "0x186C967B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C96890", Offset = "0x6C95A90", VA = "0x186C96890", Slot = "5")]
	public void ECBODLCOIDA(params Type[] KIIFEOFPDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C96970", Offset = "0x6C95B70", VA = "0x186C96970", Slot = "6")]
	public GameObject FEKAJLBOPFA(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C150", Offset = "0x2E0B350", VA = "0x182E0C150", Slot = "7")]
	public T FEKAJLBOPFA<T>(T ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BB20", Offset = "0x2E0AD20", VA = "0x182E0BB20", Slot = "8")]
	public T FEKAJLBOPFA<T>(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, bool MHPJGGMPHNJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C968E0", Offset = "0x6C95AE0", VA = "0x186C968E0", Slot = "9")]
	public GameObject FEKAJLBOPFA(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BB70", Offset = "0x2E0AD70", VA = "0x182E0BB70", Slot = "10")]
	public T FEKAJLBOPFA<T>(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E0BBD0", Offset = "0x2E0ADD0", VA = "0x182E0BBD0")]
	private T FEKAJLBOPFA<T>(GameObject ONCGCDCCCBH, Transform MBOJNCFILKL, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ, [Out] GameObject ACFBDNFIGFA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E0C1E0", Offset = "0x2E0B3E0", VA = "0x182E0C1E0")]
	private T NLKMNGCJIAN<T>(GameObject PLNJOBKLAEE, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C96B70", Offset = "0x6C95D70", VA = "0x186C96B70")]
	private void KOMOFBHDDGP(Component OPAHHNBNPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C96210", Offset = "0x6C95410", VA = "0x186C96210")]
	private void AHIENOHOEIF(Component OPAHHNBNPOH, NGFCHFBLJAC JGJLGBDNBOB, bool MHPJGGMPHNJ, bool FPBPLBKLIOF, [Optional] Type LHEIEHNHINF, [Optional] Type CPNEHKGNIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C96A00", Offset = "0x6C95C00", VA = "0x186C96A00")]
	private void KJINKILPDFA(GameObject PLNJOBKLAEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NGFCHFBLJAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> IDBCGMOJCMO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2F7BEF0", Offset = "0x2F7B0F0", VA = "0x182F7BEF0")]
	public NGFCHFBLJAC HPDIHAPBFNP<T>(T OKMPPBJEPDA)
	{
		return default(NGFCHFBLJAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C620", Offset = "0x2F7B820", VA = "0x182F7C620")]
	public T PLOCNKMCLIO<T>(T IIGPKDCCLGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F7B720", Offset = "0x2F7A920", VA = "0x182F7B720")]
	public bool HJCFEIDEHAE<T>([Out] T OKMPPBJEPDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FFKMBKGDGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool JKGBPHFLBDE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23B1980", Offset = "0x23B0B80", VA = "0x1823B1980")]
	public FFKMBKGDGOC(bool IALJIGHMDII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EDDGHDNKLDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool OJOOLKNPMMF;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C93CA0", Offset = "0x6C92EA0", VA = "0x186C93CA0")]
	public EDDGHDNKLDA(bool AHLAKJHBNEC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, NHCKHOOKHDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C99340", Offset = "0x6C98540", VA = "0x186C99340", Slot = "4")]
		public void PrepareImposter(NGFCHFBLJAC JGJLGBDNBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds MBFIELLBNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C97B00", Offset = "0x6C96D00", VA = "0x186C97B00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C97AC0", Offset = "0x6C96CC0", VA = "0x186C97AC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C97A80", Offset = "0x6C96C80", VA = "0x186C97A80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C97990", Offset = "0x6C96B90", VA = "0x186C97990")]
		private void OIEBHIELBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6C98E10", Offset = "0x6C98010", VA = "0x186C98E10")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6C98E00", Offset = "0x6C98000", VA = "0x186C98E00")]
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
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C989A0", Offset = "0x6C97BA0", VA = "0x186C989A0")]
		public void MKKLANOJIMC(Vector3 MCDJMBFBACK, Quaternion DHIADBPFOML, float PFKCIHBIINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C989D0", Offset = "0x6C97BD0", VA = "0x186C989D0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class EFJBOOBJHDH
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 ANJLPHOGLCE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> MLOGDDCCDEC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> ANHNIIIMAKD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera JMHMEGMGFCN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> GGLGFIBBEEC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> MJLMMPHLFBE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode IPCACIDLECI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color EMAJHGNKJJF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color AAMPAEAGDDO;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color DEMMOPLFMLA;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap OFJFODLPNOC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool PMCAODJGCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> MAFOIKNHAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C95BA0", Offset = "0x6C94DA0", VA = "0x186C95BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PFBMPPCPJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C94BC0", Offset = "0x6C93DC0", VA = "0x186C94BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NALBLOHLJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C94990", Offset = "0x6C93B90", VA = "0x186C94990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C943E0", Offset = "0x6C935E0", VA = "0x186C943E0")]
	public static void BFGDFGOHPOA(Vector3 LHAEEAOJMMB, Quaternion HHKKGECOHOF, ImposterRenderConfig DHGLBDFPDOC, bool AKCLHGNNIEJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C94670", Offset = "0x6C93870", VA = "0x186C94670")]
	private static void BOCDBPIAHEK(Vector3 LHAEEAOJMMB, Quaternion HHKKGECOHOF, URPLight INJCKBPKFAG, ImposterRenderConfig.LightConfig OBPKIDJNAHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C93CB0", Offset = "0x6C92EB0", VA = "0x186C93CB0")]
	public static void AFJKELOEPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C95BF0", Offset = "0x6C94DF0", VA = "0x186C95BF0")]
	private static void PMAEHBFGGFA(int CIAOPJLOIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C959F0", Offset = "0x6C94BF0", VA = "0x186C959F0")]
	public static void LAPHPNOKJJO(ImposterRenderConfig DHGLBDFPDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C94C10", Offset = "0x6C93E10", VA = "0x186C94C10")]
	public static void EJFHABJKEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C94FB0", Offset = "0x6C941B0", VA = "0x186C94FB0")]
	public static void HKODCADMKLO(GameObject ECHMBLEODLD, RenderTexture FMCMPFBDEIN, ImposterRenderConfig DHGLBDFPDOC, CGNOCMAMBLC AKOLPBJFAOI, [Optional] Vector3? AAFFEIELBEJ, [Optional] Vector3? KMPNJCIDHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C953C0", Offset = "0x6C945C0", VA = "0x186C953C0")]
	private static void JPBJEHCOMDD(GameObject ECHMBLEODLD, RenderTexture FMCMPFBDEIN, ImposterRenderConfig DHGLBDFPDOC, CGNOCMAMBLC AKOLPBJFAOI, Vector3 AAFFEIELBEJ, Vector3 KMPNJCIDHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C94CF0", Offset = "0x6C93EF0", VA = "0x186C94CF0")]
	private static void FLKNIIIMIOJ(GameObject ECHMBLEODLD, Vector3 BCGIKMHFDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C93D90", Offset = "0x6C92F90", VA = "0x186C93D90")]
	private static void ANJGPMBGODH(GameObject ONCGCDCCCBH, ImposterRenderConfig DHGLBDFPDOC, CGNOCMAMBLC AKOLPBJFAOI, [Out] Vector3 HOBOINIHKLB, [Out] Quaternion POOGCLNOMIL, [Out] float PEABEIDNJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C952F0", Offset = "0x6C944F0", VA = "0x186C952F0")]
	public static RenderTexture IDIKJHCEBEL(int OFMCKDAMODD, int AAKHKDILCDN, RenderTextureFormat EAJPHFGLPOO = RenderTextureFormat.ARGB32, string OKEJCFCJEFN = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct IJALILEAJND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public KOKEAEPGGEH MILHBMNJNLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject JMHJGGKFGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture NABAIALKMOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig JHHPBGDAFLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public CGNOCMAMBLC CGNOCMAMBLC;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6C97920", Offset = "0x6C96B20", VA = "0x186C97920")]
			public IJALILEAJND(KOKEAEPGGEH HCIFBHNBDMC, GameObject INHNLJMCIHH, RenderTexture FMCMPFBDEIN, ImposterRenderConfig IAKHDHKGLIL, CGNOCMAMBLC AKOLPBJFAOI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static EOINJFJBFND<IJALILEAJND, RenderTexture> CKBFGMGFMPE;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<IJALILEAJND> JKCNJIFBIBN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int HDCHLOPNIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C93110", Offset = "0x6C92310", VA = "0x186C93110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C93230", Offset = "0x6C92430", VA = "0x186C93230")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ECHMBLEODLD, RenderTexture FMCMPFBDEIN, ImposterRenderConfig DHGLBDFPDOC, CGNOCMAMBLC AKOLPBJFAOI, CancellationToken DDNLBFLLCLM, bool JIDDMBNDBFO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C92C60", Offset = "0x6C91E60", VA = "0x186C92C60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C931A0", Offset = "0x6C923A0", VA = "0x186C931A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C92E70", Offset = "0x6C92070", VA = "0x186C92E70")]
		private static Task<RenderTexture> HAJOOGGLNJF(IJALILEAJND GOKIBHCEEGH, CancellationToken DDNLBFLLCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C93630", Offset = "0x6C92830", VA = "0x186C93630")]
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
