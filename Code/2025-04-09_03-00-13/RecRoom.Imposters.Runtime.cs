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
	private readonly struct BGMGJFFBNFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BIEEPEMHOFP GFFPOAIIGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string FPBPKFOFMPJ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2B0", Offset = "0xA3C6B0", VA = "0x180A3D2B0")]
		public BGMGJFFBNFA(BIEEPEMHOFP OCINCALDKGJ, string OEOLCNJCACI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct FHGILOOJLBI : IAsyncStateMachine
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
		public BGMGJFFBNFA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x790A810", Offset = "0x7909C10", VA = "0x18790A810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x790ABD0", Offset = "0x7909FD0", VA = "0x18790ABD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider FDIJOPLFAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IEPIFCAFPHB<BGMGJFFBNFA, GameObject> FBPHEPBFLAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ABHBFOJBDNO PFDKGEBIGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IEPIFCAFPHB<BGMGJFFBNFA, GameObject> GMCHOKIEMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x790A3E0", Offset = "0x79097E0", VA = "0x18790A3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CEGCCEIIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x790A540", Offset = "0x7909940", VA = "0x18790A540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x790A1E0", Offset = "0x79095E0", VA = "0x18790A1E0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x790A760", Offset = "0x7909B60", VA = "0x18790A760", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x790A2C0", Offset = "0x79096C0", VA = "0x18790A2C0")]
	[AsyncStateMachine(typeof(FHGILOOJLBI))]
	private Task<GameObject> BFMJFKHCJEF(BGMGJFFBNFA LEMIJIIACGB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x790A590", Offset = "0x7909990", VA = "0x18790A590")]
	public Task<GameObject> LoadItemAsync(BIEEPEMHOFP OCINCALDKGJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x790A7D0", Offset = "0x7909BD0", VA = "0x18790A7D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DKOCAGCPBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BIEEPEMHOFP DMNFDOBLPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture GJGOKGDEMCJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B9340", Offset = "0x9B8740", VA = "0x1809B9340")]
		public DKOCAGCPBGD(BIEEPEMHOFP LNMEECGDCCD, Texture NPCKAAANCNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum FLCBNCFNCGL
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
	private class CCLKLKFMCFC : MLJCOMBFFFI<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct JDEHDILKLDD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CCLKLKFMCFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x790C0C0", Offset = "0x790B4C0", VA = "0x18790C0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x790C8B0", Offset = "0x790BCB0", VA = "0x18790C8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BIEEPEMHOFP LNMEECGDCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DOPHDKBFGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig PDLMAOHFOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken LMNHDKIFBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D PJCFCGNAGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject PNDAKOKBGIP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override GOBMEFCJDOP<Texture2D> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x79091A0", Offset = "0x79085A0", VA = "0x1879091A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x79093A0", Offset = "0x79087A0", VA = "0x1879093A0")]
		public CCLKLKFMCFC(BIEEPEMHOFP LNMEECGDCCD, RenderTexture DOPHDKBFGIH, ImposterRenderConfig PDLMAOHFOOC, CancellationToken LMNHDKIFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7909280", Offset = "0x7908680", VA = "0x187909280")]
		[AsyncStateMachine(typeof(JDEHDILKLDD))]
		private Task<Texture2D> PICOEOCNGLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7909370", Offset = "0x7908770", VA = "0x187909370", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7909200", Offset = "0x7908600", VA = "0x187909200")]
		private static void LDNEDCDOOAN(GameObject PNDAKOKBGIP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OBAJJFPDAKA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x790F160", Offset = "0x790E560", VA = "0x18790F160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA0AFE0", Offset = "0xA0A3E0", VA = "0x180A0AFE0", Slot = "5")]
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
	[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private FLCBNCFNCGL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GEDEHNCPDHB("size", FLCBNCFNCGL.Custom)]
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
	private static int MEIBNDCKBFL;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture LBCKNEKGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HDEAEPJAHFL<GameObject> JLLMJCGNHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NAHOFKDLLJE CAFPGICALNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MCOIFPENEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private HLFDOLJKNKL<Texture2D> EAOFHDNOFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BIEEPEMHOFP CDIEBOGLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture HBNHGKPLIBL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int AOLHFMEFCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x790BB90", Offset = "0x790AF90", VA = "0x18790BB90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x790BBE0", Offset = "0x790AFE0", VA = "0x18790BBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KCCEJJDJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x790B190", Offset = "0x790A590", VA = "0x18790B190")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9AA480", Offset = "0x9A9880", VA = "0x1809AA480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BIEEPEMHOFP DMNFDOBLPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA0", Offset = "0x9A8EA0", VA = "0x1809A9AA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x790B700", Offset = "0x790AB00", VA = "0x18790B700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KBMODGHKPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20577B0", Offset = "0x2056BB0", VA = "0x1820577B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HIANFDLOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x790B370", Offset = "0x790A770", VA = "0x18790B370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x790B170", Offset = "0x790A570", VA = "0x18790B170")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x790B610", Offset = "0x790AA10", VA = "0x18790B610")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x790B4B0", Offset = "0x790A8B0", VA = "0x18790B4B0")]
	private void LGBOFOPFHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x790BAB0", Offset = "0x790AEB0", VA = "0x18790BAB0")]
	public void Set(BIEEPEMHOFP NABANMIHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x790BAA0", Offset = "0x790AEA0", VA = "0x18790BAA0")]
	public void Set(Texture NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x790BA60", Offset = "0x790AE60", VA = "0x18790BA60")]
	public void Set(DKOCAGCPBGD FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x790B180", Offset = "0x790A580", VA = "0x18790B180")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x790B870", Offset = "0x790AC70", VA = "0x18790B870")]
	public void SetInternal(BIEEPEMHOFP NABANMIHMLP, [Optional] Texture BJANODBDIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x790B860", Offset = "0x790AC60", VA = "0x18790B860")]
	public void SetCustomSize(int EIJPHJKKCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9B01C0", Offset = "0x9AF5C0", VA = "0x1809B01C0")]
	public void SetAntiAliasing(int PIADLMDIELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x790B400", Offset = "0x790A800", VA = "0x18790B400")]
	[AsyncStateMachine(typeof(OBAJJFPDAKA))]
	private void INKABCEMMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x790B530", Offset = "0x790A930", VA = "0x18790B530")]
	private void ODEMBLEPPCP(Texture NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x790BB10", Offset = "0x790AF10", VA = "0x18790BB10")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HGDMKAFPLPL
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float OBLJLCJJDIO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "4")]
	public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x790B130", Offset = "0x790A530", VA = "0x18790B130")]
	public void SetReferencePoint(Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x790AF40", Offset = "0x790A340", VA = "0x18790AF40")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x790B110", Offset = "0x790A510", VA = "0x18790B110")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1D33E60", Offset = "0x1D33260", VA = "0x181D33E60")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CHNKHFELLDB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static CHNKHFELLDB KKKGLDMPEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float BIMFKNNKBID;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28614B0", Offset = "0x28608B0", VA = "0x1828614B0")]
	public CHNKHFELLDB(float PGFMOLFEBII)
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
		[Cpp2IlInjected.Address(RVA = "0x7910B00", Offset = "0x790FF00", VA = "0x187910B00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int BJDCHMKPKFA = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int MFLHJJBCANA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> OGHEKHECOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool DAKIMEPLEMG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x790BDF0", Offset = "0x790B1F0", VA = "0x18790BDF0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x790BCF0", Offset = "0x790B0F0", VA = "0x18790BCF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x790C030", Offset = "0x790B430", VA = "0x18790C030")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BIEEPEMHOFP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OLJAFNJIMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CHNKHFELLDB CHNKHFELLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BOBMECIFNLI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> APILBLOGIPO(CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MJAMNHJEFNG(BIEEPEMHOFP KNCKFHOKGJM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAJINPFIEBG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NMFBCDGFKJF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KCIFBFJDLOM(uint? JMFCDPJEHDA, [Out] HLFDOLJKNKL<Texture2D> GAHIBOHJBAI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DGPFJIPMANF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x79096F0", Offset = "0x7908AF0", VA = "0x1879096F0")]
	public static bool COMMMIGCJCH(BIEEPEMHOFP NOOFJAMMMJB, BIEEPEMHOFP BMAEPJCBAEF)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, HGDMKAFPLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79095A0", Offset = "0x79089A0", VA = "0x1879095A0", Slot = "4")]
		public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HGDMKAFPLPL
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IMENAFMICLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NILCCMNAPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NLPAPKBJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ABHBFOJBDNO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLPKAGIBGEM(params Type[] NDFGOFPJBFP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T FDPOMBFLONA<T>(T BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLKIFJNPAEM : IDisposable, ABHBFOJBDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> KPPHNHONKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> ADILCEBDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform HHCHHHKHNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> EOPICIEKFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IEMJNJDBDHN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x790FCB0", Offset = "0x790F0B0", VA = "0x18790FCB0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	public static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7910410", Offset = "0x790F810", VA = "0x187910410")]
	[UnityEngine.Scripting.Preserve]
	public PLKIFJNPAEM([CMKKAFOAFJE(null)] IMENAFMICLO MDEIGAFFECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x790FAB0", Offset = "0x790EEB0", VA = "0x18790FAB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7910250", Offset = "0x790F650", VA = "0x187910250", Slot = "5")]
	public void JLPKAGIBGEM(params Type[] NDFGOFPJBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x790FC20", Offset = "0x790F020", VA = "0x18790FC20", Slot = "6")]
	public GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x38264E0", Offset = "0x38258E0", VA = "0x1838264E0", Slot = "7")]
	public T FDPOMBFLONA<T>(T BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3825F10", Offset = "0x3825310", VA = "0x183825F10", Slot = "8")]
	public T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x790FB90", Offset = "0x790EF90", VA = "0x18790FB90", Slot = "9")]
	public GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3825EB0", Offset = "0x38252B0", VA = "0x183825EB0", Slot = "10")]
	public T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3825F60", Offset = "0x3825360", VA = "0x183825F60")]
	private T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG, [Out] GameObject LOFOGOBKNJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3826570", Offset = "0x3825970", VA = "0x183826570")]
	private T MNKKEOFCCIK<T>(GameObject GIIGFIAPGGB, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x790F9A0", Offset = "0x790EDA0", VA = "0x18790F9A0")]
	private void CICHCIFLLEN(Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x790FDA0", Offset = "0x790F1A0", VA = "0x18790FDA0")]
	private void FNMKPIMLFOM(Component DMJKAPFLGHP, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG, bool NFKOPDMBDCP, [Optional] Type KLMFHEBOCCM, [Optional] Type GEOAIGNHAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79102A0", Offset = "0x790F6A0", VA = "0x1879102A0")]
	private void MIFHJEMANPI(GameObject GIIGFIAPGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KCCEJGEPMPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> AAEACJIONOA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x36B9D50", Offset = "0x36B9150", VA = "0x1836B9D50")]
	public KCCEJGEPMPJ JFGGMENNDNP<T>(T INNDGAPKKHI)
	{
		return default(KCCEJGEPMPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x36B9C40", Offset = "0x36B9040", VA = "0x1836B9C40")]
	public T IOLMGDEDCOJ<T>(T PFCPDJEHNAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36B9470", Offset = "0x36B8870", VA = "0x1836B9470")]
	public bool GLKKFIAAGGI<T>([Out] T INNDGAPKKHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ECILOAOOHEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GPPFEGBNKNB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28634A0", Offset = "0x28628A0", VA = "0x1828634A0")]
	public ECILOAOOHEM(bool EHLJJJNHIDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NOJJGLNMCKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool CLENBNHPCAN;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x790F150", Offset = "0x790E550", VA = "0x18790F150")]
	public NOJJGLNMCKF(bool BOEBFAAHCEN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, HGDMKAFPLPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7910850", Offset = "0x790FC50", VA = "0x187910850", Slot = "4")]
		public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
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
		public Bounds HGCJMPOJDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x790ADB0", Offset = "0x790A1B0", VA = "0x18790ADB0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x790AD70", Offset = "0x790A170", VA = "0x18790AD70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x790AD30", Offset = "0x790A130", VA = "0x18790AD30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x790AC40", Offset = "0x790A040", VA = "0x18790AC40")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
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
				[Cpp2IlInjected.Address(RVA = "0x790F0C0", Offset = "0x790E4C0", VA = "0x18790F0C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x790F0B0", Offset = "0x790E4B0", VA = "0x18790F0B0")]
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
		[GEDEHNCPDHB("frameCameraToImposterBounds", true)]
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
		[GEDEHNCPDHB("autoRotateYawImposter", true)]
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
		[Cpp2IlInjected.Address(RVA = "0x790BC50", Offset = "0x790B050", VA = "0x18790BC50")]
		public void GFBPNJHOBGF(Vector3 FDFIPAIMCCP, Quaternion FPFMICHCPBI, float EBEBDCDJABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x790BC80", Offset = "0x790B080", VA = "0x18790BC80")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KBACPMIMDLP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 FAFOJLEAFGI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> ODBJKBGFJHP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> DMJOGPFDGBO;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera LJEBKBJNCKJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> MOAKIMLOHKN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> DMGGDBJAJLI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode HIPHCBKLGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color OMNPIMODHLO;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color HMFJAOIMHIO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color LNIPFKBAPFO;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap FGPBMMOEKML;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool PAIHNBFLFDI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> JCOADDMCFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x790ED70", Offset = "0x790E170", VA = "0x18790ED70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> EKECCKOKIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x790E8E0", Offset = "0x790DCE0", VA = "0x18790E8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera PDHHGAJOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x790CAD0", Offset = "0x790BED0", VA = "0x18790CAD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x790E930", Offset = "0x790DD30", VA = "0x18790E930")]
	public static void KIAHKEPOEGB(Vector3 DGBIOIGCHBF, Quaternion LKBDCNJJEGA, ImposterRenderConfig HBCJLCDHCFK, bool BBKHEAMIMGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x790E5C0", Offset = "0x790D9C0", VA = "0x18790E5C0")]
	private static void HNGJHGJNINO(Vector3 DGBIOIGCHBF, Quaternion LKBDCNJJEGA, URPLight HEIIFBLIAPP, ImposterRenderConfig.LightConfig CKJPKKECDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x790EDC0", Offset = "0x790E1C0", VA = "0x18790EDC0")]
	public static void OODILAGEAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x790CD00", Offset = "0x790C100", VA = "0x18790CD00")]
	private static void BNOADABKIPF(int BGPINMEIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x790C920", Offset = "0x790BD20", VA = "0x18790C920")]
	public static void ADEMBBMPGJD(ImposterRenderConfig HBCJLCDHCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x790EC90", Offset = "0x790E090", VA = "0x18790EC90")]
	public static void LAPPBKPACCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x790E280", Offset = "0x790D680", VA = "0x18790E280")]
	public static void GIHFMNKLGDM(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, [Optional] Vector3? MFLKAAGLCOL, [Optional] Vector3? OOMLDDBDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x790D8E0", Offset = "0x790CCE0", VA = "0x18790D8E0")]
	private static void EFPHBEGMECA(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, Vector3 MFLKAAGLCOL, Vector3 OOMLDDBDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x790D620", Offset = "0x790CA20", VA = "0x18790D620")]
	private static void DECFOGDAPGI(GameObject LFDKBOCHELG, Vector3 MCKONINIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x790DF10", Offset = "0x790D310", VA = "0x18790DF10")]
	public static void FAFNNCOJOIJ(Bounds FAAIAONLEMA, ImposterRenderConfig HBCJLCDHCFK, [Out] Vector3 KMGMFLHJNJG, [Out] Quaternion KINPHKJCPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x790D110", Offset = "0x790C510", VA = "0x18790D110")]
	private static void CAEHIBEOPKD(GameObject BKMONPLIHMM, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, [Out] Vector3 KMGMFLHJNJG, [Out] Quaternion KINPHKJCPDG, [Out] float LKANAJFEDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x790EBC0", Offset = "0x790DFC0", VA = "0x18790EBC0")]
	public static RenderTexture KNMIEICBGJM(int LFKDJGNAENO, int MOCGLJLLGCL, RenderTextureFormat HJPPOILPOFH = RenderTextureFormat.ARGB32, string AJIGOOEKGGG = "[ImposterRendering]Preview")
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
		public struct MJEGDNMONLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NOCDIBGNFAP AOPIMFKAFCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject CODIKEFBDLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture KCCEJJDJNMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig CMNPNEIHEOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CHNKHFELLDB CHNKHFELLDB;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x790F0E0", Offset = "0x790E4E0", VA = "0x18790F0E0")]
			public MJEGDNMONLA(NOCDIBGNFAP MCOJNHGAONG, GameObject PAELMBHMOGC, RenderTexture DOPHDKBFGIH, ImposterRenderConfig PDLMAOHFOOC, CHNKHFELLDB LNBJEEADBMN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static IEPIFCAFPHB<MJEGDNMONLA, RenderTexture> DABPDACNFMG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<MJEGDNMONLA> AHEIIJOFIKE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int NJBGFFCOAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7909C80", Offset = "0x7909080", VA = "0x187909C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7909DA0", Offset = "0x79091A0", VA = "0x187909DA0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, CancellationToken LMNHDKIFBOH, bool CKDGMPOKMBC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x79097D0", Offset = "0x7908BD0", VA = "0x1879097D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7909D10", Offset = "0x7909110", VA = "0x187909D10", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x79099E0", Offset = "0x7908DE0", VA = "0x1879099E0")]
		private static Task<RenderTexture> BLEACDKOEAA(MJEGDNMONLA HONINAAGDNI, CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x790A1A0", Offset = "0x79095A0", VA = "0x18790A1A0")]
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
