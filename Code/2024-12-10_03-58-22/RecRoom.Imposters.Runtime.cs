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
	private readonly struct LGKGNOBHHKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LINDMPPHABP CJNHICJLNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string MDADLGCDEMJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC7E130", Offset = "0xC7CD30", VA = "0x180C7E130")]
		public LGKGNOBHHKC(LINDMPPHABP LHJCLBDAKLM, string PDEMOMMIPEM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct OFHCGODDMPN : IAsyncStateMachine
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
		public LGKGNOBHHKC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C789C0", Offset = "0x6C775C0", VA = "0x186C789C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C78D80", Offset = "0x6C77980", VA = "0x186C78D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider PLINOMLHCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GNKAKBBCPIL<LGKGNOBHHKC, GameObject> BDLJKEDOHEF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JNPLFJJOPIA AKHOJEPCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GNKAKBBCPIL<LGKGNOBHHKC, GameObject> HPJAOHICMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C73430", Offset = "0x6C72030", VA = "0x186C73430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int EAOANPGFDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C733E0", Offset = "0x6C71FE0", VA = "0x186C733E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C73300", Offset = "0x6C71F00", VA = "0x186C73300", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C73890", Offset = "0x6C72490", VA = "0x186C73890", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C73770", Offset = "0x6C72370", VA = "0x186C73770")]
	[AsyncStateMachine(typeof(OFHCGODDMPN))]
	private Task<GameObject> MLBBLGBIALG(LGKGNOBHHKC HNMIAJJHIJN, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C73590", Offset = "0x6C72190", VA = "0x186C73590")]
	public Task<GameObject> LoadItemAsync(LINDMPPHABP LHJCLBDAKLM, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C73900", Offset = "0x6C72500", VA = "0x186C73900")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EAEBJLBMJIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LINDMPPHABP EMLFLDDEDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture NBELKKBEGID;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
		public EAEBJLBMJIP(LINDMPPHABP JOOEKJPMEFO, Texture NKCDINKPPDP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KCKALHJLBFI
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
	private class EPLHHLJJLON : IHONDELONOF<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CJCCHGNJOON : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public EPLHHLJJLON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C71F30", Offset = "0x6C70B30", VA = "0x186C71F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C72730", Offset = "0x6C71330", VA = "0x186C72730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LINDMPPHABP JOOEKJPMEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture KFBFLGILNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig GKEPFFKLDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken CKKFHABGBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D HNMMNANDJOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject JDBIOCOLCCL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override HHDNLBNGHMC<Texture2D> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C73AE0", Offset = "0x6C726E0", VA = "0x186C73AE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B40", Offset = "0x6C72740", VA = "0x186C73B40")]
		public EPLHHLJJLON(LINDMPPHABP JOOEKJPMEFO, RenderTexture KFBFLGILNDH, ImposterRenderConfig GKEPFFKLDAH, CancellationToken CKKFHABGBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C73940", Offset = "0x6C72540", VA = "0x186C73940")]
		[AsyncStateMachine(typeof(CJCCHGNJOON))]
		private Task<Texture2D> AJIEANDBKDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C73AB0", Offset = "0x6C726B0", VA = "0x186C73AB0", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C73A30", Offset = "0x6C72630", VA = "0x186C73A30")]
		private static void DOOCJCMJFCN(GameObject JDBIOCOLCCL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct AGKBAIHPHJB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C716F0", Offset = "0x6C702F0", VA = "0x186C716F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6050", Offset = "0x8D4C50", VA = "0x1808D6050", Slot = "5")]
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
	[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private KCKALHJLBFI size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[ELBALDKMPMI("size", KCKALHJLBFI.Custom)]
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
	private static int CHHEMEGGNPJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture JBBLFBPNLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private KNKACODCFIH<GameObject> LHHNJCKICKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LKOMDOLALMB IOJKJNCMGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource IMJPMIKGHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MGEGMLPKNPK<Texture2D> HGGEKHCAJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LINDMPPHABP KCCMLCJGHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MMMPOLKCJFD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int JLEKPNBNJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C75CC0", Offset = "0x6C748C0", VA = "0x186C75CC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C75D10", Offset = "0x6C74910", VA = "0x186C75D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PCPMKFLDIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C753E0", Offset = "0x6C73FE0", VA = "0x186C753E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88C4A0", Offset = "0x88B0A0", VA = "0x18088C4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LINDMPPHABP EMLFLDDEDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88C610", Offset = "0x88B210", VA = "0x18088C610")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C756A0", Offset = "0x6C742A0", VA = "0x186C756A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool HHHICBGMBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x182C920", Offset = "0x182B520", VA = "0x18182C920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int NMFOLDDCKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C758F0", Offset = "0x6C744F0", VA = "0x186C758F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C75290", Offset = "0x6C73E90", VA = "0x186C75290")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C75800", Offset = "0x6C74400", VA = "0x186C75800")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C75360", Offset = "0x6C73F60", VA = "0x186C75360")]
	private void EEOKCPPCCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C75BE0", Offset = "0x6C747E0", VA = "0x186C75BE0")]
	public void Set(LINDMPPHABP PNGKLLMCBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C75B90", Offset = "0x6C74790", VA = "0x186C75B90")]
	public void Set(Texture NKCDINKPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C75BA0", Offset = "0x6C747A0", VA = "0x186C75BA0")]
	public void Set(EAEBJLBMJIP CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C75350", Offset = "0x6C73F50", VA = "0x186C75350")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C75990", Offset = "0x6C74590", VA = "0x186C75990")]
	public void SetInternal(LINDMPPHABP PNGKLLMCBPL, [Optional] Texture AGMLBMOBIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C75980", Offset = "0x6C74580", VA = "0x186C75980")]
	public void SetCustomSize(int CANBFNEFDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x893E10", Offset = "0x892A10", VA = "0x180893E10")]
	public void SetAntiAliasing(int HPIJOFOHHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C752A0", Offset = "0x6C73EA0", VA = "0x186C752A0")]
	[AsyncStateMachine(typeof(AGKBAIHPHJB))]
	private void CMMEHGIIAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C755C0", Offset = "0x6C741C0", VA = "0x186C755C0")]
	private void JHNIECLIOMF(Texture NKCDINKPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C75C40", Offset = "0x6C74840", VA = "0x186C75C40")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, DAENLCDAAGG
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BIOGBGINGPL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public void PrepareImposter(CFMEAHPPFNL HHLMDDDPFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C75250", Offset = "0x6C73E50", VA = "0x186C75250")]
	public void SetReferencePoint(Vector3 APNDNNBECGB, Quaternion NDNBHPBJOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C75060", Offset = "0x6C73C60", VA = "0x186C75060")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C75230", Offset = "0x6C73E30", VA = "0x186C75230")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x17E7230", Offset = "0x17E5E30", VA = "0x1817E7230")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HGGKPGNOBMN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static HGGKPGNOBMN EMGPICEJLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float MEBMGMFMGIB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2324440", Offset = "0x2323040", VA = "0x182324440")]
	public HGGKPGNOBMN(float LKMKDKPOIBA)
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
		[Cpp2IlInjected.Address(RVA = "0x6C790A0", Offset = "0x6C77CA0", VA = "0x186C790A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
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
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int BAFHBALGJFJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BKOPFAFGBEG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> GGAPCAOKING;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool EJJOBGHICEJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C75F20", Offset = "0x6C74B20", VA = "0x186C75F20")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C75E20", Offset = "0x6C74A20", VA = "0x186C75E20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C76160", Offset = "0x6C74D60", VA = "0x186C76160")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LINDMPPHABP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KLOCCCGFPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HGGKPGNOBMN HGGKPGNOBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KJCAKDOEAAD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> KNMFKFKIBKH(CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PAMOPNGNJAN(LINDMPPHABP FDOEIPBMJJM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHLBEDFGCMA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MDMAAOIHBIB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FFNDMNFPLMA(uint? ELOMKDKGNAD, [Out] MGEGMLPKNPK<Texture2D> NGFMJIDPKAI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class ILHOLEHINKH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C74C70", Offset = "0x6C73870", VA = "0x186C74C70")]
	public static bool JOKIBFIJNGK(LINDMPPHABP LPNIMHPPPEN, LINDMPPHABP EOAMLHIBMHI)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, DAENLCDAAGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C727A0", Offset = "0x6C713A0", VA = "0x186C727A0", Slot = "4")]
		public void PrepareImposter(CFMEAHPPFNL HHLMDDDPFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DAENLCDAAGG
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CFMEAHPPFNL HHLMDDDPFNI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JHBBNHGAONI
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NMHKKELEJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> CBPDHKCKKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JNPLFJJOPIA
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAEAPNBKOJA(params Type[] GPANODEMADO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AOBMOMGGBFG(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T AOBMOMGGBFG<T>(T LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AOBMOMGGBFG<T>(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject AOBMOMGGBFG(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HONADIDJGOK : IDisposable, JNPLFJJOPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> MKKPDFNNGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> IPOBMIFBPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform JCCDNEJEBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> ILBFHAKNIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FHLANIKAKJM;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C74730", Offset = "0x6C73330", VA = "0x186C74730")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	public static void NPEAJDJKCFF(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C74830", Offset = "0x6C73430", VA = "0x186C74830")]
	[UnityEngine.Scripting.Preserve]
	public HONADIDJGOK([JGAMIMHCGFI(null)] JHBBNHGAONI OEBGFMMFOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C73FE0", Offset = "0x6C72BE0", VA = "0x186C73FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C74230", Offset = "0x6C72E30", VA = "0x186C74230", Slot = "5")]
	public void KAEAPNBKOJA(params Type[] GPANODEMADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C73DB0", Offset = "0x6C729B0", VA = "0x186C73DB0", Slot = "6")]
	public GameObject AOBMOMGGBFG(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E34900", Offset = "0x2E33500", VA = "0x182E34900", Slot = "7")]
	public T AOBMOMGGBFG<T>(T LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E34330", Offset = "0x2E32F30", VA = "0x182E34330", Slot = "8")]
	public T AOBMOMGGBFG<T>(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, bool BLGMKJGNFMH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C73E40", Offset = "0x6C72A40", VA = "0x186C73E40", Slot = "9")]
	public GameObject AOBMOMGGBFG(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E342D0", Offset = "0x2E32ED0", VA = "0x182E342D0", Slot = "10")]
	public T AOBMOMGGBFG<T>(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E34380", Offset = "0x2E32F80", VA = "0x182E34380")]
	private T AOBMOMGGBFG<T>(GameObject LNKGJNJHIPL, Transform CDBGCEIGNJC, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH, [Out] GameObject GBCECDIAEGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E34990", Offset = "0x2E33590", VA = "0x182E34990")]
	private T JJLNOGIGEGM<T>(GameObject DKOODDCANLH, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C73ED0", Offset = "0x6C72AD0", VA = "0x186C73ED0")]
	private void CJDGBLGKOIC(Component BHEFEMNBEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C74280", Offset = "0x6C72E80", VA = "0x186C74280")]
	private void MDPIAHOABHH(Component BHEFEMNBEDJ, CFMEAHPPFNL HHLMDDDPFNI, bool BLGMKJGNFMH, bool PCLMNHBGGLB, [Optional] Type LEEJGPNCNGO, [Optional] Type DKCGLMLOELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C740C0", Offset = "0x6C72CC0", VA = "0x186C740C0")]
	private void JDENEKCIBBK(GameObject DKOODDCANLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CFMEAHPPFNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> FCHIHEJJPCM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2BFF320", Offset = "0x2BFDF20", VA = "0x182BFF320")]
	public CFMEAHPPFNL GAOLHIMCFIN<T>(T MKGHHKADILO)
	{
		return default(CFMEAHPPFNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFA50", Offset = "0x2BFE650", VA = "0x182BFFA50")]
	public T IBIJBNAFKLE<T>(T IEDAFAANJNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFFB60", Offset = "0x2BFE760", VA = "0x182BFFB60")]
	public bool JMHMMLHCCPD<T>([Out] T MKGHHKADILO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct PEMKIONPAKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool NBBNGKPHHED;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2324190", Offset = "0x2322D90", VA = "0x182324190")]
	public PEMKIONPAKD(bool IGHKHAHKIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct LPGAJAFHMAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool KJGCPOJHIII;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C78980", Offset = "0x6C77580", VA = "0x186C78980")]
	public LPGAJAFHMAB(bool MCALHHEHMJP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, DAENLCDAAGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C78DF0", Offset = "0x6C779F0", VA = "0x186C78DF0", Slot = "4")]
		public void PrepareImposter(CFMEAHPPFNL HHLMDDDPFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
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
		public Bounds KLGNFJLFIEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C74ED0", Offset = "0x6C73AD0", VA = "0x186C74ED0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C74E90", Offset = "0x6C73A90", VA = "0x186C74E90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C74E50", Offset = "0x6C73A50", VA = "0x186C74E50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C74D60", Offset = "0x6C73960", VA = "0x186C74D60")]
		private void ILMDJPIKCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C789A0", Offset = "0x6C775A0", VA = "0x186C789A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6C78990", Offset = "0x6C77590", VA = "0x186C78990")]
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
		[ELBALDKMPMI("frameCameraToImposterBounds", true)]
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
		[ELBALDKMPMI("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x6C75D80", Offset = "0x6C74980", VA = "0x186C75D80")]
		public void MAPHLFKFFFA(Vector3 JINJJMHMJDB, Quaternion CBNMKGPOABJ, float NHNMMELMFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C75DB0", Offset = "0x6C749B0", VA = "0x186C75DB0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KPOGILNMCEG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 DKGBLGFJFIC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> CLKIKJDLHDK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> AFMEHKOMAMN;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera LNOLEELFMEA;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> GIEJCHDLDFJ;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> NIGEBOMIAPP;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode FDFCFAKNLKB;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color GEECIBHDLNO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color BCLGLCHOCJE;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color IIPADAFKBNC;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap LGMJHOONFLI;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool ANBCPFAOKHN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> FLFOPGOCDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C77440", Offset = "0x6C76040", VA = "0x186C77440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PDPIGHBNPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C77E60", Offset = "0x6C76A60", VA = "0x186C77E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera OBECIHKAGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C76990", Offset = "0x6C75590", VA = "0x186C76990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C771B0", Offset = "0x6C75DB0", VA = "0x186C771B0")]
	public static void HMIGNLGDDHG(Vector3 JOHNEHDDCHL, Quaternion ADHKGEMLGEO, ImposterRenderConfig GKIDMGILAFD, bool MLALLIJMIIB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C77490", Offset = "0x6C76090", VA = "0x186C77490")]
	private static void JLPDLLPNNHD(Vector3 JOHNEHDDCHL, Quaternion ADHKGEMLGEO, URPLight CNPMHGAENJK, ImposterRenderConfig.LightConfig NLKOBGJFEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C770D0", Offset = "0x6C75CD0", VA = "0x186C770D0")]
	public static void HIHMOFKAJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C761F0", Offset = "0x6C74DF0", VA = "0x186C761F0")]
	private static void BIOHIDDPKKI(int JALDPIOAEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C77EB0", Offset = "0x6C76AB0", VA = "0x186C77EB0")]
	public static void NKGLHIIDDFA(ImposterRenderConfig GKIDMGILAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C78690", Offset = "0x6C77290", VA = "0x186C78690")]
	public static void NOPCBIOIKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C77B20", Offset = "0x6C76720", VA = "0x186C77B20")]
	public static void NENAPKICGGK(GameObject IIBHOBCJDIG, RenderTexture KFBFLGILNDH, ImposterRenderConfig GKIDMGILAFD, HGGKPGNOBMN JMLHEPIEBMF, [Optional] Vector3? PKGDIOKICJK, [Optional] Vector3? IENONEAFHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C78060", Offset = "0x6C76C60", VA = "0x186C78060")]
	private static void NMJOGNOHMKA(GameObject IIBHOBCJDIG, RenderTexture KFBFLGILNDH, ImposterRenderConfig GKIDMGILAFD, HGGKPGNOBMN JMLHEPIEBMF, Vector3 PKGDIOKICJK, Vector3 IENONEAFHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C76600", Offset = "0x6C75200", VA = "0x186C76600")]
	private static void ENLBBCFONEI(GameObject IIBHOBCJDIG, Vector3 KNKOBAAKCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C777B0", Offset = "0x6C763B0", VA = "0x186C777B0")]
	public static void LBKEBBCLMPF(Bounds DLMCGCKMFGK, ImposterRenderConfig GKIDMGILAFD, [Out] Vector3 ABIGMNNJMKC, [Out] Quaternion LCINKIEAOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76BC0", Offset = "0x6C757C0", VA = "0x186C76BC0")]
	private static void HIEODNCLLAM(GameObject LNKGJNJHIPL, ImposterRenderConfig GKIDMGILAFD, HGGKPGNOBMN JMLHEPIEBMF, [Out] Vector3 ABIGMNNJMKC, [Out] Quaternion LCINKIEAOAI, [Out] float OFBIGAMJMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C768C0", Offset = "0x6C754C0", VA = "0x186C768C0")]
	public static RenderTexture EOIHOOEIJIP(int MBNEPKJJCNM, int DEKKEALBCEP, RenderTextureFormat DNBEJMJLODH = RenderTextureFormat.ARGB32, string KGNCHHEJBNP = "[ImposterRendering]Preview")
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
		public struct FJOADNHIBCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public OKALCPGKGOK OHDCOMICLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject CLCHEOKBDAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture PCPMKFLDIKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig DDMAONHAICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public HGGKPGNOBMN HGGKPGNOBMN;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C73D00", Offset = "0x6C72900", VA = "0x186C73D00")]
			public FJOADNHIBCG(OKALCPGKGOK CDHKEMOEPFO, GameObject NAMIPBFEPID, RenderTexture KFBFLGILNDH, ImposterRenderConfig GKEPFFKLDAH, HGGKPGNOBMN JMLHEPIEBMF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static GNKAKBBCPIL<FJOADNHIBCG, RenderTexture> CJEFKHNKIMO;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<FJOADNHIBCG> HMIMAHGDPDK;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int EJGDDCANHAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6C72DA0", Offset = "0x6C719A0", VA = "0x186C72DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C72EC0", Offset = "0x6C71AC0", VA = "0x186C72EC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IIBHOBCJDIG, RenderTexture KFBFLGILNDH, ImposterRenderConfig GKIDMGILAFD, HGGKPGNOBMN JMLHEPIEBMF, CancellationToken CKKFHABGBNL, bool KFEICBNICLN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C728F0", Offset = "0x6C714F0", VA = "0x186C728F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C72E30", Offset = "0x6C71A30", VA = "0x186C72E30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C72B00", Offset = "0x6C71700", VA = "0x186C72B00")]
		private static Task<RenderTexture> EGFLDGBPHNN(FJOADNHIBCG ENMDCGLHBGA, CancellationToken CKKFHABGBNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C732C0", Offset = "0x6C71EC0", VA = "0x186C732C0")]
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
