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
		[Cpp2IlInjected.Address(RVA = "0xA147A0", Offset = "0xA13BA0", VA = "0x180A147A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BBDE0", Offset = "0x78BB1E0", VA = "0x1878BBDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x78BC1A0", Offset = "0x78BB5A0", VA = "0x1878BC1A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private IEPIFCAFPHB<BGMGJFFBNFA, GameObject> GMCHOKIEMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78BB9A0", Offset = "0x78BADA0", VA = "0x1878BB9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CEGCCEIIFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78BBB00", Offset = "0x78BAF00", VA = "0x1878BBB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78BB7A0", Offset = "0x78BABA0", VA = "0x1878BB7A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78BBD30", Offset = "0x78BB130", VA = "0x1878BBD30", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78BB880", Offset = "0x78BAC80", VA = "0x1878BB880")]
	[AsyncStateMachine(typeof(FHGILOOJLBI))]
	private Task<GameObject> BFMJFKHCJEF(BGMGJFFBNFA LEMIJIIACGB, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78BBB50", Offset = "0x78BAF50", VA = "0x1878BBB50")]
	public Task<GameObject> LoadItemAsync(BIEEPEMHOFP OCINCALDKGJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78BBDA0", Offset = "0x78BB1A0", VA = "0x1878BBDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A3500", Offset = "0x9A2900", VA = "0x1809A3500")]
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
			[Cpp2IlInjected.Address(RVA = "0x78BD6C0", Offset = "0x78BCAC0", VA = "0x1878BD6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x78BDEC0", Offset = "0x78BD2C0", VA = "0x1878BDEC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x78BA720", Offset = "0x78B9B20", VA = "0x1878BA720", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78BA920", Offset = "0x78B9D20", VA = "0x1878BA920")]
		public CCLKLKFMCFC(BIEEPEMHOFP LNMEECGDCCD, RenderTexture DOPHDKBFGIH, ImposterRenderConfig PDLMAOHFOOC, CancellationToken LMNHDKIFBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78BA800", Offset = "0x78B9C00", VA = "0x1878BA800")]
		[AsyncStateMachine(typeof(JDEHDILKLDD))]
		private Task<Texture2D> PICOEOCNGLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78BA8F0", Offset = "0x78B9CF0", VA = "0x1878BA8F0", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x78BA780", Offset = "0x78B9B80", VA = "0x1878BA780")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C0880", Offset = "0x78BFC80", VA = "0x1878C0880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4FB0", Offset = "0x9F43B0", VA = "0x1809F4FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BD180", Offset = "0x78BC580", VA = "0x1878BD180")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78BD1D0", Offset = "0x78BC5D0", VA = "0x1878BD1D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture KCCEJJDJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78BC760", Offset = "0x78BBB60", VA = "0x1878BC760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9944B0", Offset = "0x9938B0", VA = "0x1809944B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BIEEPEMHOFP DMNFDOBLPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x993AB0", Offset = "0x992EB0", VA = "0x180993AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x78BCCE0", Offset = "0x78BC0E0", VA = "0x1878BCCE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KBMODGHKPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x204BF40", Offset = "0x204B340", VA = "0x18204BF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int HIANFDLOBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x78BC940", Offset = "0x78BBD40", VA = "0x1878BC940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x78BC740", Offset = "0x78BBB40", VA = "0x1878BC740")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x78BCBF0", Offset = "0x78BBFF0", VA = "0x1878BCBF0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x78BCA90", Offset = "0x78BBE90", VA = "0x1878BCA90")]
	private void LGBOFOPFHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x78BD0A0", Offset = "0x78BC4A0", VA = "0x1878BD0A0")]
	public void Set(BIEEPEMHOFP NABANMIHMLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x78BD090", Offset = "0x78BC490", VA = "0x1878BD090")]
	public void Set(Texture NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x78BD050", Offset = "0x78BC450", VA = "0x1878BD050")]
	public void Set(DKOCAGCPBGD FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x78BC750", Offset = "0x78BBB50", VA = "0x1878BC750")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x78BCE50", Offset = "0x78BC250", VA = "0x1878BCE50")]
	public void SetInternal(BIEEPEMHOFP NABANMIHMLP, [Optional] Texture BJANODBDIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x78BCE40", Offset = "0x78BC240", VA = "0x1878BCE40")]
	public void SetCustomSize(int EIJPHJKKCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x99A280", Offset = "0x999680", VA = "0x18099A280")]
	public void SetAntiAliasing(int PIADLMDIELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x78BC9E0", Offset = "0x78BBDE0", VA = "0x1878BC9E0")]
	[AsyncStateMachine(typeof(OBAJJFPDAKA))]
	private void INKABCEMMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78BCB10", Offset = "0x78BBF10", VA = "0x1878BCB10")]
	private void ODEMBLEPPCP(Texture NPCKAAANCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x78BD100", Offset = "0x78BC500", VA = "0x1878BD100")]
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
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x78BC700", Offset = "0x78BBB00", VA = "0x1878BC700")]
	public void SetReferencePoint(Vector3 MABKBAPDDLM, Quaternion NHANCIDGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x78BC510", Offset = "0x78BB910", VA = "0x1878BC510")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78BC6E0", Offset = "0x78BBAE0", VA = "0x1878BC6E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1D22BB0", Offset = "0x1D21FB0", VA = "0x181D22BB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2860350", Offset = "0x285F750", VA = "0x182860350")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C2250", Offset = "0x78C1650", VA = "0x1878C2250", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BD3F0", Offset = "0x78BC7F0", VA = "0x1878BD3F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78BD2F0", Offset = "0x78BC6F0", VA = "0x1878BD2F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78BD630", Offset = "0x78BCA30", VA = "0x1878BD630")]
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
	[Cpp2IlInjected.Address(RVA = "0x78BAC70", Offset = "0x78BA070", VA = "0x1878BAC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BAB20", Offset = "0x78B9F20", VA = "0x1878BAB20", Slot = "4")]
		public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x78C13E0", Offset = "0x78C07E0", VA = "0x1878C13E0")]
	[NOCPMGCIOME.CBODKAAMPCM]
	public static void FJKHLPMEJLC(DHLGDCALOEP NKMJDOBLHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x78C1B50", Offset = "0x78C0F50", VA = "0x1878C1B50")]
	[UnityEngine.Scripting.Preserve]
	public PLKIFJNPAEM([CMKKAFOAFJE(null)] IMENAFMICLO MDEIGAFFECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78C11E0", Offset = "0x78C05E0", VA = "0x1878C11E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x78C1990", Offset = "0x78C0D90", VA = "0x1878C1990", Slot = "5")]
	public void JLPKAGIBGEM(params Type[] NDFGOFPJBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x78C1350", Offset = "0x78C0750", VA = "0x1878C1350", Slot = "6")]
	public GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3812D90", Offset = "0x3812190", VA = "0x183812D90", Slot = "7")]
	public T FDPOMBFLONA<T>(T BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3812770", Offset = "0x3811B70", VA = "0x183812770", Slot = "8")]
	public T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, bool APHJJEBAELG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x78C12C0", Offset = "0x78C06C0", VA = "0x1878C12C0", Slot = "9")]
	public GameObject FDPOMBFLONA(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3812710", Offset = "0x3811B10", VA = "0x183812710", Slot = "10")]
	public T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x38127C0", Offset = "0x3811BC0", VA = "0x1838127C0")]
	private T FDPOMBFLONA<T>(GameObject BKMONPLIHMM, Transform KLDFHLFOOFN, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG, [Out] GameObject LOFOGOBKNJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3812E20", Offset = "0x3812220", VA = "0x183812E20")]
	private T MNKKEOFCCIK<T>(GameObject GIIGFIAPGGB, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x78C10D0", Offset = "0x78C04D0", VA = "0x1878C10D0")]
	private void CICHCIFLLEN(Component DMJKAPFLGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78C14E0", Offset = "0x78C08E0", VA = "0x1878C14E0")]
	private void FNMKPIMLFOM(Component DMJKAPFLGHP, KCCEJGEPMPJ MHBNBGGMEBA, bool APHJJEBAELG, bool NFKOPDMBDCP, [Optional] Type KLMFHEBOCCM, [Optional] Type GEOAIGNHAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x78C19E0", Offset = "0x78C0DE0", VA = "0x1878C19E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x36A6CC0", Offset = "0x36A60C0", VA = "0x1836A6CC0")]
	public KCCEJGEPMPJ JFGGMENNDNP<T>(T INNDGAPKKHI)
	{
		return default(KCCEJGEPMPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x36A6BB0", Offset = "0x36A5FB0", VA = "0x1836A6BB0")]
	public T IOLMGDEDCOJ<T>(T PFCPDJEHNAP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x36A63E0", Offset = "0x36A57E0", VA = "0x1836A63E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2862360", Offset = "0x2861760", VA = "0x182862360")]
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
	[Cpp2IlInjected.Address(RVA = "0x78C0870", Offset = "0x78BFC70", VA = "0x1878C0870")]
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
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C1F90", Offset = "0x78C1390", VA = "0x1878C1F90", Slot = "4")]
		public void PrepareImposter(KCCEJGEPMPJ MHBNBGGMEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x78BC380", Offset = "0x78BB780", VA = "0x1878BC380")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x78BC340", Offset = "0x78BB740", VA = "0x1878BC340")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x78BC300", Offset = "0x78BB700", VA = "0x1878BC300")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x78BC210", Offset = "0x78BB610", VA = "0x1878BC210")]
		private void OBFEEOBGEAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x78C07E0", Offset = "0x78BFBE0", VA = "0x1878C07E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x78C07D0", Offset = "0x78BFBD0", VA = "0x1878C07D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78BD250", Offset = "0x78BC650", VA = "0x1878BD250")]
		public void GFBPNJHOBGF(Vector3 FDFIPAIMCCP, Quaternion FPFMICHCPBI, float EBEBDCDJABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x78BD280", Offset = "0x78BC680", VA = "0x1878BD280")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C0470", Offset = "0x78BF870", VA = "0x1878C0470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> EKECCKOKIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x78BFFC0", Offset = "0x78BF3C0", VA = "0x1878BFFC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera PDHHGAJOEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78BE100", Offset = "0x78BD500", VA = "0x1878BE100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x78C0010", Offset = "0x78BF410", VA = "0x1878C0010")]
	public static void KIAHKEPOEGB(Vector3 DGBIOIGCHBF, Quaternion LKBDCNJJEGA, ImposterRenderConfig HBCJLCDHCFK, bool BBKHEAMIMGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78BFCA0", Offset = "0x78BF0A0", VA = "0x1878BFCA0")]
	private static void HNGJHGJNINO(Vector3 DGBIOIGCHBF, Quaternion LKBDCNJJEGA, URPLight HEIIFBLIAPP, ImposterRenderConfig.LightConfig CKJPKKECDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x78C04C0", Offset = "0x78BF8C0", VA = "0x1878C04C0")]
	public static void OODILAGEAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x78BE350", Offset = "0x78BD750", VA = "0x1878BE350")]
	private static void BNOADABKIPF(int BGPINMEIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x78BDF30", Offset = "0x78BD330", VA = "0x1878BDF30")]
	public static void ADEMBBMPGJD(ImposterRenderConfig HBCJLCDHCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x78C0380", Offset = "0x78BF780", VA = "0x1878C0380")]
	public static void LAPPBKPACCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x78BF960", Offset = "0x78BED60", VA = "0x1878BF960")]
	public static void GIHFMNKLGDM(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, [Optional] Vector3? MFLKAAGLCOL, [Optional] Vector3? OOMLDDBDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x78BEF90", Offset = "0x78BE390", VA = "0x1878BEF90")]
	private static void EFPHBEGMECA(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, Vector3 MFLKAAGLCOL, Vector3 OOMLDDBDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x78BECB0", Offset = "0x78BE0B0", VA = "0x1878BECB0")]
	private static void DECFOGDAPGI(GameObject LFDKBOCHELG, Vector3 MCKONINIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x78BF5F0", Offset = "0x78BE9F0", VA = "0x1878BF5F0")]
	public static void FAFNNCOJOIJ(Bounds FAAIAONLEMA, ImposterRenderConfig HBCJLCDHCFK, [Out] Vector3 KMGMFLHJNJG, [Out] Quaternion KINPHKJCPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x78BE780", Offset = "0x78BDB80", VA = "0x1878BE780")]
	private static void CAEHIBEOPKD(GameObject BKMONPLIHMM, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, [Out] Vector3 KMGMFLHJNJG, [Out] Quaternion KINPHKJCPDG, [Out] float LKANAJFEDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x78C02B0", Offset = "0x78BF6B0", VA = "0x1878C02B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x78C0800", Offset = "0x78BFC00", VA = "0x1878C0800")]
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
			[Cpp2IlInjected.Address(RVA = "0x78BB210", Offset = "0x78BA610", VA = "0x1878BB210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x78BB340", Offset = "0x78BA740", VA = "0x1878BB340")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LFDKBOCHELG, RenderTexture DOPHDKBFGIH, ImposterRenderConfig HBCJLCDHCFK, CHNKHFELLDB LNBJEEADBMN, CancellationToken LMNHDKIFBOH, bool CKDGMPOKMBC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x78BAD60", Offset = "0x78BA160", VA = "0x1878BAD60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x78BB2A0", Offset = "0x78BA6A0", VA = "0x1878BB2A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x78BAF70", Offset = "0x78BA370", VA = "0x1878BAF70")]
		private static Task<RenderTexture> BLEACDKOEAA(MJEGDNMONLA HONINAAGDNI, CancellationToken LMNHDKIFBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x78BB760", Offset = "0x78BAB60", VA = "0x1878BB760")]
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
