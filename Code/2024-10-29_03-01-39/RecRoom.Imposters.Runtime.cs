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
	private readonly struct BKFNFJMNFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BCLIKHPCNCC KEBCKADOMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string NJGIKIMFGFL;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
		public BKFNFJMNFKF(BCLIKHPCNCC OACEBCNNKMA, string BHEDEEKHNIF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DFKKBAPIKFJ : IAsyncStateMachine
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
		public BKFNFJMNFKF queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7F00", Offset = "0x6ED6F00", VA = "0x186ED7F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED82C0", Offset = "0x6ED72C0", VA = "0x186ED82C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider AKFOAKJLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GEBPGCJFELG<BKFNFJMNFKF, GameObject> LAODNGAOAOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ONGELHEFDID JMOMEJJDLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B5690", VA = "0x1808B6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GEBPGCJFELG<BKFNFJMNFKF, GameObject> ICMDFMLIPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8F90", Offset = "0x6ED7F90", VA = "0x186ED8F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KKIAGMJJGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8D40", Offset = "0x6ED7D40", VA = "0x186ED8D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8D90", Offset = "0x6ED7D90", VA = "0x186ED8D90", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6ED92C0", Offset = "0x6ED82C0", VA = "0x186ED92C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6ED8E70", Offset = "0x6ED7E70", VA = "0x186ED8E70")]
	[AsyncStateMachine(typeof(DFKKBAPIKFJ))]
	private Task<GameObject> BGEEPAAEOCK(BKFNFJMNFKF DCCHJOCHEFL, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6ED90F0", Offset = "0x6ED80F0", VA = "0x186ED90F0")]
	public Task<GameObject> LoadItemAsync(BCLIKHPCNCC OACEBCNNKMA, CancellationToken CLIKNEKJHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9330", Offset = "0x6ED8330", VA = "0x186ED9330")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class FMCEGBMMGLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BCLIKHPCNCC DLMLCCHEHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HKBDFPPGPLA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
		public FMCEGBMMGLO(BCLIKHPCNCC DMBDLFCGMOG, Texture JKGKKEHABOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum IPKJIHGIALJ
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
	private class LMBFLEFEPOC : DGEDOOCBMOL<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct GFBOEMGFEKI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LMBFLEFEPOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6ED93B0", Offset = "0x6ED83B0", VA = "0x186ED93B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6ED9BA0", Offset = "0x6ED8BA0", VA = "0x186ED9BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BCLIKHPCNCC DMBDLFCGMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FGKBJGPHADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig CKECJJHHNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken CLIKNEKJHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D NKCAALHEIHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject MHMBIHILIIL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override OBJFFICJNII<Texture2D> JBMDKMDJKJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EDB390", Offset = "0x6EDA390", VA = "0x186EDB390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> LJBGLDHADMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB3F0", Offset = "0x6EDA3F0", VA = "0x186EDB3F0")]
		public LMBFLEFEPOC(BCLIKHPCNCC DMBDLFCGMOG, RenderTexture FGKBJGPHADB, ImposterRenderConfig CKECJJHHNKC, CancellationToken CLIKNEKJHEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB270", Offset = "0x6EDA270", VA = "0x186EDB270")]
		[AsyncStateMachine(typeof(GFBOEMGFEKI))]
		private Task<Texture2D> FBLHDDFLHOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB360", Offset = "0x6EDA360", VA = "0x186EDB360", Slot = "10")]
		protected override void FDFMEFJGFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB1F0", Offset = "0x6EDA1F0", VA = "0x186EDB1F0")]
		private static void ADFKLLOOJAE(GameObject MHMBIHILIIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OCKMNJCGNKL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6EDC4A0", Offset = "0x6EDB4A0", VA = "0x186EDC4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9031A0", Offset = "0x9021A0", VA = "0x1809031A0", Slot = "5")]
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
	[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private IPKJIHGIALJ size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EELAEKFBIFP("size", IPKJIHGIALJ.Custom)]
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
	private static int JDAABFJDBBN;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture AAGPNCPAJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private ODEBOBJILCG<GameObject> MOPPJGDKDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EDMIDDLGGJL HDMNPNMAJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OCGANIIFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private DIHMDMOKEDJ<Texture2D> GANHOLDFJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BCLIKHPCNCC FNEADEPLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FOIMHCNCJCP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int KHMEMIMPKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAB70", Offset = "0x6ED9B70", VA = "0x186EDAB70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6EDABC0", Offset = "0x6ED9BC0", VA = "0x186EDABC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture GPNOCPBCJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA240", Offset = "0x6ED9240", VA = "0x186EDA240")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E20", Offset = "0x8B8E20", VA = "0x1808B9E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BCLIKHPCNCC DLMLCCHEHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B4270", Offset = "0x8B3270", VA = "0x1808B4270")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA5E0", Offset = "0x6ED95E0", VA = "0x186EDA5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KBMDAIKHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B693B0", Offset = "0x1B683B0", VA = "0x181B693B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GJICBJPNJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EDA420", Offset = "0x6ED9420", VA = "0x186EDA420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA220", Offset = "0x6ED9220", VA = "0x186EDA220")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA740", Offset = "0x6ED9740", VA = "0x186EDA740")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA560", Offset = "0x6ED9560", VA = "0x186EDA560")]
	private void KKIJFDCFDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAA90", Offset = "0x6ED9A90", VA = "0x186EDAA90")]
	public void Set(BCLIKHPCNCC PIFGFNHCHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAA80", Offset = "0x6ED9A80", VA = "0x186EDAA80")]
	public void Set(Texture JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAA40", Offset = "0x6ED9A40", VA = "0x186EDAA40")]
	public void Set(FMCEGBMMGLO BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA230", Offset = "0x6ED9230", VA = "0x186EDA230")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA840", Offset = "0x6ED9840", VA = "0x186EDA840")]
	public void SetInternal(BCLIKHPCNCC PIFGFNHCHIK, [Optional] Texture CBCFNOCDHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA830", Offset = "0x6ED9830", VA = "0x186EDA830")]
	public void SetCustomSize(int CJBCFMLBECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8C34A0", Offset = "0x8C24A0", VA = "0x1808C34A0")]
	public void SetAntiAliasing(int PBDEHBBJJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA4B0", Offset = "0x6ED94B0", VA = "0x186EDA4B0")]
	[AsyncStateMachine(typeof(OCKMNJCGNKL))]
	private void JLBLEFDPFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA140", Offset = "0x6ED9140", VA = "0x186EDA140")]
	private void AHEJPFCHIIM(Texture JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EDAAF0", Offset = "0x6ED9AF0", VA = "0x186EDAAF0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, IBCMGCPMGFF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float BMCPBLAIHOJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "4")]
	public void PrepareImposter(NFMLOLOOBIO IEEFMIOJLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA100", Offset = "0x6ED9100", VA = "0x186EDA100")]
	public void SetReferencePoint(Vector3 OFOBLJHNFGM, Quaternion FEOKMKIDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6ED9F10", Offset = "0x6ED8F10", VA = "0x186ED9F10")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EDA0E0", Offset = "0x6ED90E0", VA = "0x186EDA0E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x19C91C0", Offset = "0x19C81C0", VA = "0x1819C91C0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FGEEOCOKOOC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static FGEEOCOKOOC FNAANGBBIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float LLMNJKPKEHP;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24BDD70", Offset = "0x24BCD70", VA = "0x1824BDD70")]
	public FGEEOCOKOOC(float PCKHHKHLLJL)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCF90", Offset = "0x6EDBF90", VA = "0x186EDCF90", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
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
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int JHDCPNFPOGA = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BFGKCEHPEKK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> NKAGFAOKJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool FEHEFOABMGM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EDADC0", Offset = "0x6ED9DC0", VA = "0x186EDADC0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EDACC0", Offset = "0x6ED9CC0", VA = "0x186EDACC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EDB000", Offset = "0x6EDA000", VA = "0x186EDB000")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BCLIKHPCNCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KPKJKJDMEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	FGEEOCOKOOC FGEEOCOKOOC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FJHEMLNKHJG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DECHJKPOHPP(CancellationToken CLIKNEKJHEI);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HKLJHCJJEGO(BCLIKHPCNCC DFABCHNPEEM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJNDMIPOFHA();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EGHLCGEFMMJ();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DICGFPGOCEJ(uint? JMJJCPLAFLM, [Out] DIHMDMOKEDJ<Texture2D> KENKBPOCKPD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JLEDBNHCKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB090", Offset = "0x6EDA090", VA = "0x186EDB090")]
	public static bool POHCNADLHBL(BCLIKHPCNCC BCCMLKPBOPB, BCLIKHPCNCC LDHCHPDONPO)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, IBCMGCPMGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7DA0", Offset = "0x6ED6DA0", VA = "0x186ED7DA0", Slot = "4")]
		public void PrepareImposter(NFMLOLOOBIO IEEFMIOJLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IBCMGCPMGFF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NFMLOLOOBIO IEEFMIOJLFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BKAKICAGFGA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NACHLDPNDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> CFLMOMMPMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ONGELHEFDID
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJLFMODOKIK(params Type[] PJKPOKEEKDH);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OMDFALALPIC(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OMDFALALPIC<T>(T MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OMDFALALPIC<T>(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OMDFALALPIC(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MNADDEDGOCL : IDisposable, ONGELHEFDID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> FFCFJEDEPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> GJDAPDHHNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform KNMJOBDLOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> EBIHBDKHMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JBBJDHLODHD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBE40", Offset = "0x6EDAE40", VA = "0x186EDBE40")]
	[AEDCCIMPEFD.GIGKNHONDJE]
	public static void MKFFGPHAFOG(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EDC060", Offset = "0x6EDB060", VA = "0x186EDC060")]
	[UnityEngine.Scripting.Preserve]
	public MNADDEDGOCL([GAHPILLNNBL(null)] BKAKICAGFGA EJEPMGLCGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBAE0", Offset = "0x6EDAAE0", VA = "0x186EDBAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBA90", Offset = "0x6EDAA90", VA = "0x186EDBA90", Slot = "5")]
	public void CJLFMODOKIK(params Type[] PJKPOKEEKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBFD0", Offset = "0x6EDAFD0", VA = "0x186EDBFD0", Slot = "6")]
	public GameObject OMDFALALPIC(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x308A7C0", Offset = "0x30897C0", VA = "0x18308A7C0", Slot = "7")]
	public T OMDFALALPIC<T>(T MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x308AE30", Offset = "0x3089E30", VA = "0x18308AE30", Slot = "8")]
	public T OMDFALALPIC<T>(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, bool GAMGFKHBFKP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBF40", Offset = "0x6EDAF40", VA = "0x186EDBF40", Slot = "9")]
	public GameObject OMDFALALPIC(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x308ADD0", Offset = "0x3089DD0", VA = "0x18308ADD0", Slot = "10")]
	public T OMDFALALPIC<T>(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x308A850", Offset = "0x3089850", VA = "0x18308A850")]
	private T OMDFALALPIC<T>(GameObject MBJCMFAMEBD, Transform JNLBEALAMNB, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP, [Out] GameObject AAHNEBPAPEJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x308A320", Offset = "0x3089320", VA = "0x18308A320")]
	private T AHBGMOBOAGD<T>(GameObject IEELEEMHGEB, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBD30", Offset = "0x6EDAD30", VA = "0x186EDBD30")]
	private void LDMBIAIFJKH(Component GEICOLLOJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDB5E0", Offset = "0x6EDA5E0", VA = "0x186EDB5E0")]
	private void AADFOOMJPLA(Component GEICOLLOJJK, NFMLOLOOBIO IEEFMIOJLFJ, bool GAMGFKHBFKP, bool CJBGKLJNDNM, [Optional] Type FMJELOCBFLM, [Optional] Type AGDNKMGBGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDBBC0", Offset = "0x6EDABC0", VA = "0x186EDBBC0")]
	private void KIIKJDJPLNI(GameObject IEELEEMHGEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NFMLOLOOBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> JHDAPNIEBHK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x311F060", Offset = "0x311E060", VA = "0x18311F060")]
	public NFMLOLOOBIO NONCGFKLPGD<T>(T MDFACGAGPAC)
	{
		return default(NFMLOLOOBIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x311EF50", Offset = "0x311DF50", VA = "0x18311EF50")]
	public T KIJHOBDIGPJ<T>(T MJBMFFMBOMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x311F790", Offset = "0x311E790", VA = "0x18311F790")]
	public bool OKBNAJGEJDO<T>([Out] T MDFACGAGPAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LMHDIPCBFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool LELFHFOIKKH;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24BC480", Offset = "0x24BB480", VA = "0x1824BC480")]
	public LMHDIPCBFDB(bool AOJAJAACHEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DAPLBOONMBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool GAHKDKCFDAA;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7EF0", Offset = "0x6ED6EF0", VA = "0x186ED7EF0")]
	public DAPLBOONMBK(bool EHEGHELJKIA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, IBCMGCPMGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EDCCE0", Offset = "0x6EDBCE0", VA = "0x186EDCCE0", Slot = "4")]
		public void PrepareImposter(NFMLOLOOBIO IEEFMIOJLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		public Bounds HECPNGLPELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6ED9D80", Offset = "0x6ED8D80", VA = "0x186ED9D80")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9D40", Offset = "0x6ED8D40", VA = "0x186ED9D40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9D00", Offset = "0x6ED8D00", VA = "0x186ED9D00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6ED9C10", Offset = "0x6ED8C10", VA = "0x186ED9C10")]
		private void OPLFPHGJCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
				[Cpp2IlInjected.Address(RVA = "0x6EDB5C0", Offset = "0x6EDA5C0", VA = "0x186EDB5C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6EDB5B0", Offset = "0x6EDA5B0", VA = "0x186EDB5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EDAC30", Offset = "0x6ED9C30", VA = "0x186EDAC30")]
		public void EDMENAMOMPM(Vector3 IHNAEPCNJHJ, Quaternion OAECHPAPKMO, float PNLMPODGKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EDAC60", Offset = "0x6ED9C60", VA = "0x186EDAC60")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CCOOPNNJBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly Vector3 DFPLKBNJDML;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<URPLight> GPCDDMFNHMD;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly List<Light> DEGGABCMAMM;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Camera KPEEGJLIHPC;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<Renderer> JAFJCJLGGIE;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly List<ImposterBoundsOverride> GLFIIHEDABM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static AmbientMode ECPAPPIJDDN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color IIFEHCIKDDD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color DNJHPPOJEHP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Color FKMEKMEEFLP;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static Cubemap LIIPGIFNOOH;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static bool BGKEKFENLEI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> CIJDPLKPFKI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7510", Offset = "0x6ED6510", VA = "0x186ED7510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OGIHPJMADCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6ED70B0", Offset = "0x6ED60B0", VA = "0x186ED70B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera POMFJDJEPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6ED6990", Offset = "0x6ED5990", VA = "0x186ED6990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5840", Offset = "0x6ED4840", VA = "0x186ED5840")]
	public static void CHNICJEDODC(Vector3 KMFLFKHFDJC, Quaternion HNFMJPFKACB, ImposterRenderConfig IDFHMPKHBJG, bool CKFCDDOCCFG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5AD0", Offset = "0x6ED4AD0", VA = "0x186ED5AD0")]
	private static void CMHACNBFKDA(Vector3 KMFLFKHFDJC, Quaternion HNFMJPFKACB, URPLight CICOGPNMBKL, ImposterRenderConfig.LightConfig KPLBIGEGPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6ED68B0", Offset = "0x6ED58B0", VA = "0x186ED68B0")]
	public static void KKIEHIJGAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7100", Offset = "0x6ED6100", VA = "0x186ED7100")]
	private static void OPAKMACOKAO(int CJKCMFNFCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6BC0", Offset = "0x6ED5BC0", VA = "0x186ED6BC0")]
	public static void MNLLKJECDPI(ImposterRenderConfig IDFHMPKHBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6180", Offset = "0x6ED5180", VA = "0x186ED6180")]
	public static void GNCGKPILGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6D70", Offset = "0x6ED5D70", VA = "0x186ED6D70")]
	public static void MPAHFFGBBHL(GameObject OAPKLPIAIOG, RenderTexture FGKBJGPHADB, ImposterRenderConfig IDFHMPKHBJG, FGEEOCOKOOC PBCNABKMFLA, [Optional] Vector3? JKBKNAKGGOK, [Optional] Vector3? NPJHBMOHBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6ED7560", Offset = "0x6ED6560", VA = "0x186ED7560")]
	private static void PFLADEKJLEC(GameObject OAPKLPIAIOG, RenderTexture FGKBJGPHADB, ImposterRenderConfig IDFHMPKHBJG, FGEEOCOKOOC PBCNABKMFLA, Vector3 JKBKNAKGGOK, Vector3 NPJHBMOHBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5EC0", Offset = "0x6ED4EC0", VA = "0x186ED5EC0")]
	private static void DOMDJPEABHG(GameObject OAPKLPIAIOG, Vector3 AHPACGMKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED6260", Offset = "0x6ED5260", VA = "0x186ED6260")]
	private static void KCFFJILHADK(GameObject MBJCMFAMEBD, ImposterRenderConfig IDFHMPKHBJG, FGEEOCOKOOC PBCNABKMFLA, [Out] Vector3 AHJPJONMJFO, [Out] Quaternion LPACCIFEABJ, [Out] float EGCBMCKHKHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED5DF0", Offset = "0x6ED4DF0", VA = "0x186ED5DF0")]
	public static RenderTexture DJEALOPAKLN(int IMBLFJLFJPK, int KJLGCHNIMAK, RenderTextureFormat PKNNBLNOLJP = RenderTextureFormat.ARGB32, string PCPOMJOFBMN = "[ImposterRendering]Preview")
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
		public struct LKLCJPCIEJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public IIAHDMFNNHP BENGLBBECJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GameObject NPKJJHLPCDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public RenderTexture GPNOCPBCJDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ImposterRenderConfig CPEECPEIEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public FGEEOCOKOOC FGEEOCOKOOC;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6EDB180", Offset = "0x6EDA180", VA = "0x186EDB180")]
			public LKLCJPCIEJO(IIAHDMFNNHP CKPIAGAFCGI, GameObject AHPILFMAAEH, RenderTexture FGKBJGPHADB, ImposterRenderConfig CKECJJHHNKC, FGEEOCOKOOC PBCNABKMFLA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static GEBPGCJFELG<LKLCJPCIEJO, RenderTexture> ABNHHACAPNE;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly List<LKLCJPCIEJO> OBKHAMDEPIM;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int JMACHBBCNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6ED87E0", Offset = "0x6ED77E0", VA = "0x186ED87E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8900", Offset = "0x6ED7900", VA = "0x186ED8900")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject OAPKLPIAIOG, RenderTexture FGKBJGPHADB, ImposterRenderConfig IDFHMPKHBJG, FGEEOCOKOOC PBCNABKMFLA, CancellationToken CLIKNEKJHEI, bool MAKOLFEMCEC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8330", Offset = "0x6ED7330", VA = "0x186ED8330", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8870", Offset = "0x6ED7870", VA = "0x186ED8870", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8540", Offset = "0x6ED7540", VA = "0x186ED8540")]
		private static Task<RenderTexture> BOMGDELGBJC(LKLCJPCIEJO NBILGHMOOHK, CancellationToken CLIKNEKJHEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6ED8D00", Offset = "0x6ED7D00", VA = "0x186ED8D00")]
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
