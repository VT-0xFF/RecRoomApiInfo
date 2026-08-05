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
using RecRoom.DataLayer.Registration;
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
	private readonly struct PIECKNINENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OKICIJMOCBJ POPOADIHPJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DDMJIJIMJLE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
		public PIECKNINENJ(OKICIJMOCBJ CDDMPFJONMG, string OOPCHLJEAEO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MHOMGMFMOEK : IAsyncStateMachine
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
		public PIECKNINENJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x749CCB0", Offset = "0x749C0B0", VA = "0x18749CCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x749D070", Offset = "0x749C470", VA = "0x18749D070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DDLGLOJCOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EDKFEDBHBOL<PIECKNINENJ, GameObject> JKPOOMFOIBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FBAKFEIHNGH MGPMFKLLAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private EDKFEDBHBOL<PIECKNINENJ, GameObject> JCCINLBMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7498010", Offset = "0x7497410", VA = "0x187498010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int GFHBGAHMOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7498170", Offset = "0x7497570", VA = "0x187498170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7497F30", Offset = "0x7497330", VA = "0x187497F30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74984B0", Offset = "0x74978B0", VA = "0x1874984B0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7498390", Offset = "0x7497790", VA = "0x187498390")]
	[AsyncStateMachine(typeof(MHOMGMFMOEK))]
	private Task<GameObject> OLIJMLNHHKP(PIECKNINENJ MCNFLIMLOBO, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74981C0", Offset = "0x74975C0", VA = "0x1874981C0")]
	public Task<GameObject> LoadItemAsync(OKICIJMOCBJ CDDMPFJONMG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7498520", Offset = "0x7497920", VA = "0x187498520")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EMGHEJDLLJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public OKICIJMOCBJ ENLNOAEBGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HKNAGMNOLHP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x957D80", Offset = "0x957180", VA = "0x180957D80")]
		public EMGHEJDLLJO(OKICIJMOCBJ LLAGPEFJEGP, Texture IHOMIJNFMIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum GAKFFODCLNL
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
	private class NDHCEABFMAJ : IBMEPBNFOMN<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct KCPCKMNCBLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public NDHCEABFMAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7499B10", Offset = "0x7498F10", VA = "0x187499B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x749A300", Offset = "0x7499700", VA = "0x18749A300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly OKICIJMOCBJ LLAGPEFJEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DBGJHDJANEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig MMOOBHBACFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken LAEIHJHNGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D DEDOJNMDIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject BJDCOEEKPPN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NEEPBAPEEOL<Texture2D> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x749D240", Offset = "0x749C640", VA = "0x18749D240", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x749D320", Offset = "0x749C720", VA = "0x18749D320")]
		public NDHCEABFMAJ(OKICIJMOCBJ LLAGPEFJEGP, RenderTexture DBGJHDJANEN, ImposterRenderConfig MMOOBHBACFL, CancellationToken LAEIHJHNGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x749D120", Offset = "0x749C520", VA = "0x18749D120")]
		[AsyncStateMachine(typeof(KCPCKMNCBLD))]
		private Task<Texture2D> IGKPLCBBICD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x749D210", Offset = "0x749C610", VA = "0x18749D210", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x749D2A0", Offset = "0x749C6A0", VA = "0x18749D2A0")]
		private static void NOPOKGLEDCO(GameObject BJDCOEEKPPN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ONFFGLCDBJH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x749D4E0", Offset = "0x749C8E0", VA = "0x18749D4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private GAKFFODCLNL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[FKOECLOBFCN("size", GAKFFODCLNL.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int KHDPMKDCKLI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture BPMCBCJEJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private POFJKOIINNK<GameObject> GLNCLKJIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private AEIHFJALFJE BGBHDDJFPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource PMAMMIAHALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private EBHOPDBMNPK<Texture2D> HIEHAPJILIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private OKICIJMOCBJ LGJCCCLJDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DFHMMBDJNAB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int KHINMLBPAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74994D0", Offset = "0x74988D0", VA = "0x1874994D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7499520", Offset = "0x7498920", VA = "0x187499520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture IHEABPOCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7498AB0", Offset = "0x7497EB0", VA = "0x187498AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x94B7F0", Offset = "0x94ABF0", VA = "0x18094B7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private OKICIJMOCBJ ENLNOAEBGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x94FD90", Offset = "0x94F190", VA = "0x18094FD90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7498DF0", Offset = "0x74981F0", VA = "0x187498DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool JEBFDKKEGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1EF79C0", Offset = "0x1EF6DC0", VA = "0x181EF79C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int KBDGCOMCFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7498F50", Offset = "0x7498350", VA = "0x187498F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7498A90", Offset = "0x7497E90", VA = "0x187498A90")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74990A0", Offset = "0x74984A0", VA = "0x1874990A0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7498D70", Offset = "0x7498170", VA = "0x187498D70")]
	private void JALACEPGLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74993F0", Offset = "0x74987F0", VA = "0x1874993F0")]
	public void Set(OKICIJMOCBJ POEDECGGKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74993A0", Offset = "0x74987A0", VA = "0x1874993A0")]
	public void Set(Texture IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74993B0", Offset = "0x74987B0", VA = "0x1874993B0")]
	public void Set(EMGHEJDLLJO KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7498AA0", Offset = "0x7497EA0", VA = "0x187498AA0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74991A0", Offset = "0x74985A0", VA = "0x1874991A0")]
	public void SetInternal(OKICIJMOCBJ POEDECGGKLJ, [Optional] Texture NBECMAEJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7499190", Offset = "0x7498590", VA = "0x187499190")]
	public void SetCustomSize(int EAJDBGALPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x94B9F0", Offset = "0x94ADF0", VA = "0x18094B9F0")]
	public void SetAntiAliasing(int IJDJEJLFBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7498FF0", Offset = "0x74983F0", VA = "0x187498FF0")]
	[AsyncStateMachine(typeof(ONFFGLCDBJH))]
	private void OBJIKNNODBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7498C90", Offset = "0x7498090", VA = "0x187498C90")]
	private void IIOBBPBMANI(Texture IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7499450", Offset = "0x7498850", VA = "0x187499450")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, KHNOGBHBOHO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float LCGMALDDPEN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
	public void PrepareImposter(LDDEFNHJHDL FJJOKDBOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7498A50", Offset = "0x7497E50", VA = "0x187498A50")]
	public void SetReferencePoint(Vector3 IJNCCGADGJC, Quaternion BALNGIJIBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7498860", Offset = "0x7497C60", VA = "0x187498860")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7498A30", Offset = "0x7497E30", VA = "0x187498A30")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D70", Offset = "0x1C25170", VA = "0x181C25D70")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MLKAKOEMJIE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static MLKAKOEMJIE BFLDPGCOOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float EHGJBFODJCH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2740420", Offset = "0x273F820", VA = "0x182740420")]
	public MLKAKOEMJIE(float KIOOOINOBKC)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x749DFF0", Offset = "0x749D3F0", VA = "0x18749DFF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int BECDHPPNNDE = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BDLPEIFFEEG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> ELKFJCFIAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool EDGOHBAKDLK;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7499740", Offset = "0x7498B40", VA = "0x187499740")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7499640", Offset = "0x7498A40", VA = "0x187499640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7499990", Offset = "0x7498D90", VA = "0x187499990")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OKICIJMOCBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KLEIAHPKEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MLKAKOEMJIE MLKAKOEMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FLAHPMKEEDA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> NDFNHKAONIK(CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FJFDKDAALHE(OKICIJMOCBJ OKCHLIEAIJP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GLEAFDMFNCJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JDOPBDKCICJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DCDMEFBLMCD(uint? AKCODDKNFFE, [Out] EBHOPDBMNPK<Texture2D> MCOEGLDGPLA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KCEELPDHPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7499A20", Offset = "0x7498E20", VA = "0x187499A20")]
	public static bool HBDOMFHFLPK(OKICIJMOCBJ OOAFJOFINDC, OKICIJMOCBJ CLPGIODPHPF)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, KHNOGBHBOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74964E0", Offset = "0x74958E0", VA = "0x1874964E0", Slot = "4")]
		public void PrepareImposter(LDDEFNHJHDL FJJOKDBOKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KHNOGBHBOHO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LDDEFNHJHDL FJJOKDBOKAE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AKHDBLCFAAD
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OFHEFFFAHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> EIKOCJNNAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface FBAKFEIHNGH
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PINABMDFADM(params Type[] KNENHKODPKI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject DEBPCHKBNMA(GameObject CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DEBPCHKBNMA<T>(T CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DEBPCHKBNMA<T>(GameObject CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject DEBPCHKBNMA(GameObject CFENBMBECBB, Transform LDIAONMHHPK, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DIHOOBMIDJG : IDisposable, FBAKFEIHNGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GMGIOOKGMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> EFKBOIEDFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform JINKBGBKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> OPGGMHILEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ADJFBOMDDGF;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7496630", Offset = "0x7495A30", VA = "0x187496630")]
	[HLOHOCOKELO.IDGFAEKKODB]
	public static void AOKDCDMDNDH(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x74970B0", Offset = "0x74964B0", VA = "0x1874970B0")]
	[UnityEngine.Scripting.Preserve]
	public DIHOOBMIDJG([IBJCGEMJMJL(null)] AKHDBLCFAAD CPOBENDGGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74969C0", Offset = "0x7495DC0", VA = "0x1874969C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7496BB0", Offset = "0x7495FB0", VA = "0x187496BB0", Slot = "5")]
	public void PINABMDFADM(params Type[] KNENHKODPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7496930", Offset = "0x7495D30", VA = "0x187496930", Slot = "6")]
	public GameObject DEBPCHKBNMA(GameObject CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3206B10", Offset = "0x3205F10", VA = "0x183206B10", Slot = "7")]
	public T DEBPCHKBNMA<T>(T CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3206A60", Offset = "0x3205E60", VA = "0x183206A60", Slot = "8")]
	public T DEBPCHKBNMA<T>(GameObject CFENBMBECBB, Transform LDIAONMHHPK, bool FEJEAIHIOKM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x74968A0", Offset = "0x7495CA0", VA = "0x1874968A0", Slot = "9")]
	public GameObject DEBPCHKBNMA(GameObject CFENBMBECBB, Transform LDIAONMHHPK, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3206AB0", Offset = "0x3205EB0", VA = "0x183206AB0", Slot = "10")]
	public T DEBPCHKBNMA<T>(GameObject CFENBMBECBB, Transform LDIAONMHHPK, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3206BA0", Offset = "0x3205FA0", VA = "0x183206BA0")]
	private T DEBPCHKBNMA<T>(GameObject CFENBMBECBB, Transform LDIAONMHHPK, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM, [Out] GameObject HHKAIIOOOFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x32065C0", Offset = "0x32059C0", VA = "0x1832065C0")]
	private T CCNAHAMLDEH<T>(GameObject HHDLNMHBJJD, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7496AA0", Offset = "0x7495EA0", VA = "0x187496AA0")]
	private void HPLNHKCNEFC(Component MEFMJJOMDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7496C00", Offset = "0x7496000", VA = "0x187496C00")]
	private void PPBPBBIEPKI(Component MEFMJJOMDFE, LDDEFNHJHDL FJJOKDBOKAE, bool FEJEAIHIOKM, bool GNCHOKAJPED, [Optional] Type MNJPJHDFDGK, [Optional] Type LLEMHJIMGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7496730", Offset = "0x7495B30", VA = "0x187496730")]
	private void CMGPGAJCJIA(GameObject HHDLNMHBJJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LDDEFNHJHDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> LCAAMMDJLJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34731C0", Offset = "0x34725C0", VA = "0x1834731C0")]
	public LDDEFNHJHDL ECFLGDLFBIO<T>(T PHJNOPPOOGL)
	{
		return default(LDDEFNHJHDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34740D0", Offset = "0x34734D0", VA = "0x1834740D0")]
	public T NPPDIJEBOHO<T>(T IDJBNLNBJCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34738F0", Offset = "0x3472CF0", VA = "0x1834738F0")]
	public bool FKKNKLKECHH<T>([Out] T PHJNOPPOOGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JOLOCIGNIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool EKPCJMCNHMJ;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2740760", Offset = "0x273FB60", VA = "0x182740760")]
	public JOLOCIGNIBA(bool HGLDBMNPOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BLNLKBKPBPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool FKGPKOCONED;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x74964D0", Offset = "0x74958D0", VA = "0x1874964D0")]
	public BLNLKBKPBPC(bool PPPONIAAEMN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, KHNOGBHBOHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x749DD30", Offset = "0x749D130", VA = "0x18749DD30", Slot = "4")]
		public void PrepareImposter(LDDEFNHJHDL FJJOKDBOKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
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
		public Bounds CMGAAOACEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x74986D0", Offset = "0x7497AD0", VA = "0x1874986D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7498690", Offset = "0x7497A90", VA = "0x187498690")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7498650", Offset = "0x7497A50", VA = "0x187498650")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7498560", Offset = "0x7497960", VA = "0x187498560")]
		private void CPMNJGPKHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
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
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x749CC20", Offset = "0x749C020", VA = "0x18749CC20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x749CC10", Offset = "0x749C010", VA = "0x18749CC10")]
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
		[FKOECLOBFCN("frameCameraToImposterBounds", true)]
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
		[FKOECLOBFCN("autoRotateYawImposter", true)]
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

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74995A0", Offset = "0x74989A0", VA = "0x1874995A0")]
		public void JJJBFCAKEDJ(Vector3 ILINMNBKBOG, Quaternion IEAMGODGICO, float MNBNFCLNKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x74995D0", Offset = "0x74989D0", VA = "0x1874995D0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KNALBHNOGIC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 JHIDNIJOEEB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> BDHDFNDEPPF;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> ADDNMHMMKOE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera LDAFDIPGJIC;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> PJCMCNMDIHF;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> IFEPIHKMGCL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode BFGEGPPALHE;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color CKGBIDOEMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BJAIIEGHDAA;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color KONOKJGGIEK;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap INFFAOHMGJC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool DEOJDLBBCDG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> PEHGIMGKLFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x749C7C0", Offset = "0x749BBC0", VA = "0x18749C7C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> NNKMEAILJIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x749AF10", Offset = "0x749A310", VA = "0x18749AF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera FDHLCJOFODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x749ACC0", Offset = "0x749A0C0", VA = "0x18749ACC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x749B330", Offset = "0x749A730", VA = "0x18749B330")]
	public static void JLKMLBKMKBD(Vector3 PDEPONMNDEC, Quaternion DHKKOOBNGJK, ImposterRenderConfig PAPLCAIHFNK, bool LHDKAAHEHPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x749C4A0", Offset = "0x749B8A0", VA = "0x18749C4A0")]
	private static void NJNMBEJCLKK(Vector3 PDEPONMNDEC, Quaternion DHKKOOBNGJK, URPLight IECAFBFBFPF, ImposterRenderConfig.LightConfig ELMFHEJHCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x749ABE0", Offset = "0x7499FE0", VA = "0x18749ABE0")]
	public static void DAEGFFHIEPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x749B5D0", Offset = "0x749A9D0", VA = "0x18749B5D0")]
	private static void KCGBPBOJMID(int NPFDBNFAGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x749C810", Offset = "0x749BC10", VA = "0x18749C810")]
	public static void OOFLGICEGGO(ImposterRenderConfig PAPLCAIHFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x749B240", Offset = "0x749A640", VA = "0x18749B240")]
	public static void IKDGLDGNIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x749A8A0", Offset = "0x7499CA0", VA = "0x18749A8A0")]
	public static void BPKPAPIEJMH(GameObject KEINGHEGPPL, RenderTexture DBGJHDJANEN, ImposterRenderConfig PAPLCAIHFNK, MLKAKOEMJIE LAINGFFAKOB, [Optional] Vector3? HOGFLKNBELD, [Optional] Vector3? KGEFGCHFCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x749BAD0", Offset = "0x749AED0", VA = "0x18749BAD0")]
	private static void LJHDKIDPKHP(GameObject KEINGHEGPPL, RenderTexture DBGJHDJANEN, ImposterRenderConfig PAPLCAIHFNK, MLKAKOEMJIE LAINGFFAKOB, Vector3 HOGFLKNBELD, Vector3 KGEFGCHFCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x749AF60", Offset = "0x749A360", VA = "0x18749AF60")]
	private static void GLDANNLLDGE(GameObject KEINGHEGPPL, Vector3 HKILJLBAJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x749C130", Offset = "0x749B530", VA = "0x18749C130")]
	public static void NAMAOIMCKNA(Bounds LDHFFEBPOEF, ImposterRenderConfig PAPLCAIHFNK, [Out] Vector3 HBLJKNOPNBG, [Out] Quaternion FBIKHAFHFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x749A370", Offset = "0x7499770", VA = "0x18749A370")]
	private static void ALGBDPKFIAD(GameObject CFENBMBECBB, ImposterRenderConfig PAPLCAIHFNK, MLKAKOEMJIE LAINGFFAKOB, [Out] Vector3 HBLJKNOPNBG, [Out] Quaternion FBIKHAFHFNA, [Out] float EDMMPKMBGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x749BA00", Offset = "0x749AE00", VA = "0x18749BA00")]
	public static RenderTexture KHDPJLHBLHO(int DGJBPFCGALI, int KFGPKPDDOBN, RenderTextureFormat HGFLLJFOAAE = RenderTextureFormat.ARGB32, string GGCEDPOELNF = "[ImposterRendering]Preview")
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
		public struct MBNHLOGFBIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NKJHMBFDFON CNOMNJHBKPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject MJLIHBELGMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture IHEABPOCIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig KBFOHNNNCLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public MLKAKOEMJIE MLKAKOEMJIE;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x749CC40", Offset = "0x749C040", VA = "0x18749CC40")]
			public MBNHLOGFBIK(NKJHMBFDFON ACMOBPAMBFB, GameObject LBPFJJJLEPE, RenderTexture DBGJHDJANEN, ImposterRenderConfig MMOOBHBACFL, MLKAKOEMJIE LAINGFFAKOB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static EDKFEDBHBOL<MBNHLOGFBIK, RenderTexture> MAMOJONFPEH;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<MBNHLOGFBIK> AEPFJHBJJMB;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int KIKGGGOEOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x74979A0", Offset = "0x7496DA0", VA = "0x1874979A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7497AD0", Offset = "0x7496ED0", VA = "0x187497AD0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KEINGHEGPPL, RenderTexture DBGJHDJANEN, ImposterRenderConfig PAPLCAIHFNK, MLKAKOEMJIE LAINGFFAKOB, CancellationToken LAEIHJHNGEK, bool DLPCKKOCANK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74974F0", Offset = "0x74968F0", VA = "0x1874974F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7497A30", Offset = "0x7496E30", VA = "0x187497A30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7497700", Offset = "0x7496B00", VA = "0x187497700")]
		private static Task<RenderTexture> ILEJAGEEKAB(MBNHLOGFBIK IEKDEFIDOMC, CancellationToken LAEIHJHNGEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7497EF0", Offset = "0x74972F0", VA = "0x187497EF0")]
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
