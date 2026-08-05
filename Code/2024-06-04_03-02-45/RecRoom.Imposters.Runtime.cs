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
	private readonly struct CHHGIPCILCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ILFGHKCEEAA EJODJMKELFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DHCMDJCLOOB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
		public CHHGIPCILCA(ILFGHKCEEAA BLDILOHKFLJ, string AKFEKJBHCJF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct KHCMMGCMJJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CHHGIPCILCA queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6878A60", Offset = "0x6877260", VA = "0x186878A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6878E00", Offset = "0x6877600", VA = "0x186878E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider CNBLHOGAAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private INJFFGCPKLN<CHHGIPCILCA, GameObject> NJKLECJBHDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NIIGOPHLDJE MBKDMHHHCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private INJFFGCPKLN<CHHGIPCILCA, GameObject> OILHPJANHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6873C90", Offset = "0x6872490", VA = "0x186873C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KECLPAAHAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6873FD0", Offset = "0x68727D0", VA = "0x186873FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6873AB0", Offset = "0x68722B0", VA = "0x186873AB0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6874020", Offset = "0x6872820", VA = "0x186874020", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872370", VA = "0x186873B70")]
	[AsyncStateMachine(typeof(KHCMMGCMJJE))]
	private Task<GameObject> IHOAOLAAOLI(CHHGIPCILCA FFPIPDBMHBM, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6873DF0", Offset = "0x68725F0", VA = "0x186873DF0")]
	public Task<GameObject> LoadItemAsync(ILFGHKCEEAA BLDILOHKFLJ, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6874090", Offset = "0x6872890", VA = "0x186874090")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HODBJFAIFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ILFGHKCEEAA BLGOOALHEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture EDKIHPBNCCD;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
		public HODBJFAIFCK(ILFGHKCEEAA IKPJKFKHEHK, Texture JHIAEMLCNGK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum BLLHALLPKCP
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
	private class ALPIJGPGDDA : ENCFPIMNNAD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct PLPAIGNNMLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ALPIJGPGDDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68796A0", Offset = "0x6877EA0", VA = "0x1868796A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6879EA0", Offset = "0x68786A0", VA = "0x186879EA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ILFGHKCEEAA IKPJKFKHEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture DIONIANHKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig PCFDPPPFAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken ODNHMAMKFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject NGGCKFFMABA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MOJHALOLCAP<Texture> NLEDEKFNGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6872CA0", Offset = "0x68714A0", VA = "0x186872CA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> DNDGGIIEMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6872D90", Offset = "0x6871590", VA = "0x186872D90")]
		public ALPIJGPGDDA(ILFGHKCEEAA IKPJKFKHEHK, RenderTexture DIONIANHKFP, ImposterRenderConfig PCFDPPPFAAF, CancellationToken ODNHMAMKFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6872BB0", Offset = "0x68713B0", VA = "0x186872BB0")]
		[AsyncStateMachine(typeof(PLPAIGNNMLB))]
		private Task<Texture> BFBDBPMMEOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6872D80", Offset = "0x6871580", VA = "0x186872D80", Slot = "10")]
		protected override void HFGHGPHLEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6872D00", Offset = "0x6871500", VA = "0x186872D00")]
		private static void HCFGELIKGFD(GameObject NGGCKFFMABA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct OLHPCBFEANA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6878EA0", Offset = "0x68776A0", VA = "0x186878EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A33E0", VA = "0x1809A4BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private BLLHALLPKCP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[BLIABGLLHHC("size", BLLHALLPKCP.Custom)]
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
	private static int GHKEAIBHNEJ;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MBNNCKACOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private MMCMKPIFPAL<GameObject> DKDMDMCLICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private PEJDBLFKJJN IKHMLHIFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NPNHNCBGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private MJMNDKPKIPJ<Texture> LBHOKKENJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ILFGHKCEEAA NPPHLMJBMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture JIKOMCGLNGC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MMJLJOKLNEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6878530", Offset = "0x6876D30", VA = "0x186878530")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6878580", Offset = "0x6876D80", VA = "0x186878580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture GBALINJDJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6877D10", Offset = "0x6876510", VA = "0x186877D10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8473A0", Offset = "0x845BA0", VA = "0x1808473A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ILFGHKCEEAA BLGOOALHEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x843FF0", Offset = "0x8427F0", VA = "0x180843FF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6877BB0", Offset = "0x68763B0", VA = "0x186877BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool NOPNDPEADEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1531470", Offset = "0x152FC70", VA = "0x181531470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int OKNIAGCCDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6877B10", Offset = "0x6876310", VA = "0x186877B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6877B00", Offset = "0x6876300", VA = "0x186877B00")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6878100", Offset = "0x6876900", VA = "0x186878100")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6877EF0", Offset = "0x68766F0", VA = "0x186877EF0")]
	private void NONBPGBKLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6878400", Offset = "0x6876C00", VA = "0x186878400")]
	public void Set(ILFGHKCEEAA PIAAMAOOCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6878410", Offset = "0x6876C10", VA = "0x186878410")]
	public void Set(Texture JHIAEMLCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6878420", Offset = "0x6876C20", VA = "0x186878420")]
	public void Set(HODBJFAIFCK IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6877BA0", Offset = "0x68763A0", VA = "0x186877BA0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6878200", Offset = "0x6876A00", VA = "0x186878200")]
	public void SetInternal(ILFGHKCEEAA PIAAMAOOCMN, [Optional] Texture HGGLCLEFGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68781F0", Offset = "0x68769F0", VA = "0x1868781F0")]
	public void SetCustomSize(int JOJEAPKLAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84B750", Offset = "0x849F50", VA = "0x18084B750")]
	public void SetAntiAliasing(int CIPCGJGPNHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6877F70", Offset = "0x6876770", VA = "0x186877F70")]
	[AsyncStateMachine(typeof(OLHPCBFEANA))]
	private void OJMAMKCIHBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6878020", Offset = "0x6876820", VA = "0x186878020")]
	private void OLJPLFDFHAJ(Texture JHIAEMLCNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68784B0", Offset = "0x6876CB0", VA = "0x1868784B0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, MPLEGBKCLPO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float GJBMMJABCLI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void PrepareImposter(KONNHGLCLAF EKJGIMBPPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6877AC0", Offset = "0x68762C0", VA = "0x186877AC0")]
	public void SetReferencePoint(Vector3 KKDCNJKFOII, Quaternion HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68778D0", Offset = "0x68760D0", VA = "0x1868778D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6877AA0", Offset = "0x68762A0", VA = "0x186877AA0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15A6D20", Offset = "0x15A5520", VA = "0x1815A6D20")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct EIJGOMMIEMB
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static EIJGOMMIEMB IOOLCGGJPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float BOJOHCHMDIE;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x20E8C40", Offset = "0x20E7440", VA = "0x1820E8C40")]
	public EIJGOMMIEMB(float CAFDAIDKMCH)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int EAFNELMOFGG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int CPEIJICELCE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> PMMNIPILDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HLCPECEAFDL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6878780", Offset = "0x6876F80", VA = "0x186878780")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6878680", Offset = "0x6876E80", VA = "0x186878680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68789D0", Offset = "0x68771D0", VA = "0x1868789D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ILFGHKCEEAA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string MEKILOPHFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EIJGOMMIEMB EIJGOMMIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ACCNJMFOKNN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> LIHOACFLHGK(CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKPOJIILGHK(ILFGHKCEEAA OGFCKBADKBE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPFFNOIGNDC();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHFENMBLONP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HFKAMEAFMIG([Out] MJMNDKPKIPJ<Texture> OEAGJBDFMEK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BOGLDGFPODB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6872F50", Offset = "0x6871750", VA = "0x186872F50")]
	public static bool KEHMCBBHNNL(ILFGHKCEEAA JMLHDMBNJLA, ILFGHKCEEAA BHMDEFEBKJC)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, MPLEGBKCLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6873040", Offset = "0x6871840", VA = "0x186873040", Slot = "4")]
		public void PrepareImposter(KONNHGLCLAF EKJGIMBPPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MPLEGBKCLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KONNHGLCLAF EKJGIMBPPBA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OLEBEEDFODO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> CMMMIMKKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GINOEJFACLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NIIGOPHLDJE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBKNHKMKIFA(params Type[] DHGCKNFJOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject PDKBPFBGGHC(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PDKBPFBGGHC<T>(T OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PDKBPFBGGHC<T>(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject PDKBPFBGGHC(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FPPDDDINIAK : IDisposable, NIIGOPHLDJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> ADPLBEFCDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> BLNNJAJLGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform FPLLDJHFOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> MAAMLDECPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GMDMBKCCKCG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6874110", Offset = "0x6872910", VA = "0x186874110")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	public static void DCCJADFNLLG(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6874BA0", Offset = "0x68733A0", VA = "0x186874BA0")]
	[Preserve]
	public FPPDDDINIAK([GNKLNMHODGG(null)] OLEBEEDFODO BEGDIDNOLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6874210", Offset = "0x6872A10", VA = "0x186874210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6874A30", Offset = "0x6873230", VA = "0x186874A30", Slot = "5")]
	public void NBKNHKMKIFA(params Type[] DHGCKNFJOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6874A80", Offset = "0x6873280", VA = "0x186874A80", Slot = "6")]
	public GameObject PDKBPFBGGHC(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A81380", Offset = "0x2A7FB80", VA = "0x182A81380", Slot = "7")]
	public T PDKBPFBGGHC<T>(T OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A81410", Offset = "0x2A7FC10", VA = "0x182A81410", Slot = "8")]
	public T PDKBPFBGGHC<T>(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, bool OEPFIKKBCEN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6874B10", Offset = "0x6873310", VA = "0x186874B10", Slot = "9")]
	public GameObject PDKBPFBGGHC(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A80DA0", Offset = "0x2A7F5A0", VA = "0x182A80DA0", Slot = "10")]
	public T PDKBPFBGGHC<T>(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A80E00", Offset = "0x2A7F600", VA = "0x182A80E00")]
	private T PDKBPFBGGHC<T>(GameObject OFMCNHNFFAE, Transform GGJNHHDMGON, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN, [Out] GameObject PHGIIPIDGGK) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A80900", Offset = "0x2A7F100", VA = "0x182A80900")]
	private T NMDBPDCGCIJ<T>(GameObject DLBGNHFNDNP, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6874920", Offset = "0x6873120", VA = "0x186874920")]
	private void LACFDMCFPNC(Component KFMACDKHBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68742F0", Offset = "0x6872AF0", VA = "0x1868742F0")]
	private void FJBAFHHMPCM(Component KFMACDKHBNH, KONNHGLCLAF EKJGIMBPPBA, bool OEPFIKKBCEN, bool GKMHJPBMCLJ, [Optional] Type HBPONDHOEOB, [Optional] Type OFBGOBPCNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68747B0", Offset = "0x6872FB0", VA = "0x1868747B0")]
	private void KJJPIDGHIML(GameObject DLBGNHFNDNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KONNHGLCLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> FKOPNIPNOGP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B2CF20", Offset = "0x2B2B720", VA = "0x182B2CF20")]
	public KONNHGLCLAF KAMKODPJIMO<T>(T JKGMLJEOOBJ)
	{
		return default(KONNHGLCLAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D650", Offset = "0x2B2BE50", VA = "0x182B2D650")]
	public T NBGKOOJKKKA<T>(T HLCNDDGKJJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2C740", Offset = "0x2B2AF40", VA = "0x182B2C740")]
	public bool GIPAEIFMNNK<T>([Out] T JKGMLJEOOBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FBCJLKHBJEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool EGOKENCGPOP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xDCDC00", Offset = "0xDCC400", VA = "0x180DCDC00")]
	public FBCJLKHBJEP(bool GGFBHEOCBHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GHKLNEMLENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LOKAIJOBLNB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68775C0", Offset = "0x6875DC0", VA = "0x1868775C0")]
	public GHKLNEMLENC(bool IFDMFMCPCHC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, MPLEGBKCLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6879F10", Offset = "0x6878710", VA = "0x186879F10", Slot = "4")]
		public void PrepareImposter(KONNHGLCLAF EKJGIMBPPBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds NGLIPOJKNBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6877740", Offset = "0x6875F40", VA = "0x186877740")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6877700", Offset = "0x6875F00", VA = "0x186877700")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68776C0", Offset = "0x6875EC0", VA = "0x1868776C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68775D0", Offset = "0x6875DD0", VA = "0x1868775D0")]
		private void LLGHLEHEJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x6878E80", Offset = "0x6877680", VA = "0x186878E80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6878E70", Offset = "0x6877670", VA = "0x186878E70")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68785F0", Offset = "0x6876DF0", VA = "0x1868785F0")]
		public void GNGCBJLMGGC(Vector3 BOOOMFONEAG, Quaternion FAKJGOGNAJI, float OLDEABNOFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6878620", Offset = "0x6876E20", VA = "0x186878620")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GBMLLKCCOOH
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 AHOLNDKMEDN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> PJAGFKICGGC;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> HJKIEDINAPC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera DLDEJFBENGL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> JMOPCBOBMPG;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> OGKCHLJGJOL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode DPHBABLDGLD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color DHLGDBCFICJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color GADILIALNBK;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color DCCCIBPBLNB;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap DKNMFFOJALG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool DNBNFDNOGOJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> NDOMKIJJPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6876FD0", Offset = "0x68757D0", VA = "0x186876FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> AENHGGMOFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68764E0", Offset = "0x6874CE0", VA = "0x1868764E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LIAIEKGIBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6876CC0", Offset = "0x68754C0", VA = "0x186876CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6876A30", Offset = "0x6875230", VA = "0x186876A30")]
	public static void KJBHKALAHGN(Vector3 GABGGOCHDIC, Quaternion HBDGGBJHBEM, ImposterRenderConfig NJBACFGJEIF, bool GNDOMMLJENF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6877020", Offset = "0x6875820", VA = "0x186877020")]
	private static void PDEMLKEBBIP(Vector3 GABGGOCHDIC, Quaternion HBDGGBJHBEM, URPLight AMDNLLPMFJC, ImposterRenderConfig.LightConfig LHBBACKDHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6876EF0", Offset = "0x68756F0", VA = "0x186876EF0")]
	public static void MALOKFOHKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6876530", Offset = "0x6874D30", VA = "0x186876530")]
	private static void HMKOJKKOLOP(int CNPKMCNMCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68756B0", Offset = "0x6873EB0", VA = "0x1868756B0")]
	public static void CLMEPFNBFHJ(ImposterRenderConfig NJBACFGJEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6876950", Offset = "0x6875150", VA = "0x186876950")]
	public static void IBKLHKPHEIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6874FE0", Offset = "0x68737E0", VA = "0x186874FE0")]
	public static void CANDPHFCNHK(GameObject KLMJFBDKIMA, RenderTexture DIONIANHKFP, ImposterRenderConfig NJBACFGJEIF, EIJGOMMIEMB KAFPJCNHEHK, [Optional] Vector3? FIGIDMPDDEH, [Optional] Vector3? LMMAPBKALIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6875EB0", Offset = "0x68746B0", VA = "0x186875EB0")]
	private static void DPDCPPOLFML(GameObject KLMJFBDKIMA, RenderTexture DIONIANHKFP, ImposterRenderConfig NJBACFGJEIF, EIJGOMMIEMB KAFPJCNHEHK, Vector3 FIGIDMPDDEH, Vector3 LMMAPBKALIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68753F0", Offset = "0x6873BF0", VA = "0x1868753F0")]
	private static void CIDMFECCEJL(GameObject KLMJFBDKIMA, Vector3 NPABHEJGIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6875860", Offset = "0x6874060", VA = "0x186875860")]
	private static void DFAIIABKMFA(GameObject OFMCNHNFFAE, ImposterRenderConfig NJBACFGJEIF, EIJGOMMIEMB KAFPJCNHEHK, [Out] Vector3 OLKBIPMAPCA, [Out] Quaternion CALGHMEEEAI, [Out] float POBIDCDBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6875320", Offset = "0x6873B20", VA = "0x186875320")]
	public static RenderTexture CBLGEECDOAP(int OIMODFKJOJM, int HNDAFEMONEJ, RenderTextureFormat NFAJBIAKHPK = RenderTextureFormat.ARGB32, string EDCCCHLMFOI = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct GCCLPILKHFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EJKPJGCLKPC PINNCAELMIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject PAICHEAJOFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture GBALINJDJKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig NKPHNHOHKBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public EIJGOMMIEMB EIJGOMMIEMB;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6877550", Offset = "0x6875D50", VA = "0x186877550")]
			public GCCLPILKHFL(EJKPJGCLKPC KKMFDNKGMPB, GameObject EMPDHCKAHOM, RenderTexture DIONIANHKFP, ImposterRenderConfig PCFDPPPFAAF, EIJGOMMIEMB KAFPJCNHEHK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static INJFFGCPKLN<GCCLPILKHFL, RenderTexture> EACKEOIKCLN;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<GCCLPILKHFL> AMGCNGKKBFL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int MAEFPGOJMPC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6873570", Offset = "0x6871D70", VA = "0x186873570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6873670", Offset = "0x6871E70", VA = "0x186873670")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KLMJFBDKIMA, RenderTexture DIONIANHKFP, ImposterRenderConfig NJBACFGJEIF, EIJGOMMIEMB KAFPJCNHEHK, CancellationToken ODNHMAMKFFP, bool EDGPBDKHIMB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6873190", Offset = "0x6871990", VA = "0x186873190", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68735E0", Offset = "0x6871DE0", VA = "0x1868735E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6873380", Offset = "0x6871B80", VA = "0x186873380")]
		private static Task<RenderTexture> FLGOMFHDDEC(GCCLPILKHFL HOIMFEOPBGP, CancellationToken ODNHMAMKFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6873A70", Offset = "0x6872270", VA = "0x186873A70")]
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
